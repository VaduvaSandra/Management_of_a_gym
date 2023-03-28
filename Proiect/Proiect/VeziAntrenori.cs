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

namespace Proiect
{
    public partial class VeziAntrenori : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=online_tv;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public VeziAntrenori()
        {
            InitializeComponent();
        }

        private void VeziAntrenori_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = "Select * from Antrenori";
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[2].ToString());
                lv.SubItems.Add(dr[3].ToString());
                lv.SubItems.Add(dr[4].ToString());
                listView1.Items.Add(lv);
            }
            conn.Close();
        }
    }
}
