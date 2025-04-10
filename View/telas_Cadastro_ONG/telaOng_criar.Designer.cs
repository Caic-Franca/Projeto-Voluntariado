namespace Projeto_Voluntariado.View.telas_Cadastro_ONG
{
    partial class telaOng_criar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaOng_criar));
            this.btn_OngMenuVolta = new System.Windows.Forms.Button();
            this.btn_VltCriarONG = new System.Windows.Forms.Button();
            this.btn_LogOng = new System.Windows.Forms.Button();
            this.qst_VLT = new System.Windows.Forms.Label();
            this.bnf_VLT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_OngMenuVolta
            // 
            this.btn_OngMenuVolta.Location = new System.Drawing.Point(685, 410);
            this.btn_OngMenuVolta.Name = "btn_OngMenuVolta";
            this.btn_OngMenuVolta.Size = new System.Drawing.Size(75, 23);
            this.btn_OngMenuVolta.TabIndex = 11;
            this.btn_OngMenuVolta.Text = "Voltar";
            this.btn_OngMenuVolta.UseVisualStyleBackColor = true;
            this.btn_OngMenuVolta.Click += new System.EventHandler(this.btn_VltMenuVolta_Click);
            // 
            // btn_VltCriarONG
            // 
            this.btn_VltCriarONG.Location = new System.Drawing.Point(376, 324);
            this.btn_VltCriarONG.Name = "btn_VltCriarONG";
            this.btn_VltCriarONG.Size = new System.Drawing.Size(98, 41);
            this.btn_VltCriarONG.TabIndex = 10;
            this.btn_VltCriarONG.Text = "Não, criar conta!";
            this.btn_VltCriarONG.UseVisualStyleBackColor = true;
            this.btn_VltCriarONG.Click += new System.EventHandler(this.btn_VltCriar_Click);
            // 
            // btn_LogOng
            // 
            this.btn_LogOng.Location = new System.Drawing.Point(126, 324);
            this.btn_LogOng.Name = "btn_LogOng";
            this.btn_LogOng.Size = new System.Drawing.Size(98, 41);
            this.btn_LogOng.TabIndex = 9;
            this.btn_LogOng.Text = "Sim, acessar comunidade!";
            this.btn_LogOng.UseVisualStyleBackColor = true;
            this.btn_LogOng.Click += new System.EventHandler(this.btn_VltLog_Click);
            // 
            // qst_VLT
            // 
            this.qst_VLT.AutoSize = true;
            this.qst_VLT.Location = new System.Drawing.Point(213, 274);
            this.qst_VLT.Name = "qst_VLT";
            this.qst_VLT.Size = new System.Drawing.Size(200, 13);
            this.qst_VLT.TabIndex = 8;
            this.qst_VLT.Text = "Você já faz parte da nossa comunidade?";
            this.qst_VLT.Click += new System.EventHandler(this.qst_VLT_Click);
            // 
            // bnf_VLT
            // 
            this.bnf_VLT.AutoSize = true;
            this.bnf_VLT.Location = new System.Drawing.Point(123, 98);
            this.bnf_VLT.Name = "bnf_VLT";
            this.bnf_VLT.Size = new System.Drawing.Size(545, 117);
            this.bnf_VLT.TabIndex = 7;
            this.bnf_VLT.Text = resources.GetString("bnf_VLT.Text");
            this.bnf_VLT.Click += new System.EventHandler(this.bnf_VLT_Click);
            // 
            // telaOng_criar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 551);
            this.Controls.Add(this.btn_OngMenuVolta);
            this.Controls.Add(this.btn_VltCriarONG);
            this.Controls.Add(this.btn_LogOng);
            this.Controls.Add(this.qst_VLT);
            this.Controls.Add(this.bnf_VLT);
            this.Name = "telaOng_criar";
            this.Text = "telaOng_criar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OngMenuVolta;
        private System.Windows.Forms.Button btn_VltCriarONG;
        private System.Windows.Forms.Button btn_LogOng;
        private System.Windows.Forms.Label qst_VLT;
        private System.Windows.Forms.Label bnf_VLT;
    }
}