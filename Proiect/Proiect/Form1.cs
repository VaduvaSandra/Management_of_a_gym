namespace Proiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean b = true;

        private void membriiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Membrii m = new Membrii();
            m.Show();

        }

        private void antrenoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Antrenori a = new Antrenori();
            a.Show();
        }

        private void cautaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CautaMembrii cm = new CautaMembrii();
            cm.Show();
        }

        private void abonamenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abonamente ab = new Abonamente();
            ab.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Log Out! Confirm?","LOG OUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                LogIn lg = new LogIn();
                lg.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\vaduv\Desktop\Imagini\right-arrow.png");
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\vaduv\Desktop\Imagini\down-arrow.png");
            }
        }

        private void echipamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Echipament ec = new Echipament();
            ec.Show();
        }

        private void produseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produse pr = new Produse();
            pr.Show();
        }

        private void adaugaAbonamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugaAbonament aa = new AdaugaAbonament();
            aa.Show();
        }
    }
}