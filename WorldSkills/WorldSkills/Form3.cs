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
        private DataTable dtbl;
        private AutoCompleteStringCollection ColorSource;
        private AutoCompleteStringCollection TeamSource;
        public bool success = false;

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
            this.dtbl = dtbl;
            this.ColorSource = colorSource;
            this.TeamSource = teamSource;

            txbCor.AutoCompleteMode = AutoCompleteMode.Append;
            txbCor.AutoCompleteCustomSource = colorSource;
            txbCor.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txbTime.AutoCompleteMode = AutoCompleteMode.Append;
            txbTime.AutoCompleteCustomSource = teamSource;
            txbTime.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog imageSearch = new OpenFileDialog())
            {
                imageSearch.Title = "Selecione a sua Foto de Perfil";
                imageSearch.Filter = "jpg files (*.jpg)|*.jpg";

                if (imageSearch.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(imageSearch.FileName);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txbSenha, txbApelido, txbCor, txbTime };
            foreach (TextBox txb in textBoxes)
            {
                if (txb.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos antes de salvar.", "WsTowers - Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            foreach (DataRow row in dtbl.Rows)
            {
                if (row["apelido"].ToString() == txbApelido.Text)
                {
                    MessageBox.Show("Apelido já cadastrado.", "WsTowers - Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            byte[] imageByteArray;
            try
            {
                ImageConverter converter = new ImageConverter();
                imageByteArray = (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));
            }
            catch (NullReferenceException)
            {
                imageByteArray = null;
            }

            SqlCommand cmd = new SqlCommand(
                $"UPDATE dbo.usuarios " +
                $"SET senha = (@senha), apelido = (@apelido), corfavorita = (@cor), timefavorito = (@time), nascimento = (@nascimento), foto = (@foto), datacadastro = (@datacadastro) " +
                $"WHERE idusuario = (@idusuario);", sqlcon);

            cmd.Parameters.AddWithValue("@senha", txbSenha.Text);
            cmd.Parameters.AddWithValue("@apelido", txbApelido.Text);
            cmd.Parameters.AddWithValue("@cor", txbCor.Text);
            cmd.Parameters.AddWithValue("@time", txbTime.Text);
            cmd.Parameters.AddWithValue("@nascimento", DateTime.Parse(txbNascimento.Text));
            cmd.Parameters.AddWithValue("@foto", imageByteArray);
            cmd.Parameters.AddWithValue("@datacadastro", DateTime.Now);
            cmd.Parameters.AddWithValue("@idusuario", Usuario["idusuario"].ToString());

            sqlcon.Open();
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            success = true;
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
