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
    public partial class FormularioActividadesDeCapacitaciones : Form
    {
        private ActividadLogica ActividadLogica;
        private Actividad ActividadSeleccionado;
        public FormularioActividadesDeCapacitaciones()
        {
            InitializeComponent();
            ActividadLogica = new ActividadLogica();

            CargarActividads();
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            //comboPuesto.Text = "";
            //comboArea.Text = "";

        }

        private void CargarActividads()
        {
            listaActividades.DataSource = ActividadLogica.LeerActividad();
        }






        private void FormularioActividads_Load(object sender, EventArgs e)
        {
            CargarActividads();
        }




        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }



        private void listaActividades_SelectionChanged_1(object sender, EventArgs e)
        {
            if (listaActividades.SelectedRows.Count > 0)
            {
                // Obtener el cliente seleccionado de la fila actual
                ActividadSeleccionado = (Actividad)listaActividades.SelectedRows[0].DataBoundItem;
                // Carga los datos en los campos de texto
                txtNombre.Text = ActividadSeleccionado.NombreActividad;
                txtDescripcion.Text = ActividadSeleccionado.Descripcion;
                //comboPuesto.Text = ActividadSeleccionado.Puesto;
                //comboArea.Text = ActividadSeleccionado.Area;
            }
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Actividad nuevoActividad = new Actividad
            {
                NombreActividad = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                //Puesto = Convert.ToInt32(comboPuesto.SelectedValue),
                //Area = Convert.ToInt32(comboArea.SelectedValue)
            };

            ActividadLogica.CrearActividad(nuevoActividad);

            CargarActividads();
            LimpiarCampos();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (ActividadSeleccionado != null)
            {
                // Actualizar el objeto ActividadSeleccionado con los datos modificados
                ActividadSeleccionado.NombreActividad = txtNombre.Text;
                ActividadSeleccionado.Descripcion = txtDescripcion.Text;
                //ActividadSeleccionado.Sueldo = Convert.ToInt32(txtSueldo.Text);
                //ActividadSeleccionado.Direccion = txtDireccion.Text;

                // Llamar al método de la lógica para editar el Actividad
                ActividadLogica.ActualizarActividad(ActividadSeleccionado);

                // Actualizar la vista con los Actividads actualizados
                CargarActividads();

                // Limpiar los campos después de guardar
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un Actividad para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (ActividadSeleccionado != null)
            {
                // Mostrar un cuadro de diálogo de confirmación
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este Actividad?", "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Llamar al método de la lógica para eliminar el Actividad
                    ActividadLogica.EliminarActividad(ActividadSeleccionado.idActividad);

                    // Actualizar la vista con los Actividads actualizados
                    CargarActividads();

                    // Limpiar los campos después de eliminar
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un Actividad para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listaActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
