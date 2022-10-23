
namespace BULocalization
{
	partial class ChangeDefaultLanguage
	{
		private System.ComponentModel.IContainer components = null;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeDefaultLanguage));
			this.TranslationGroupBox = new System.Windows.Forms.GroupBox();
			this.Namespacelabel = new System.Windows.Forms.Label();
			this.namespacesComboBox = new System.Windows.Forms.ComboBox();
			this.setItemStateButton = new System.Windows.Forms.Button();
			this.sourceTextBox = new System.Windows.Forms.TextBox();
			this.AutoPastAndSetcheckBox = new System.Windows.Forms.CheckBox();
			this.Savebutton = new System.Windows.Forms.Button();
			this.namespacesListBox = new System.Windows.Forms.ListBox();
			this.namespacesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addNamespaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.renameNamespaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeNamespaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeNamespaceButton = new System.Windows.Forms.Button();
			this.newNamespaceButton = new System.Windows.Forms.Button();
			this.renameNamespaceButton = new System.Windows.Forms.Button();
			this.WhereTosendlabel = new System.Windows.Forms.Label();
			this.WhereTosendtextBox = new System.Windows.Forms.TextBox();
			this.wwwlabel = new System.Windows.Forms.Label();
			this.WWWtextBox = new System.Windows.Forms.TextBox();
			this.MaintabControl = new System.Windows.Forms.TabControl();
			this.ItemstabPage = new System.Windows.Forms.TabPage();
			this.searchButton = new System.Windows.Forms.Button();
			this.addNewItemButton = new System.Windows.Forms.Button();
			this.removeItemButton = new System.Windows.Forms.Button();
			this.itemsListView = new System.Windows.Forms.ListView();
			this.imageColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.idColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.textColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.itemsListContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addNewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copySourceItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyItemIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.removeLanguageItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.itemsImagesList = new System.Windows.Forms.ImageList(this.components);
			this.NamespacestabPage = new System.Windows.Forms.TabPage();
			this.OptionstabPage = new System.Windows.Forms.TabPage();
			this.contactInformationGroupBox = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.CurrgroupBox = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.copyrtextBox = new System.Windows.Forms.TextBox();
			this.emailtextBox = new System.Windows.Forms.TextBox();
			this.natnametextBox = new System.Windows.Forms.TextBox();
			this.authtextBox = new System.Windows.Forms.TextBox();
			this.copyrlabel = new System.Windows.Forms.Label();
			this.nlnlabel = new System.Windows.Forms.Label();
			this.emaillabel = new System.Windows.Forms.Label();
			this.Authlabel = new System.Windows.Forms.Label();
			this.TranslationGroupBox.SuspendLayout();
			this.namespacesContextMenuStrip.SuspendLayout();
			this.MaintabControl.SuspendLayout();
			this.ItemstabPage.SuspendLayout();
			this.itemsListContextMenuStrip.SuspendLayout();
			this.NamespacestabPage.SuspendLayout();
			this.OptionstabPage.SuspendLayout();
			this.contactInformationGroupBox.SuspendLayout();
			this.CurrgroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// TranslationGroupBox
			// 
			this.TranslationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.TranslationGroupBox.Controls.Add(this.Namespacelabel);
			this.TranslationGroupBox.Controls.Add(this.namespacesComboBox);
			this.TranslationGroupBox.Controls.Add(this.setItemStateButton);
			this.TranslationGroupBox.Controls.Add(this.sourceTextBox);
			this.TranslationGroupBox.Enabled = false;
			this.TranslationGroupBox.Location = new System.Drawing.Point(6, 173);
			this.TranslationGroupBox.Name = "TranslationGroupBox";
			this.TranslationGroupBox.Size = new System.Drawing.Size(656, 175);
			this.TranslationGroupBox.TabIndex = 4;
			this.TranslationGroupBox.TabStop = false;
			this.TranslationGroupBox.Text = "Selected Item";
			// 
			// Namespacelabel
			// 
			this.Namespacelabel.Location = new System.Drawing.Point(6, 16);
			this.Namespacelabel.Name = "Namespacelabel";
			this.Namespacelabel.Size = new System.Drawing.Size(71, 20);
			this.Namespacelabel.TabIndex = 7;
			this.Namespacelabel.Text = "Namespace:";
			// 
			// namespacesComboBox
			// 
			this.namespacesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.namespacesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.namespacesComboBox.FormattingEnabled = true;
			this.namespacesComboBox.Location = new System.Drawing.Point(83, 13);
			this.namespacesComboBox.Name = "namespacesComboBox";
			this.namespacesComboBox.Size = new System.Drawing.Size(233, 21);
			this.namespacesComboBox.TabIndex = 5;
			this.namespacesComboBox.SelectedIndexChanged += new System.EventHandler(this.namespacesComboBoxSelectedIndexChanged);
			// 
			// setItemStateButton
			// 
			this.setItemStateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.setItemStateButton.Image = ((System.Drawing.Image)(resources.GetObject("setItemStateButton.Image")));
			this.setItemStateButton.Location = new System.Drawing.Point(623, 40);
			this.setItemStateButton.Name = "setItemStateButton";
			this.setItemStateButton.Size = new System.Drawing.Size(27, 126);
			this.setItemStateButton.TabIndex = 7;
			this.setItemStateButton.UseVisualStyleBackColor = true;
			this.setItemStateButton.Click += new System.EventHandler(this.setItemStateButtonClick);
			this.setItemStateButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDownOnItems);
			// 
			// sourceTextBox
			// 
			this.sourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.sourceTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.sourceTextBox.Location = new System.Drawing.Point(6, 40);
			this.sourceTextBox.Multiline = true;
			this.sourceTextBox.Name = "sourceTextBox";
			this.sourceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.sourceTextBox.Size = new System.Drawing.Size(610, 126);
			this.sourceTextBox.TabIndex = 6;
			this.sourceTextBox.WordWrap = false;
			this.sourceTextBox.TextChanged += new System.EventHandler(this.sourceTextBoxTextChanged);
			this.sourceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDownOnItems);
			this.sourceTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sourceTextBoxKeyUp);
			// 
			// AutoPastAndSetcheckBox
			// 
			this.AutoPastAndSetcheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.AutoPastAndSetcheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.AutoPastAndSetcheckBox.Checked = true;
			this.AutoPastAndSetcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AutoPastAndSetcheckBox.Location = new System.Drawing.Point(6, 351);
			this.AutoPastAndSetcheckBox.Name = "AutoPastAndSetcheckBox";
			this.AutoPastAndSetcheckBox.Size = new System.Drawing.Size(506, 24);
			this.AutoPastAndSetcheckBox.TabIndex = 8;
			this.AutoPastAndSetcheckBox.Text = "Past text from buffer into SOURCE field, press button SET automatically after pre" +
			"ssing NEW button";
			this.AutoPastAndSetcheckBox.UseVisualStyleBackColor = true;
			this.AutoPastAndSetcheckBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDownOnItems);
			// 
			// Savebutton
			// 
			this.Savebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Savebutton.Location = new System.Drawing.Point(609, 432);
			this.Savebutton.Name = "Savebutton";
			this.Savebutton.Size = new System.Drawing.Size(79, 23);
			this.Savebutton.TabIndex = 9;
			this.Savebutton.Text = "Save";
			this.Savebutton.UseVisualStyleBackColor = true;
			this.Savebutton.Click += new System.EventHandler(this.saveButtonClick);
			this.Savebutton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDownOnItems);
			// 
			// namespacesListBox
			// 
			this.namespacesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.namespacesListBox.ContextMenuStrip = this.namespacesContextMenuStrip;
			this.namespacesListBox.FormattingEnabled = true;
			this.namespacesListBox.Location = new System.Drawing.Point(6, 6);
			this.namespacesListBox.Name = "namespacesListBox";
			this.namespacesListBox.ScrollAlwaysVisible = true;
			this.namespacesListBox.Size = new System.Drawing.Size(557, 368);
			this.namespacesListBox.TabIndex = 0;
			this.namespacesListBox.SelectedIndexChanged += new System.EventHandler(this.namespacesListBoxSelectedIndexChanged);
			this.namespacesListBox.DoubleClick += new System.EventHandler(this.renameNamespace);
			this.namespacesListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.namespacesListBoxMouseDown);
			// 
			// namespacesContextMenuStrip
			// 
			this.namespacesContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.addNamespaceToolStripMenuItem,
									this.renameNamespaceToolStripMenuItem,
									this.removeNamespaceToolStripMenuItem});
			this.namespacesContextMenuStrip.Name = "namespacesContextMenuStrip";
			this.namespacesContextMenuStrip.Size = new System.Drawing.Size(137, 70);
			this.namespacesContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.namespacesContextMenuStripOpening);
			// 
			// addNamespaceToolStripMenuItem
			// 
			this.addNamespaceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNamespaceToolStripMenuItem.Image")));
			this.addNamespaceToolStripMenuItem.Name = "addNamespaceToolStripMenuItem";
			this.addNamespaceToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.addNamespaceToolStripMenuItem.Text = "Add...";
			this.addNamespaceToolStripMenuItem.Click += new System.EventHandler(this.addNamespace);
			// 
			// renameNamespaceToolStripMenuItem
			// 
			this.renameNamespaceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("renameNamespaceToolStripMenuItem.Image")));
			this.renameNamespaceToolStripMenuItem.Name = "renameNamespaceToolStripMenuItem";
			this.renameNamespaceToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.renameNamespaceToolStripMenuItem.Text = "Rename...";
			this.renameNamespaceToolStripMenuItem.Click += new System.EventHandler(this.renameNamespace);
			// 
			// removeNamespaceToolStripMenuItem
			// 
			this.removeNamespaceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeNamespaceToolStripMenuItem.Image")));
			this.removeNamespaceToolStripMenuItem.Name = "removeNamespaceToolStripMenuItem";
			this.removeNamespaceToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.removeNamespaceToolStripMenuItem.Text = "Remove";
			this.removeNamespaceToolStripMenuItem.Click += new System.EventHandler(this.removeNamespace);
			// 
			// removeNamespaceButton
			// 
			this.removeNamespaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.removeNamespaceButton.BackColor = System.Drawing.Color.Transparent;
			this.removeNamespaceButton.Enabled = false;
			this.removeNamespaceButton.Image = ((System.Drawing.Image)(resources.GetObject("removeNamespaceButton.Image")));
			this.removeNamespaceButton.Location = new System.Drawing.Point(569, 78);
			this.removeNamespaceButton.Name = "removeNamespaceButton";
			this.removeNamespaceButton.Size = new System.Drawing.Size(93, 30);
			this.removeNamespaceButton.TabIndex = 3;
			this.removeNamespaceButton.Text = "Remove";
			this.removeNamespaceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.removeNamespaceButton.UseVisualStyleBackColor = false;
			this.removeNamespaceButton.Click += new System.EventHandler(this.removeNamespace);
			// 
			// newNamespaceButton
			// 
			this.newNamespaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.newNamespaceButton.Image = ((System.Drawing.Image)(resources.GetObject("newNamespaceButton.Image")));
			this.newNamespaceButton.Location = new System.Drawing.Point(569, 6);
			this.newNamespaceButton.Name = "newNamespaceButton";
			this.newNamespaceButton.Size = new System.Drawing.Size(93, 30);
			this.newNamespaceButton.TabIndex = 1;
			this.newNamespaceButton.Text = "Add...";
			this.newNamespaceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.newNamespaceButton.UseVisualStyleBackColor = true;
			this.newNamespaceButton.Click += new System.EventHandler(this.addNamespace);
			// 
			// renameNamespaceButton
			// 
			this.renameNamespaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.renameNamespaceButton.Enabled = false;
			this.renameNamespaceButton.Image = ((System.Drawing.Image)(resources.GetObject("renameNamespaceButton.Image")));
			this.renameNamespaceButton.Location = new System.Drawing.Point(569, 42);
			this.renameNamespaceButton.Name = "renameNamespaceButton";
			this.renameNamespaceButton.Size = new System.Drawing.Size(93, 30);
			this.renameNamespaceButton.TabIndex = 2;
			this.renameNamespaceButton.Text = "Rename...";
			this.renameNamespaceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.renameNamespaceButton.UseVisualStyleBackColor = true;
			this.renameNamespaceButton.Click += new System.EventHandler(this.renameNamespace);
			// 
			// WhereTosendlabel
			// 
			this.WhereTosendlabel.Location = new System.Drawing.Point(6, 16);
			this.WhereTosendlabel.Name = "WhereTosendlabel";
			this.WhereTosendlabel.Size = new System.Drawing.Size(62, 18);
			this.WhereTosendlabel.TabIndex = 12;
			this.WhereTosendlabel.Text = "E-mail:";
			// 
			// WhereTosendtextBox
			// 
			this.WhereTosendtextBox.Location = new System.Drawing.Point(74, 13);
			this.WhereTosendtextBox.Name = "WhereTosendtextBox";
			this.WhereTosendtextBox.Size = new System.Drawing.Size(331, 20);
			this.WhereTosendtextBox.TabIndex = 0;
			// 
			// wwwlabel
			// 
			this.wwwlabel.Location = new System.Drawing.Point(6, 42);
			this.wwwlabel.Name = "wwwlabel";
			this.wwwlabel.Size = new System.Drawing.Size(62, 16);
			this.wwwlabel.TabIndex = 14;
			this.wwwlabel.Text = "URL:";
			// 
			// WWWtextBox
			// 
			this.WWWtextBox.Location = new System.Drawing.Point(74, 39);
			this.WWWtextBox.Name = "WWWtextBox";
			this.WWWtextBox.Size = new System.Drawing.Size(331, 20);
			this.WWWtextBox.TabIndex = 1;
			// 
			// MaintabControl
			// 
			this.MaintabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.MaintabControl.Controls.Add(this.ItemstabPage);
			this.MaintabControl.Controls.Add(this.NamespacestabPage);
			this.MaintabControl.Controls.Add(this.OptionstabPage);
			this.MaintabControl.Location = new System.Drawing.Point(12, 12);
			this.MaintabControl.Name = "MaintabControl";
			this.MaintabControl.SelectedIndex = 0;
			this.MaintabControl.Size = new System.Drawing.Size(676, 407);
			this.MaintabControl.TabIndex = 17;
			// 
			// ItemstabPage
			// 
			this.ItemstabPage.Controls.Add(this.searchButton);
			this.ItemstabPage.Controls.Add(this.addNewItemButton);
			this.ItemstabPage.Controls.Add(this.removeItemButton);
			this.ItemstabPage.Controls.Add(this.itemsListView);
			this.ItemstabPage.Controls.Add(this.AutoPastAndSetcheckBox);
			this.ItemstabPage.Controls.Add(this.TranslationGroupBox);
			this.ItemstabPage.Location = new System.Drawing.Point(4, 22);
			this.ItemstabPage.Name = "ItemstabPage";
			this.ItemstabPage.Padding = new System.Windows.Forms.Padding(3);
			this.ItemstabPage.Size = new System.Drawing.Size(668, 381);
			this.ItemstabPage.TabIndex = 0;
			this.ItemstabPage.Text = "Items";
			this.ItemstabPage.UseVisualStyleBackColor = true;
			// 
			// searchButton
			// 
			this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
			this.searchButton.Location = new System.Drawing.Point(569, 42);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(93, 30);
			this.searchButton.TabIndex = 2;
			this.searchButton.Text = "Search";
			this.searchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.search);
			this.searchButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDownOnItems);
			// 
			// addNewItemButton
			// 
			this.addNewItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addNewItemButton.Image = ((System.Drawing.Image)(resources.GetObject("addNewItemButton.Image")));
			this.addNewItemButton.Location = new System.Drawing.Point(569, 6);
			this.addNewItemButton.Name = "addNewItemButton";
			this.addNewItemButton.Size = new System.Drawing.Size(93, 30);
			this.addNewItemButton.TabIndex = 1;
			this.addNewItemButton.Text = "Add...";
			this.addNewItemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.addNewItemButton.UseVisualStyleBackColor = true;
			this.addNewItemButton.Click += new System.EventHandler(this.addNewItem);
			this.addNewItemButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDownOnItems);
			// 
			// removeItemButton
			// 
			this.removeItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.removeItemButton.BackColor = System.Drawing.Color.Transparent;
			this.removeItemButton.Enabled = false;
			this.removeItemButton.Image = ((System.Drawing.Image)(resources.GetObject("removeItemButton.Image")));
			this.removeItemButton.Location = new System.Drawing.Point(569, 78);
			this.removeItemButton.Name = "removeItemButton";
			this.removeItemButton.Size = new System.Drawing.Size(93, 30);
			this.removeItemButton.TabIndex = 3;
			this.removeItemButton.Text = "Remove";
			this.removeItemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.removeItemButton.UseVisualStyleBackColor = false;
			this.removeItemButton.Click += new System.EventHandler(this.removeItem);
			this.removeItemButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDownOnItems);
			// 
			// itemsListView
			// 
			this.itemsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.itemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.imageColumnHeader,
									this.idColumnHeader,
									this.textColumnHeader});
			this.itemsListView.ContextMenuStrip = this.itemsListContextMenuStrip;
			this.itemsListView.FullRowSelect = true;
			this.itemsListView.LargeImageList = this.itemsImagesList;
			this.itemsListView.Location = new System.Drawing.Point(6, 6);
			this.itemsListView.MultiSelect = false;
			this.itemsListView.Name = "itemsListView";
			this.itemsListView.Size = new System.Drawing.Size(560, 161);
			this.itemsListView.SmallImageList = this.itemsImagesList;
			this.itemsListView.TabIndex = 0;
			this.itemsListView.UseCompatibleStateImageBehavior = false;
			this.itemsListView.View = System.Windows.Forms.View.Details;
			this.itemsListView.Resize += new System.EventHandler(this.itemsListViewResize);
			this.itemsListView.SelectedIndexChanged += new System.EventHandler(this.itemsListBoxSelectedIndexChanged);
			this.itemsListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDownOnItems);
			// 
			// imageColumnHeader
			// 
			this.imageColumnHeader.Text = "";
			this.imageColumnHeader.Width = 20;
			// 
			// idColumnHeader
			// 
			this.idColumnHeader.Text = "Id";
			this.idColumnHeader.Width = 40;
			// 
			// textColumnHeader
			// 
			this.textColumnHeader.Text = "Text";
			this.textColumnHeader.Width = 490;
			// 
			// itemsListContextMenuStrip
			// 
			this.itemsListContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.addNewItemToolStripMenuItem,
									this.copySourceItemToolStripMenuItem,
									this.copyItemIdToolStripMenuItem,
									this.toolStripSeparator1,
									this.removeLanguageItemToolStripMenuItem});
			this.itemsListContextMenuStrip.Name = "itemsListContextMenuStrip";
			this.itemsListContextMenuStrip.Size = new System.Drawing.Size(134, 98);
			this.itemsListContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.itemsListContextMenuStripOpening);
			// 
			// addNewItemToolStripMenuItem
			// 
			this.addNewItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewItemToolStripMenuItem.Image")));
			this.addNewItemToolStripMenuItem.Name = "addNewItemToolStripMenuItem";
			this.addNewItemToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.addNewItemToolStripMenuItem.Text = "Add...";
			this.addNewItemToolStripMenuItem.Click += new System.EventHandler(this.addNewItem);
			// 
			// copySourceItemToolStripMenuItem
			// 
			this.copySourceItemToolStripMenuItem.Name = "copySourceItemToolStripMenuItem";
			this.copySourceItemToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.copySourceItemToolStripMenuItem.Text = "Copy text";
			this.copySourceItemToolStripMenuItem.Click += new System.EventHandler(this.copyItemSource);
			// 
			// copyItemIdToolStripMenuItem
			// 
			this.copyItemIdToolStripMenuItem.Name = "copyItemIdToolStripMenuItem";
			this.copyItemIdToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.copyItemIdToolStripMenuItem.Text = "Copy id";
			this.copyItemIdToolStripMenuItem.Click += new System.EventHandler(this.copyItemId);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
			// 
			// removeLanguageItemToolStripMenuItem
			// 
			this.removeLanguageItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeLanguageItemToolStripMenuItem.Image")));
			this.removeLanguageItemToolStripMenuItem.Name = "removeLanguageItemToolStripMenuItem";
			this.removeLanguageItemToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.removeLanguageItemToolStripMenuItem.Text = "Remove";
			this.removeLanguageItemToolStripMenuItem.Click += new System.EventHandler(this.removeItem);
			// 
			// itemsImagesList
			// 
			this.itemsImagesList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("itemsImagesList.ImageStream")));
			this.itemsImagesList.TransparentColor = System.Drawing.Color.Transparent;
			this.itemsImagesList.Images.SetKeyName(0, "Error.ico");
			this.itemsImagesList.Images.SetKeyName(1, "GoodLocalizationItem.ico");
			// 
			// NamespacestabPage
			// 
			this.NamespacestabPage.Controls.Add(this.newNamespaceButton);
			this.NamespacestabPage.Controls.Add(this.namespacesListBox);
			this.NamespacestabPage.Controls.Add(this.removeNamespaceButton);
			this.NamespacestabPage.Controls.Add(this.renameNamespaceButton);
			this.NamespacestabPage.Location = new System.Drawing.Point(4, 22);
			this.NamespacestabPage.Name = "NamespacestabPage";
			this.NamespacestabPage.Padding = new System.Windows.Forms.Padding(3);
			this.NamespacestabPage.Size = new System.Drawing.Size(668, 381);
			this.NamespacestabPage.TabIndex = 1;
			this.NamespacestabPage.Text = "Namespaces";
			this.NamespacestabPage.UseVisualStyleBackColor = true;
			// 
			// OptionstabPage
			// 
			this.OptionstabPage.Controls.Add(this.contactInformationGroupBox);
			this.OptionstabPage.Controls.Add(this.CurrgroupBox);
			this.OptionstabPage.Location = new System.Drawing.Point(4, 22);
			this.OptionstabPage.Name = "OptionstabPage";
			this.OptionstabPage.Size = new System.Drawing.Size(668, 381);
			this.OptionstabPage.TabIndex = 2;
			this.OptionstabPage.Text = "Options";
			this.OptionstabPage.UseVisualStyleBackColor = true;
			// 
			// contactInformationGroupBox
			// 
			this.contactInformationGroupBox.Controls.Add(this.WhereTosendlabel);
			this.contactInformationGroupBox.Controls.Add(this.label2);
			this.contactInformationGroupBox.Controls.Add(this.wwwlabel);
			this.contactInformationGroupBox.Controls.Add(this.label1);
			this.contactInformationGroupBox.Controls.Add(this.WhereTosendtextBox);
			this.contactInformationGroupBox.Controls.Add(this.WWWtextBox);
			this.contactInformationGroupBox.Location = new System.Drawing.Point(15, 11);
			this.contactInformationGroupBox.Name = "contactInformationGroupBox";
			this.contactInformationGroupBox.Size = new System.Drawing.Size(434, 72);
			this.contactInformationGroupBox.TabIndex = 0;
			this.contactInformationGroupBox.TabStop = false;
			this.contactInformationGroupBox.Text = "Contact information for translators";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(410, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 23);
			this.label2.TabIndex = 21;
			this.label2.Text = "*";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(410, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 23);
			this.label1.TabIndex = 20;
			this.label1.Text = "*";
			// 
			// CurrgroupBox
			// 
			this.CurrgroupBox.Controls.Add(this.label4);
			this.CurrgroupBox.Controls.Add(this.label3);
			this.CurrgroupBox.Controls.Add(this.copyrtextBox);
			this.CurrgroupBox.Controls.Add(this.emailtextBox);
			this.CurrgroupBox.Controls.Add(this.natnametextBox);
			this.CurrgroupBox.Controls.Add(this.authtextBox);
			this.CurrgroupBox.Controls.Add(this.copyrlabel);
			this.CurrgroupBox.Controls.Add(this.nlnlabel);
			this.CurrgroupBox.Controls.Add(this.emaillabel);
			this.CurrgroupBox.Controls.Add(this.Authlabel);
			this.CurrgroupBox.Location = new System.Drawing.Point(15, 89);
			this.CurrgroupBox.Name = "CurrgroupBox";
			this.CurrgroupBox.Size = new System.Drawing.Size(434, 132);
			this.CurrgroupBox.TabIndex = 1;
			this.CurrgroupBox.TabStop = false;
			this.CurrgroupBox.Text = "Translation Template contact information";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(411, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 23);
			this.label4.TabIndex = 22;
			this.label4.Text = "*";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(411, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 23);
			this.label3.TabIndex = 21;
			this.label3.Text = "*";
			// 
			// copyrtextBox
			// 
			this.copyrtextBox.Location = new System.Drawing.Point(74, 71);
			this.copyrtextBox.Name = "copyrtextBox";
			this.copyrtextBox.Size = new System.Drawing.Size(331, 20);
			this.copyrtextBox.TabIndex = 2;
			this.copyrtextBox.Text = "(c) 2008 <Author>, <E-mail>";
			// 
			// emailtextBox
			// 
			this.emailtextBox.Location = new System.Drawing.Point(74, 45);
			this.emailtextBox.Name = "emailtextBox";
			this.emailtextBox.Size = new System.Drawing.Size(331, 20);
			this.emailtextBox.TabIndex = 1;
			// 
			// natnametextBox
			// 
			this.natnametextBox.Location = new System.Drawing.Point(74, 97);
			this.natnametextBox.Name = "natnametextBox";
			this.natnametextBox.Size = new System.Drawing.Size(331, 20);
			this.natnametextBox.TabIndex = 3;
			// 
			// authtextBox
			// 
			this.authtextBox.Location = new System.Drawing.Point(74, 19);
			this.authtextBox.Name = "authtextBox";
			this.authtextBox.Size = new System.Drawing.Size(331, 20);
			this.authtextBox.TabIndex = 0;
			// 
			// copyrlabel
			// 
			this.copyrlabel.Location = new System.Drawing.Point(6, 74);
			this.copyrlabel.Name = "copyrlabel";
			this.copyrlabel.Size = new System.Drawing.Size(62, 23);
			this.copyrlabel.TabIndex = 2;
			this.copyrlabel.Text = "Copyright:";
			// 
			// nlnlabel
			// 
			this.nlnlabel.Location = new System.Drawing.Point(6, 97);
			this.nlnlabel.Name = "nlnlabel";
			this.nlnlabel.Size = new System.Drawing.Size(62, 23);
			this.nlnlabel.TabIndex = 18;
			this.nlnlabel.Text = "Language:";
			// 
			// emaillabel
			// 
			this.emaillabel.Location = new System.Drawing.Point(6, 48);
			this.emaillabel.Name = "emaillabel";
			this.emaillabel.Size = new System.Drawing.Size(62, 23);
			this.emaillabel.TabIndex = 1;
			this.emaillabel.Text = "E-mail:";
			// 
			// Authlabel
			// 
			this.Authlabel.Location = new System.Drawing.Point(6, 22);
			this.Authlabel.Name = "Authlabel";
			this.Authlabel.Size = new System.Drawing.Size(62, 23);
			this.Authlabel.TabIndex = 0;
			this.Authlabel.Text = "Author:";
			// 
			// ChangeDefaultLanguage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 467);
			this.Controls.Add(this.MaintabControl);
			this.Controls.Add(this.Savebutton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(706, 494);
			this.Name = "ChangeDefaultLanguage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Translation Template - BULocalization";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.changeDefaultLanguageFormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDownOnItems);
			this.TranslationGroupBox.ResumeLayout(false);
			this.TranslationGroupBox.PerformLayout();
			this.namespacesContextMenuStrip.ResumeLayout(false);
			this.MaintabControl.ResumeLayout(false);
			this.ItemstabPage.ResumeLayout(false);
			this.itemsListContextMenuStrip.ResumeLayout(false);
			this.NamespacestabPage.ResumeLayout(false);
			this.OptionstabPage.ResumeLayout(false);
			this.contactInformationGroupBox.ResumeLayout(false);
			this.contactInformationGroupBox.PerformLayout();
			this.CurrgroupBox.ResumeLayout(false);
			this.CurrgroupBox.PerformLayout();
			this.ResumeLayout(false);
		}
		private const string _DeleteNamespace = "Are you sure you want delete this namespace?";
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ImageList itemsImagesList;
		private System.Windows.Forms.ColumnHeader imageColumnHeader;
		private System.Windows.Forms.Button setItemStateButton;
		private System.Windows.Forms.ToolStripMenuItem copyItemIdToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copySourceItemToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewItemToolStripMenuItem;
		private System.Windows.Forms.Button removeItemButton;
		private System.Windows.Forms.Button addNewItemButton;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox contactInformationGroupBox;
		private System.Windows.Forms.GroupBox TranslationGroupBox;
		private System.Windows.Forms.ToolStripMenuItem removeLanguageItemToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeNamespaceToolStripMenuItem;
		private System.Windows.Forms.Button removeNamespaceButton;
		private System.Windows.Forms.Button newNamespaceButton;
		private System.Windows.Forms.Button renameNamespaceButton;
		private System.Windows.Forms.ToolStripMenuItem renameNamespaceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNamespaceToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip namespacesContextMenuStrip;
		private System.Windows.Forms.ContextMenuStrip itemsListContextMenuStrip;
		private System.Windows.Forms.ColumnHeader textColumnHeader;
		private System.Windows.Forms.ColumnHeader idColumnHeader;
		private System.Windows.Forms.ListView itemsListView;
		private System.Windows.Forms.Label nlnlabel;
		private System.Windows.Forms.TextBox natnametextBox;
		private System.Windows.Forms.Label Authlabel;
		private System.Windows.Forms.Label emaillabel;
		private System.Windows.Forms.Label copyrlabel;
		private System.Windows.Forms.TextBox authtextBox;
		private System.Windows.Forms.TextBox emailtextBox;
		private System.Windows.Forms.TextBox copyrtextBox;
		private System.Windows.Forms.GroupBox CurrgroupBox;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.CheckBox AutoPastAndSetcheckBox;
		private System.Windows.Forms.TabPage OptionstabPage;
		private System.Windows.Forms.TabPage NamespacestabPage;
		private System.Windows.Forms.TabPage ItemstabPage;
		private System.Windows.Forms.TabControl MaintabControl;
		private System.Windows.Forms.TextBox WWWtextBox;
		private System.Windows.Forms.Label wwwlabel;
		private System.Windows.Forms.TextBox WhereTosendtextBox;
		private System.Windows.Forms.Label WhereTosendlabel;
		private System.Windows.Forms.ComboBox namespacesComboBox;
		private System.Windows.Forms.Label Namespacelabel;
		private System.Windows.Forms.ListBox namespacesListBox;
		private System.Windows.Forms.TextBox sourceTextBox;
		private System.Windows.Forms.Button Savebutton;
	}
}
