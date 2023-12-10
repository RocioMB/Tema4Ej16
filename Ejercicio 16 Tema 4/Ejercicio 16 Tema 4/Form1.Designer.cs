namespace Ejercicio_16_Tema_4
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
            this.factorialBtn = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.introduzcaNLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // factorialBtn
            // 
            this.factorialBtn.Location = new System.Drawing.Point(325, 204);
            this.factorialBtn.Name = "factorialBtn";
            this.factorialBtn.Size = new System.Drawing.Size(131, 60);
            this.factorialBtn.TabIndex = 0;
            this.factorialBtn.Text = "Calcular factorial";
            this.factorialBtn.UseVisualStyleBackColor = true;
            this.factorialBtn.Click += new System.EventHandler(this.factorialBtn_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(361, 128);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(117, 26);
            this.txtN.TabIndex = 1;
            // 
            // introduzcaNLabel
            // 
            this.introduzcaNLabel.AutoSize = true;
            this.introduzcaNLabel.Location = new System.Drawing.Point(207, 131);
            this.introduzcaNLabel.Name = "introduzcaNLabel";
            this.introduzcaNLabel.Size = new System.Drawing.Size(138, 20);
            this.introduzcaNLabel.TabIndex = 2;
            this.introduzcaNLabel.Text = "Introducir número:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.introduzcaNLabel);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.factorialBtn);
            this.Name = "Form1";
            this.Text = "Ejercicio 16 Tema 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button factorialBtn;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label introduzcaNLabel;
    }
}

