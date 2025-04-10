namespace Projeto_Voluntariado.View.telas_Cadastro_VLT
{
    partial class TelaLogSenhaVlt
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnSenVltVoltar = new System.Windows.Forms.Button();
            this.btnConfSenhVlt = new System.Windows.Forms.Button();
            this.txtVlt_useremail = new System.Windows.Forms.TextBox();
            this.txtSenha_Vlt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail do usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // btnSenVltVoltar
            // 
            this.btnSenVltVoltar.Location = new System.Drawing.Point(114, 168);
            this.btnSenVltVoltar.Name = "btnSenVltVoltar";
            this.btnSenVltVoltar.Size = new System.Drawing.Size(58, 23);
            this.btnSenVltVoltar.TabIndex = 2;
            this.btnSenVltVoltar.Text = "Voltar";
            this.btnSenVltVoltar.UseVisualStyleBackColor = true;
            // 
            // btnConfSenhVlt
            // 
            this.btnConfSenhVlt.Location = new System.Drawing.Point(178, 168);
            this.btnConfSenhVlt.Name = "btnConfSenhVlt";
            this.btnConfSenhVlt.Size = new System.Drawing.Size(58, 23);
            this.btnConfSenhVlt.TabIndex = 3;
            this.btnConfSenhVlt.Text = "Confirmar";
            this.btnConfSenhVlt.UseVisualStyleBackColor = true;
            // 
            // txtVlt_useremail
            // 
            this.txtVlt_useremail.Location = new System.Drawing.Point(53, 67);
            this.txtVlt_useremail.Name = "txtVlt_useremail";
            this.txtVlt_useremail.Size = new System.Drawing.Size(161, 20);
            this.txtVlt_useremail.TabIndex = 4;
            // 
            // txtSenha_Vlt
            // 
            this.txtSenha_Vlt.Location = new System.Drawing.Point(53, 106);
            this.txtSenha_Vlt.Name = "txtSenha_Vlt";
            this.txtSenha_Vlt.Size = new System.Drawing.Size(161, 20);
            this.txtSenha_Vlt.TabIndex = 5;
            // 
            // TelaLogSenhaVlt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 203);
            this.Controls.Add(this.txtSenha_Vlt);
            this.Controls.Add(this.txtVlt_useremail);
            this.Controls.Add(this.btnConfSenhVlt);
            this.Controls.Add(this.btnSenVltVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaLogSenhaVlt";
            this.Text = "TelaLogSenhaVlt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSenVltVoltar;
        private System.Windows.Forms.Button btnConfSenhVlt;
        private System.Windows.Forms.TextBox txtVlt_useremail;
        private System.Windows.Forms.TextBox txtSenha_Vlt;
    }
}