namespace DI_Tema4_Ejer8
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
            this.abrir = new System.Windows.Forms.Button();
            this.retroceso = new System.Windows.Forms.Button();
            this.avance = new System.Windows.Forms.Button();
            this.labelDirectorio = new System.Windows.Forms.Label();
            this.labelDatos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // abrir
            // 
            this.abrir.Location = new System.Drawing.Point(644, 42);
            this.abrir.Name = "abrir";
            this.abrir.Size = new System.Drawing.Size(75, 23);
            this.abrir.TabIndex = 0;
            this.abrir.Text = "Abrir";
            this.abrir.UseVisualStyleBackColor = true;
            this.abrir.Click += new System.EventHandler(this.abrir_Click);
            // 
            // retroceso
            // 
            this.retroceso.Location = new System.Drawing.Point(644, 90);
            this.retroceso.Name = "retroceso";
            this.retroceso.Size = new System.Drawing.Size(75, 23);
            this.retroceso.TabIndex = 1;
            this.retroceso.Text = "<=";
            this.retroceso.UseVisualStyleBackColor = true;
            this.retroceso.Click += new System.EventHandler(this.retroceso_Click);
            // 
            // avance
            // 
            this.avance.Location = new System.Drawing.Point(644, 135);
            this.avance.Name = "avance";
            this.avance.Size = new System.Drawing.Size(75, 23);
            this.avance.TabIndex = 2;
            this.avance.Text = "=>";
            this.avance.UseVisualStyleBackColor = true;
            this.avance.Click += new System.EventHandler(this.avance_Click);
            // 
            // labelDirectorio
            // 
            this.labelDirectorio.AutoSize = true;
            this.labelDirectorio.Location = new System.Drawing.Point(644, 190);
            this.labelDirectorio.Name = "labelDirectorio";
            this.labelDirectorio.Size = new System.Drawing.Size(0, 13);
            this.labelDirectorio.TabIndex = 3;
            // 
            // labelDatos
            // 
            this.labelDatos.AutoSize = true;
            this.labelDatos.Location = new System.Drawing.Point(644, 222);
            this.labelDatos.Name = "labelDatos";
            this.labelDatos.Size = new System.Drawing.Size(0, 13);
            this.labelDatos.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 387);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDatos);
            this.Controls.Add(this.labelDirectorio);
            this.Controls.Add(this.avance);
            this.Controls.Add(this.retroceso);
            this.Controls.Add(this.abrir);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button abrir;
        private System.Windows.Forms.Button retroceso;
        private System.Windows.Forms.Button avance;
        private System.Windows.Forms.Label labelDirectorio;
        private System.Windows.Forms.Label labelDatos;
        private System.Windows.Forms.Panel panel1;
    }
}

