using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Web;

namespace WorldSkills
{
    public partial class Form4 : Form
    {

        private DataRow usuario;
        private SqlConnection sqlcon;
        private int index = 0;
        public bool var=false;
        private DataTable dtbl = new DataTable();
        public string randpass;
        public Form2 form2; 

        public Form4(DataRow Usuario,SqlConnection Sqlcon, Form2 form2)

        {
            InitializeComponent();
            this.usuario = Usuario;
            this.sqlcon = Sqlcon;
            this.form2 = form2;
            SqlDataAdapter sqlda = new SqlDataAdapter("Select * from Pergunta", sqlcon);
            DataTable dtbl1 = new DataTable();
            sqlda.Fill(dtbl1);
            dtbl = dtbl1;
            LblPergunta.Text = dtbl.Rows[index][1].ToString();

            randpass = CreatePassword(6);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //erros de inserção de resposta!!!!!!
            string answer = txbAnswer.Text.ToString();
            if (var)
            {
                Clipboard.SetText(randpass);
                this.Hide();
                form2.Unhide();
                form2.countdown();
            }

            else if (index == 0)
            {
                try
                {
                    DateTime asnw = Convert.ToDateTime(answer);
                    DateTime bd = Convert.ToDateTime(usuario["nascimento"].ToString());
                    if (asnw == bd)
                    {
                        LblPergunta.Text = "Nova Senha";
                        button1.Text = "Copiar";
                        txbAnswer.Enabled = false;
                        txbAnswer.Text = randpass;
                        var = true;
                    }
                    else
                    {
                        MessageBox.Show("Você Errou", "WsTowers - Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch(Exception E)
                {
                    MessageBox.Show(E.GetType().ToString()+" \nDATA NO FORMATO INCORRETO");
                }
                
            }
            else if(index == 1)
            {
                if(answer == usuario["timefavorito"].ToString())
                {
                    LblPergunta.Text = "Nova Senha";
                    button1.Text = "Copiar";
                    txbAnswer.Enabled = false;
                    txbAnswer.Text = randpass;
                    var = true;
                }
                else
                {
                    MessageBox.Show("Você Errou", "WsTowers - Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            else if (index == 2)
            {
                if (answer == usuario["corFavorita"].ToString())
                {
                    LblPergunta.Text = "Nova Senha";
                    button1.Text = "Copiar";
                    txbAnswer.Enabled = false;
                    txbAnswer.Text = randpass;
                    var = true;
                }
                else
                {
                    MessageBox.Show("Você Errou", "WsTowers - Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (index == 3)
            {
                if (answer == usuario["apelido"].ToString())
                {
                    LblPergunta.Text = "Nova Senha";
                    button1.Text = "Copiar";
                    txbAnswer.Enabled = false;
                    txbAnswer.Text = randpass;
                    var = true;
                }
                else
                {
                    MessageBox.Show("Você Errou", "WsTowers - Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }


            if (!var)
            {
                index++;
                LblPergunta.Text = dtbl.Rows[index][1].ToString();
                txbAnswer.Clear();
            }

            
                        
        }

        private void txbAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }


    }
}
