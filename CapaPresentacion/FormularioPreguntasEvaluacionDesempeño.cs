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
    public partial class FormularioPreguntasEvaluacionDesempeño : Form
    {
        public FormularioPreguntasEvaluacionDesempeño()
        {
            InitializeComponent();
            cbOp1.CheckedChanged += CheckBox_CheckedChanged;
            cbOp2.CheckedChanged += CheckBox_CheckedChanged;
            cbOp3.CheckedChanged += CheckBox_CheckedChanged;
            cbOp4.CheckedChanged += CheckBox_CheckedChanged;
            ListarDetEvaDesempeño();
            gboxPregunta.Enabled = false;
        }

        public void ListarDetEvaDesempeño()
        {
            List<entPregEvaDesempeño> listaDetEvaDesempeño = LogPregEvaDesempeño.Instancia.ListarPregEvaDesempeño();
            if (listaDetEvaDesempeño.Count > 0) // para verificar si existen filas
            {
                dgvPregEvaDesempeño.Columns.Clear(); // se eliminan todas las columnas existentes del DataGridView antes de mostrar el resultado de la consulta
                BindingSource datosEnlazados = new BindingSource(); // objeto para vincular el resultado de la consulta al DataGridView
                datosEnlazados.DataSource = listaDetEvaDesempeño;
                dgvPregEvaDesempeño.DataSource = datosEnlazados; // se vincula el resultado de la consulta al DataGridView y se mostran los registros
                //configurarColumnasDataGridView();
                dgvPregEvaDesempeño.Rows[0].Selected = false; // permite que la primera fila del DataGridView no esté seleccionada
            }
        }
        private void LimpiarVariables()
        {
            txtidPregEvaDesempeño.Text = " ";
            txtidEvaDesempeño.Text = " ";
            txtPregunta.Text = " ";
            txtOpcion1.Text = " ";
            txtOpcion2.Text = " ";
            txtOpcion3.Text = " ";
            txtOpcion4.Text = " ";
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox changedCheckBox = sender as System.Windows.Forms.CheckBox;

            if (changedCheckBox.Checked)
            {
                cbOp1.Enabled = cbOp1 == changedCheckBox;
                cbOp2.Enabled = cbOp2 == changedCheckBox;
                cbOp3.Enabled = cbOp3 == changedCheckBox;
                cbOp4.Enabled = cbOp4 == changedCheckBox;
            }
            else
            {
                cbOp1.Enabled = true;
                cbOp2.Enabled = true;
                cbOp3.Enabled = true;
                cbOp4.Enabled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            txtidPregEvaDesempeño.Enabled = false;
            btnAgregar.Enabled = true;
            gboxPregunta.Enabled = true;
            btnModificar.Enabled = false;
            LimpiarVariables();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = true;
            gboxPregunta.Enabled = true;
            btnAgregar.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ListarDetEvaDesempeño();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gboxPregunta.Enabled = false;
            btnEliminar.Enabled = true;
            txtidPregEvaDesempeño.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entPregEvaDesempeño preg = new entPregEvaDesempeño();
            preg.Pregunta = txtPregunta.Text.Trim();
            preg.Opcion1 = txtOpcion1.Text.Trim();
            preg.Opcion2 = txtOpcion2.Text.Trim();
            preg.Opcion3 = txtOpcion3.Text.Trim();
            preg.Opcion4 = txtOpcion4.Text.Trim();

            if (cbOp1.Checked)
                preg.Respuesta = txtOpcion1.Text.Trim();
            else if (cbOp2.Checked)
                preg.Respuesta = txtOpcion2.Text.Trim();
            else if (cbOp3.Checked)
                preg.Respuesta = txtOpcion3.Text.Trim();
            else if (cbOp4.Checked)
                preg.Respuesta = txtOpcion4.Text.Trim();

            preg.idEvaluacionDesempeño = int.Parse(txtidEvaDesempeño.Text);
            LogPregEvaDesempeño.Instancia.InsertarPregEvaDesempeño(preg);
            LimpiarVariables();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entPregEvaDesempeño p = new entPregEvaDesempeño();

                p.idEvaluacionDesempeño = int.Parse(txtidEvaDesempeño.Text);
                p.Pregunta = txtPregunta.Text.Trim();
                p.Opcion1 = txtOpcion1.Text.Trim();
                p.Opcion2 = txtOpcion2.Text.Trim();
                p.Opcion3 = txtOpcion3.Text.Trim();
                p.Opcion4 = txtOpcion4.Text.Trim();

                if (cbOp1.Checked)
                    p.Respuesta = txtOpcion1.Text.Trim();
                else if (cbOp2.Checked)
                    p.Respuesta = txtOpcion2.Text.Trim();
                else if (cbOp3.Checked)
                    p.Respuesta = txtOpcion3.Text.Trim();
                else if (cbOp4.Checked)
                    p.Respuesta = txtOpcion4.Text.Trim();

                p.idPreguntasEvaluacionDesempeño = int.Parse(txtidPregEvaDesempeño.Text);

                LogPregEvaDesempeño.Instancia.EditarPregEvaDesempeño(p);
                LimpiarVariables();
            }
            catch (Exception ex)
            {
                MessageBox.Show("err" + ex);
                throw ex;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                entPregEvaDesempeño c = new entPregEvaDesempeño();
                c.idPreguntasEvaluacionDesempeño = int.Parse(txtidPregEvaDesempeño.Text.Trim());
                LogPregEvaDesempeño.Instancia.EliminarPregEvaDesempeño(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
        }
    }
}
