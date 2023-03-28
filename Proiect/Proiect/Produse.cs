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
using System.IO;


namespace Proiect
{
    public partial class Produse : Form
    {
        public Produse()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=online_tv;Integrated Security=True");
        SqlCommand cmd;
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*.Jpg;*png;*Gif)|*.Jpg;*png;*Gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) ;
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Insert into Produse(Nume_produs,Imagine)Values(@Nume_produs,@Imagine)", conn);
            cmd.Parameters.AddWithValue("Nume_produs", txtNume.Text);
            MemoryStream memstr = new MemoryStream();
            pictureBox1.Image.Save(memstr, pictureBox1.Image.RawFormat);
            cmd.Parameters.AddWithValue("Imagine", memstr.ToArray());
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Date introduse cu succes!");
            load_data();
        }
        private void load_data()
        {
            cmd = new SqlCommand("Select * from  Produse order by id desc", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.RowTemplate.Height = 75;
            dataGridView1.DataSource = dt;
            DataGridViewImageColumn pic1 = new DataGridViewImageColumn();
            pic1 = (DataGridViewImageColumn)dataGridView1.Columns[2];
            pic1.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void Produse_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNume.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[2].Value);
            pictureBox1.Image = Image .FromStream(ms);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Update Produse Set Nume_produs = @Nume_produs, Imagine = @Imagine where Id = @Id ", conn);
            cmd.Parameters.AddWithValue("Nume_produs", txtNume.Text);
            MemoryStream memstr = new MemoryStream();
            pictureBox1.Image.Save(memstr, pictureBox1.Image.RawFormat);
            cmd.Parameters.AddWithValue("Imagine", memstr.ToArray());
            cmd.Parameters.AddWithValue("Id", Id.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            load_data();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Delete * from Produse where Id=@id", conn);
            cmd.Parameters.AddWithValue("Id", Id.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            load_data();
            pictureBox1.Image = null;
            txtNume.Text = "";
            Id.Text = "";
        }
    }
}
