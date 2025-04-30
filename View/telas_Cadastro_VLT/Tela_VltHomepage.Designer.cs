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
            this.btn_SairVlt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SairVlt
            // 
            this.btn_SairVlt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SairVlt.Location = new System.Drawing.Point(522, 504);
            this.btn_SairVlt.Name = "btn_SairVlt";
            this.btn_SairVlt.Size = new System.Drawing.Size(126, 43);
            this.btn_SairVlt.TabIndex = 4;
            this.btn_SairVlt.Text = "Sair";
            this.btn_SairVlt.UseVisualStyleBackColor = true;
            this.btn_SairVlt.Click += new System.EventHandler(this.btn_SairVlt_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(82, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 409);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 104);
            this.button1.TabIndex = 5;
            this.button1.Text = "Visualizar minhas oportunidades";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 104);
            this.button2.TabIndex = 4;
            this.button2.Text = "Verificar lista de oportunidades";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Olá, XXXX.\r\n\r\nO que vamos fazer hoje:";
            // 
            // Tela_VltHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(719, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_SairVlt);
            this.Name = "Tela_VltHomepage";
            this.Text = "Tela_VltHomepage";

            this.Load += new System.EventHandler(this.Tela_VltHomepage_Load_1);

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_SairVlt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}