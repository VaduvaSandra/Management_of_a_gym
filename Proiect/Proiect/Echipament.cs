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
    public partial class Echipament : Form
    {
        public Echipament()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            String eqName = txtNume.Text;
            String eqDescription = txtDescriere.Text;
            String GrupaM = cmbGM.Text;
            

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=localhost;Initial Catalog = online_tv; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "insert into Echipament(NumeEchipament,Descriere,GrupaMusculara) values ('" + eqName + "','" + eqDescription + "','" + GrupaM + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Date Salvate");
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            txtNume.Clear();
            txtDescriere.Clear();
            cmbGM.Text = "";
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            VeziEchipament ve = new VeziEchipament();
            ve.Show();
        }
    }
}
