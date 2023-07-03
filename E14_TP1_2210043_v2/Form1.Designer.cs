namespace E14_TP1_2210043_v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.noPatineur = new System.Windows.Forms.ColumnHeader();
            this.nom = new System.Windows.Forms.ColumnHeader();
            this.prenom = new System.Windows.Forms.ColumnHeader();
            this.age = new System.Windows.Forms.ColumnHeader();
            this.club = new System.Windows.Forms.ColumnHeader();
            this.pointsTotaux = new System.Windows.Forms.ColumnHeader();
            this.listView2 = new System.Windows.Forms.ListView();
            this.NoPatineur2 = new System.Windows.Forms.ColumnHeader();
            this.NoCourse = new System.Windows.Forms.ColumnHeader();
            this.Distance = new System.Windows.Forms.ColumnHeader();
            this.Position = new System.Windows.Forms.ColumnHeader();
            this.Temps = new System.Windows.Forms.ColumnHeader();
            this.NomCourse = new System.Windows.Forms.ColumnHeader();
            this.Points = new System.Windows.Forms.ColumnHeader();
            this.btnExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.PeachPuff;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.noPatineur,
            this.nom,
            this.prenom,
            this.age,
            this.club,
            this.pointsTotaux});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(13, 13);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(880, 914);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // noPatineur
            // 
            this.noPatineur.Text = "noPatineur";
            this.noPatineur.Width = 100;
            // 
            // nom
            // 
            this.nom.Text = "nom";
            this.nom.Width = 240;
            // 
            // prenom
            // 
            this.prenom.Text = "prenom";
            this.prenom.Width = 240;
            // 
            // age
            // 
            this.age.Text = "age";
            this.age.Width = 55;
            // 
            // club
            // 
            this.club.Text = "club";
            this.club.Width = 140;
            // 
            // pointsTotaux
            // 
            this.pointsTotaux.Text = "pointsTotaux";
            this.pointsTotaux.Width = 100;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.MistyRose;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NoPatineur2,
            this.NoCourse,
            this.Distance,
            this.Position,
            this.Temps,
            this.NomCourse,
            this.Points});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView2.Location = new System.Drawing.Point(901, 13);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(880, 914);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // NoPatineur2
            // 
            this.NoPatineur2.Text = "NoPatineur";
            this.NoPatineur2.Width = 100;
            // 
            // NoCourse
            // 
            this.NoCourse.Text = "NoCourse";
            this.NoCourse.Width = 100;
            // 
            // Distance
            // 
            this.Distance.Text = "Distance";
            this.Distance.Width = 100;
            // 
            // Position
            // 
            this.Position.Text = "Position";
            this.Position.Width = 100;
            // 
            // Temps
            // 
            this.Temps.Text = "Temps";
            this.Temps.Width = 100;
            // 
            // NomCourse
            // 
            this.NomCourse.Text = "NomCourse";
            this.NomCourse.Width = 275;
            // 
            // Points
            // 
            this.Points.Text = "Points";
            this.Points.Width = 100;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnExcel.Location = new System.Drawing.Point(1789, 13);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(244, 914);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "&Charger Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2046, 940);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private ColumnHeader noPatineur;
        private ColumnHeader nom;
        private ColumnHeader prenom;
        private ColumnHeader age;
        private ColumnHeader club;
        private ColumnHeader pointsTotaux;
        private ListView listView2;
        private ColumnHeader NoPatineur2;
        private ColumnHeader NoCourse;
        private ColumnHeader Distance;
        private ColumnHeader Position;
        private ColumnHeader Temps;
        private ColumnHeader NomCourse;
        private ColumnHeader Points;
        private Button btnExcel;
    }
}