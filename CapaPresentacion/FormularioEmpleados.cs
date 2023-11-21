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
    public partial class FormularioEmpleados : Form
    {
        private EmpleadoLogica empleadoLogica;
        private string connectionString = "Server=TONY;Database=bdProyectoBimbo; Integrated Security=True;";// Reemplaza con tu cadena de conexión;
        public FormularioEmpleados()
        {
            InitializeComponent();
            // Establece el controlador de eventos para el evento SelectionChanged del DataGridView
            listaEmpleados.SelectionChanged += listaEmpleados_SelectionChanged;
            this.connectionString = connectionString;
            empleadoLogica = new EmpleadoLogica(connectionString);

            // Configura las columnas del DataGridView
            listaEmpleados.Columns.Add("IdEmpleado", "ID");
            listaEmpleados.Columns.Add("Nombre", "Nombre");
            listaEmpleados.Columns.Add("Apellido", "Apellido");
            listaEmpleados.Columns.Add("FechaContratacion", "Fecha Contratación");
            listaEmpleados.Columns.Add("Puesto", "Puesto");
            listaEmpleados.Columns.Add("Area", "Área");

            CargarEmpleados();
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            pickerFechaContratacion.Value = DateTime.Now;
            cbPuesto.Text = "";
            cbArea.Text = "";
           
        }

        private void CargarEmpleados()
        {
            List<Empleado> empleados = empleadoLogica.LeerEmpleados();
            listaEmpleados.Rows.Clear();

            foreach (var empleado in empleados)
            {
                listaEmpleados.Rows.Add(empleado.IdEmpleado, empleado.Nombre, empleado.Apellido, empleado.FechaContratacion, empleado.Puesto, empleado.Area);
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime fechaContratacion = pickerFechaContratacion.Value;
            string puesto = cbPuesto.Text;
            string area = cbArea.Text;

            Empleado empleado = new Empleado
            {
                Nombre = nombre,
                Apellido = apellido,
                FechaContratacion = fechaContratacion,
                Puesto = puesto,
                Area = area
            };

            empleadoLogica.CrearEmpleado(empleado);

            CargarEmpleados();
            LimpiarCampos();

        }

        private void listaEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (listaEmpleados.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = listaEmpleados.SelectedRows[0];

                // Obtiene los valores de las celdas seleccionadas
                int idEmpleado = Convert.ToInt32(selectedRow.Cells["IdEmpleado"].Value);
                string nombre = selectedRow.Cells["Nombre"].Value.ToString();
                string apellido = selectedRow.Cells["Apellido"].Value.ToString();
                DateTime fechaContratacion = Convert.ToDateTime(selectedRow.Cells["FechaContratacion"].Value);
                string puesto = selectedRow.Cells["Puesto"].Value.ToString();
                string area = selectedRow.Cells["Area"].Value.ToString();

                // Carga los datos en los campos de texto
                txtNombre.Text = nombre;
                txtApellido.Text = apellido;
                pickerFechaContratacion.Value = fechaContratacion;
                cbPuesto.Text = puesto;
                cbArea.Text = area;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Habilita los campos de texto para editar
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            pickerFechaContratacion.Enabled = true;
            cbPuesto.Enabled = true;
            cbArea.Enabled = true;

            // Cambia el texto del botón "Guardar" a "Guardar Cambios"
            btnGuardar.Text = "Guardar Cambios";

            // Deshabilita el botón "Editar"
            btnEditar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listaEmpleados.SelectedRows.Count > 0)
            {
                // Pregunta al usuario si está seguro de que desea eliminar el empleado
                DialogResult confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este empleado?", "Confirmación de eliminación", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    // Obtiene el ID del empleado seleccionado
                    int idEmpleado = Convert.ToInt32(listaEmpleados.SelectedRows[0].Cells["IDEmpleado"].Value); // Reemplaza "IDEmpleado" con el nombre de la columna real

                    // Llama al método para eliminar el empleado
                    empleadoLogica.EliminarEmpleado(idEmpleado);

                    // Refresca el DataGridView para reflejar los cambios
                    CargarEmpleados();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
