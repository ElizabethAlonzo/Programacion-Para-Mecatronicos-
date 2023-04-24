namespace Proyecto_37
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
            this.BT_Uno = new System.Windows.Forms.Button();
            this.LB_Mensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_Uno
            // 
            this.BT_Uno.Location = new System.Drawing.Point(53, 48);
            this.BT_Uno.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Uno.Name = "BT_Uno";
            this.BT_Uno.Size = new System.Drawing.Size(56, 19);
            this.BT_Uno.TabIndex = 0;
            this.BT_Uno.Text = "Uno";
            this.BT_Uno.UseVisualStyleBackColor = true;
            this.BT_Uno.Click += new System.EventHandler(this.BT_Uno_Click);
            // 
            // LB_Mensaje
            // 
            this.LB_Mensaje.AutoSize = true;
            this.LB_Mensaje.Location = new System.Drawing.Point(59, 80);
            this.LB_Mensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Mensaje.Name = "LB_Mensaje";
            this.LB_Mensaje.Size = new System.Drawing.Size(35, 13);
            this.LB_Mensaje.TabIndex = 3;
            this.LB_Mensaje.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 301);
            this.Controls.Add(this.LB_Mensaje);
            this.Controls.Add(this.BT_Uno);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Uno;
        private System.Windows.Forms.Label LB_Mensaje;
    }
}

