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
    public partial class FormularioAreas : Form
    {
        public FormularioAreas()
        {
            InitializeComponent();
            btnCancelar.Visible = false;
            grupboxDatos.Enabled = false;
            txtId.Enabled = false;
            btnVolver.Visible = false;
            btnEliminar.Enabled = false;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            listarAreas();
        }
        public void LimpiarVariables()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }
        public void listarAreas()
        {
            dtaAreas.DataSource = logAreas.Instancia.ListarAreas();
        }

        private void FormularioAreas_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            grupboxDatos.Enabled = true;
            btnModificar.Enabled = false;
            btnVolver.Visible = true;
            dtaAreas.Enabled = false;
            btnRegistrar.Enabled = true;
            btnCancelar.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            grupboxDatos.Enabled = true;
            btnRegistrar.Enabled = false;
            btnCancelar.Visible = true;
            btnVolver.Visible = false;
            dtaAreas.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entAreas a = new entAreas();
                a.idArea = int.Parse(txtId.Text.Trim());
                a.Nombre = txtNombre.Text.Trim();
                a.Descripcion = txtDescripcion.Text.Trim();

                logAreas.Instancia.ModificarArea(a);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupboxDatos.Enabled = false;
            btnNuevo.Visible = true;
            btnCancelar.Visible = false;
            listarAreas();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            MessageBox.Show("Área modificada correctamente.");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            btnNuevo.Visible = true;
            btnRegistrar.Visible = true;
            btnCancelar.Visible = false;
            grupboxDatos.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            dtaAreas.Enabled = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            btnModificar.Visible = true;
            btnVolver.Visible = false;
            grupboxDatos.Enabled = false;
            dtaAreas.Enabled = true;
            btnRegistrar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private ErrorProvider errorProvider = new ErrorProvider();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            // Verificar si los campos están vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "Por favor, ingrese una nombre.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                errorProvider.SetError(txtDescripcion, "Por favor, ingrese una Descripcion.");
                return;
            }
            try
            {
                entAreas ar = new entAreas();
                ar.Nombre = txtNombre.Text.Trim();
                ar.Descripcion = txtDescripcion.Text.Trim();

                logAreas.Instancia.RegistrarArea(ar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupboxDatos.Enabled = false;
            btnModificar.Visible = true;
            btnVolver.Visible = false;
            listarAreas();
            btnRegistrar.Enabled = false;
            dtaAreas.Enabled = true;
            MessageBox.Show("Área registrada correctamente.");
        }

        private void dtaAreas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dtaAreas.Rows[e.RowIndex]; //
            txtId.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[2].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idArea = Convert.ToInt32(txtId.Text); // Asume que tienes un TextBox llamado txtIdArea para ingresar el ID del área a eliminar
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que quieres eliminar?", "Confirmacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                EliminarArea(idArea);
                listarAreas();
                grupboxDatos.Enabled = false;
                btnNuevo.Visible = true;
                btnRegistrar.Visible = true;
                btnCancelar.Visible = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                LimpiarVariables();
                MessageBox.Show("Área eliminada correctamente.");
            }
        }
        public void EliminarArea(int idArea)
        {
            string connectionString = "Server=DESKTOP-7O3687Q;Database=bdProyectoBimbo;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("dbo.DeleteArea", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agrega el parámetro al comando
                    command.Parameters.Add(new SqlParameter("@idArea", idArea));

                    command.ExecuteNonQuery();
                }
            }
        }

        
    }
}
