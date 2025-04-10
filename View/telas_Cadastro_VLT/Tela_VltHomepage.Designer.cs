namespace Projeto_Voluntariado.View.telas_VLT
{
    partial class Tela_VltHomepage
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
            this.btn_OpListVlt = new System.Windows.Forms.Button();
            this.btn_MyOpsVlt = new System.Windows.Forms.Button();
            this.btn_VoltarVlt = new System.Windows.Forms.Button();
            this.btn_SairVlt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Olá, XXXX.\r\n\r\nO que vamos fazer hoje:";
            // 
            // btn_OpListVlt
            // 
            this.btn_OpListVlt.Location = new System.Drawing.Point(15, 97);
            this.btn_OpListVlt.Name = "btn_OpListVlt";
            this.btn_OpListVlt.Size = new System.Drawing.Size(220, 104);
            this.btn_OpListVlt.TabIndex = 1;
            this.btn_OpListVlt.Text = "Verificar lista de oportunidades";
            this.btn_OpListVlt.UseVisualStyleBackColor = true;
            // 
            // btn_MyOpsVlt
            // 
            this.btn_MyOpsVlt.Location = new System.Drawing.Point(15, 207);
            this.btn_MyOpsVlt.Name = "btn_MyOpsVlt";
            this.btn_MyOpsVlt.Size = new System.Drawing.Size(220, 104);
            this.btn_MyOpsVlt.TabIndex = 2;
            this.btn_MyOpsVlt.Text = "Visualizar minhas oportunidades";
            this.btn_MyOpsVlt.UseVisualStyleBackColor = true;
            // 
            // btn_VoltarVlt
            // 
            this.btn_VoltarVlt.Location = new System.Drawing.Point(453, 504);
            this.btn_VoltarVlt.Name = "btn_VoltarVlt";
            this.btn_VoltarVlt.Size = new System.Drawing.Size(126, 43);
            this.btn_VoltarVlt.TabIndex = 3;
            this.btn_VoltarVlt.Text = "Voltar";
            this.btn_VoltarVlt.UseVisualStyleBackColor = true;
            // 
            // btn_SairVlt
            // 
            this.btn_SairVlt.Location = new System.Drawing.Point(585, 504);
            this.btn_SairVlt.Name = "btn_SairVlt";
            this.btn_SairVlt.Size = new System.Drawing.Size(126, 43);
            this.btn_SairVlt.TabIndex = 4;
            this.btn_SairVlt.Text = "Sair";
            this.btn_SairVlt.UseVisualStyleBackColor = true;
            // 
            // Tela_VltHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 576);
            this.Controls.Add(this.btn_SairVlt);
            this.Controls.Add(this.btn_VoltarVlt);
            this.Controls.Add(this.btn_MyOpsVlt);
            this.Controls.Add(this.btn_OpListVlt);
            this.Controls.Add(this.label1);
            this.Name = "Tela_VltHomepage";
            this.Text = "Tela_VltHomepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OpListVlt;
        private System.Windows.Forms.Button btn_MyOpsVlt;
        private System.Windows.Forms.Button btn_VoltarVlt;
        private System.Windows.Forms.Button btn_SairVlt;
    }
}