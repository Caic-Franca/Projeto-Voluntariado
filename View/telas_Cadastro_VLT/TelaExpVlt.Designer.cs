﻿namespace Projeto_Voluntariado.View.telas_VLT
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
            this.btn_VoltVltCad2 = new System.Windows.Forms.Button();
            this.btn_ConcCadVlt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_VoltVltCad2
            // 
            this.btn_VoltVltCad2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_VoltVltCad2.Location = new System.Drawing.Point(555, 405);
            this.btn_VoltVltCad2.Name = "btn_VoltVltCad2";
            this.btn_VoltVltCad2.Size = new System.Drawing.Size(75, 23);
            this.btn_VoltVltCad2.TabIndex = 6;
            this.btn_VoltVltCad2.Text = "Voltar";
            this.btn_VoltVltCad2.UseVisualStyleBackColor = true;
            this.btn_VoltVltCad2.Click += new System.EventHandler(this.btn_VoltVltCad2_Click);
            // 
            // btn_ConcCadVlt
            // 
            this.btn_ConcCadVlt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ConcCadVlt.Location = new System.Drawing.Point(663, 405);
            this.btn_ConcCadVlt.Name = "btn_ConcCadVlt";
            this.btn_ConcCadVlt.Size = new System.Drawing.Size(75, 23);
            this.btn_ConcCadVlt.TabIndex = 7;
            this.btn_ConcCadVlt.Text = "Concluir";
            this.btn_ConcCadVlt.UseVisualStyleBackColor = true;
            this.btn_ConcCadVlt.Click += new System.EventHandler(this.btn_ConcCadVlt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(92, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 354);
            this.panel1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 270);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(553, 66);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 150);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(553, 85);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(22, 36);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(553, 85);
            this.textBox3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Disponibilidade (Dias e período): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Habilidades e Experiências (Opcional):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Áreas de Interesse (ex: Meio Ambiente, Educação, Tecnologia, etc.):";
            // 
            // TelaExpVlt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ConcCadVlt);
            this.Controls.Add(this.btn_VoltVltCad2);
            this.Name = "TelaExpVlt";
            this.Text = "TelaExpVlt";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_VoltVltCad2;
        private System.Windows.Forms.Button btn_ConcCadVlt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}