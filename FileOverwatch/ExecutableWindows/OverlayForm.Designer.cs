using CommonTools;

namespace ExecutableWindows
{
    partial class OverlayForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeListView1 = new BrightIdeasSoftware.TreeListView();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnLinkFile = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAddContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TvOrganization = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.TvGroupsMembers = new BrightIdeasSoftware.ObjectListView();
            this.BtnRefreshGroupsMembers = new System.Windows.Forms.Button();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TvOrganization)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TvGroupsMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeListView1);
            this.panel1.Controls.Add(this.BtnRefresh);
            this.panel1.Location = new System.Drawing.Point(486, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 604);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // treeListView1
            // 
            this.treeListView1.CellEditUseWholeCell = false;
            this.treeListView1.HideSelection = false;
            this.treeListView1.Location = new System.Drawing.Point(3, 29);
            this.treeListView1.Name = "treeListView1";
            this.treeListView1.ShowGroups = false;
            this.treeListView1.Size = new System.Drawing.Size(824, 572);
            this.treeListView1.TabIndex = 2;
            this.treeListView1.UseCompatibleStateImageBehavior = false;
            this.treeListView1.View = System.Windows.Forms.View.Details;
            this.treeListView1.VirtualMode = true;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(752, 3);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtnRefresh.TabIndex = 1;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TvOrganization);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(12, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 604);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.erstellenToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1375, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // erstellenToolStripMenuItem
            // 
            this.erstellenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.organizationToolStripMenuItem,
            this.groupToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.BtnLinkFile});
            this.erstellenToolStripMenuItem.Name = "erstellenToolStripMenuItem";
            this.erstellenToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.erstellenToolStripMenuItem.Text = "Erstellen...";
            // 
            // organizationToolStripMenuItem
            // 
            this.organizationToolStripMenuItem.Name = "organizationToolStripMenuItem";
            this.organizationToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.organizationToolStripMenuItem.Text = "Organization";
            this.organizationToolStripMenuItem.Click += new System.EventHandler(this.organizationToolStripMenuItem_Click);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.groupToolStripMenuItem.Text = "Group";
            this.groupToolStripMenuItem.Click += new System.EventHandler(this.groupToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.memberToolStripMenuItem_Click);
            // 
            // BtnLinkFile
            // 
            this.BtnLinkFile.Name = "BtnLinkFile";
            this.BtnLinkFile.Size = new System.Drawing.Size(142, 22);
            this.BtnLinkFile.Text = "File Linking";
            this.BtnLinkFile.Click += new System.EventHandler(this.BtnLinkFile_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAddContextMenu});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // BtnAddContextMenu
            // 
            this.BtnAddContextMenu.Name = "BtnAddContextMenu";
            this.BtnAddContextMenu.Size = new System.Drawing.Size(174, 22);
            this.BtnAddContextMenu.Text = "Add Context Menu";
            this.BtnAddContextMenu.Click += new System.EventHandler(this.BtnAddContextMenu_Click);
            // 
            // TvOrganization
            // 
            this.TvOrganization.AllColumns.Add(this.olvColumn2);
            this.TvOrganization.CellEditUseWholeCell = false;
            this.TvOrganization.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn2});
            this.TvOrganization.Cursor = System.Windows.Forms.Cursors.Default;
            this.TvOrganization.HideSelection = false;
            this.TvOrganization.Location = new System.Drawing.Point(4, 29);
            this.TvOrganization.Name = "TvOrganization";
            this.TvOrganization.Size = new System.Drawing.Size(248, 572);
            this.TvOrganization.TabIndex = 4;
            this.TvOrganization.UseCompatibleStateImageBehavior = false;
            this.TvOrganization.View = System.Windows.Forms.View.Details;
            this.TvOrganization.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.TvOrganization_ItemSelectionChanged);
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Name";
            this.olvColumn2.Text = "Name";
            this.olvColumn2.Width = 100;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnRefreshGroupsMembers);
            this.panel3.Controls.Add(this.TvGroupsMembers);
            this.panel3.Location = new System.Drawing.Point(274, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 604);
            this.panel3.TabIndex = 4;
            // 
            // TvGroupsMembers
            // 
            this.TvGroupsMembers.AllColumns.Add(this.olvColumn1);
            this.TvGroupsMembers.AllColumns.Add(this.olvColumn3);
            this.TvGroupsMembers.AllColumns.Add(this.olvColumn4);
            this.TvGroupsMembers.CellEditUseWholeCell = false;
            this.TvGroupsMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn3,
            this.olvColumn4});
            this.TvGroupsMembers.HideSelection = false;
            this.TvGroupsMembers.Location = new System.Drawing.Point(3, 29);
            this.TvGroupsMembers.Name = "TvGroupsMembers";
            this.TvGroupsMembers.Size = new System.Drawing.Size(200, 572);
            this.TvGroupsMembers.TabIndex = 0;
            this.TvGroupsMembers.UseCompatibleStateImageBehavior = false;
            this.TvGroupsMembers.View = System.Windows.Forms.View.Details;
            // 
            // BtnRefreshGroupsMembers
            // 
            this.BtnRefreshGroupsMembers.Location = new System.Drawing.Point(128, 3);
            this.BtnRefreshGroupsMembers.Name = "BtnRefreshGroupsMembers";
            this.BtnRefreshGroupsMembers.Size = new System.Drawing.Size(75, 23);
            this.BtnRefreshGroupsMembers.TabIndex = 1;
            this.BtnRefreshGroupsMembers.Text = "Refresh";
            this.BtnRefreshGroupsMembers.UseVisualStyleBackColor = true;
            this.BtnRefreshGroupsMembers.Click += new System.EventHandler(this.BtnRefreshGroupsMembers_Click);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "FirstName";
            this.olvColumn1.Text = "Firstname";
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "LastName";
            this.olvColumn3.Text = "Lastname";
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "GroupName";
            this.olvColumn4.Text = "Group";
            // 
            // OverlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 648);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OverlayForm";
            this.Text = "File Overwatch";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TvOrganization)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TvGroupsMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnAddContextMenu;
        private System.Windows.Forms.ToolStripMenuItem BtnLinkFile;
        private BrightIdeasSoftware.TreeListView treeListView1;
        private BrightIdeasSoftware.ObjectListView TvOrganization;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnRefreshGroupsMembers;
        private BrightIdeasSoftware.ObjectListView TvGroupsMembers;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
    }
}

