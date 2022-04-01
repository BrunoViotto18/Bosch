
namespace WorldSkills
{
    partial class Form5
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
            this.btnConfirma = new System.Windows.Forms.Button();
            this.txbNewPass = new System.Windows.Forms.TextBox();
            this.LblPergunta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(128, 73);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(75, 23);
            this.btnConfirma.TabIndex = 5;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbNewPass
            // 
            this.txbNewPass.Location = new System.Drawing.Point(22, 47);
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.PasswordChar = '*';
            this.txbNewPass.Size = new System.Drawing.Size(283, 20);
            this.txbNewPass.TabIndex = 4;
            // 
            // LblPergunta
            // 
            this.LblPergunta.Location = new System.Drawing.Point(19, 21);
            this.LblPergunta.Name = "LblPergunta";
            this.LblPergunta.Size = new System.Drawing.Size(297, 23);
            this.LblPergunta.TabIndex = 3;
            this.LblPergunta.Text = "Digite sua nova senha:";
            this.LblPergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 116);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txbNewPass);
            this.Controls.Add(this.LblPergunta);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.TextBox txbNewPass;
        private System.Windows.Forms.Label LblPergunta;
    }
}