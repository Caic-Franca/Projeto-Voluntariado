﻿namespace Projeto_Voluntariado.View.telas_Cadastro_ONG
{
    partial class TelaConfCadOp
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
            this.btn_OpCriada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_OpCriada
            // 
            this.btn_OpCriada.Location = new System.Drawing.Point(298, 162);
            this.btn_OpCriada.Name = "btn_OpCriada";
            this.btn_OpCriada.Size = new System.Drawing.Size(75, 23);
            this.btn_OpCriada.TabIndex = 5;
            this.btn_OpCriada.Text = "Ok";
            this.btn_OpCriada.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Oportunidade Criada!";
            // 
            // TelaConfCadOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 274);
            this.Controls.Add(this.btn_OpCriada);
            this.Controls.Add(this.label1);
            this.Name = "TelaConfCadOp";
            this.Text = "TelaConfCadOp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OpCriada;
        private System.Windows.Forms.Label label1;
    }
}