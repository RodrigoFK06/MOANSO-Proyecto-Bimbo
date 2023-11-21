namespace CapaPresentacion
{
    partial class FormDetalleEvaluacionDesempeño
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
            this.dgvDetEvaDesempeño = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gbCalificarPregunta = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NudNota = new System.Windows.Forms.NumericUpDown();
            this.txtidPregEvaDesempeño = new System.Windows.Forms.TextBox();
            this.txtidDetalleEva = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetEvaDesempeño)).BeginInit();
            this.gbCalificarPregunta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudNota)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetEvaDesempeño
            // 
            this.dgvDetEvaDesempeño.AllowUserToOrderColumns = true;
            this.dgvDetEvaDesempeño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetEvaDesempeño.Location = new System.Drawing.Point(532, 199);
            this.dgvDetEvaDesempeño.Name = "dgvDetEvaDesempeño";
            this.dgvDetEvaDesempeño.ReadOnly = true;
            this.dgvDetEvaDesempeño.Size = new System.Drawing.Size(413, 277);
            this.dgvDetEvaDesempeño.TabIndex = 19;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(855, 519);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 33);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(306, 140);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 33);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(110, 140);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 33);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(379, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(323, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "DETALLE EVALUACION DESEMPEÑO";
            // 
            // gbCalificarPregunta
            // 
            this.gbCalificarPregunta.Controls.Add(this.label3);
            this.gbCalificarPregunta.Controls.Add(this.btnCancelar);
            this.gbCalificarPregunta.Controls.Add(this.btnModificar);
            this.gbCalificarPregunta.Controls.Add(this.label2);
            this.gbCalificarPregunta.Controls.Add(this.btnAgregar);
            this.gbCalificarPregunta.Controls.Add(this.label1);
            this.gbCalificarPregunta.Controls.Add(this.NudNota);
            this.gbCalificarPregunta.Controls.Add(this.txtidPregEvaDesempeño);
            this.gbCalificarPregunta.Controls.Add(this.txtidDetalleEva);
            this.gbCalificarPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCalificarPregunta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbCalificarPregunta.Location = new System.Drawing.Point(56, 199);
            this.gbCalificarPregunta.Name = "gbCalificarPregunta";
            this.gbCalificarPregunta.Size = new System.Drawing.Size(423, 310);
            this.gbCalificarPregunta.TabIndex = 14;
            this.gbCalificarPregunta.TabStop = false;
            this.gbCalificarPregunta.Text = "Calificar Pregunta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nota:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(298, 253);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 33);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificar.Location = new System.Drawing.Point(171, 253);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 33);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "idPreguntaEvaDesempeño:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Location = new System.Drawing.Point(42, 253);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 33);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "idDetalleEvaluacion:";
            // 
            // NudNota
            // 
            this.NudNota.Location = new System.Drawing.Point(81, 115);
            this.NudNota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudNota.Name = "NudNota";
            this.NudNota.Size = new System.Drawing.Size(86, 22);
            this.NudNota.TabIndex = 4;
            // 
            // txtidPregEvaDesempeño
            // 
            this.txtidPregEvaDesempeño.Location = new System.Drawing.Point(216, 165);
            this.txtidPregEvaDesempeño.Name = "txtidPregEvaDesempeño";
            this.txtidPregEvaDesempeño.Size = new System.Drawing.Size(148, 22);
            this.txtidPregEvaDesempeño.TabIndex = 3;
            // 
            // txtidDetalleEva
            // 
            this.txtidDetalleEva.Location = new System.Drawing.Point(173, 58);
            this.txtidDetalleEva.Name = "txtidDetalleEva";
            this.txtidDetalleEva.Size = new System.Drawing.Size(148, 22);
            this.txtidDetalleEva.TabIndex = 3;
            // 
            // FormDetalleEvaluacionDesempeño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1000, 617);
            this.Controls.Add(this.dgvDetEvaDesempeño);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbCalificarPregunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetalleEvaluacionDesempeño";
            this.Text = "FormDetalleEvaluacionDesempeño";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetEvaDesempeño)).EndInit();
            this.gbCalificarPregunta.ResumeLayout(false);
            this.gbCalificarPregunta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetEvaDesempeño;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbCalificarPregunta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NudNota;
        private System.Windows.Forms.TextBox txtidPregEvaDesempeño;
        private System.Windows.Forms.TextBox txtidDetalleEva;
    }
}