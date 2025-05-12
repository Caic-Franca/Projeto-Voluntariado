namespace Projeto_Voluntariado.View.telas_Cadastro_ONG
{
    partial class TelaCriarOpOng
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOportunidadesOng = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOportunidadesOng)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Voluntários: ";
            // 
            // dgvOportunidadesOng
            // 
            this.dgvOportunidadesOng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOportunidadesOng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOportunidadesOng.Location = new System.Drawing.Point(0, 0);
            this.dgvOportunidadesOng.Name = "dgvOportunidadesOng";
            this.dgvOportunidadesOng.Size = new System.Drawing.Size(611, 797);
            this.dgvOportunidadesOng.TabIndex = 2;
            // 
            // TelaCriarOpOng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(611, 797);
            this.Controls.Add(this.dgvOportunidadesOng);
            this.Controls.Add(this.label1);
            this.Name = "TelaCriarOpOng";
            this.Text = "ListaDeVoluntarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOportunidadesOng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOportunidadesOng;
    }
}