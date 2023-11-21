using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void abrirFormEmpleados(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form frmEmple = formHija as Form;
            frmEmple.TopLevel = false;
            frmEmple.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frmEmple);
            this.panelContenedor.Tag = frmEmple;
            frmEmple.Show();
        }

        private void abrirFormActividades(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form frmActi = formHija as Form;
            frmActi.TopLevel = false;
            frmActi.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frmActi);
            this.panelContenedor.Tag = frmActi;
            frmActi.Show();
        }

        private void abrirFormAsistencias(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form frmAsis = formHija as Form;
            frmAsis.TopLevel = false;
            frmAsis.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frmAsis);
            this.panelContenedor.Tag = frmAsis;
            frmAsis.Show();
        }

        private void abrirFormEncuestas(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form frmEncu = formHija as Form;
            frmEncu.TopLevel = false;
            frmEncu.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frmEncu);
            this.panelContenedor.Tag = frmEncu;
            frmEncu.Show();
        }

        private void abrirFormCronograma(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form frmCrono = formHija as Form;
            frmCrono.TopLevel = false;
            frmCrono.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frmCrono);
            this.panelContenedor.Tag = frmCrono;
            frmCrono.Show();
        }

        private void abrirFormEstCompetencia(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form frmEstComp = formHija as Form;
            frmEstComp.TopLevel = false;
            frmEstComp.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frmEstComp);
            this.panelContenedor.Tag = frmEstComp;
            frmEstComp.Show();
        }

        private void abrirFormEvaDesempeño(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form frmEvaDes = formHija as Form;
            frmEvaDes.TopLevel = false;
            frmEvaDes.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frmEvaDes);
            this.panelContenedor.Tag = frmEvaDes;
            frmEvaDes.Show();
        }

        private void abrirFormEvaProgreso(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form frmEvaPro = formHija as Form;
            frmEvaPro.TopLevel = false;
            frmEvaPro.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frmEvaPro);
            this.panelContenedor.Tag = frmEvaPro;
            frmEvaPro.Show();
        }

        private void abrirResDesempeño(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form frmResDes = formHija as Form;
            frmResDes.TopLevel = false;
            frmResDes.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frmResDes);
            this.panelContenedor.Tag = frmResDes;
            frmResDes.Show();
        }

        private void abrirDocNecFormativas(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form frmDocNecFormativas = formHija as Form;
            frmDocNecFormativas.TopLevel = false;
            frmDocNecFormativas.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frmDocNecFormativas);
            this.panelContenedor.Tag = frmDocNecFormativas;
            frmDocNecFormativas.Show();
        }

        private void abrirPlanDesarrolloFormativo(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form frmPlanDesFormativo = formHija as Form;
            frmPlanDesFormativo.TopLevel = false;
            frmPlanDesFormativo.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frmPlanDesFormativo);
            this.panelContenedor.Tag = frmPlanDesFormativo;
            frmPlanDesFormativo.Show();
        }

        private void abrirDocResultadosProgreso(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form frmDocResProgreso = formHija as Form;
            frmDocResProgreso.TopLevel = false;
            frmDocResProgreso.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frmDocResProgreso);
            this.panelContenedor.Tag = frmDocResProgreso;
            frmDocResProgreso.Show();
        }

        private void abrirResolucioinEvaProgreso(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form frmResolEvaProgreso = formHija as Form;
            frmResolEvaProgreso.TopLevel = false;
            frmResolEvaProgreso.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frmResolEvaProgreso);
            this.panelContenedor.Tag = frmResolEvaProgreso;
            frmResolEvaProgreso.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormEmpleados(new FormularioEmpleados());
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            //abrirFormActividades(new FormularioActividades());
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            abrirFormAsistencias(new FormularioAreas());
        }

        private void btnEncuestas_Click(object sender, EventArgs e)
        {
            abrirFormEncuestas(new FormularioEncuestas());
        }

        private void btnCronograma_Click(object sender, EventArgs e)
        {
            abrirFormCronograma(new FormularioCronograma());
        }

        private void btnEstandaresCompetencia_Click(object sender, EventArgs e)
        {
            abrirFormEstCompetencia(new FormularioEstandarCompetencia());
        }

        private void btnEvaluacionDesempeño_Click(object sender, EventArgs e)
        {
            abrirFormEvaDesempeño(new FormularioEvaluacionDesempeño());
        }

        private void btnEvaluacionProgreso_Click(object sender, EventArgs e)
        {
            abrirFormEvaProgreso(new FormularioEvaluacionProgreso());
        }

        private void btnResultadoDesempeño_Click(object sender, EventArgs e)
        {
            abrirResDesempeño(new FormularioPreguntaEncuesta());
        }

        private void btnDocNecesidadesFormativas_Click(object sender, EventArgs e)
        {
            abrirDocNecFormativas(new FormularioDocumentoNecesidadesFormativas());
        }

        private void btnResultadosProgreso_Click(object sender, EventArgs e)
        {
            abrirDocResultadosProgreso(new FormularioDocumentoResultadosProgreso());
        }

        private void btnPlanDesarrolloFormativo_Click(object sender, EventArgs e)
        {
            abrirPlanDesarrolloFormativo(new FormularioPlanDesarrolloFormativo());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirResolucioinEvaProgreso(new FormularioResolucionEvaluacionProgreso());
        }
    }
}
