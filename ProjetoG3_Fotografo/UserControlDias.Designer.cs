namespace ProjetoG3_Fotografo
{
    partial class UserControlDias
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDias
            // 
            this.lbDias.AutoSize = true;
            this.lbDias.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDias.Location = new System.Drawing.Point(38, 10);
            this.lbDias.Name = "lbDias";
            this.lbDias.Size = new System.Drawing.Size(25, 20);
            this.lbDias.TabIndex = 0;
            this.lbDias.Text = "00";
            // 
            // UserControlDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbDias);
            this.Name = "UserControlDias";
            this.Size = new System.Drawing.Size(101, 62);
            this.Load += new System.EventHandler(this.UserControlDias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbDias;
    }
}
