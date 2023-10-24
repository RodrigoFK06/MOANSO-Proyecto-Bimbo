namespace CapaPresentacion
{
    partial class FormularioDocumentoResultadosProgreso
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
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.listaDocResultadosProgreso = new System.Windows.Forms.DataGridView();
            this.pickerFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboEmpleados = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaDocResultadosProgreso)).BeginInit();
            this.SuspendLayout();
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(173, 154);
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(207, 20);
            this.txtResultados.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Resultados:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(305, 258);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 75;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(173, 258);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 74;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // listaDocResultadosProgreso
            // 
            this.listaDocResultadosProgreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDocResultadosProgreso.Location = new System.Drawing.Point(448, 121);
            this.listaDocResultadosProgreso.Name = "listaDocResultadosProgreso";
            this.listaDocResultadosProgreso.Size = new System.Drawing.Size(439, 228);
            this.listaDocResultadosProgreso.TabIndex = 73;
            // 
            // pickerFechaCreacion
            // 
            this.pickerFechaCreacion.Location = new System.Drawing.Point(173, 115);
            this.pickerFechaCreacion.Name = "pickerFechaCreacion";
            this.pickerFechaCreacion.Size = new System.Drawing.Size(207, 20);
            this.pickerFechaCreacion.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Fecha Creacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 29);
            this.label1.TabIndex = 70;
            this.label1.Text = "Documento Resultados Progreso";
            // 
            // comboEmpleados
            // 
            this.comboEmpleados.FormattingEnabled = true;
            this.comboEmpleados.Location = new System.Drawing.Point(173, 192);
            this.comboEmpleados.Name = "comboEmpleados";
            this.comboEmpleados.Size = new System.Drawing.Size(207, 21);
            this.comboEmpleados.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Empleado:";
            // 
            // FormularioDocumentoResultadosProgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.comboEmpleados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.listaDocResultadosProgreso);
            this.Controls.Add(this.pickerFechaCreacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioDocumentoResultadosProgreso";
            this.Text = "FormularioDocumentoResultadosProgreso";
            ((System.ComponentModel.ISupportInitialize)(this.listaDocResultadosProgreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView listaDocResultadosProgreso;
        private System.Windows.Forms.DateTimePicker pickerFechaCreacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboEmpleados;
        private System.Windows.Forms.Label label5;
    }
}