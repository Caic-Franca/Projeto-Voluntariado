namespace Projeto_Voluntariado.View.telas_VLT
{
    partial class TelaExpVlt
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_interVlt = new System.Windows.Forms.TextBox();
            this.txt_ExVlt = new System.Windows.Forms.TextBox();
            this.txt_DispVlt = new System.Windows.Forms.TextBox();
            this.btn_VoltVltCad2 = new System.Windows.Forms.Button();
            this.btn_ConcCadVlt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Áreas de Interesse (ex: Meio Ambiente, Educação, Tecnologia, etc.):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Habilidades e Experiências (Opcional):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Disponibilidade (Dias e período): ";
            // 
            // txt_interVlt
            // 
            this.txt_interVlt.Location = new System.Drawing.Point(36, 45);
            this.txt_interVlt.Multiline = true;
            this.txt_interVlt.Name = "txt_interVlt";
            this.txt_interVlt.Size = new System.Drawing.Size(553, 85);
            this.txt_interVlt.TabIndex = 3;
            // 
            // txt_ExVlt
            // 
            this.txt_ExVlt.Location = new System.Drawing.Point(36, 159);
            this.txt_ExVlt.Multiline = true;
            this.txt_ExVlt.Name = "txt_ExVlt";
            this.txt_ExVlt.Size = new System.Drawing.Size(553, 85);
            this.txt_ExVlt.TabIndex = 4;
            // 
            // txt_DispVlt
            // 
            this.txt_DispVlt.Location = new System.Drawing.Point(36, 279);
            this.txt_DispVlt.Multiline = true;
            this.txt_DispVlt.Name = "txt_DispVlt";
            this.txt_DispVlt.Size = new System.Drawing.Size(553, 66);
            this.txt_DispVlt.TabIndex = 5;
            // 
            // btn_VoltVltCad2
            // 
            this.btn_VoltVltCad2.Location = new System.Drawing.Point(555, 405);
            this.btn_VoltVltCad2.Name = "btn_VoltVltCad2";
            this.btn_VoltVltCad2.Size = new System.Drawing.Size(75, 23);
            this.btn_VoltVltCad2.TabIndex = 6;
            this.btn_VoltVltCad2.Text = "Voltar";
            this.btn_VoltVltCad2.UseVisualStyleBackColor = true;
            // 
            // btn_ConcCadVlt
            // 
            this.btn_ConcCadVlt.Location = new System.Drawing.Point(663, 405);
            this.btn_ConcCadVlt.Name = "btn_ConcCadVlt";
            this.btn_ConcCadVlt.Size = new System.Drawing.Size(75, 23);
            this.btn_ConcCadVlt.TabIndex = 7;
            this.btn_ConcCadVlt.Text = "Concluir";
            this.btn_ConcCadVlt.UseVisualStyleBackColor = true;
            // 
            // TelaExpVlt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ConcCadVlt);
            this.Controls.Add(this.btn_VoltVltCad2);
            this.Controls.Add(this.txt_DispVlt);
            this.Controls.Add(this.txt_ExVlt);
            this.Controls.Add(this.txt_interVlt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaExpVlt";
            this.Text = "TelaExpVlt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_interVlt;
        private System.Windows.Forms.TextBox txt_ExVlt;
        private System.Windows.Forms.TextBox txt_DispVlt;
        private System.Windows.Forms.Button btn_VoltVltCad2;
        private System.Windows.Forms.Button btn_ConcCadVlt;
    }
}