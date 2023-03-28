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
    public partial class CautaMembrii : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=online_tv;Integrated Security=True");
        public CautaMembrii()
        {
            InitializeComponent();
            
        }

       public void populateGrid()
        {
            conn.Open();
            string query = "select * from Membrii";
            SqlDataAdapter da=new SqlDataAdapter(query,conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DataGV.DataSource = ds.Tables[0];
            conn.Close();
        }
        public void textBoxFilter()
        {
            conn.Open();
            string query = "select * from Membrii where Nume = '"+ txtsearch.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DataGV.DataSource = ds.Tables[0];
            conn.Close();
        }
        public void TipAbonamentFilter()
        {
            conn.Open();
            string query = "select * from Membrii where TipAbonament = '" + comboBox1.SelectedItem.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DataGV.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void CautaMembrii_Load(object sender, EventArgs e)
        {
            populateGrid();

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            textBoxFilter();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            populateGrid();
            txtsearch.Text = "";
            comboBox1.Text = "Tip Abonament";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipAbonamentFilter();
        }
    }
}

