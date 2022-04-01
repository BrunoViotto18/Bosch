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
    public partial class Form1 : Form
    {
        public DataRow Index { get; private set; }
        public bool Success { get; private set; }
        public bool Cadastrado { get; private set; }
        private SqlConnection sqlcon;

        public Form1(SqlConnection Sqlcon)
        {
            InitializeComponent();
            this.sqlcon = Sqlcon;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string email = txbEmail.Text;
            SqlDataAdapter sqlda = new SqlDataAdapter("Select * from usuarios", sqlcon);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);

            bool verify = false;
            foreach (DataRow row in dtbl.Rows)
            {
                if (row["Email"].ToString() == email)
                {
                    Index = row;
                    verify = true;
                    break;
                }
            }

            if (verify)
            {
                this.Success = true;
                if (Index["datacadastro"].ToString() == "")
                {
                    /*
                    if (DateTime.Now - DateTime.Parse(Index["dataconvite"].ToString()) < TimeSpan.Parse("30.00:00:00"))
                    {
                        this.Cadastrado = false;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Convite expirado.", "WsTowers - Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    */
                    this.Cadastrado = false;
                }
                else
                {
                    this.Cadastrado = true;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Email Inválido", "WsTowers - Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
