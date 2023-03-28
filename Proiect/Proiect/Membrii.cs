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
    public partial class Membrii : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog = online_tv; Integrated Security = True");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;
        SqlDataReader dr;
        public Membrii()
        {
            InitializeComponent();
           
        }

        private void btngetdata_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            String Nume = txtNume.Text;
            String Prenume = txtPrenume.Text;
            String Telefon = txtTelefon.Text;
            String TipAbonament = cmbTA.Text;
            String ValabilitateAbonament = cmbVA.Text;
            String Data = Convert.ToDateTime(dateTimePicker1.Text).ToString();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=localhost;Initial Catalog = online_tv; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "insert into Membrii(Nume,Prenume,Telefon,TipAbonament,ValabilitateAbonament,Data) values ('" + Nume + "','" + Prenume + "','" + Telefon + "','" + TipAbonament + "','" + ValabilitateAbonament + "','" + Data + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Date Salvate");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]); 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = textBox4.Text;

                listView1.SelectedItems[0].SubItems[1].Text = txtNume.Text;
                listView1.SelectedItems[0].SubItems[2].Text = txtPrenume.Text;
                listView1.SelectedItems[0].SubItems[3].Text = txtTelefon.Text;

                listView1.SelectedItems[0].SubItems[4].Text = cmbTA.Text;
                listView1.SelectedItems[0].SubItems[5].Text = cmbVA.Text;

                listView1.SelectedItems[0].SubItems[6].Text = dateTimePicker1.Text;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNume.Text = "";
            txtPrenume.Text = "";
            txtTelefon.Text = "";
            textBox4.Text = "";

            cmbTA.Text = "";
            cmbVA.Text = "";

            dateTimePicker1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = new ListViewItem(textBox4.Text);
            newItem.SubItems.Add(txtNume.Text);
            newItem.SubItems.Add(txtPrenume.Text);
            newItem.SubItems.Add(txtTelefon.Text);
            newItem.SubItems.Add(cmbTA.Text);
            newItem.SubItems.Add(cmbVA.Text);
            newItem.SubItems.Add(dateTimePicker1.Text);

            if (listView1.Items.ContainsKey(textBox4.Text))
            {
                MessageBox.Show("ID-ul exista deja!");
            }
            else
            {
                listView1.Items.Add(newItem);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void Membrii_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Id", 150);
            listView1.Columns.Add("Nume", 150);
            listView1.Columns.Add("Prenume", 150);
            listView1.Columns.Add("Telefon", 10);
            listView1.Columns.Add("TipAbonament", 120);
            listView1.Columns.Add("ValabilitateAbonament", 120);
            listView1.Columns.Add("Data", 105);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                textBox4.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtNume.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtPrenume.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtTelefon.Text = listView1.SelectedItems[0].SubItems[3].Text;

                cmbTA.Text = listView1.SelectedItems[0].SubItems[4].Text;
                cmbVA.Text = listView1.SelectedItems[0].SubItems[5].Text;

                dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[6].Text;


            }
        }

        private void button7_Click(object sender, EventArgs e)
        { 

            conn.Open();
            cmd = new SqlCommand("select * from Membrii", conn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "testTable");
            conn.Close();

            dt = ds.Tables["testTable"];
            int i;
            for(i =0; i <= dt.Rows.Count -1; i++)
            {
                listView1.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void listView1_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox4.Text = listView1.SelectedItems[0].SubItems[0].Text;

                txtNume.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtPrenume.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtTelefon.Text = listView1.SelectedItems[0].SubItems[3].Text;

                cmbTA.Text = listView1.SelectedItems[0].SubItems[4].Text;
                cmbVA.Text = listView1.SelectedItems[0].SubItems[5].Text;

                dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[6].Text;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
