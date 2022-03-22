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
    public partial class Form6 : Form
    {
        private DataTable DataNotificacoes;
        SqlConnection sqlcon;

        public Form6(DataRow Usuario, SqlConnection sqlcon)
        {
            InitializeComponent();
            this.sqlcon = sqlcon;
            dgvNotificacoes.MultiSelect = false;

            SqlDataAdapter sqlda = new SqlDataAdapter("Select * from notificacao", sqlcon);
            sqlda.Fill(DataNotificacoes);
        }

        private void dgvNotificacoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Mostrar tela de notificações
        private void button4_Click(object sender, EventArgs e)
        {
            dgvNotificacoes.Rows.Clear();
            DataNotificacoes.Clear();
            SqlDataAdapter sqlda = new SqlDataAdapter("Select * from notificacao", sqlcon);
            sqlda.Fill(DataNotificacoes);

            dgvNotificacoes.Visible = true;

            int dgvRow = 0;
            foreach (DataRow row in DataNotificacoes.Rows)
            {
                for (int i = 0; i < 5; i++)
                {
                    dgvNotificacoes.Rows[dgvRow].Cells[i].Value = row[i];
                }
                dgvRow++;
            }
        }
    }
}
