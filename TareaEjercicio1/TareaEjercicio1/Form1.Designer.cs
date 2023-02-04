namespace TareaEjercicio1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Calcularbutton1 = new System.Windows.Forms.Button();
            this.IngreseelvalortextBox1 = new System.Windows.Forms.TextBox();
            this.ResultadotextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el valor";
            // 
            // Calcularbutton1
            // 
            this.Calcularbutton1.Location = new System.Drawing.Point(203, 125);
            this.Calcularbutton1.Name = "Calcularbutton1";
            this.Calcularbutton1.Size = new System.Drawing.Size(75, 23);
            this.Calcularbutton1.TabIndex = 2;
            this.Calcularbutton1.Text = "Calcular";
            this.Calcularbutton1.UseVisualStyleBackColor = true;
            this.Calcularbutton1.Click += new System.EventHandler(this.Calcularbutton1_Click);
            // 
            // IngreseelvalortextBox1
            // 
            this.IngreseelvalortextBox1.Location = new System.Drawing.Point(246, 77);
            this.IngreseelvalortextBox1.Name = "IngreseelvalortextBox1";
            this.IngreseelvalortextBox1.Size = new System.Drawing.Size(100, 22);
            this.IngreseelvalortextBox1.TabIndex = 3;
            // 
            // ResultadotextBox2
            // 
            this.ResultadotextBox2.Location = new System.Drawing.Point(191, 168);
            this.ResultadotextBox2.Name = "ResultadotextBox2";
            this.ResultadotextBox2.Size = new System.Drawing.Size(189, 22);
            this.ResultadotextBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultadotextBox2);
            this.Controls.Add(this.IngreseelvalortextBox1);
            this.Controls.Add(this.Calcularbutton1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Calcularbutton1;
        private System.Windows.Forms.TextBox IngreseelvalortextBox1;
        private System.Windows.Forms.TextBox ResultadotextBox2;
    }
}

