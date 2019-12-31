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
            this.TvOrganization = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoCleanUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performCleanUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnLinkFile = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnFileLinking = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnFileGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnEditOrganization = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnEditGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnEditMember = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAddContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnRefreshGroupsMembers = new System.Windows.Forms.Button();
            this.TvGroupsMembers = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblMemberOf = new System.Windows.Forms.Label();
            this.LblCreateDate = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblCountry = new System.Windows.Forms.Label();
            this.LblState = new System.Windows.Forms.Label();
            this.LblCity = new System.Windows.Forms.Label();
            this.LblZip = new System.Windows.Forms.Label();
            this.LblNumber = new System.Windows.Forms.Label();
            this.LblStreet = new System.Windows.Forms.Label();
            this.LblBirthdate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.LblBirthDateDesc = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblGenderDesc = new System.Windows.Forms.Label();
            this.LblPath = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.PbPicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TvOrganization)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TvGroupsMembers)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPicture)).BeginInit();
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
            this.treeListView1.Size = new System.Drawing.Size(611, 572);
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
            this.editToolStripMenuItem,
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
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executeToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoCleanUpToolStripMenuItem,
            this.databaseExportToolStripMenuItem});
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.executeToolStripMenuItem.Text = "Execute...";
            // 
            // autoCleanUpToolStripMenuItem
            // 
            this.autoCleanUpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.performCleanUpToolStripMenuItem});
            this.autoCleanUpToolStripMenuItem.Name = "autoCleanUpToolStripMenuItem";
            this.autoCleanUpToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.autoCleanUpToolStripMenuItem.Text = "Clean Up...";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // performCleanUpToolStripMenuItem
            // 
            this.performCleanUpToolStripMenuItem.Name = "performCleanUpToolStripMenuItem";
            this.performCleanUpToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.performCleanUpToolStripMenuItem.Text = "Perform Clean Up";
            // 
            // databaseExportToolStripMenuItem
            // 
            this.databaseExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupDatabaseToolStripMenuItem,
            this.mapDatabaseToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.databaseExportToolStripMenuItem.Name = "databaseExportToolStripMenuItem";
            this.databaseExportToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.databaseExportToolStripMenuItem.Text = "Database...";
            // 
            // backupDatabaseToolStripMenuItem
            // 
            this.backupDatabaseToolStripMenuItem.Name = "backupDatabaseToolStripMenuItem";
            this.backupDatabaseToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.backupDatabaseToolStripMenuItem.Text = "Backup";
            // 
            // mapDatabaseToolStripMenuItem
            // 
            this.mapDatabaseToolStripMenuItem.Name = "mapDatabaseToolStripMenuItem";
            this.mapDatabaseToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.mapDatabaseToolStripMenuItem.Text = "Re-Map";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.quitToolStripMenuItem.Text = "Quit";
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
            this.BtnLinkFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnFileLinking,
            this.BtnFileGroup});
            this.BtnLinkFile.Name = "BtnLinkFile";
            this.BtnLinkFile.Size = new System.Drawing.Size(142, 22);
            this.BtnLinkFile.Text = "Files";
            this.BtnLinkFile.Click += new System.EventHandler(this.BtnLinkFile_Click);
            // 
            // BtnFileLinking
            // 
            this.BtnFileLinking.Name = "BtnFileLinking";
            this.BtnFileLinking.Size = new System.Drawing.Size(134, 22);
            this.BtnFileLinking.Text = "File Linking";
            this.BtnFileLinking.Click += new System.EventHandler(this.BtnFileLinking_Click);
            // 
            // BtnFileGroup
            // 
            this.BtnFileGroup.Name = "BtnFileGroup";
            this.BtnFileGroup.Size = new System.Drawing.Size(134, 22);
            this.BtnFileGroup.Text = "File Group";
            this.BtnFileGroup.Click += new System.EventHandler(this.BtnFileGroup_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnEditOrganization,
            this.BtnEditGroup,
            this.BtnEditMember});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.editToolStripMenuItem.Text = "Edit...";
            // 
            // BtnEditOrganization
            // 
            this.BtnEditOrganization.Name = "BtnEditOrganization";
            this.BtnEditOrganization.Size = new System.Drawing.Size(180, 22);
            this.BtnEditOrganization.Text = "Organization";
            this.BtnEditOrganization.Click += new System.EventHandler(this.BtnEditOrganization_Click);
            // 
            // BtnEditGroup
            // 
            this.BtnEditGroup.Name = "BtnEditGroup";
            this.BtnEditGroup.Size = new System.Drawing.Size(180, 22);
            this.BtnEditGroup.Text = "Group";
            this.BtnEditGroup.Click += new System.EventHandler(this.BtnEditGroup_Click);
            // 
            // BtnEditMember
            // 
            this.BtnEditMember.Name = "BtnEditMember";
            this.BtnEditMember.Size = new System.Drawing.Size(180, 22);
            this.BtnEditMember.Text = "Member";
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
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnRefreshGroupsMembers);
            this.panel3.Controls.Add(this.TvGroupsMembers);
            this.panel3.Location = new System.Drawing.Point(274, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 604);
            this.panel3.TabIndex = 4;
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
            // TvGroupsMembers
            // 
            this.TvGroupsMembers.AllColumns.Add(this.olvColumn4);
            this.TvGroupsMembers.AllColumns.Add(this.olvColumn1);
            this.TvGroupsMembers.AllColumns.Add(this.olvColumn3);
            this.TvGroupsMembers.CellEditUseWholeCell = false;
            this.TvGroupsMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn4,
            this.olvColumn1,
            this.olvColumn3});
            this.TvGroupsMembers.Cursor = System.Windows.Forms.Cursors.Default;
            this.TvGroupsMembers.HideSelection = false;
            this.TvGroupsMembers.Location = new System.Drawing.Point(3, 29);
            this.TvGroupsMembers.Name = "TvGroupsMembers";
            this.TvGroupsMembers.Size = new System.Drawing.Size(200, 572);
            this.TvGroupsMembers.TabIndex = 0;
            this.TvGroupsMembers.UseCompatibleStateImageBehavior = false;
            this.TvGroupsMembers.View = System.Windows.Forms.View.Details;
            this.TvGroupsMembers.SelectedIndexChanged += new System.EventHandler(this.TvGroupsMembers_SelectedIndexChanged);
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "GroupName";
            this.olvColumn4.DisplayIndex = 2;
            this.olvColumn4.IsVisible = false;
            this.olvColumn4.Text = "Group";
            this.olvColumn4.Width = 0;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "FirstName";
            this.olvColumn1.DisplayIndex = 0;
            this.olvColumn1.Text = "Firstname";
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "LastName";
            this.olvColumn3.DisplayIndex = 1;
            this.olvColumn3.Text = "Lastname";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LblMemberOf);
            this.panel4.Controls.Add(this.LblCreateDate);
            this.panel4.Controls.Add(this.LblGender);
            this.panel4.Controls.Add(this.LblCountry);
            this.panel4.Controls.Add(this.LblState);
            this.panel4.Controls.Add(this.LblCity);
            this.panel4.Controls.Add(this.LblZip);
            this.panel4.Controls.Add(this.LblNumber);
            this.panel4.Controls.Add(this.LblStreet);
            this.panel4.Controls.Add(this.LblBirthdate);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.TbDescription);
            this.panel4.Controls.Add(this.LblBirthDateDesc);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.LblGenderDesc);
            this.panel4.Controls.Add(this.LblPath);
            this.panel4.Controls.Add(this.LblName);
            this.panel4.Controls.Add(this.LblType);
            this.panel4.Controls.Add(this.PbPicture);
            this.panel4.Location = new System.Drawing.Point(1109, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(254, 604);
            this.panel4.TabIndex = 5;
            // 
            // LblMemberOf
            // 
            this.LblMemberOf.AutoSize = true;
            this.LblMemberOf.Location = new System.Drawing.Point(76, 446);
            this.LblMemberOf.Name = "LblMemberOf";
            this.LblMemberOf.Size = new System.Drawing.Size(41, 13);
            this.LblMemberOf.TabIndex = 26;
            this.LblMemberOf.Text = "label22";
            // 
            // LblCreateDate
            // 
            this.LblCreateDate.AutoSize = true;
            this.LblCreateDate.Location = new System.Drawing.Point(103, 420);
            this.LblCreateDate.Name = "LblCreateDate";
            this.LblCreateDate.Size = new System.Drawing.Size(41, 13);
            this.LblCreateDate.TabIndex = 25;
            this.LblCreateDate.Text = "label21";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(56, 360);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(41, 13);
            this.LblGender.TabIndex = 24;
            this.LblGender.Text = "label20";
            // 
            // LblCountry
            // 
            this.LblCountry.AutoSize = true;
            this.LblCountry.Location = new System.Drawing.Point(62, 340);
            this.LblCountry.Name = "LblCountry";
            this.LblCountry.Size = new System.Drawing.Size(41, 13);
            this.LblCountry.TabIndex = 22;
            this.LblCountry.Text = "label18";
            // 
            // LblState
            // 
            this.LblState.AutoSize = true;
            this.LblState.Location = new System.Drawing.Point(51, 320);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(41, 13);
            this.LblState.TabIndex = 21;
            this.LblState.Text = "label17";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(126, 300);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(41, 13);
            this.LblCity.TabIndex = 20;
            this.LblCity.Text = "label16";
            // 
            // LblZip
            // 
            this.LblZip.AutoSize = true;
            this.LblZip.Location = new System.Drawing.Point(41, 300);
            this.LblZip.Name = "LblZip";
            this.LblZip.Size = new System.Drawing.Size(41, 13);
            this.LblZip.TabIndex = 19;
            this.LblZip.Text = "label15";
            // 
            // LblNumber
            // 
            this.LblNumber.AutoSize = true;
            this.LblNumber.Location = new System.Drawing.Point(199, 280);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(41, 13);
            this.LblNumber.TabIndex = 18;
            this.LblNumber.Text = "label14";
            // 
            // LblStreet
            // 
            this.LblStreet.AutoSize = true;
            this.LblStreet.Location = new System.Drawing.Point(54, 280);
            this.LblStreet.Name = "LblStreet";
            this.LblStreet.Size = new System.Drawing.Size(41, 13);
            this.LblStreet.TabIndex = 17;
            this.LblStreet.Text = "label13";
            // 
            // LblBirthdate
            // 
            this.LblBirthdate.AutoSize = true;
            this.LblBirthdate.Location = new System.Drawing.Point(68, 260);
            this.LblBirthdate.Name = "LblBirthdate";
            this.LblBirthdate.Size = new System.Drawing.Size(41, 13);
            this.LblBirthdate.TabIndex = 16;
            this.LblBirthdate.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 446);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Member of:";
            // 
            // TbDescription
            // 
            this.TbDescription.Location = new System.Drawing.Point(3, 472);
            this.TbDescription.Multiline = true;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(248, 129);
            this.TbDescription.TabIndex = 14;
            // 
            // LblBirthDateDesc
            // 
            this.LblBirthDateDesc.AutoSize = true;
            this.LblBirthDateDesc.Location = new System.Drawing.Point(10, 260);
            this.LblBirthDateDesc.Name = "LblBirthDateDesc";
            this.LblBirthDateDesc.Size = new System.Drawing.Size(52, 13);
            this.LblBirthDateDesc.TabIndex = 13;
            this.LblBirthDateDesc.Text = "Birthdate:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Date of Creation:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Country:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Zip:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nr.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Street:";
            // 
            // LblGenderDesc
            // 
            this.LblGenderDesc.AutoSize = true;
            this.LblGenderDesc.Location = new System.Drawing.Point(10, 360);
            this.LblGenderDesc.Name = "LblGenderDesc";
            this.LblGenderDesc.Size = new System.Drawing.Size(45, 13);
            this.LblGenderDesc.TabIndex = 4;
            this.LblGenderDesc.Text = "Gender:";
            // 
            // LblPath
            // 
            this.LblPath.AutoSize = true;
            this.LblPath.Location = new System.Drawing.Point(3, 29);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(35, 13);
            this.LblPath.TabIndex = 3;
            this.LblPath.Text = "label1";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(3, 53);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "label1";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(3, 3);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(35, 13);
            this.LblType.TabIndex = 1;
            this.LblType.Text = "label1";
            // 
            // PbPicture
            // 
            this.PbPicture.Location = new System.Drawing.Point(3, 69);
            this.PbPicture.Name = "PbPicture";
            this.PbPicture.Size = new System.Drawing.Size(248, 188);
            this.PbPicture.TabIndex = 0;
            this.PbPicture.TabStop = false;
            // 
            // OverlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 648);
            this.Controls.Add(this.panel4);
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
            ((System.ComponentModel.ISupportInitialize)(this.TvOrganization)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TvGroupsMembers)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPicture)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem BtnFileLinking;
        private System.Windows.Forms.ToolStripMenuItem BtnFileGroup;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblPath;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.PictureBox PbPicture;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.Label LblBirthDateDesc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblGenderDesc;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoCleanUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performCleanUpToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblMemberOf;
        private System.Windows.Forms.Label LblCreateDate;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblCountry;
        private System.Windows.Forms.Label LblState;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Label LblZip;
        private System.Windows.Forms.Label LblNumber;
        private System.Windows.Forms.Label LblStreet;
        private System.Windows.Forms.Label LblBirthdate;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnEditOrganization;
        private System.Windows.Forms.ToolStripMenuItem BtnEditGroup;
        private System.Windows.Forms.ToolStripMenuItem BtnEditMember;
    }
}

