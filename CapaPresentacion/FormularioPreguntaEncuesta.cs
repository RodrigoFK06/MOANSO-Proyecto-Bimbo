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
using CapaEntidad;
using CapaLogicaNegocio;

namespace CapaPresentacion
{
    public partial class FormularioPreguntaEncuesta : Form
    {
        public FormularioPreguntaEncuesta()
        {
            InitializeComponent();
            listarPreguntas();
            LlenarDatosCmboxEncuesta();
            btnCancelar.Visible = false;
            grupboxDatos.Enabled = false;
            txtId.Enabled = false;
            txtIdEncuesta.Enabled = false;
            btnVolver.Visible = false;
            btnEliminar.Enabled = false;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
        }
        public void LimpiarVariables()
        {
            txtId.Text = "";
            txtPregunta.Text = "";
            txtO1.Text = "";
            txtO2.Text = "";
            txtO3.Text = "";
            txtO4.Text = "";
            cboEncuesta.Text = "";
            txtIdEncuesta.Text = "";
        }
        private void PreguntaEncuesta_Load(object sender, EventArgs e)
        {

        }
        private void LlenarDatosCmboxEncuesta()
        {
            cboEncuesta.DataSource = logEncuesta.Instancia.ListarEncuesta();
            cboEncuesta.DisplayMember = "Titulo";
            cboEncuesta.ValueMember = "idEncuesta";
        }
        public void listarPreguntas()
        {
            dtaPreguntas.DataSource = logPreguntasE.Instancia.ListarPreguntas();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            grupboxDatos.Enabled = true;
            btnModificar.Enabled = false;
            btnVolver.Visible = true;
            dtaPreguntas.Enabled = false;
            btnRegistrar.Enabled = true;
            btnCancelar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entPreguntasE p = new entPreguntasE();
                p.idPreguntasEncuesta = int.Parse(txtId.Text.Trim());
                p.Pregunta = txtPregunta.Text.Trim();
                p.Opcion1 = txtO1.Text.Trim();
                p.Opcion2 = txtO2.Text.Trim();
                p.Opcion3 = txtO3.Text.Trim();
                p.Opcion4 = txtO4.Text.Trim();
                p.idEncuesta = Convert.ToInt32(cboEncuesta.SelectedValue);
                logPreguntasE.Instancia.ModificarPreguntas(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupboxDatos.Enabled = false;
            btnNuevo.Visible = true;
            btnCancelar.Visible = false;
            listarPreguntas();
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
            btnEliminar.Enabled = false;
            dtaPreguntas.Enabled = true;
        }

        private void dtaPreguntas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dtaPreguntas.Rows[e.RowIndex]; //
            txtId.Text = filaActual.Cells[0].Value.ToString();
            txtPregunta.Text = filaActual.Cells[1].Value.ToString();
            txtO1.Text = filaActual.Cells[2].Value.ToString();
            txtO2.Text = filaActual.Cells[3].Value.ToString();
            txtO3.Text = filaActual.Cells[4].Value.ToString();
            txtO4.Text = filaActual.Cells[5].Value.ToString();
            txtIdEncuesta.Text = filaActual.Cells[6].Value.ToString();
        }
        private ErrorProvider errorProvider = new ErrorProvider();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            // Verificar si los campos están vacíos
            if (string.IsNullOrWhiteSpace(txtPregunta.Text))
            {
                errorProvider.SetError(txtPregunta, "Por favor, ingrese una pregunta.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtO1.Text))
            {
                errorProvider.SetError(txtO1, "Por favor, ingresar una opcion.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtO2.Text))
            {
                errorProvider.SetError(txtO2, "Por favor, ingresar una opcion.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtO3.Text))
            {
                errorProvider.SetError(txtO3, "Por favor, ingresar una opcion.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtO4.Text))
            {
                errorProvider.SetError(txtO4, "Por favor, ingresar una opcion.");
                return;
            }
            if (string.IsNullOrWhiteSpace(cboEncuesta.Text))
            {
                errorProvider.SetError(cboEncuesta, "Por favor, seleccione una opcion.");
                return;
            }
            try
            {
                entPreguntasE p = new entPreguntasE();
                p.Pregunta = txtPregunta.Text.Trim();
                p.Opcion1 = txtO1.Text.Trim();
                p.Opcion2 = txtO2.Text.Trim();
                p.Opcion3 = txtO3.Text.Trim();
                p.Opcion4 = txtO4.Text.Trim();
                p.idEncuesta = Convert.ToInt32(cboEncuesta.SelectedValue);
                logPreguntasE.Instancia.RegistrarPreguntas(p);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupboxDatos.Enabled = false;
            btnModificar.Visible = true;
            btnVolver.Visible = false;
            listarPreguntas();
            btnRegistrar.Enabled = false;
            dtaPreguntas.Enabled = true;

            MessageBox.Show("Área registrada correctamente.");
        }
        public void EliminarPregunta(int idPregunta)
        {
            string connectionString = "Server=DESKTOP-7O3687Q;Database=bdProyectoBimbo;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("dbo.DeletePreguntasEncuesta", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agrega el parámetro al comando
                    command.Parameters.Add(new SqlParameter("@idPreguntasEncuesta", idPregunta));

                    command.ExecuteNonQuery();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idPregunta = Convert.ToInt32(txtId.Text); // Asume que tienes un TextBox llamado txtId para ingresar el ID a eliminar
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que quieres eliminar?", "Confirmacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                EliminarPregunta(idPregunta);
                listarPreguntas();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            grupboxDatos.Enabled = true;
            btnRegistrar.Enabled = false;
            btnCancelar.Visible = true;
            btnVolver.Visible = false;
            dtaPreguntas.Enabled = true;
            cboEncuesta.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            btnModificar.Visible = true;
            btnVolver.Visible = false;
            grupboxDatos.Enabled = false;
            dtaPreguntas.Enabled = true;
            btnRegistrar.Enabled = false;
            btnEliminar.Enabled = false;
        }
    }
}