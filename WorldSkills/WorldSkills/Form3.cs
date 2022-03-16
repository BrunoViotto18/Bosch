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
    public partial class Form3 : Form
    {
        private DataRow Usuario;
        private SqlConnection sqlcon;

        public Form3(DataRow usuario, SqlConnection sqlcon)
        {
            InitializeComponent();
            this.Usuario = usuario;
            this.sqlcon = sqlcon;

            txbEmail.Text = this.Usuario["Email"].ToString();
            txbEmail.Enabled = false;

            SqlDataAdapter sqlda = new SqlDataAdapter("Select * from usuarios", sqlcon);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            AutoCompleteStringCollection colorSource = new AutoCompleteStringCollection();
            AutoCompleteStringCollection teamSource = new AutoCompleteStringCollection();
            foreach (DataRow row in dtbl.Rows)
            {
                colorSource.Add(row["corfavorita"].ToString());
                teamSource.Add(row["timefavorito"].ToString());
            }
            txbCor.AutoCompleteCustomSource = colorSource;
            txbCor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txbTime.AutoCompleteMode = AutoCompleteMode.Append;
            txbTime.AutoCompleteCustomSource = teamSource;
            txbTime.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void txbCor_TextChanged(object sender, EventArgs e)
        {
            if (txbCor.Text.Length > 3)
            {
                txbCor.AutoCompleteMode = AutoCompleteMode.Append;
                return;
            }
            txbCor.AutoCompleteMode = AutoCompleteMode.None;
        }

        private void txbTime_TextChanged(object sender, EventArgs e)
        {
            if (txbTime.Text.Length > 3)
            {
                txbTime.AutoCompleteMode = AutoCompleteMode.Append;
                return;
            }
            txbTime.AutoCompleteMode = AutoCompleteMode.None;
        }
    }
}
