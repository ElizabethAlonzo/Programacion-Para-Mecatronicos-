namespace Proyecto_19
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
            this.LV_Alimentos = new System.Windows.Forms.ListView();
            this.TX_Elmento = new System.Windows.Forms.TextBox();
            this.GB_Grupos = new System.Windows.Forms.GroupBox();
            this.BT_Agregar = new System.Windows.Forms.Button();
            this.RB_Carnes = new System.Windows.Forms.RadioButton();
            this.RB_Frutas = new System.Windows.Forms.RadioButton();
            this.GB_Grupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // LV_Alimentos
            // 
            this.LV_Alimentos.HideSelection = false;
            this.LV_Alimentos.Location = new System.Drawing.Point(67, 11);
            this.LV_Alimentos.Margin = new System.Windows.Forms.Padding(2);
            this.LV_Alimentos.Name = "LV_Alimentos";
            this.LV_Alimentos.Size = new System.Drawing.Size(300, 182);
            this.LV_Alimentos.TabIndex = 0;
            this.LV_Alimentos.UseCompatibleStateImageBehavior = false;
            this.LV_Alimentos.SelectedIndexChanged += new System.EventHandler(this.LV_Alimentos_SelectedIndexChanged);
            // 
            // TX_Elmento
            // 
            this.TX_Elmento.Location = new System.Drawing.Point(94, 219);
            this.TX_Elmento.Margin = new System.Windows.Forms.Padding(2);
            this.TX_Elmento.Name = "TX_Elmento";
            this.TX_Elmento.Size = new System.Drawing.Size(76, 20);
            this.TX_Elmento.TabIndex = 1;
            // 
            // GB_Grupos
            // 
            this.GB_Grupos.Controls.Add(this.BT_Agregar);
            this.GB_Grupos.Controls.Add(this.RB_Carnes);
            this.GB_Grupos.Controls.Add(this.RB_Frutas);
            this.GB_Grupos.Location = new System.Drawing.Point(217, 219);
            this.GB_Grupos.Margin = new System.Windows.Forms.Padding(2);
            this.GB_Grupos.Name = "GB_Grupos";
            this.GB_Grupos.Padding = new System.Windows.Forms.Padding(2);
            this.GB_Grupos.Size = new System.Drawing.Size(150, 81);
            this.GB_Grupos.TabIndex = 2;
            this.GB_Grupos.TabStop = false;
            this.GB_Grupos.Text = "Grupos";
            // 
            // BT_Agregar
            // 
            this.BT_Agregar.Location = new System.Drawing.Point(76, 26);
            this.BT_Agregar.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Agregar.Name = "BT_Agregar";
            this.BT_Agregar.Size = new System.Drawing.Size(56, 19);
            this.BT_Agregar.TabIndex = 2;
            this.BT_Agregar.Text = "Agregar";
            this.BT_Agregar.UseVisualStyleBackColor = true;
            this.BT_Agregar.Click += new System.EventHandler(this.BT_Agregar_Click);
            // 
            // RB_Carnes
            // 
            this.RB_Carnes.AutoSize = true;
            this.RB_Carnes.Location = new System.Drawing.Point(4, 36);
            this.RB_Carnes.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Carnes.Name = "RB_Carnes";
            this.RB_Carnes.Size = new System.Drawing.Size(58, 17);
            this.RB_Carnes.TabIndex = 1;
            this.RB_Carnes.TabStop = true;
            this.RB_Carnes.Text = "Carnes";
            this.RB_Carnes.UseVisualStyleBackColor = true;
            // 
            // RB_Frutas
            // 
            this.RB_Frutas.AutoSize = true;
            this.RB_Frutas.Location = new System.Drawing.Point(2, 15);
            this.RB_Frutas.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Frutas.Name = "RB_Frutas";
            this.RB_Frutas.Size = new System.Drawing.Size(54, 17);
            this.RB_Frutas.TabIndex = 0;
            this.RB_Frutas.TabStop = true;
            this.RB_Frutas.Text = "Frutas";
            this.RB_Frutas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 334);
            this.Controls.Add(this.GB_Grupos);
            this.Controls.Add(this.TX_Elmento);
            this.Controls.Add(this.LV_Alimentos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB_Grupos.ResumeLayout(false);
            this.GB_Grupos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LV_Alimentos;
        private System.Windows.Forms.TextBox TX_Elmento;
        private System.Windows.Forms.GroupBox GB_Grupos;
        private System.Windows.Forms.Button BT_Agregar;
        private System.Windows.Forms.RadioButton RB_Carnes;
        private System.Windows.Forms.RadioButton RB_Frutas;
    }
}

