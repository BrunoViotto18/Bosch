using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorldSkills
{
    public partial class Form2 : Form
    {
        public DataRow Usuario;
        public SqlConnection sqlcon;
        public Form4 form4;
        private Form5 form5;
        public int count = 1;
        public int count_ = 10;
        private bool var = false; 
        private Timer MyTimer = new Timer();
        public bool success = false;
        //public SqlConnection sqlcon = new SqlConnection(@"Data Source = JVLPC0510\SQLSERVER; Initial Catalog = WorldSkills_Nathan; Integrated Security = True");

        public Form2(DataRow usuario, SqlConnection Sqlcon)
        {
            InitializeComponent();
            this.sqlcon = Sqlcon;
            this.Usuario = usuario;
            form4 = new Form4(Usuario, sqlcon, this);
            form5 = new Form5(this);

            txbEmail.Text = Usuario["Email"].ToString();

            Hiding();

            if (Properties.Settings.Default.userPass != string.Empty && txbEmail.Text == Properties.Settings.Default.userEmail)
            {
                txbSenha.Text = Properties.Settings.Default.userPass;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!form4.var)
            {
                if (Usuario["Senha"].ToString() == txbSenha.Text)
                {
                    MessageBox.Show("Senha correta!", "WsTowers - Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    if (checkRemember.Checked)
                    {
                        Properties.Settings.Default.userPass = txbSenha.Text;
                        Properties.Settings.Default.userEmail = txbEmail.Text;
                        Properties.Settings.Default.Save();
                    }
                    success = true;
                }
                else
                {
                    MessageBox.Show("Senha incorreta!", "WsTowers - Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if(txbSenha.Text == form4.randpass)
                {
                    this.var = true;
                    this.Hide();
                    form5.Show();

                }
            }
            
            
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
 

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            form4.ShowDialog();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txbSenha.Text = Clipboard.GetText();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            lblNumber.Text = count_.ToString();
            switch (count)
            {
                case 2:
                    c1.Visible = true;
                    break;
                case 4:
                    c2.Visible = true;
                    break;
                case 6:
                    c3.Visible = true;
                    break;
                case 8:
                    c4.Visible = true;
                    break;
                case 10:
                    c5.Visible = true;
                    break;
            }
            if (count != 11 && !var)
            {
                count++;
                count_--;
                
            }
            else
            {
                Hiding();
                form4.var = false;
                MyTimer.Stop();
            }
            
        }

        public void Unhide()
        {
            btnPaste.Visible = true;
            txbSenha.Enabled = false;
            lblNumber.Visible = true;
            label3.Visible = true;
        }


        public void countdown()
        {
            if (form4.var)
            {
                
                MyTimer.Interval = (1000);
                MyTimer.Tick += new EventHandler(MyTimer_Tick);
                MyTimer.Start();
            }
        }

        public void Hiding()
        {
            Clipboard.Clear();
            txbSenha.Enabled = true;
            btnPaste.Visible = false;
            txbEmail.Enabled = false;
            lblNumber.Visible = false;
            label3.Visible = false;
            c1.Visible = false;
            c2.Visible = false;
            c3.Visible = false;
            c4.Visible = false;
            c5.Visible = false;
        }
    }
}
