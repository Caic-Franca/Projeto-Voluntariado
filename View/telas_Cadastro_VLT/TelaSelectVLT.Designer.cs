namespace Projeto_Voluntariado.View.telas_VLT
{
    partial class TelaSelectVLT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaSelectVLT));
            this.abrt_Vlt = new System.Windows.Forms.Label();
            this.bnf_VLT = new System.Windows.Forms.Label();
            this.qst_VLT = new System.Windows.Forms.Label();
            this.btn_VltLog = new System.Windows.Forms.Button();
            this.btn_VltCriar = new System.Windows.Forms.Button();
            this.btn_VltMenuVolta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // abrt_Vlt
            // 
            this.abrt_Vlt.AutoSize = true;
            this.abrt_Vlt.Location = new System.Drawing.Point(191, 102);
            this.abrt_Vlt.Name = "abrt_Vlt";
            this.abrt_Vlt.Size = new System.Drawing.Size(480, 13);
            this.abrt_Vlt.TabIndex = 0;
            this.abrt_Vlt.Text = "Maravilha! Nosso intuito é te dar a oportunidades de usar suas habilidades para a" +
    "judar o proxímo! :D";
            // 
            // bnf_VLT
            // 
            this.bnf_VLT.AutoSize = true;
            this.bnf_VLT.Location = new System.Drawing.Point(191, 150);
            this.bnf_VLT.Name = "bnf_VLT";
            this.bnf_VLT.Size = new System.Drawing.Size(559, 143);
            this.bnf_VLT.TabIndex = 1;
            this.bnf_VLT.Text = resources.GetString("bnf_VLT.Text");
            // 
            // qst_VLT
            // 
            this.qst_VLT.AutoSize = true;
            this.qst_VLT.Location = new System.Drawing.Point(314, 355);
            this.qst_VLT.Name = "qst_VLT";
            this.qst_VLT.Size = new System.Drawing.Size(200, 13);
            this.qst_VLT.TabIndex = 2;
            this.qst_VLT.Text = "Você já faz parte da nossa comunidade?";
            // 
            // btn_VltLog
            // 
            this.btn_VltLog.Location = new System.Drawing.Point(277, 408);
            this.btn_VltLog.Name = "btn_VltLog";
            this.btn_VltLog.Size = new System.Drawing.Size(98, 41);
            this.btn_VltLog.TabIndex = 3;
            this.btn_VltLog.Text = "Sim, acessar comunidade!";
            this.btn_VltLog.UseVisualStyleBackColor = true;
            // 
            // btn_VltCriar
            // 
            this.btn_VltCriar.Location = new System.Drawing.Point(527, 408);
            this.btn_VltCriar.Name = "btn_VltCriar";
            this.btn_VltCriar.Size = new System.Drawing.Size(98, 41);
            this.btn_VltCriar.TabIndex = 4;
            this.btn_VltCriar.Text = "Não, criar conta!";
            this.btn_VltCriar.UseVisualStyleBackColor = true;
            // 
            // btn_VltMenuVolta
            // 
            this.btn_VltMenuVolta.Location = new System.Drawing.Point(836, 494);
            this.btn_VltMenuVolta.Name = "btn_VltMenuVolta";
            this.btn_VltMenuVolta.Size = new System.Drawing.Size(75, 23);
            this.btn_VltMenuVolta.TabIndex = 5;
            this.btn_VltMenuVolta.Text = "Voltar";
            this.btn_VltMenuVolta.UseVisualStyleBackColor = true;
            // 
            // TelaSelectVLT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 545);
            this.Controls.Add(this.btn_VltMenuVolta);
            this.Controls.Add(this.btn_VltCriar);
            this.Controls.Add(this.btn_VltLog);
            this.Controls.Add(this.qst_VLT);
            this.Controls.Add(this.bnf_VLT);
            this.Controls.Add(this.abrt_Vlt);
            this.Name = "TelaSelectVLT";
            this.Text = "TelaSelectVLT";
            this.Load += new System.EventHandler(this.TelaSelectVLT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label abrt_Vlt;
        private System.Windows.Forms.Label bnf_VLT;
        private System.Windows.Forms.Label qst_VLT;
        private System.Windows.Forms.Button btn_VltLog;
        private System.Windows.Forms.Button btn_VltCriar;
        private System.Windows.Forms.Button btn_VltMenuVolta;
    }
}