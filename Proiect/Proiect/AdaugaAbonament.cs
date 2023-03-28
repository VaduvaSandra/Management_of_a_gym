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
    public partial class AdaugaAbonament : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=online_tv;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public AdaugaAbonament()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            String TipAbonament = cmbTA.Text;
            String Pret = cmbPret.Text;

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=localhost;Initial Catalog = online_tv; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "insert into Abonamente(Tip,Pret) values ('" + TipAbonament + "','" + Pret + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Date Salvate");
        }

        private void AdaugaAbonament_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = "Select * from Abonamente";
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[2].ToString());
               
                listView1.Items.Add(lv);
            }
            conn.Close();
        }
    }
}
