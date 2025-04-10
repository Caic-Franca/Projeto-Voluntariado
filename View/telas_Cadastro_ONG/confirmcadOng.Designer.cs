namespace Projeto_Voluntariado.View.telas_Cadastro_ONG
{
    partial class confirmcadOng
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
            this.btn_confOng = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_confOng
            // 
            this.btn_confOng.Location = new System.Drawing.Point(263, 171);
            this.btn_confOng.Name = "btn_confOng";
            this.btn_confOng.Size = new System.Drawing.Size(75, 23);
            this.btn_confOng.TabIndex = 3;
            this.btn_confOng.Text = "Ok";
            this.btn_confOng.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parabéns, seu cadastro foi criado!";
            // 
            // confirmcadOng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 293);
            this.Controls.Add(this.btn_confOng);
            this.Controls.Add(this.label1);
            this.Name = "confirmcadOng";
            this.Text = "confirmcadOng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_confOng;
        private System.Windows.Forms.Label label1;
    }
}