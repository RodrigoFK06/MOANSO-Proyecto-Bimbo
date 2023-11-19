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
using static System.Windows.Forms.MonthCalendar;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class FormularioActividadesDeCapacitaciones : Form
    {
        private ActividadLogica actividadLogica;
        private Actividad actividad;
        public FormularioActividadesDeCapacitaciones()
        {
            InitializeComponent();
            // Establece el controlador de eventos para el evento SelectionChanged del DataGridView
            listaActividades.SelectionChanged += listaActividades_SelectionChanged;


            // Configura las columnas del DataGridView
            listaActividades.Columns.Add("idActividad", "Id");
            listaActividades.Columns.Add("NombreActividad", "NombreActividad");
            listaActividades.Columns.Add("Descripcion", "Descripcion");


            CargarActividades();
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";


        }

        private void CargarActividades()
        {
            List<Actividad> actividades = actividadLogica.LeerActividades();
            listaActividades.Rows.Clear();

            foreach (var actividad in actividades)
            {
                listaActividades.Rows.Add(actividad.idActividad, actividad.NombreActividad, actividad.Descripcion);
            }
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string Descripcion = txtDescripcion.Text;


            Actividad actividad = new Actividad
            {
                NombreActividad = nombre,
                Descripcion = Descripcion,

            };

            actividadLogica.CrearActividad(actividad);

            CargarActividades();
            LimpiarCampos();

        }

        private void listaActividades_SelectionChanged(object sender, EventArgs e)
        {
            if (listaActividades.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = listaActividades.SelectedRows[0];

                // Obtiene los valores de las celdas seleccionadas
                int idActividad = Convert.ToInt32(selectedRow.Cells["idActividad"].Value);
                string nombre = selectedRow.Cells["NombreActividad"].Value.ToString();
                string descripcion = selectedRow.Cells["Descripcion"].Value.ToString();

                // Carga los datos en los campos de texto
                txtNombre.Text = nombre;
                txtDescripcion.Text = descripcion;

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Habilita los campos de texto para editar
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;


            // Cambia el texto del botón "Guardar" a "Guardar Cambios"
            btnRegistrar.Text = "Guardar Cambios";

            // Deshabilita el botón "Editar"
            btnModificar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listaActividades.SelectedRows.Count > 0)
            {
                // Pregunta al usuario si está seguro de que desea eliminar el empleado
                DialogResult confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar esta actividad?", "Confirmación de eliminación", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    // Obtiene el ID del empleado seleccionado
                    int idActividad = Convert.ToInt32(listaActividades.SelectedRows[0].Cells["idActividad"].Value); // Reemplaza "IDEmpleado" con el nombre de la columna real

                    // Llama al método para eliminar el empleado
                    actividadLogica.EliminarActividad(idActividad);

                    // Refresca el DataGridView para reflejar los cambios
                    CargarActividades();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
