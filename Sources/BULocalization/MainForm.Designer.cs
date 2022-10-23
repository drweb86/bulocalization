namespace BULocalization
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.localeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.recentProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateTranslationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.askTranslatorsToUpgradeTheirTranslationsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.supportRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.featureRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openWeblinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MaintoolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this._TranslationManagmentInIconsToolStrip = new System.Windows.Forms.ToolStrip();
			this.UpdateSimpleLanguagetoolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.UpgradetoolStripButton = new System.Windows.Forms.ToolStripButton();
			this.LetterSendtoolStripButton = new System.Windows.Forms.ToolStripButton();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.copyEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.languageItemsListView = new System.Windows.Forms.ListView();
			this.nameColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.specificNameColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.authorColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.supportedColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.imagesList = new System.Windows.Forms.ImageList(this.components);
			this.writeEmailToTranslatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.MaintoolStripContainer.TopToolStripPanel.SuspendLayout();
			this.MaintoolStripContainer.SuspendLayout();
			this._TranslationManagmentInIconsToolStrip.SuspendLayout();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.localeFileToolStripMenuItem,
									this.optionsToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(724, 24);
			this.menuStrip.TabIndex = 1;
			this.menuStrip.Text = "menuStrip1";
			// 
			// localeFileToolStripMenuItem
			// 
			this.localeFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.createNewToolStripMenuItem,
									this.loadToolStripMenuItem,
									this.closeProjectToolStripMenuItem,
									this.toolStripSeparator1,
									this.recentProjectsToolStripMenuItem,
									this.toolStripSeparator7,
									this.exitToolStripMenuItem});
			this.localeFileToolStripMenuItem.Name = "localeFileToolStripMenuItem";
			this.localeFileToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
			this.localeFileToolStripMenuItem.Text = "Localization Project";
			// 
			// createNewToolStripMenuItem
			// 
			this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
			this.createNewToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.createNewToolStripMenuItem.Text = "Create new...";
			this.createNewToolStripMenuItem.Click += new System.EventHandler(this.CreateNewToolStripMenuItemClick);
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.loadToolStripMenuItem.Text = "Open...";
			this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadLangdataGridViewoolStripMenuItemClick);
			// 
			// closeProjectToolStripMenuItem
			// 
			this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
			this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.closeProjectToolStripMenuItem.Text = "Close";
			this.closeProjectToolStripMenuItem.Click += new System.EventHandler(this.CloseProjectToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
			// 
			// recentProjectsToolStripMenuItem
			// 
			this.recentProjectsToolStripMenuItem.Name = "recentProjectsToolStripMenuItem";
			this.recentProjectsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.recentProjectsToolStripMenuItem.Text = "Recent projects";
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(160, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.updateTranslationsToolStripMenuItem,
									this.askTranslatorsToUpgradeTheirTranslationsToolStripMenuItem1,
									this.toolStripSeparator4,
									this.emailToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.optionsToolStripMenuItem.Text = "Tools";
			// 
			// updateTranslationsToolStripMenuItem
			// 
			this.updateTranslationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateTranslationsToolStripMenuItem.Image")));
			this.updateTranslationsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
			this.updateTranslationsToolStripMenuItem.Name = "updateTranslationsToolStripMenuItem";
			this.updateTranslationsToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
			this.updateTranslationsToolStripMenuItem.Text = "Update translations";
			this.updateTranslationsToolStripMenuItem.Click += new System.EventHandler(this.UpdateAllTranslationsToolStripMenuItemClick);
			// 
			// askTranslatorsToUpgradeTheirTranslationsToolStripMenuItem1
			// 
			this.askTranslatorsToUpgradeTheirTranslationsToolStripMenuItem1.Name = "askTranslatorsToUpgradeTheirTranslationsToolStripMenuItem1";
			this.askTranslatorsToUpgradeTheirTranslationsToolStripMenuItem1.Size = new System.Drawing.Size(297, 22);
			this.askTranslatorsToUpgradeTheirTranslationsToolStripMenuItem1.Text = "Ask translators to upgrade their translations";
			this.askTranslatorsToUpgradeTheirTranslationsToolStripMenuItem1.Click += new System.EventHandler(this.AskTranslatorsToUpgradeTheirTranslationsToolStripMenuItemClick);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(294, 6);
			// 
			// emailToolStripMenuItem
			// 
			this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
			this.emailToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
			this.emailToolStripMenuItem.Text = "Settings...";
			this.emailToolStripMenuItem.Click += new System.EventHandler(this.EmailToolStripMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.documentationToolStripMenuItem,
									this.toolStripSeparator6,
									this.supportRequestToolStripMenuItem,
									this.featureRequestToolStripMenuItem,
									this.reportABugToolStripMenuItem,
									this.openWeblinkToolStripMenuItem,
									this.toolStripSeparator3,
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.helpToolStripMenuItem.Text = "About";
			// 
			// documentationToolStripMenuItem
			// 
			this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
			this.documentationToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.documentationToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.documentationToolStripMenuItem.Text = "Documentation";
			this.documentationToolStripMenuItem.Click += new System.EventHandler(this.DocumentationToolStripMenuItemClick);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(173, 6);
			// 
			// supportRequestToolStripMenuItem
			// 
			this.supportRequestToolStripMenuItem.Name = "supportRequestToolStripMenuItem";
			this.supportRequestToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.supportRequestToolStripMenuItem.Text = "Support request";
			this.supportRequestToolStripMenuItem.Click += new System.EventHandler(this.SupportRequestToolStripMenuItemClick);
			// 
			// featureRequestToolStripMenuItem
			// 
			this.featureRequestToolStripMenuItem.Name = "featureRequestToolStripMenuItem";
			this.featureRequestToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.featureRequestToolStripMenuItem.Text = "Feature request";
			this.featureRequestToolStripMenuItem.Click += new System.EventHandler(this.FeatureRequestToolStripMenuItemClick);
			// 
			// reportABugToolStripMenuItem
			// 
			this.reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
			this.reportABugToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.reportABugToolStripMenuItem.Text = "Report a bug";
			this.reportABugToolStripMenuItem.Click += new System.EventHandler(this.ReportABugToolStripMenuItemClick);
			// 
			// openWeblinkToolStripMenuItem
			// 
			this.openWeblinkToolStripMenuItem.Name = "openWeblinkToolStripMenuItem";
			this.openWeblinkToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.openWeblinkToolStripMenuItem.Text = "Visit homepage";
			this.openWeblinkToolStripMenuItem.Click += new System.EventHandler(this.OpenWeblinkToolStripMenuItemClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(173, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripMenuItem.Image")));
			this.addToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.addToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.addToolStripMenuItem.Text = "Add...";
			this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItemClick);
			// 
			// modifyToolStripMenuItem
			// 
			this.modifyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modifyToolStripMenuItem.Image")));
			this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
			this.modifyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.modifyToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.modifyToolStripMenuItem.Text = "Rename...";
			this.modifyToolStripMenuItem.Click += new System.EventHandler(this.ModifyToolStripMenuItemClick);
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeToolStripMenuItem.Image")));
			this.removeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.removeToolStripMenuItem.Text = "Remove";
			this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItemClick);
			// 
			// MaintoolStripContainer
			// 
			this.MaintoolStripContainer.BottomToolStripPanelVisible = false;
			// 
			// MaintoolStripContainer.ContentPanel
			// 
			this.MaintoolStripContainer.ContentPanel.Size = new System.Drawing.Size(724, 5);
			this.MaintoolStripContainer.Dock = System.Windows.Forms.DockStyle.Top;
			this.MaintoolStripContainer.LeftToolStripPanelVisible = false;
			this.MaintoolStripContainer.Location = new System.Drawing.Point(0, 24);
			this.MaintoolStripContainer.Margin = new System.Windows.Forms.Padding(0);
			this.MaintoolStripContainer.Name = "MaintoolStripContainer";
			this.MaintoolStripContainer.RightToolStripPanelVisible = false;
			this.MaintoolStripContainer.Size = new System.Drawing.Size(724, 58);
			this.MaintoolStripContainer.TabIndex = 12;
			this.MaintoolStripContainer.Text = "toolStripContainer1";
			// 
			// MaintoolStripContainer.TopToolStripPanel
			// 
			this.MaintoolStripContainer.TopToolStripPanel.Controls.Add(this._TranslationManagmentInIconsToolStrip);
			this.MaintoolStripContainer.TopToolStripPanel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.MaintoolStripContainer.TopToolStripPanel.MaximumSize = new System.Drawing.Size(0, 55);
			this.MaintoolStripContainer.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			// 
			// _TranslationManagmentInIconsToolStrip
			// 
			this._TranslationManagmentInIconsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this._TranslationManagmentInIconsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.UpdateSimpleLanguagetoolStripButton1,
									this.UpgradetoolStripButton,
									this.LetterSendtoolStripButton});
			this._TranslationManagmentInIconsToolStrip.Location = new System.Drawing.Point(3, 0);
			this._TranslationManagmentInIconsToolStrip.Name = "_TranslationManagmentInIconsToolStrip";
			this._TranslationManagmentInIconsToolStrip.Size = new System.Drawing.Size(212, 53);
			this._TranslationManagmentInIconsToolStrip.TabIndex = 11;
			this._TranslationManagmentInIconsToolStrip.Text = "Translation tools";
			// 
			// UpdateSimpleLanguagetoolStripButton1
			// 
			this.UpdateSimpleLanguagetoolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.UpdateSimpleLanguagetoolStripButton1.Enabled = false;
			this.UpdateSimpleLanguagetoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("UpdateSimpleLanguagetoolStripButton1.Image")));
			this.UpdateSimpleLanguagetoolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.UpdateSimpleLanguagetoolStripButton1.ImageTransparentColor = System.Drawing.Color.White;
			this.UpdateSimpleLanguagetoolStripButton1.Name = "UpdateSimpleLanguagetoolStripButton1";
			this.UpdateSimpleLanguagetoolStripButton1.Size = new System.Drawing.Size(53, 50);
			this.UpdateSimpleLanguagetoolStripButton1.Text = "Update selected item";
			this.UpdateSimpleLanguagetoolStripButton1.Click += new System.EventHandler(this.UpdateSimpleLanguagetoolStripButton1Click);
			// 
			// UpgradetoolStripButton
			// 
			this.UpgradetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.UpgradetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UpgradetoolStripButton.Image")));
			this.UpgradetoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.UpgradetoolStripButton.ImageTransparentColor = System.Drawing.Color.White;
			this.UpgradetoolStripButton.Name = "UpgradetoolStripButton";
			this.UpgradetoolStripButton.Size = new System.Drawing.Size(53, 50);
			this.UpgradetoolStripButton.Text = "Upgrade all translations on \"default\" translation base";
			this.UpgradetoolStripButton.Click += new System.EventHandler(this.UpgradetoolStripButtonClick);
			// 
			// LetterSendtoolStripButton
			// 
			this.LetterSendtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.LetterSendtoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("LetterSendtoolStripButton.Image")));
			this.LetterSendtoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.LetterSendtoolStripButton.ImageTransparentColor = System.Drawing.Color.White;
			this.LetterSendtoolStripButton.Name = "LetterSendtoolStripButton";
			this.LetterSendtoolStripButton.Size = new System.Drawing.Size(94, 50);
			this.LetterSendtoolStripButton.Text = "Send letters to translators: ask them to upgrade their translations";
			this.LetterSendtoolStripButton.Click += new System.EventHandler(this.LetterSendtoolStripButtonClick);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.addToolStripMenuItem,
									this.modifyToolStripMenuItem,
									this.removeToolStripMenuItem,
									this.toolStripSeparator2,
									this.copyEmailToolStripMenuItem,
									this.writeEmailToTranslatorToolStripMenuItem,
									this.updateToolStripMenuItem});
			this.contextMenuStrip.Name = "_contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(206, 164);
			this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripOpening);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
			// 
			// copyEmailToolStripMenuItem
			// 
			this.copyEmailToolStripMenuItem.Name = "copyEmailToolStripMenuItem";
			this.copyEmailToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.copyEmailToolStripMenuItem.Text = "Copy e-mail";
			this.copyEmailToolStripMenuItem.Click += new System.EventHandler(this.copyEmailToolStripMenuItemClick);
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.updateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateToolStripMenuItem.Image")));
			this.updateToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.updateToolStripMenuItem.Text = "Update...";
			this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItemClick);
			// 
			// languageItemsListView
			// 
			this.languageItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.nameColumnHeader,
									this.specificNameColumnHeader,
									this.authorColumnHeader,
									this.supportedColumnHeader});
			this.languageItemsListView.ContextMenuStrip = this.contextMenuStrip;
			this.languageItemsListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.languageItemsListView.FullRowSelect = true;
			this.languageItemsListView.LargeImageList = this.imagesList;
			this.languageItemsListView.Location = new System.Drawing.Point(0, 82);
			this.languageItemsListView.MultiSelect = false;
			this.languageItemsListView.Name = "languageItemsListView";
			this.languageItemsListView.Size = new System.Drawing.Size(724, 257);
			this.languageItemsListView.SmallImageList = this.imagesList;
			this.languageItemsListView.StateImageList = this.imagesList;
			this.languageItemsListView.TabIndex = 14;
			this.languageItemsListView.UseCompatibleStateImageBehavior = false;
			this.languageItemsListView.View = System.Windows.Forms.View.Details;
			this.languageItemsListView.SelectedIndexChanged += new System.EventHandler(this.languageItemsListViewSelectedIndexChanged);
			this.languageItemsListView.DoubleClick += new System.EventHandler(this.languageItemsListViewDoubleClick);
			// 
			// nameColumnHeader
			// 
			this.nameColumnHeader.Text = "Name";
			this.nameColumnHeader.Width = 200;
			// 
			// specificNameColumnHeader
			// 
			this.specificNameColumnHeader.Text = "Specific name";
			this.specificNameColumnHeader.Width = 200;
			// 
			// authorColumnHeader
			// 
			this.authorColumnHeader.Text = "Author";
			this.authorColumnHeader.Width = 200;
			// 
			// supportedColumnHeader
			// 
			this.supportedColumnHeader.Text = "Is supported";
			this.supportedColumnHeader.Width = 100;
			// 
			// imagesList
			// 
			this.imagesList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagesList.ImageStream")));
			this.imagesList.TransparentColor = System.Drawing.Color.White;
			this.imagesList.Images.SetKeyName(0, "Language.PNG");
			// 
			// writeEmailToTranslatorToolStripMenuItem
			// 
			this.writeEmailToTranslatorToolStripMenuItem.Name = "writeEmailToTranslatorToolStripMenuItem";
			this.writeEmailToTranslatorToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.writeEmailToTranslatorToolStripMenuItem.Text = "Write e-mail to translator";
			this.writeEmailToTranslatorToolStripMenuItem.Click += new System.EventHandler(this.WriteEmailToTranslatorToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(724, 339);
			this.Controls.Add(this.languageItemsListView);
			this.Controls.Add(this.MaintoolStripContainer);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.MinimumSize = new System.Drawing.Size(732, 373);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BULocalization";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.MaintoolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.MaintoolStripContainer.TopToolStripPanel.PerformLayout();
			this.MaintoolStripContainer.ResumeLayout(false);
			this.MaintoolStripContainer.PerformLayout();
			this._TranslationManagmentInIconsToolStrip.ResumeLayout(false);
			this._TranslationManagmentInIconsToolStrip.PerformLayout();
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
	}
		private System.Windows.Forms.ToolStripMenuItem writeEmailToTranslatorToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem askTranslatorsToUpgradeTheirTranslationsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem updateTranslationsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ImageList imagesList;
		private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyEmailToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripMenuItem recentProjectsToolStripMenuItem;
		private System.Windows.Forms.ListView languageItemsListView;
		private System.Windows.Forms.ColumnHeader supportedColumnHeader;
		private System.Windows.Forms.ColumnHeader authorColumnHeader;
		private System.Windows.Forms.ColumnHeader specificNameColumnHeader;
		private System.Windows.Forms.ColumnHeader nameColumnHeader;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem localeFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openWeblinkToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem supportRequestToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem featureRequestToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportABugToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripButton UpgradetoolStripButton;
		private System.Windows.Forms.ToolStripButton LetterSendtoolStripButton;
		private System.Windows.Forms.ToolStripContainer MaintoolStripContainer;
		private System.Windows.Forms.ToolStripButton UpdateSimpleLanguagetoolStripButton1;
		private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem;
		private System.Windows.Forms.ToolStrip _TranslationManagmentInIconsToolStrip;
	}
}
