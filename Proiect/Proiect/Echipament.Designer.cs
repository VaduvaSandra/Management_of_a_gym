namespace Proiect
{
    partial class Echipament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Echipament));
            this.label11 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtDescriere = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.showbtn = new System.Windows.Forms.Button();
            this.cmbGM = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Sigmar One", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(408, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 187);
            this.label11.TabIndex = 27;
            this.label11.Text = "Power Gym";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(205, 263);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(278, 27);
            this.txtNume.TabIndex = 28;
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(205, 343);
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(278, 120);
            this.txtDescriere.TabIndex = 29;
            this.txtDescriere.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nume aparat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Descriere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Grupa Musculara";
            // 
            // savebtn
            // 
            this.savebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.savebtn.Image = ((System.Drawing.Image)(resources.GetObject("savebtn.Image")));
            this.savebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savebtn.Location = new System.Drawing.Point(167, 622);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(94, 39);
            this.savebtn.TabIndex = 36;
            this.savebtn.Text = "Save";
            this.savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetbtn.Image = ((System.Drawing.Image)(resources.GetObject("resetbtn.Image")));
            this.resetbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetbtn.Location = new System.Drawing.Point(389, 622);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(94, 39);
            this.resetbtn.TabIndex = 37;
            this.resetbtn.Text = "Reset";
            this.resetbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // showbtn
            // 
            this.showbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showbtn.Image = ((System.Drawing.Image)(resources.GetObject("showbtn.Image")));
            this.showbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showbtn.Location = new System.Drawing.Point(652, 605);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(220, 56);
            this.showbtn.TabIndex = 38;
            this.showbtn.Text = "Vezi echipamentele";
            this.showbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // cmbGM
            // 
            this.cmbGM.FormattingEnabled = true;
            this.cmbGM.Items.AddRange(new object[] {
            "Trapez",
            "Pectorali",
            "Dorsali",
            "Deltoizi",
            "Triceps",
            "Biceps",
            "Cvadriceps",
            "Biceps Femural",
            "Abdomen",
            "Gambe",
            "Fesieri",
            "Aductori"});
            this.cmbGM.Location = new System.Drawing.Point(205, 513);
            this.cmbGM.Name = "cmbGM";
            this.cmbGM.Size = new System.Drawing.Size(278, 28);
            this.cmbGM.TabIndex = 39;
            // 
            // Echipament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 690);
            this.Controls.Add(this.cmbGM);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label11);
            this.Name = "Echipament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Echipament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label11;
        private TextBox txtNume;
        private RichTextBox txtDescriere;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button savebtn;
        private Button resetbtn;
        private Button showbtn;
        private ComboBox cmbGM;
    }
}