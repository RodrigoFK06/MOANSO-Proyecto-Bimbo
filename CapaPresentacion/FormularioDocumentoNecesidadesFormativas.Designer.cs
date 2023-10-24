namespace CapaPresentacion
{
    partial class FormularioDocumentoNecesidadesFormativas
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
            this.pickerFechaImplementacion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNecesidades = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.listaDocNecesidadesFormativas = new System.Windows.Forms.DataGridView();
            this.pickerFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaDocNecesidadesFormativas)).BeginInit();
            this.SuspendLayout();
            // 
            // pickerFechaImplementacion
            // 
            this.pickerFechaImplementacion.Location = new System.Drawing.Point(173, 196);
            this.pickerFechaImplementacion.Name = "pickerFechaImplementacion";
            this.pickerFechaImplementacion.Size = new System.Drawing.Size(207, 20);
            this.pickerFechaImplementacion.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Fecha Implementacion:";
            // 
            // txtNecesidades
            // 
            this.txtNecesidades.Location = new System.Drawing.Point(173, 155);
            this.txtNecesidades.Name = "txtNecesidades";
            this.txtNecesidades.Size = new System.Drawing.Size(207, 20);
            this.txtNecesidades.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Necesidades:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(305, 259);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(173, 259);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 58;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // listaDocNecesidadesFormativas
            // 
            this.listaDocNecesidadesFormativas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDocNecesidadesFormativas.Location = new System.Drawing.Point(448, 122);
            this.listaDocNecesidadesFormativas.Name = "listaDocNecesidadesFormativas";
            this.listaDocNecesidadesFormativas.Size = new System.Drawing.Size(439, 228);
            this.listaDocNecesidadesFormativas.TabIndex = 57;
            // 
            // pickerFechaCreacion
            // 
            this.pickerFechaCreacion.Location = new System.Drawing.Point(173, 116);
            this.pickerFechaCreacion.Name = "pickerFechaCreacion";
            this.pickerFechaCreacion.Size = new System.Drawing.Size(207, 20);
            this.pickerFechaCreacion.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Fecha Creacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = "Documento Necesidades Formativas";
            // 
            // FormularioDocumentoNecesidadesFormativas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.pickerFechaImplementacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNecesidades);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.listaDocNecesidadesFormativas);
            this.Controls.Add(this.pickerFechaCreacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioDocumentoNecesidadesFormativas";
            this.Text = "FormularioDocumentoNecesidadesFormativas";
            ((System.ComponentModel.ISupportInitialize)(this.listaDocNecesidadesFormativas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker pickerFechaImplementacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNecesidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView listaDocNecesidadesFormativas;
        private System.Windows.Forms.DateTimePicker pickerFechaCreacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}