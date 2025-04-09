namespace Projeto_Voluntariado
{
    partial class Home
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.abertura_Enun = new System.Windows.Forms.Label();
            this.abertura_Slogan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_select_ONG = new System.Windows.Forms.Button();
            this.Ong_Vlt = new System.Windows.Forms.Label();
            this.btn_select_VLT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // abertura_Enun
            // 
            this.abertura_Enun.AutoSize = true;
            this.abertura_Enun.Location = new System.Drawing.Point(204, 79);
            this.abertura_Enun.Name = "abertura_Enun";
            this.abertura_Enun.Size = new System.Drawing.Size(363, 13);
            this.abertura_Enun.TabIndex = 0;
            this.abertura_Enun.Text = "Seja bem-vindo(a) ao nosso portal de contratação de serviços voluntariado!";
            // 
            // abertura_Slogan
            // 
            this.abertura_Slogan.AutoSize = true;
            this.abertura_Slogan.Location = new System.Drawing.Point(204, 191);
            this.abertura_Slogan.Name = "abertura_Slogan";
            this.abertura_Slogan.Size = new System.Drawing.Size(319, 26);
            this.abertura_Slogan.TabIndex = 1;
            this.abertura_Slogan.Text = "Te convidamos a se juntar a nós conectando Corações e Causas!\r\n                  " +
    "                    Seja a Mudança!";
            this.abertura_Slogan.Click += new System.EventHandler(this.abertura_Slogan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nós somos o ponto de encontro entre ONGs apaixonadas por transformar o mundo e vo" +
    "luntários(as) que desejam fazer a diferença!";
            // 
            // btn_select_ONG
            // 
            this.btn_select_ONG.Location = new System.Drawing.Point(195, 340);
            this.btn_select_ONG.Name = "btn_select_ONG";
            this.btn_select_ONG.Size = new System.Drawing.Size(75, 23);
            this.btn_select_ONG.TabIndex = 3;
            this.btn_select_ONG.Text = "ONG";
            this.btn_select_ONG.UseVisualStyleBackColor = true;
            // 
            // Ong_Vlt
            // 
            this.Ong_Vlt.AutoSize = true;
            this.Ong_Vlt.Location = new System.Drawing.Point(204, 262);
            this.Ong_Vlt.Name = "Ong_Vlt";
            this.Ong_Vlt.Size = new System.Drawing.Size(354, 13);
            this.Ong_Vlt.TabIndex = 4;
            this.Ong_Vlt.Text = "Para seguirmos, por favor nos conte, você é um(a) voluntário(a) ou ONG?";
            // 
            // btn_select_VLT
            // 
            this.btn_select_VLT.Location = new System.Drawing.Point(448, 340);
            this.btn_select_VLT.Name = "btn_select_VLT";
            this.btn_select_VLT.Size = new System.Drawing.Size(75, 23);
            this.btn_select_VLT.TabIndex = 5;
            this.btn_select_VLT.Text = "Voluntário(a)";
            this.btn_select_VLT.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 539);
            this.Controls.Add(this.btn_select_VLT);
            this.Controls.Add(this.Ong_Vlt);
            this.Controls.Add(this.btn_select_ONG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.abertura_Slogan);
            this.Controls.Add(this.abertura_Enun);
            this.Name = "Home";
            this.Text = "Home Contratação Voluntária";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label abertura_Enun;
        private System.Windows.Forms.Label abertura_Slogan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_select_ONG;
        private System.Windows.Forms.Label Ong_Vlt;
        private System.Windows.Forms.Button btn_select_VLT;
    }
}

