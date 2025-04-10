namespace Projeto_Voluntariado.View.telas_Cadastro_ONG
{
    partial class TelaHomeOng
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
            this.btn_SairVlt = new System.Windows.Forms.Button();
            this.btn_VoltarVlt = new System.Windows.Forms.Button();
            this.btn_MyOpsOng = new System.Windows.Forms.Button();
            this.btn_CriarOpOng = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ListVolunt_Ong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SairVlt
            // 
            this.btn_SairVlt.Location = new System.Drawing.Point(590, 578);
            this.btn_SairVlt.Name = "btn_SairVlt";
            this.btn_SairVlt.Size = new System.Drawing.Size(126, 43);
            this.btn_SairVlt.TabIndex = 9;
            this.btn_SairVlt.Text = "Sair";
            this.btn_SairVlt.UseVisualStyleBackColor = true;
            // 
            // btn_VoltarVlt
            // 
            this.btn_VoltarVlt.Location = new System.Drawing.Point(439, 578);
            this.btn_VoltarVlt.Name = "btn_VoltarVlt";
            this.btn_VoltarVlt.Size = new System.Drawing.Size(126, 43);
            this.btn_VoltarVlt.TabIndex = 8;
            this.btn_VoltarVlt.Text = "Voltar";
            this.btn_VoltarVlt.UseVisualStyleBackColor = true;
            // 
            // btn_MyOpsOng
            // 
            this.btn_MyOpsOng.Location = new System.Drawing.Point(146, 225);
            this.btn_MyOpsOng.Name = "btn_MyOpsOng";
            this.btn_MyOpsOng.Size = new System.Drawing.Size(220, 104);
            this.btn_MyOpsOng.TabIndex = 7;
            this.btn_MyOpsOng.Text = "Visualizar minhas oportunidades publicadas";
            this.btn_MyOpsOng.UseVisualStyleBackColor = true;
            // 
            // btn_CriarOpOng
            // 
            this.btn_CriarOpOng.Location = new System.Drawing.Point(146, 115);
            this.btn_CriarOpOng.Name = "btn_CriarOpOng";
            this.btn_CriarOpOng.Size = new System.Drawing.Size(220, 104);
            this.btn_CriarOpOng.TabIndex = 6;
            this.btn_CriarOpOng.Text = "publicar oportunidade";
            this.btn_CriarOpOng.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Olá, XXXX.\r\n\r\nO que vamos fazer hoje:";
            // 
            // btn_ListVolunt_Ong
            // 
            this.btn_ListVolunt_Ong.Location = new System.Drawing.Point(146, 335);
            this.btn_ListVolunt_Ong.Name = "btn_ListVolunt_Ong";
            this.btn_ListVolunt_Ong.Size = new System.Drawing.Size(220, 104);
            this.btn_ListVolunt_Ong.TabIndex = 10;
            this.btn_ListVolunt_Ong.Text = "Visualizar lista de Voluntários";
            this.btn_ListVolunt_Ong.UseVisualStyleBackColor = true;
            // 
            // TelaHomeOng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 623);
            this.Controls.Add(this.btn_ListVolunt_Ong);
            this.Controls.Add(this.btn_SairVlt);
            this.Controls.Add(this.btn_VoltarVlt);
            this.Controls.Add(this.btn_MyOpsOng);
            this.Controls.Add(this.btn_CriarOpOng);
            this.Controls.Add(this.label1);
            this.Name = "TelaHomeOng";
            this.Text = "TelaHomeOng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SairVlt;
        private System.Windows.Forms.Button btn_VoltarVlt;
        private System.Windows.Forms.Button btn_MyOpsOng;
        private System.Windows.Forms.Button btn_CriarOpOng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ListVolunt_Ong;
    }
}