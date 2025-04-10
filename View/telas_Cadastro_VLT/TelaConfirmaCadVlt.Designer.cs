namespace Projeto_Voluntariado.View.telas_Cadastro_VLT
{
    partial class TelaConfirmaCadVlt
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
            this.btn_confVlt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parabéns, seu cadastro foi criado!";
            // 
            // btn_confVlt
            // 
            this.btn_confVlt.Location = new System.Drawing.Point(203, 169);
            this.btn_confVlt.Name = "btn_confVlt";
            this.btn_confVlt.Size = new System.Drawing.Size(75, 23);
            this.btn_confVlt.TabIndex = 1;
            this.btn_confVlt.Text = "Ok";
            this.btn_confVlt.UseVisualStyleBackColor = true;
            // 
            // TelaConfirmaCadVlt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 204);
            this.Controls.Add(this.btn_confVlt);
            this.Controls.Add(this.label1);
            this.Name = "TelaConfirmaCadVlt";
            this.Text = "TelaConfirmaCadVlt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_confVlt;
    }
}