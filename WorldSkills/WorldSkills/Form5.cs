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
    public partial class Form5 : Form
    {

        public Form2 form2;
        public Form5(Form2 form2)
        {
            InitializeComponent();
            this.form2 = form2;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                "UPDATE DBO.USUARIOS " +
                "SET senha = (@senha) " +
                "WHERE idusuario =(@idusuario);",form2.sqlcon);

            cmd.Parameters.AddWithValue("@senha", txbNewPass.Text);
            cmd.Parameters.AddWithValue("@idusuario", form2.Usuario["idusuario"]);

            form2.sqlcon.Open();
            cmd.ExecuteNonQuery();
            form2.sqlcon.Close();

            form2.Usuario["Senha"] = txbNewPass.Text;

            this.Hide();
            form2.Hiding();
            form2.Show();

            this.Close();
        }
    }
}
