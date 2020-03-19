namespace BloodBankSystem
{
    partial class frameHome
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
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.panelOPositive = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOPositiveCount = new System.Windows.Forms.Label();
            this.labelBloodGroup = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblONegativeCount = new System.Windows.Forms.Label();
            this.lblONegative = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblANegativeCount = new System.Windows.Forms.Label();
            this.lblANegative = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAPositiveCount = new System.Windows.Forms.Label();
            this.lblAPositive = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblABNegativeCount = new System.Windows.Forms.Label();
            this.lblABNegative = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblABPositiveCount = new System.Windows.Forms.Label();
            this.lblABPositive = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lblBNegativeCount = new System.Windows.Forms.Label();
            this.lblBNegative = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.lblBPositiveCount = new System.Windows.Forms.Label();
            this.lblBPositive = new System.Windows.Forms.Label();
            this.dgvDonors = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.menuStripTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelOPositive.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripTop.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.donorsToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(1207, 33);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // donorsToolStripMenuItem
            // 
            this.donorsToolStripMenuItem.Name = "donorsToolStripMenuItem";
            this.donorsToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.donorsToolStripMenuItem.Text = "Donors";
            this.donorsToolStripMenuItem.Click += new System.EventHandler(this.donorsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblAppName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 547);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 33);
            this.panel1.TabIndex = 1;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Location = new System.Drawing.Point(364, 4);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(87, 20);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "BloodBank";
            // 
            // panelOPositive
            // 
            this.panelOPositive.BackColor = System.Drawing.Color.White;
            this.panelOPositive.Controls.Add(this.lblName);
            this.panelOPositive.Controls.Add(this.lblOPositiveCount);
            this.panelOPositive.Controls.Add(this.labelBloodGroup);
            this.panelOPositive.Location = new System.Drawing.Point(12, 50);
            this.panelOPositive.Name = "panelOPositive";
            this.panelOPositive.Size = new System.Drawing.Size(219, 103);
            this.panelOPositive.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(108, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 29);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Donors";
            // 
            // lblOPositiveCount
            // 
            this.lblOPositiveCount.AutoSize = true;
            this.lblOPositiveCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPositiveCount.Location = new System.Drawing.Point(138, 9);
            this.lblOPositiveCount.Name = "lblOPositiveCount";
            this.lblOPositiveCount.Size = new System.Drawing.Size(42, 46);
            this.lblOPositiveCount.TabIndex = 1;
            this.lblOPositiveCount.Text = "0";
            // 
            // labelBloodGroup
            // 
            this.labelBloodGroup.AutoSize = true;
            this.labelBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBloodGroup.ForeColor = System.Drawing.Color.DarkRed;
            this.labelBloodGroup.Location = new System.Drawing.Point(22, 23);
            this.labelBloodGroup.Name = "labelBloodGroup";
            this.labelBloodGroup.Size = new System.Drawing.Size(91, 55);
            this.labelBloodGroup.TabIndex = 0;
            this.labelBloodGroup.Text = "O+";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblONegativeCount);
            this.panel2.Controls.Add(this.lblONegative);
            this.panel2.Location = new System.Drawing.Point(264, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 103);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Donors";
            // 
            // lblONegativeCount
            // 
            this.lblONegativeCount.AutoSize = true;
            this.lblONegativeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblONegativeCount.Location = new System.Drawing.Point(138, 9);
            this.lblONegativeCount.Name = "lblONegativeCount";
            this.lblONegativeCount.Size = new System.Drawing.Size(42, 46);
            this.lblONegativeCount.TabIndex = 1;
            this.lblONegativeCount.Text = "0";
            // 
            // lblONegative
            // 
            this.lblONegative.AutoSize = true;
            this.lblONegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblONegative.ForeColor = System.Drawing.Color.DarkRed;
            this.lblONegative.Location = new System.Drawing.Point(22, 23);
            this.lblONegative.Name = "lblONegative";
            this.lblONegative.Size = new System.Drawing.Size(79, 55);
            this.lblONegative.TabIndex = 0;
            this.lblONegative.Text = "O-";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblANegativeCount);
            this.panel3.Controls.Add(this.lblANegative);
            this.panel3.Location = new System.Drawing.Point(261, 182);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 103);
            this.panel3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Donors";
            // 
            // lblANegativeCount
            // 
            this.lblANegativeCount.AutoSize = true;
            this.lblANegativeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblANegativeCount.Location = new System.Drawing.Point(138, 9);
            this.lblANegativeCount.Name = "lblANegativeCount";
            this.lblANegativeCount.Size = new System.Drawing.Size(42, 46);
            this.lblANegativeCount.TabIndex = 1;
            this.lblANegativeCount.Text = "0";
            // 
            // lblANegative
            // 
            this.lblANegative.AutoSize = true;
            this.lblANegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblANegative.ForeColor = System.Drawing.Color.DarkRed;
            this.lblANegative.Location = new System.Drawing.Point(22, 23);
            this.lblANegative.Name = "lblANegative";
            this.lblANegative.Size = new System.Drawing.Size(74, 55);
            this.lblANegative.TabIndex = 0;
            this.lblANegative.Text = "A-";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.lblAPositiveCount);
            this.panel4.Controls.Add(this.lblAPositive);
            this.panel4.Location = new System.Drawing.Point(12, 177);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(219, 103);
            this.panel4.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(108, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Donors";
            // 
            // lblAPositiveCount
            // 
            this.lblAPositiveCount.AutoSize = true;
            this.lblAPositiveCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPositiveCount.Location = new System.Drawing.Point(138, 9);
            this.lblAPositiveCount.Name = "lblAPositiveCount";
            this.lblAPositiveCount.Size = new System.Drawing.Size(42, 46);
            this.lblAPositiveCount.TabIndex = 1;
            this.lblAPositiveCount.Text = "0";
            // 
            // lblAPositive
            // 
            this.lblAPositive.AutoSize = true;
            this.lblAPositive.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPositive.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAPositive.Location = new System.Drawing.Point(22, 23);
            this.lblAPositive.Name = "lblAPositive";
            this.lblAPositive.Size = new System.Drawing.Size(86, 55);
            this.lblAPositive.TabIndex = 0;
            this.lblAPositive.Text = "A+";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.lblABNegativeCount);
            this.panel5.Controls.Add(this.lblABNegative);
            this.panel5.Location = new System.Drawing.Point(264, 428);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(219, 103);
            this.panel5.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(108, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 29);
            this.label10.TabIndex = 2;
            this.label10.Text = "Donors";
            // 
            // lblABNegativeCount
            // 
            this.lblABNegativeCount.AutoSize = true;
            this.lblABNegativeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABNegativeCount.Location = new System.Drawing.Point(138, 9);
            this.lblABNegativeCount.Name = "lblABNegativeCount";
            this.lblABNegativeCount.Size = new System.Drawing.Size(42, 46);
            this.lblABNegativeCount.TabIndex = 1;
            this.lblABNegativeCount.Text = "0";
            // 
            // lblABNegative
            // 
            this.lblABNegative.AutoSize = true;
            this.lblABNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABNegative.ForeColor = System.Drawing.Color.DarkRed;
            this.lblABNegative.Location = new System.Drawing.Point(22, 23);
            this.lblABNegative.Name = "lblABNegative";
            this.lblABNegative.Size = new System.Drawing.Size(107, 55);
            this.lblABNegative.TabIndex = 0;
            this.lblABNegative.Text = "AB-";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.lblABPositiveCount);
            this.panel6.Controls.Add(this.lblABPositive);
            this.panel6.Location = new System.Drawing.Point(12, 428);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(219, 103);
            this.panel6.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(108, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 29);
            this.label13.TabIndex = 2;
            this.label13.Text = "Donors";
            // 
            // lblABPositiveCount
            // 
            this.lblABPositiveCount.AutoSize = true;
            this.lblABPositiveCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABPositiveCount.Location = new System.Drawing.Point(138, 9);
            this.lblABPositiveCount.Name = "lblABPositiveCount";
            this.lblABPositiveCount.Size = new System.Drawing.Size(42, 46);
            this.lblABPositiveCount.TabIndex = 1;
            this.lblABPositiveCount.Text = "0";
            // 
            // lblABPositive
            // 
            this.lblABPositive.AutoSize = true;
            this.lblABPositive.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABPositive.ForeColor = System.Drawing.Color.DarkRed;
            this.lblABPositive.Location = new System.Drawing.Point(22, 23);
            this.lblABPositive.Name = "lblABPositive";
            this.lblABPositive.Size = new System.Drawing.Size(119, 55);
            this.lblABPositive.TabIndex = 0;
            this.lblABPositive.Text = "AB+";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.lblBNegativeCount);
            this.panel7.Controls.Add(this.lblBNegative);
            this.panel7.Location = new System.Drawing.Point(264, 301);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(219, 103);
            this.panel7.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(108, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 29);
            this.label16.TabIndex = 2;
            this.label16.Text = "Donors";
            // 
            // lblBNegativeCount
            // 
            this.lblBNegativeCount.AutoSize = true;
            this.lblBNegativeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBNegativeCount.Location = new System.Drawing.Point(138, 9);
            this.lblBNegativeCount.Name = "lblBNegativeCount";
            this.lblBNegativeCount.Size = new System.Drawing.Size(42, 46);
            this.lblBNegativeCount.TabIndex = 1;
            this.lblBNegativeCount.Text = "0";
            // 
            // lblBNegative
            // 
            this.lblBNegative.AutoSize = true;
            this.lblBNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBNegative.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBNegative.Location = new System.Drawing.Point(22, 23);
            this.lblBNegative.Name = "lblBNegative";
            this.lblBNegative.Size = new System.Drawing.Size(74, 55);
            this.lblBNegative.TabIndex = 0;
            this.lblBNegative.Text = "B-";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.label19);
            this.panel8.Controls.Add(this.lblBPositiveCount);
            this.panel8.Controls.Add(this.lblBPositive);
            this.panel8.Location = new System.Drawing.Point(12, 301);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(219, 103);
            this.panel8.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(108, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 29);
            this.label19.TabIndex = 2;
            this.label19.Text = "Donors";
            // 
            // lblBPositiveCount
            // 
            this.lblBPositiveCount.AutoSize = true;
            this.lblBPositiveCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPositiveCount.Location = new System.Drawing.Point(138, 9);
            this.lblBPositiveCount.Name = "lblBPositiveCount";
            this.lblBPositiveCount.Size = new System.Drawing.Size(42, 46);
            this.lblBPositiveCount.TabIndex = 1;
            this.lblBPositiveCount.Text = "0";
            // 
            // lblBPositive
            // 
            this.lblBPositive.AutoSize = true;
            this.lblBPositive.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPositive.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBPositive.Location = new System.Drawing.Point(22, 23);
            this.lblBPositive.Name = "lblBPositive";
            this.lblBPositive.Size = new System.Drawing.Size(86, 55);
            this.lblBPositive.TabIndex = 0;
            this.lblBPositive.Text = "B+";
            // 
            // dgvDonors
            // 
            this.dgvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonors.Location = new System.Drawing.Point(552, 124);
            this.dgvDonors.Name = "dgvDonors";
            this.dgvDonors.RowHeadersWidth = 62;
            this.dgvDonors.RowTemplate.Height = 28;
            this.dgvDonors.Size = new System.Drawing.Size(643, 407);
            this.dgvDonors.TabIndex = 10;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(552, 59);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(116, 20);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search Donors";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(693, 60);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(502, 26);
            this.txtSearch.TabIndex = 12;
            // 
            // frameHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1207, 580);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvDonors);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panelOPositive);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.menuStripTop);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "frameHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelOPositive.ResumeLayout(false);
            this.panelOPositive.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Panel panelOPositive;
        private System.Windows.Forms.Label lblOPositiveCount;
        private System.Windows.Forms.Label labelBloodGroup;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblONegativeCount;
        private System.Windows.Forms.Label lblONegative;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblANegativeCount;
        private System.Windows.Forms.Label lblANegative;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAPositiveCount;
        private System.Windows.Forms.Label lblAPositive;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblABNegativeCount;
        private System.Windows.Forms.Label lblABNegative;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblABPositiveCount;
        private System.Windows.Forms.Label lblABPositive;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblBNegativeCount;
        private System.Windows.Forms.Label lblBNegative;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblBPositiveCount;
        private System.Windows.Forms.Label lblBPositive;
        private System.Windows.Forms.DataGridView dgvDonors;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

