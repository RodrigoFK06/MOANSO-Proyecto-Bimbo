using CapaEntidad;
using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormularioEstandarCompetencia : Form
    {
        private logEstandarCompetencia estandarCompetenciaLogic = logEstandarCompetencia.Instancia;
        public FormularioEstandarCompetencia()
        {
            InitializeComponent();
            dgvEstandarCompetencia.ReadOnly = true;
            CargarDatosComboBoxArea();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Obtener el siguiente ID
            int siguienteId = logEstandarCompetencia.Instancia.ObtenerSiguienteIdEstandarCompetencia();

            // Asignar el siguiente ID al txtIdEstandar
            txtIdEstandar.Text = siguienteId.ToString();

            // Activar el GroupBox
            gbxDescripciónEstandar.Enabled = true;

            // Habilitar solo el botón "Agregar" y deshabilitar los demás
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            txtIdEstandar.Enabled=false;

            btnGuardar.Visible = true;
            btnEliminar.Visible = false;
            btnEditar.Visible = false;
        }

        private void btnModificador_Click(object sender, EventArgs e)
        {
            gbxDescripciónEstandar.Enabled = true;
            txtIdEstandar.Enabled = true;
            txtIdEstandar.Clear();

            btnGuardar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled=true;

            btnGuardar.Visible = false;
            btnEliminar.Visible = true;
            btnEditar.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int idEstandarCompetencia = Convert.ToInt32(txtIdEstandar.Text);

                // Obtener los detalles del estándar de competencia por su id
                entEstandarCompetencia estandar = logEstandarCompetencia.Instancia.ObtenerEstandarCompetenciaPorId(idEstandarCompetencia);

                // Llenar los campos con los detalles obtenidos
                if (estandar != null)
                {
                    txtDescripcion.Text = estandar.Descripcion;
                    cbxNivelRequerido.SelectedIndex = cbxNivelRequerido.FindStringExact(estandar.NivelRequerido.ToString());
                    cbxArea.SelectedIndex = cbxArea.FindStringExact(estandar.IdArea.ToString());
                    // Puedes llenar más campos según tu estructura
                }
                else
                {
                    MessageBox.Show("No se encontró el estándar de competencia con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los detalles del estándar de competencia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener datos desde los controles del formulario
            int nivelRequerido = Convert.ToInt32(cbxNivelRequerido.SelectedItem);
            string descripcion = txtDescripcion.Text;
            int idArea = Convert.ToInt32(((DataRowView)cbxArea.SelectedItem)["idArea"]);


            // Crear una instancia de entEstandarCompetencia con los datos
            entEstandarCompetencia nuevoEstandar = new entEstandarCompetencia
            {
                NivelRequerido = nivelRequerido,
                Descripcion = descripcion,
                IdArea = idArea
            };

            try
            {
                // Llamar al método de la capa de lógica para insertar el nuevo estándar
                bool insertado = logEstandarCompetencia.Instancia.InsertarEstandarCompetencia(nuevoEstandar);

                CargarDatosDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int idEstandarCompetencia = Convert.ToInt32(txtIdEstandar.Text);

                // Obtener los detalles del estándar de competencia por su id
                entEstandarCompetencia estandar = logEstandarCompetencia.Instancia.ObtenerEstandarCompetenciaPorId(idEstandarCompetencia);

                // Llenar los campos con los detalles obtenidos
                if (estandar != null)
                {
                    estandar.NivelRequerido = Convert.ToInt32(cbxNivelRequerido.SelectedItem);
                    estandar.Descripcion = txtDescripcion.Text;
                    estandar.IdArea = Convert.ToInt32(((DataRowView)cbxArea.SelectedItem)["idArea"]);
                    // Puedes llenar más campos según tu estructura

                    // Realizar la edición y verificar si se ha editado correctamente
                    bool editado = logEstandarCompetencia.Instancia.EditarEstandarCompetencia(estandar);

                    if (editado)
                    {
                        MessageBox.Show("Estándar de competencia editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo editar el estándar de competencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el estándar de competencia con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar el estándar de competencia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarDatosDataGridView();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idEstandarCompetencia = Convert.ToInt32(txtIdEstandar.Text);

                // Realizar la eliminación y verificar si se ha eliminado correctamente
                bool eliminado = logEstandarCompetencia.Instancia.EliminarEstandarCompetencia(idEstandarCompetencia);

                if (eliminado)
                {
                    MessageBox.Show("Estándar de competencia eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los campos o realizar otras acciones después de la eliminación
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el estándar de competencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el estándar de competencia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarDatosDataGridView();
        }

        private void FormularioEstandarCompetencia_Load(object sender, EventArgs e)
        {
            gbxDescripciónEstandar.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            txtIdEstandar.Enabled=false;
            btnBuscar.Enabled = false;

            CargarDatosDataGridView();
        }

        private void CargarDatosDataGridView()
        {
            try
            {
                // Obtener la lista de estándares desde la capa de lógica
                List<entEstandarCompetencia> listaEstandares = logEstandarCompetencia.Instancia.ListarEstandarCompetencia();

                // Asignar la lista como origen de datos para la DataGridView
                dgvEstandarCompetencia.DataSource = listaEstandares;

                // Opcional: Ajustar el ancho de las columnas de la DataGridView
                dgvEstandarCompetencia.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos en la DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtDescripcion.Text = string.Empty;
            cbxNivelRequerido.SelectedIndex = -1;
            cbxArea.SelectedIndex = -1;
        }

        private void CargarDatosComboBoxArea()
        {
            try
            {
                // Obtener datos desde la lógica
                DataTable dataTable = estandarCompetenciaLogic.ObtenerIdArea();

                // Asignar datos al ComboBox
                cbxArea.DataSource = dataTable;
                cbxArea.DisplayMember = "idArea";
                // cbxArea.ValueMember = "idArea"; // Esto es opcional dependiendo de tus necesidades
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
