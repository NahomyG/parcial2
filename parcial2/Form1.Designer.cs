namespace parcial2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.DG = new System.Windows.Forms.GroupBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GD = new System.Windows.Forms.Button();
            this.Hombre = new System.Windows.Forms.RadioButton();
            this.Mujer = new System.Windows.Forms.RadioButton();
            this.CU = new System.Windows.Forms.Label();
            this.Cic = new System.Windows.Forms.Label();
            this.txtCum = new System.Windows.Forms.TextBox();
            this.txtCiclo = new System.Windows.Forms.TextBox();
            this.lblCarrera = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.Label();
            this.NC = new System.Windows.Forms.Label();
            this.Profesor = new System.Windows.Forms.Label();
            this.rdbProfesor = new System.Windows.Forms.TextBox();
            this.DG.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(17, 85);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(237, 20);
            this.txtNombres.TabIndex = 0;
            // 
            // DG
            // 
            this.DG.Controls.Add(this.rdbProfesor);
            this.DG.Controls.Add(this.Profesor);
            this.DG.Controls.Add(this.txtApellidos);
            this.DG.Controls.Add(this.label1);
            this.DG.Controls.Add(this.GD);
            this.DG.Controls.Add(this.Hombre);
            this.DG.Controls.Add(this.Mujer);
            this.DG.Controls.Add(this.CU);
            this.DG.Controls.Add(this.Cic);
            this.DG.Controls.Add(this.txtCum);
            this.DG.Controls.Add(this.txtCiclo);
            this.DG.Controls.Add(this.lblCarrera);
            this.DG.Controls.Add(this.txtCarrera);
            this.DG.Controls.Add(this.NC);
            this.DG.Controls.Add(this.txtNombres);
            this.DG.Location = new System.Drawing.Point(22, 12);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(766, 426);
            this.DG.TabIndex = 1;
            this.DG.TabStop = false;
            this.DG.Text = "Datos Generales";
            this.DG.UseCompatibleTextRendering = true;
            this.DG.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(457, 85);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(237, 20);
            this.txtApellidos.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Apellidos";
            // 
            // GD
            // 
            this.GD.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GD.Location = new System.Drawing.Point(557, 333);
            this.GD.Name = "GD";
            this.GD.Size = new System.Drawing.Size(137, 53);
            this.GD.TabIndex = 10;
            this.GD.Text = "Guardar Datos";
            this.GD.UseVisualStyleBackColor = false;
            this.GD.Click += new System.EventHandler(this.GD_Click);
            // 
            // Hombre
            // 
            this.Hombre.AutoSize = true;
            this.Hombre.Location = new System.Drawing.Point(632, 270);
            this.Hombre.Name = "Hombre";
            this.Hombre.Size = new System.Drawing.Size(62, 17);
            this.Hombre.TabIndex = 9;
            this.Hombre.TabStop = true;
            this.Hombre.Text = "Hombre";
            this.Hombre.UseVisualStyleBackColor = true;
            // 
            // Mujer
            // 
            this.Mujer.AutoSize = true;
            this.Mujer.Location = new System.Drawing.Point(515, 270);
            this.Mujer.Name = "Mujer";
            this.Mujer.Size = new System.Drawing.Size(51, 17);
            this.Mujer.TabIndex = 8;
            this.Mujer.TabStop = true;
            this.Mujer.Text = "Mujer";
            this.Mujer.UseVisualStyleBackColor = true;
            this.Mujer.CheckedChanged += new System.EventHandler(this.Mujer_CheckedChanged);
            // 
            // CU
            // 
            this.CU.AutoSize = true;
            this.CU.BackColor = System.Drawing.SystemColors.Window;
            this.CU.Location = new System.Drawing.Point(14, 333);
            this.CU.Name = "CU";
            this.CU.Size = new System.Drawing.Size(31, 13);
            this.CU.TabIndex = 7;
            this.CU.Text = "CUM";
            // 
            // Cic
            // 
            this.Cic.AutoSize = true;
            this.Cic.Location = new System.Drawing.Point(14, 237);
            this.Cic.Name = "Cic";
            this.Cic.Size = new System.Drawing.Size(30, 13);
            this.Cic.TabIndex = 6;
            this.Cic.Text = "Ciclo";
            // 
            // txtCum
            // 
            this.txtCum.Location = new System.Drawing.Point(17, 364);
            this.txtCum.Name = "txtCum";
            this.txtCum.Size = new System.Drawing.Size(100, 20);
            this.txtCum.TabIndex = 5;
            // 
            // txtCiclo
            // 
            this.txtCiclo.Location = new System.Drawing.Point(17, 267);
            this.txtCiclo.Name = "txtCiclo";
            this.txtCiclo.Size = new System.Drawing.Size(185, 20);
            this.txtCiclo.TabIndex = 4;
            // 
            // lblCarrera
            // 
            this.lblCarrera.Location = new System.Drawing.Point(17, 175);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(185, 20);
            this.lblCarrera.TabIndex = 3;
            // 
            // txtCarrera
            // 
            this.txtCarrera.AutoSize = true;
            this.txtCarrera.Location = new System.Drawing.Point(14, 133);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(41, 13);
            this.txtCarrera.TabIndex = 2;
            this.txtCarrera.Text = "Carrera";
            // 
            // NC
            // 
            this.NC.AutoSize = true;
            this.NC.Location = new System.Drawing.Point(14, 54);
            this.NC.Name = "NC";
            this.NC.Size = new System.Drawing.Size(49, 13);
            this.NC.TabIndex = 1;
            this.NC.Text = "Nombres";
            // 
            // Profesor
            // 
            this.Profesor.AutoSize = true;
            this.Profesor.Location = new System.Drawing.Point(454, 133);
            this.Profesor.Name = "Profesor";
            this.Profesor.Size = new System.Drawing.Size(103, 13);
            this.Profesor.TabIndex = 13;
            this.Profesor.Text = "Nombre del Profesor";
            // 
            // rdbProfesor
            // 
            this.rdbProfesor.Location = new System.Drawing.Point(457, 175);
            this.rdbProfesor.Name = "rdbProfesor";
            this.rdbProfesor.Size = new System.Drawing.Size(237, 20);
            this.rdbProfesor.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DG);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DG.ResumeLayout(false);
            this.DG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.GroupBox DG;
        private System.Windows.Forms.TextBox lblCarrera;
        private System.Windows.Forms.Label txtCarrera;
        private System.Windows.Forms.Label NC;
        private System.Windows.Forms.Label Cic;
        private System.Windows.Forms.TextBox txtCum;
        private System.Windows.Forms.TextBox txtCiclo;
        private System.Windows.Forms.Label CU;
        private System.Windows.Forms.RadioButton Hombre;
        private System.Windows.Forms.RadioButton Mujer;
        private System.Windows.Forms.Button GD;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Profesor;
        private System.Windows.Forms.TextBox rdbProfesor;
    }
}

