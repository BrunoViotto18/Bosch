using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSkills
{
    public partial class Form2 : Form
    {
        public DataRow Usuario;

        public Form2(DataRow usuario)
        {
            InitializeComponent();
            this.Usuario = usuario;
            txbEmail.Text = Usuario["Email"].ToString();
            txbEmail.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Usuario["Senha"].ToString() == txbSenha.Text)
            {
                MessageBox.Show("Senha correta!", "WsTowers - Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Senha incorreta!", "WsTowers - Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
