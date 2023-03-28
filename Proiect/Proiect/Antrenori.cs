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

namespace Proiect
{
    public partial class Antrenori : Form
    {
        public Antrenori()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            String antNume = txtNume.Text;
            String antPrenume = txtPrenume.Text;
            String Categ = cmbCategorie.Text;
            String Perioada = cmbPeioada.Text;


            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=localhost;Initial Catalog = online_tv; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "insert into Antrenori(Nume,Prenume,Categorie,Perioada) values ('" + antNume + "','" + antPrenume + "','" + Categ + "','" + Perioada + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Date Salvate");
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            txtNume.Clear();
            txtPrenume.Clear();
            cmbCategorie.Text = "";
            cmbPeioada.Text = "";
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            VeziAntrenori va = new VeziAntrenori();
            va.Show();
        }
    }
}
