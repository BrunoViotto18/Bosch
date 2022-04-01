
namespace WorldSkills
{
    partial class Form6
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNotificacoes = new System.Windows.Forms.DataGridView();
            this.dgvData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRemetente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNotificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificacoes)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvNotificacoes);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 287);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notificações";
            // 
            // dgvNotificacoes
            // 
            this.dgvNotificacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvData,
            this.dgvHora,
            this.dgvRemetente,
            this.dgvNotificacao,
            this.dgvStatus});
            this.dgvNotificacoes.Location = new System.Drawing.Point(3, 49);
            this.dgvNotificacoes.Name = "dgvNotificacoes";
            this.dgvNotificacoes.Size = new System.Drawing.Size(560, 235);
            this.dgvNotificacoes.TabIndex = 0;
            // 
            // dgvData
            // 
            this.dgvData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvData.HeaderText = "Data";
            this.dgvData.Name = "dgvData";
            // 
            // dgvHora
            // 
            this.dgvHora.HeaderText = "Hora";
            this.dgvHora.Name = "dgvHora";
            // 
            // dgvRemetente
            // 
            this.dgvRemetente.HeaderText = "Remetente";
            this.dgvRemetente.Name = "dgvRemetente";
            // 
            // dgvNotificacao
            // 
            this.dgvNotificacao.HeaderText = "Notificacao";
            this.dgvNotificacao.Name = "dgvNotificacao";
            // 
            // dgvStatus
            // 
            this.dgvStatus.HeaderText = "Status";
            this.dgvStatus.Name = "dgvStatus";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(584, 37);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Convidados";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(109, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Jogos";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(215, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ranking";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(321, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "Notificações";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(427, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "Configurações";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(533, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 30);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificacoes)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNotificacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRemetente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNotificacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}