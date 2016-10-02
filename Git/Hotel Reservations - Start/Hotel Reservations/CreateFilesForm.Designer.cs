namespace Hotel_Reservations
{
    partial class CreateFilesForm
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createHotelsxmlFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayHotelsxmlsFileInBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createRoominventoryxmlFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayRoominventoryxmlFileInBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadHotelFileButton = new System.Windows.Forms.Button();
            this.ShowHtmlHotelsButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 464);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(268, 29);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "(status of last operation)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createHotelsxmlFileToolStripMenuItem,
            this.displayHotelsxmlsFileInBrowserToolStripMenuItem,
            this.createRoominventoryxmlFileToolStripMenuItem,
            this.displayRoominventoryxmlFileInBrowserToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createHotelsxmlFileToolStripMenuItem
            // 
            this.createHotelsxmlFileToolStripMenuItem.Name = "createHotelsxmlFileToolStripMenuItem";
            this.createHotelsxmlFileToolStripMenuItem.Size = new System.Drawing.Size(426, 30);
            this.createHotelsxmlFileToolStripMenuItem.Text = "Create Hotels.xml file";
            this.createHotelsxmlFileToolStripMenuItem.Click += new System.EventHandler(this.createHotelsxmlFileToolStripMenuItem_Click);
            // 
            // displayHotelsxmlsFileInBrowserToolStripMenuItem
            // 
            this.displayHotelsxmlsFileInBrowserToolStripMenuItem.Name = "displayHotelsxmlsFileInBrowserToolStripMenuItem";
            this.displayHotelsxmlsFileInBrowserToolStripMenuItem.Size = new System.Drawing.Size(426, 30);
            this.displayHotelsxmlsFileInBrowserToolStripMenuItem.Text = "Display Hotels.xmls file in browser";
            this.displayHotelsxmlsFileInBrowserToolStripMenuItem.Click += new System.EventHandler(this.displayHotelsxmlsFileInBrowserToolStripMenuItem_Click);
            // 
            // createRoominventoryxmlFileToolStripMenuItem
            // 
            this.createRoominventoryxmlFileToolStripMenuItem.Name = "createRoominventoryxmlFileToolStripMenuItem";
            this.createRoominventoryxmlFileToolStripMenuItem.Size = new System.Drawing.Size(426, 30);
            this.createRoominventoryxmlFileToolStripMenuItem.Text = "Create roominventory.xml file";
            this.createRoominventoryxmlFileToolStripMenuItem.Click += new System.EventHandler(this.createRoominventoryxmlFileToolStripMenuItem_Click);
            // 
            // displayRoominventoryxmlFileInBrowserToolStripMenuItem
            // 
            this.displayRoominventoryxmlFileInBrowserToolStripMenuItem.Name = "displayRoominventoryxmlFileInBrowserToolStripMenuItem";
            this.displayRoominventoryxmlFileInBrowserToolStripMenuItem.Size = new System.Drawing.Size(426, 30);
            this.displayRoominventoryxmlFileInBrowserToolStripMenuItem.Text = "Display roominventory.xml file in browser";
            this.displayRoominventoryxmlFileInBrowserToolStripMenuItem.Click += new System.EventHandler(this.displayRoominventoryxmlFileInBrowserToolStripMenuItem_Click);
            // 
            // loadHotelFileButton
            // 
            this.loadHotelFileButton.Location = new System.Drawing.Point(167, 131);
            this.loadHotelFileButton.Name = "loadHotelFileButton";
            this.loadHotelFileButton.Size = new System.Drawing.Size(478, 88);
            this.loadHotelFileButton.TabIndex = 6;
            this.loadHotelFileButton.Text = "Load Hotel File ( click me first )";
            this.loadHotelFileButton.UseVisualStyleBackColor = true;
            this.loadHotelFileButton.Click += new System.EventHandler(this.loadHotelFileButton_Click);
            // 
            // ShowHtmlHotelsButton
            // 
            this.ShowHtmlHotelsButton.Location = new System.Drawing.Point(167, 239);
            this.ShowHtmlHotelsButton.Name = "ShowHtmlHotelsButton";
            this.ShowHtmlHotelsButton.Size = new System.Drawing.Size(478, 88);
            this.ShowHtmlHotelsButton.TabIndex = 7;
            this.ShowHtmlHotelsButton.Text = "Show hotels HTML";
            this.ShowHtmlHotelsButton.UseVisualStyleBackColor = true;
            this.ShowHtmlHotelsButton.Click += new System.EventHandler(this.ShowHtmlHotelsButton_Click);
            // 
            // CreateFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 502);
            this.Controls.Add(this.ShowHtmlHotelsButton);
            this.Controls.Add(this.loadHotelFileButton);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment 2 - Faura  & Miranda";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createHotelsxmlFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayHotelsxmlsFileInBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createRoominventoryxmlFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayRoominventoryxmlFileInBrowserToolStripMenuItem;
        private System.Windows.Forms.Button loadHotelFileButton;
        private System.Windows.Forms.Button ShowHtmlHotelsButton;
    }
}

