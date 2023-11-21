namespace CapaPresentacion
{
    partial class FormularioPreguntaEncuesta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.grupboxDatos = new System.Windows.Forms.GroupBox();
            this.txtIdEncuesta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboEncuesta = new System.Windows.Forms.ComboBox();
            this.txtO4 = new System.Windows.Forms.TextBox();
            this.txtO3 = new System.Windows.Forms.TextBox();
            this.txtO2 = new System.Windows.Forms.TextBox();
            this.txtO1 = new System.Windows.Forms.TextBox();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtaPreguntas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.grupboxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightCyan;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditar.Location = new System.Drawing.Point(179, 54);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 49;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.LightCyan;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNuevo.Location = new System.Drawing.Point(54, 54);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 48;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 455);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 58);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccion de acciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(178, 20);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Location = new System.Drawing.Point(16, 20);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Location = new System.Drawing.Point(97, 20);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // grupboxDatos
            // 
            this.grupboxDatos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grupboxDatos.Controls.Add(this.txtIdEncuesta);
            this.grupboxDatos.Controls.Add(this.label10);
            this.grupboxDatos.Controls.Add(this.txtId);
            this.grupboxDatos.Controls.Add(this.label9);
            this.grupboxDatos.Controls.Add(this.btnVolver);
            this.grupboxDatos.Controls.Add(this.btnCancelar);
            this.grupboxDatos.Controls.Add(this.cboEncuesta);
            this.grupboxDatos.Controls.Add(this.txtO4);
            this.grupboxDatos.Controls.Add(this.txtO3);
            this.grupboxDatos.Controls.Add(this.txtO2);
            this.grupboxDatos.Controls.Add(this.txtO1);
            this.grupboxDatos.Controls.Add(this.txtPregunta);
            this.grupboxDatos.Controls.Add(this.label8);
            this.grupboxDatos.Controls.Add(this.label7);
            this.grupboxDatos.Controls.Add(this.label6);
            this.grupboxDatos.Controls.Add(this.label5);
            this.grupboxDatos.Controls.Add(this.label4);
            this.grupboxDatos.Controls.Add(this.label3);
            this.grupboxDatos.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupboxDatos.Location = new System.Drawing.Point(40, 83);
            this.grupboxDatos.Name = "grupboxDatos";
            this.grupboxDatos.Size = new System.Drawing.Size(234, 355);
            this.grupboxDatos.TabIndex = 46;
            this.grupboxDatos.TabStop = false;
            this.grupboxDatos.Text = "Datos de encuesta";
            // 
            // txtIdEncuesta
            // 
            this.txtIdEncuesta.Cursor = System.Windows.Forms.Cursors.No;
            this.txtIdEncuesta.Location = new System.Drawing.Point(95, 254);
            this.txtIdEncuesta.Name = "txtIdEncuesta";
            this.txtIdEncuesta.Size = new System.Drawing.Size(43, 21);
            this.txtIdEncuesta.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Id Encuesta:";
            // 
            // txtId
            // 
            this.txtId.Cursor = System.Windows.Forms.Cursors.No;
            this.txtId.Location = new System.Drawing.Point(162, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(44, 21);
            this.txtId.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Id:";
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Location = new System.Drawing.Point(27, 317);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(131, 317);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboEncuesta
            // 
            this.cboEncuesta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboEncuesta.FormattingEnabled = true;
            this.cboEncuesta.Location = new System.Drawing.Point(25, 290);
            this.cboEncuesta.Name = "cboEncuesta";
            this.cboEncuesta.Size = new System.Drawing.Size(181, 21);
            this.cboEncuesta.TabIndex = 11;
            // 
            // txtO4
            // 
            this.txtO4.Location = new System.Drawing.Point(25, 219);
            this.txtO4.Name = "txtO4";
            this.txtO4.Size = new System.Drawing.Size(181, 21);
            this.txtO4.TabIndex = 10;
            // 
            // txtO3
            // 
            this.txtO3.Location = new System.Drawing.Point(25, 179);
            this.txtO3.Name = "txtO3";
            this.txtO3.Size = new System.Drawing.Size(181, 21);
            this.txtO3.TabIndex = 9;
            // 
            // txtO2
            // 
            this.txtO2.Location = new System.Drawing.Point(25, 139);
            this.txtO2.Name = "txtO2";
            this.txtO2.Size = new System.Drawing.Size(181, 21);
            this.txtO2.TabIndex = 8;
            // 
            // txtO1
            // 
            this.txtO1.Location = new System.Drawing.Point(25, 99);
            this.txtO1.Name = "txtO1";
            this.txtO1.Size = new System.Drawing.Size(181, 21);
            this.txtO1.TabIndex = 7;
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(25, 59);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(181, 21);
            this.txtPregunta.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Encuesta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Opcion 4:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Opcion 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Opcion 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Opcion 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pregunta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(28, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 30);
            this.label2.TabIndex = 45;
            this.label2.Text = "Preguntas Encuestas";
            // 
            // dtaPreguntas
            // 
            this.dtaPreguntas.AllowUserToAddRows = false;
            this.dtaPreguntas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaPreguntas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaPreguntas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtaPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaPreguntas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtaPreguntas.Location = new System.Drawing.Point(317, 12);
            this.dtaPreguntas.MultiSelect = false;
            this.dtaPreguntas.Name = "dtaPreguntas";
            this.dtaPreguntas.ReadOnly = true;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dtaPreguntas.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtaPreguntas.Size = new System.Drawing.Size(453, 501);
            this.dtaPreguntas.TabIndex = 50;
            this.dtaPreguntas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaPreguntas_CellClick);
            // 
            // FormularioPreguntaEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(807, 525);
            this.Controls.Add(this.dtaPreguntas);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grupboxDatos);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioPreguntaEncuesta";
            this.Text = "PreguntaEncuesta";
            this.Load += new System.EventHandler(this.PreguntaEncuesta_Load);
            this.groupBox1.ResumeLayout(false);
            this.grupboxDatos.ResumeLayout(false);
            this.grupboxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaPreguntas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox grupboxDatos;
        private System.Windows.Forms.TextBox txtIdEncuesta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboEncuesta;
        private System.Windows.Forms.TextBox txtO4;
        private System.Windows.Forms.TextBox txtO3;
        private System.Windows.Forms.TextBox txtO2;
        private System.Windows.Forms.TextBox txtO1;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtaPreguntas;
    }
}