namespace Proyecto_15
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
            this.CB_Alimentos = new System.Windows.Forms.ComboBox();
            this.TB_Agregar = new System.Windows.Forms.TextBox();
            this.BT_Adicionar = new System.Windows.Forms.Button();
            this.LB_Indice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CB_Alimentos
            // 
            this.CB_Alimentos.FormattingEnabled = true;
            this.CB_Alimentos.Items.AddRange(new object[] {
            "Galletas",
            "Té",
            "Chocolate "});
            this.CB_Alimentos.Location = new System.Drawing.Point(68, 34);
            this.CB_Alimentos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CB_Alimentos.Name = "CB_Alimentos";
            this.CB_Alimentos.Size = new System.Drawing.Size(118, 21);
            this.CB_Alimentos.TabIndex = 0;
            this.CB_Alimentos.Text = "Alimentos";
            this.CB_Alimentos.SelectedIndexChanged += new System.EventHandler(this.CB_Alimentos_SelectedIndexChanged);
            // 
            // TB_Agregar
            // 
            this.TB_Agregar.Location = new System.Drawing.Point(29, 79);
            this.TB_Agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Agregar.Name = "TB_Agregar";
            this.TB_Agregar.Size = new System.Drawing.Size(76, 20);
            this.TB_Agregar.TabIndex = 1;
            // 
            // BT_Adicionar
            // 
            this.BT_Adicionar.Location = new System.Drawing.Point(133, 79);
            this.BT_Adicionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BT_Adicionar.Name = "BT_Adicionar";
            this.BT_Adicionar.Size = new System.Drawing.Size(69, 24);
            this.BT_Adicionar.TabIndex = 2;
            this.BT_Adicionar.Text = "Adicionar";
            this.BT_Adicionar.UseVisualStyleBackColor = true;
            this.BT_Adicionar.Click += new System.EventHandler(this.BT_Adicionar_Click);
            // 
            // LB_Indice
            // 
            this.LB_Indice.AutoSize = true;
            this.LB_Indice.Location = new System.Drawing.Point(47, 64);
            this.LB_Indice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Indice.Name = "LB_Indice";
            this.LB_Indice.Size = new System.Drawing.Size(35, 13);
            this.LB_Indice.TabIndex = 3;
            this.LB_Indice.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 219);
            this.Controls.Add(this.LB_Indice);
            this.Controls.Add(this.BT_Adicionar);
            this.Controls.Add(this.TB_Agregar);
            this.Controls.Add(this.CB_Alimentos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Alimentos;
        private System.Windows.Forms.TextBox TB_Agregar;
        private System.Windows.Forms.Button BT_Adicionar;
        private System.Windows.Forms.Label LB_Indice;
    }
}

