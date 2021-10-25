
namespace Snake
{
    partial class Snake_Window
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
            this.Snake_Head = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Snake_Head)).BeginInit();
            this.SuspendLayout();
            // 
            // Snake_Head
            // 
            this.Snake_Head.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Snake_Head.Location = new System.Drawing.Point(437, 260);
            this.Snake_Head.Name = "Snake_Head";
            this.Snake_Head.Size = new System.Drawing.Size(50, 50);
            this.Snake_Head.TabIndex = 0;
            this.Snake_Head.TabStop = false;
            // 
            // Snake_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Snake_Head);
            this.Name = "Snake_Window";
            this.Tag = "";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Snake_Head)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Snake_Head;
    }
}

