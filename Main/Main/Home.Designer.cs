namespace Main
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.objectiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libaryRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciculationServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Purple;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.adToolStripMenuItem,
            this.bookSearchToolStripMenuItem,
            this.userGuideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.BackColor = System.Drawing.Color.Orchid;
            this.aboutUsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem1,
            this.objectiveToolStripMenuItem});
            this.aboutUsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.aboutUsToolStripMenuItem.Text = "Home";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem1
            // 
            this.aboutUsToolStripMenuItem1.Name = "aboutUsToolStripMenuItem1";
            this.aboutUsToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.aboutUsToolStripMenuItem1.Text = "About Us";
            this.aboutUsToolStripMenuItem1.Click += new System.EventHandler(this.aboutUsToolStripMenuItem1_Click);
            // 
            // objectiveToolStripMenuItem
            // 
            this.objectiveToolStripMenuItem.Name = "objectiveToolStripMenuItem";
            this.objectiveToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.objectiveToolStripMenuItem.Text = "Objective";
            this.objectiveToolStripMenuItem.Click += new System.EventHandler(this.objectiveToolStripMenuItem_Click);
            // 
            // adToolStripMenuItem
            // 
            this.adToolStripMenuItem.BackColor = System.Drawing.Color.Violet;
            this.adToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adToolStripMenuItem.Name = "adToolStripMenuItem";
            this.adToolStripMenuItem.Size = new System.Drawing.Size(130, 25);
            this.adToolStripMenuItem.Text = "Administration";
            this.adToolStripMenuItem.Click += new System.EventHandler(this.adToolStripMenuItem_Click);
            // 
            // bookSearchToolStripMenuItem
            // 
            this.bookSearchToolStripMenuItem.BackColor = System.Drawing.Color.Orchid;
            this.bookSearchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookSearchToolStripMenuItem.Name = "bookSearchToolStripMenuItem";
            this.bookSearchToolStripMenuItem.Size = new System.Drawing.Size(113, 25);
            this.bookSearchToolStripMenuItem.Text = "Book Search";
            this.bookSearchToolStripMenuItem.Click += new System.EventHandler(this.bookSearchToolStripMenuItem_Click);
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.BackColor = System.Drawing.Color.Violet;
            this.userGuideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicInformationToolStripMenuItem,
            this.libaryRulesToolStripMenuItem,
            this.ciculationServiceToolStripMenuItem});
            this.userGuideToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(113, 25);
            this.userGuideToolStripMenuItem.Text = "User\'s Guide";
            // 
            // basicInformationToolStripMenuItem
            // 
            this.basicInformationToolStripMenuItem.Name = "basicInformationToolStripMenuItem";
            this.basicInformationToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.basicInformationToolStripMenuItem.Text = "Basic Information";
            this.basicInformationToolStripMenuItem.Click += new System.EventHandler(this.basicInformationToolStripMenuItem_Click);
            // 
            // libaryRulesToolStripMenuItem
            // 
            this.libaryRulesToolStripMenuItem.Name = "libaryRulesToolStripMenuItem";
            this.libaryRulesToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.libaryRulesToolStripMenuItem.Text = "Libary Rules";
            this.libaryRulesToolStripMenuItem.Click += new System.EventHandler(this.libaryRulesToolStripMenuItem_Click);
            // 
            // ciculationServiceToolStripMenuItem
            // 
            this.ciculationServiceToolStripMenuItem.Name = "ciculationServiceToolStripMenuItem";
            this.ciculationServiceToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.ciculationServiceToolStripMenuItem.Text = "Ciculation Service";
            this.ciculationServiceToolStripMenuItem.Click += new System.EventHandler(this.ciculationServiceToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Main.Properties.Resources.l1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(294, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 266);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(440, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 71);
            this.label1.TabIndex = 3;
            this.label1.Text = "AUST LIBRARY";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1366, 746);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem objectiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libaryRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciculationServiceToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}