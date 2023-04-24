namespace Proyecto_26
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
            this.LB_Mensaje = new System.Windows.Forms.Label();
            this.BT_Fuente = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // LB_Mensaje
            // 
            this.LB_Mensaje.AutoSize = true;
            this.LB_Mensaje.Location = new System.Drawing.Point(17, 73);
            this.LB_Mensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Mensaje.Name = "LB_Mensaje";
            this.LB_Mensaje.Size = new System.Drawing.Size(280, 13);
            this.LB_Mensaje.TabIndex = 0;
            this.LB_Mensaje.Text = "Hey! )¿Qué pasa chavales?¿Todo  bien? ¿todo correcto?";
           
            // 
            // BT_Fuente
            // 
            this.BT_Fuente.Location = new System.Drawing.Point(120, 129);
            this.BT_Fuente.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Fuente.Name = "BT_Fuente";
            this.BT_Fuente.Size = new System.Drawing.Size(56, 19);
            this.BT_Fuente.TabIndex = 1;
            this.BT_Fuente.Text = "Fuente";
            this.BT_Fuente.UseVisualStyleBackColor = true;
            this.BT_Fuente.Click += new System.EventHandler(this.BT_Fuente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 366);
            this.Controls.Add(this.BT_Fuente);
            this.Controls.Add(this.LB_Mensaje);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Mensaje;
        private System.Windows.Forms.Button BT_Fuente;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

