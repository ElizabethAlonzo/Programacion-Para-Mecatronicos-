namespace Proyecto_32
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
            this.BT_Invalidate = new System.Windows.Forms.Button();
            this.BT_Dibuje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_Invalidate
            // 
            this.BT_Invalidate.Location = new System.Drawing.Point(273, 64);
            this.BT_Invalidate.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Invalidate.Name = "BT_Invalidate";
            this.BT_Invalidate.Size = new System.Drawing.Size(76, 19);
            this.BT_Invalidate.TabIndex = 0;
            this.BT_Invalidate.Text = "Invalidate";
            this.BT_Invalidate.UseVisualStyleBackColor = true;
            // 
            // BT_Dibuje
            // 
            this.BT_Dibuje.Location = new System.Drawing.Point(273, 118);
            this.BT_Dibuje.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Dibuje.Name = "BT_Dibuje";
            this.BT_Dibuje.Size = new System.Drawing.Size(76, 19);
            this.BT_Dibuje.TabIndex = 1;
            this.BT_Dibuje.Text = "Dibuje";
            this.BT_Dibuje.UseVisualStyleBackColor = true;
            this.BT_Dibuje.Click += new System.EventHandler(this.BT_Dibuje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 242);
            this.Controls.Add(this.BT_Dibuje);
            this.Controls.Add(this.BT_Invalidate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_Invalidate;
        private System.Windows.Forms.Button BT_Dibuje;
    }
}

