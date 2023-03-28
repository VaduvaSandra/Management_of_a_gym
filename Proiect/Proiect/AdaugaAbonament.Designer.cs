namespace Proiect
{
    partial class AdaugaAbonament
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugaAbonament));
            this.label11 = new System.Windows.Forms.Label();
            this.cmbTA = new System.Windows.Forms.ComboBox();
            this.cmbPret = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Sigmar One", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(344, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 187);
            this.label11.TabIndex = 28;
            this.label11.Text = "Power Gym";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cmbTA
            // 
            this.cmbTA.FormattingEnabled = true;
            this.cmbTA.Items.AddRange(new object[] {
            "Fitness",
            "Yoga",
            "Kickbox"});
            this.cmbTA.Location = new System.Drawing.Point(355, 549);
            this.cmbTA.Name = "cmbTA";
            this.cmbTA.Size = new System.Drawing.Size(151, 28);
            this.cmbTA.TabIndex = 29;
            // 
            // cmbPret
            // 
            this.cmbPret.FormattingEnabled = true;
            this.cmbPret.Items.AddRange(new object[] {
            "200",
            "250",
            "300"});
            this.cmbPret.Location = new System.Drawing.Point(355, 609);
            this.cmbPret.Name = "cmbPret";
            this.cmbPret.Size = new System.Drawing.Size(151, 28);
            this.cmbPret.TabIndex = 30;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(62, 251);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(796, 232);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tip Abonament";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pret";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(8, 537);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(236, 40);
            this.label9.TabIndex = 32;
            this.label9.Text = "Tip abonament";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(8, 597);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 40);
            this.label1.TabIndex = 33;
            this.label1.Text = "Pret";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // savebtn
            // 
            this.savebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.savebtn.Image = ((System.Drawing.Image)(resources.GetObject("savebtn.Image")));
            this.savebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savebtn.Location = new System.Drawing.Point(721, 572);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(94, 39);
            this.savebtn.TabIndex = 37;
            this.savebtn.Text = "Save";
            this.savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // AdaugaAbonament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(901, 690);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmbPret);
            this.Controls.Add(this.cmbTA);
            this.Controls.Add(this.label11);
            this.Name = "AdaugaAbonament";
            this.Text = "AdaugaAbonament";
            this.Load += new System.EventHandler(this.AdaugaAbonament_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label11;
        private ComboBox cmbTA;
        private ComboBox cmbPret;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label9;
        private Label label1;
        private Button savebtn;
    }
}