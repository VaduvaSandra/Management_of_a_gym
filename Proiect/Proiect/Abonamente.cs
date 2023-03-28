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
using System.Data.Sql;

namespace Proiect
{
    public partial class Abonamente : Form
    {
       
        public Abonamente()
        {
            InitializeComponent();
        }

        private void Abonamente_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog = online_tv; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Membrii.Id,Membrii.Nume,Membrii.Prenume,Abonamente.Tip,Abonamente.Pret From Membrii INNER JOIN Abonamente ON Membrii.Id=Abonamente.Id",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Nume";
            dataGridView1.Columns[2].HeaderText = "Prenume";
            dataGridView1.Columns[3].HeaderText = "Tip";
            dataGridView1.Columns[4].HeaderText = "Pret";

        }
    }
}
