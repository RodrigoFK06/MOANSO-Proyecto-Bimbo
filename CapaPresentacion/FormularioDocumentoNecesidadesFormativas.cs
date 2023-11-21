using CapaEntidad;
using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormularioDocumentoNecesidadesFormativas : Form
    {
        private logNecesidadesFormativas necesidadesFormativasLogic = logNecesidadesFormativas.Instancia;
        private DataTable dtNecesidadesFormativas = new DataTable(); // DataTable para la DataGridView
        public FormularioDocumentoNecesidadesFormativas()
        {
            InitializeComponent();
            dgvNecesidadesFormativas.ReadOnly = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivarControles();

            // Obtén el próximo idNecesidadesFormativas
            int siguienteId = logNecesidadesFormativas.Instancia.ObtenerSiguienteIdNecesidadesFormativas();

            // Asigna el próximo id al campo txtIdNecesidades
            txtIdNecesidades.Text = siguienteId.ToString();
            txtIdNecesidades.Enabled = true;

            txtNecesidades.Enabled = false;
            pickerFechaImplementacion.Enabled = false;
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el idNecesidadesFormativas a eliminar (puedes usar un TextBox u otro control)
                int idNecesidadesFormativas = ObtenerIdNecesidadesFormativas();

                // Llamar al método de la capa de lógica para eliminar
                bool eliminado = logNecesidadesFormativas.Instancia.EliminarNecesidadesFormativas(idNecesidadesFormativas);

                if (eliminado)
                {
                    MessageBox.Show("Necesidad eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Puedes realizar otras acciones después de la eliminación, como recargar la DataGridView, etc.
                    CargarDatosDataGridView();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la necesidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la necesidad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que los campos obligatorios estén llenos
            if (ValidarCampos())
            {
                // Crear un objeto entNecesidadesFormativas con los datos del formulario
                entNecesidadesFormativas nuevaNecesidad = new entNecesidadesFormativas
                {
                    FechaCreacion = pickerFechaCreacion.Value,
                    FechaImplementacion = pickerFechaImplementacion.Value,
                    Necesidades = txtNecesidades.Text,
                    idEstandarCompetencia = Convert.ToInt32(cbxEstandarCompetencia.SelectedValue),
                    idResolucionEvaluacionDesempeño = Convert.ToInt32(cbxIdResolucionEvaluacion.SelectedValue)
                };

                // Insertar en la base de datos usando la lógica
                if (necesidadesFormativasLogic.InsertarNecesidadesFormativas(nuevaNecesidad))
                {
                    // Si la inserción es exitosa, agregar la fila al DataTable
                    DataRow newRow = dtNecesidadesFormativas.NewRow();
                    newRow["FechaCreacion"] = nuevaNecesidad.FechaCreacion;
                    newRow["FechaImplementacion"] = nuevaNecesidad.FechaImplementacion;
                    newRow["Necesidades"] = nuevaNecesidad.Necesidades;
                    newRow["idEstandarCompetencia"] = nuevaNecesidad.idEstandarCompetencia;
                    newRow["idResolucionEvaluacionDesempeño"] = nuevaNecesidad.idResolucionEvaluacionDesempeño;
                    dtNecesidadesFormativas.Rows.Add(newRow);

                    // Limpiar controles después de agregar
                    LimpiarControles();
                }
                else
                {
                    MessageBox.Show("Error al insertar en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CargarDatosDataGridView();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID de NecesidadesFormativas desde el TextBox
                int idNecesidadesFormativas = Convert.ToInt32(txtIdNecesidades.Text);

                // Llamar al método de la capa lógica para obtener los detalles
                entNecesidadesFormativas necesidadFormativa = necesidadesFormativasLogic.ObtenerNecesidadFormativaPorId(idNecesidadesFormativas);

                // Verificar si se encontró la necesidad formativa
                if (necesidadFormativa != null)
                {
                    // Rellenar los campos con los detalles obtenidos
                    pickerFechaCreacion.Value = necesidadFormativa.FechaCreacion;
                    txtNecesidades.Text = necesidadFormativa.Necesidades;
                    cbxEstandarCompetencia.SelectedValue = necesidadFormativa.idEstandarCompetencia;
                    cbxIdResolucionEvaluacion.SelectedValue = necesidadFormativa.idResolucionEvaluacionDesempeño;
                    pickerFechaImplementacion.Value = necesidadFormativa.FechaImplementacion;
                }
                else
                {
                    // Limpiar los campos si no se encontró la necesidad formativa
                    LimpiarCampos();
                    MessageBox.Show("No se encontró la necesidad formativa con el ID proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener detalles de la necesidad formativa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el idResolucionEvaluacionDesempeno desde algún lugar, por ejemplo, txtIdResolucionEvaluacionDesempeno
                int idResolucionEvaluacionDesempeno = Convert.ToInt32(cbxIdResolucionEvaluacion.Text);
                int idEstandarCompetencia = Convert.ToInt32(cbxEstandarCompetencia.Text);

                // Llamar a los métodos para obtener NivelRequerido y NotaTotal
                int nivelRequerido = logEstandarCompetencia.Instancia.ObtenerNivelRequerido(idEstandarCompetencia);
                int notaTotal = logNecesidadesFormativas.Instancia.ObtenerNotaTotal(idResolucionEvaluacionDesempeno);

                // Comparar NivelRequerido y NotaTotal
                if (notaTotal <= nivelRequerido)
                {
                    // Habilitar los campos txtNecesidades y pickerFechaImplementacion
                    txtNecesidades.Enabled = true;
                    pickerFechaImplementacion.Enabled = true;

                    // Mostrar un mensaje indicando que se necesita crear una Necesidad Formativa
                    MessageBox.Show("Se necesita crear una Necesidad Formativa.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNecesidades.Enabled = true;
                    pickerFechaImplementacion.Enabled = true;
                }
                else
                {
                    // Deshabilitar los campos txtNecesidades y pickerFechaImplementacion
                    txtNecesidades.Enabled = false;
                    pickerFechaImplementacion.Enabled = false;

                    // Mostrar un mensaje indicando que no se necesita crear una Necesidad Formativa
                    MessageBox.Show("No se necesita crear una Necesidad Formativa.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            pickerFechaCreacion.Value = DateTime.Now;
            txtNecesidades.Text = string.Empty;
            cbxEstandarCompetencia.SelectedIndex = -1;
            cbxIdResolucionEvaluacion.SelectedIndex = -1;
            pickerFechaImplementacion.Value = DateTime.Now;
        }

        private int ObtenerIdNecesidadesFormativas()
        {
            // Lógica para obtener el idNecesidadesFormativas, por ejemplo, desde un TextBox
            return Convert.ToInt32(txtIdNecesidades.Text);
        }


        private void CargarDatosDataGridView()
        {
            try
            {
                // Obtén los datos desde la lógica
                List<entNecesidadesFormativas> listaNecesidades = necesidadesFormativasLogic.ListarNecesidadesFormativas();

                // Asigna los datos al DataGridView
                dgvNecesidadesFormativas.DataSource = listaNecesidades;
            }
            catch (Exception ex)
            {
                // Maneja la excepción según tus necesidades
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void ConfigurarDataGridView()
        {
            // Configurar estructura del DataTable para la DataGridView
            dtNecesidadesFormativas.Columns.Add("FechaCreacion", typeof(DateTime));
            dtNecesidadesFormativas.Columns.Add("FechaImplementacion", typeof(DateTime));
            dtNecesidadesFormativas.Columns.Add("Necesidades", typeof(string));
            dtNecesidadesFormativas.Columns.Add("idEstandarCompetencia", typeof(int));
            dtNecesidadesFormativas.Columns.Add("idResolucionEvaluacionDesempeño", typeof(int));

            // Asignar DataTable a la DataGridView
            dgvNecesidadesFormativas.DataSource = dtNecesidadesFormativas;
        }


        private void DesactivarControles()
        {
            // Desactivar controles en el GroupBox
            pickerFechaCreacion.Enabled = false;
            pickerFechaImplementacion.Enabled = false;
            txtNecesidades.Enabled = false;
            cbxEstandarCompetencia.Enabled = false;
            cbxIdResolucionEvaluacion.Enabled = false;

            // Desactivar botones
            btnAgregar.Enabled = false;
            btnInhabilitar.Enabled = false;
        }

        private void ActivarControles()
        {
            // Activar controles en el GroupBox
            pickerFechaCreacion.Enabled = true;
            pickerFechaImplementacion.Enabled = true;
            txtNecesidades.Enabled = true;
            cbxEstandarCompetencia.Enabled = true;
            cbxIdResolucionEvaluacion.Enabled = true;


            // Activar botones
            btnAgregar.Enabled = true;
            btnInhabilitar.Enabled = true;
        }

        private void LimpiarControles()
        {
            // Limpiar controles en el GroupBox
            pickerFechaCreacion.Value = DateTime.Now;
            pickerFechaImplementacion.Value = DateTime.Now;
            txtNecesidades.Text = string.Empty;
            cbxEstandarCompetencia.SelectedIndex = 0;
            cbxIdResolucionEvaluacion.SelectedIndex = 0;
        }

        private bool ValidarCampos()
        {
            return !string.IsNullOrEmpty(txtNecesidades.Text)
                && cbxEstandarCompetencia.SelectedIndex != -1
                && cbxIdResolucionEvaluacion.SelectedIndex != -1;
        }

        private void CargarDatosComboBoxResolucionEvaluacion()
        {
            try
            {
                // Obtener datos desde la lógica
                DataTable dataTable = necesidadesFormativasLogic.ObtenerIdResolucionEvaluacionDesempeno();

                // Asignar datos al ComboBox
                cbxIdResolucionEvaluacion.DataSource = dataTable;
                cbxIdResolucionEvaluacion.DisplayMember = "idResolucionEvaluacionDesempeño";
                cbxIdResolucionEvaluacion.ValueMember = "idResolucionEvaluacionDesempeño"; // Valor seleccionado es el ID
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosComboBox()
        {
            try
            {
                // Obtener datos desde la lógica
                DataTable dataTable = necesidadesFormativasLogic.ObtenerIdEstandarCompetencia();

                // Asignar datos al ComboBox
                cbxEstandarCompetencia.DataSource = dataTable;
                cbxEstandarCompetencia.DisplayMember = "idEstandarCompetencia";
                cbxEstandarCompetencia.ValueMember = "idEstandarCompetencia"; // Valor seleccionado es el ID
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormularioDocumentoNecesidadesFormativas_Load(object sender, EventArgs e)
        {
            // Configurar la estructura del DataTable para la DataGridView
            ConfigurarDataGridView();

            // Desactivar controles al cargar el formulario
            DesactivarControles();

            // Cargar datos en los ComboBox
            CargarDatosComboBox();

            CargarDatosDataGridView();

            CargarDatosComboBoxResolucionEvaluacion();



            dgvNecesidadesFormativas.Columns["Necesidades"].Width = 234;
            dgvNecesidadesFormativas.Columns["FechaCreacion"].Width = 100;
            dgvNecesidadesFormativas.Columns["FechaImplementacion"].Width = 120;
            dgvNecesidadesFormativas.Columns["idEstandarCompetencia"].Width = 120;
            dgvNecesidadesFormativas.Columns["idResolucionEvaluacionDesempeño"].Width = 192;
        }
    }
}
