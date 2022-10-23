using System.Windows.Forms;

namespace BULocalization.TranslationEditor
{
	partial class LocalizationEditorForm
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
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalizationEditorForm));
			this.MainmenuStrip = new System.Windows.Forms.MenuStrip();
			this.translationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.prepareLetterForSendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openTranslationURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.translationModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.reviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.releaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.translategroupBox = new System.Windows.Forms.GroupBox();
			this.translationtextBox = new System.Windows.Forms.TextBox();
			this.sourceTextGroupBox = new System.Windows.Forms.GroupBox();
			this.sourcetextBox = new System.Windows.Forms.TextBox();
			this.itemsdataGridView = new System.Windows.Forms.DataGridView();
			this.tp = new System.Windows.Forms.DataGridViewImageColumn();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Src = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Transl = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.translationStateIimagesList = new System.Windows.Forms.ImageList(this.components);
			this.mainFormSplitContainer = new System.Windows.Forms.SplitContainer();
			this.translationSplitContainer = new System.Windows.Forms.SplitContainer();
			this.mainFormStatusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.MainmenuStrip.SuspendLayout();
			this.translategroupBox.SuspendLayout();
			this.sourceTextGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemsdataGridView)).BeginInit();
			this.mainFormSplitContainer.Panel1.SuspendLayout();
			this.mainFormSplitContainer.Panel2.SuspendLayout();
			this.mainFormSplitContainer.SuspendLayout();
			this.translationSplitContainer.Panel1.SuspendLayout();
			this.translationSplitContainer.Panel2.SuspendLayout();
			this.translationSplitContainer.SuspendLayout();
			this.mainFormStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainmenuStrip
			// 
			this.MainmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.translationToolStripMenuItem,
									this.translationModeToolStripMenuItem,
									this.toolsToolStripMenuItem});
			this.MainmenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MainmenuStrip.Name = "MainmenuStrip";
			this.MainmenuStrip.Size = new System.Drawing.Size(713, 24);
			this.MainmenuStrip.TabIndex = 0;
			this.MainmenuStrip.Text = "menuStrip1";
			// 
			// translationToolStripMenuItem
			// 
			this.translationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.saveToolStripMenuItem,
									this.toolStripSeparator2,
									this.optionsToolStripMenuItem,
									this.prepareLetterForSendingToolStripMenuItem,
									this.openTranslationURLToolStripMenuItem,
									this.toolStripSeparator1,
									this.exitToolStripMenuItem});
			this.translationToolStripMenuItem.Name = "translationToolStripMenuItem";
			this.translationToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.translationToolStripMenuItem.Text = "Translation";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.optionsToolStripMenuItem.Text = "Info";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItemClick);
			// 
			// prepareLetterForSendingToolStripMenuItem
			// 
			this.prepareLetterForSendingToolStripMenuItem.Name = "prepareLetterForSendingToolStripMenuItem";
			this.prepareLetterForSendingToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.prepareLetterForSendingToolStripMenuItem.Text = "Send translation...";
			this.prepareLetterForSendingToolStripMenuItem.Click += new System.EventHandler(this.PrepareLetterForSendingToolStripMenuItemClick);
			// 
			// openTranslationURLToolStripMenuItem
			// 
			this.openTranslationURLToolStripMenuItem.Name = "openTranslationURLToolStripMenuItem";
			this.openTranslationURLToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.openTranslationURLToolStripMenuItem.Text = "Open translation URL";
			this.openTranslationURLToolStripMenuItem.Click += new System.EventHandler(this.OpenTranslationURLToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// translationModeToolStripMenuItem
			// 
			this.translationModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.helpToolStripMenuItem,
									this.toolStripSeparator3,
									this.reviewToolStripMenuItem,
									this.releaseToolStripMenuItem});
			this.translationModeToolStripMenuItem.Name = "translationModeToolStripMenuItem";
			this.translationModeToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.translationModeToolStripMenuItem.Text = "Mode";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.helpToolStripMenuItem.Text = "Help";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItemClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(120, 6);
			// 
			// reviewToolStripMenuItem
			// 
			this.reviewToolStripMenuItem.Name = "reviewToolStripMenuItem";
			this.reviewToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.reviewToolStripMenuItem.Text = "Review";
			this.reviewToolStripMenuItem.Click += new System.EventHandler(this.DebugToolStripMenuItemClick);
			// 
			// releaseToolStripMenuItem
			// 
			this.releaseToolStripMenuItem.Checked = true;
			this.releaseToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.releaseToolStripMenuItem.Name = "releaseToolStripMenuItem";
			this.releaseToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.releaseToolStripMenuItem.Text = "Release";
			this.releaseToolStripMenuItem.Click += new System.EventHandler(this.ReleaseToolStripMenuItemClick);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.searchToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.searchToolStripMenuItem.Text = "Search...";
			this.searchToolStripMenuItem.Click += new System.EventHandler(this.FindReferencesToolStripMenuItemClick);
			// 
			// translategroupBox
			// 
			this.translategroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.translategroupBox.Controls.Add(this.translationtextBox);
			this.translategroupBox.Location = new System.Drawing.Point(3, 3);
			this.translategroupBox.Name = "translategroupBox";
			this.translategroupBox.Size = new System.Drawing.Size(707, 103);
			this.translategroupBox.TabIndex = 3;
			this.translategroupBox.TabStop = false;
			this.translategroupBox.Text = "Translation";
			// 
			// translationtextBox
			// 
			this.translationtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.translationtextBox.Font = new System.Drawing.Font("Courier New", 11.25F);
			this.translationtextBox.Location = new System.Drawing.Point(6, 19);
			this.translationtextBox.Multiline = true;
			this.translationtextBox.Name = "translationtextBox";
			this.translationtextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.translationtextBox.Size = new System.Drawing.Size(695, 78);
			this.translationtextBox.TabIndex = 0;
			this.translationtextBox.WordWrap = false;
			this.translationtextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TranslationtextBoxKeyUp);
			// 
			// sourceTextGroupBox
			// 
			this.sourceTextGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.sourceTextGroupBox.Controls.Add(this.sourcetextBox);
			this.sourceTextGroupBox.Location = new System.Drawing.Point(0, 0);
			this.sourceTextGroupBox.Name = "sourceTextGroupBox";
			this.sourceTextGroupBox.Size = new System.Drawing.Size(710, 96);
			this.sourceTextGroupBox.TabIndex = 4;
			this.sourceTextGroupBox.TabStop = false;
			this.sourceTextGroupBox.Text = "Text to translate";
			// 
			// sourcetextBox
			// 
			this.sourcetextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.sourcetextBox.BackColor = System.Drawing.Color.Khaki;
			this.sourcetextBox.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.sourcetextBox.Location = new System.Drawing.Point(6, 19);
			this.sourcetextBox.Multiline = true;
			this.sourcetextBox.Name = "sourcetextBox";
			this.sourcetextBox.ReadOnly = true;
			this.sourcetextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.sourcetextBox.Size = new System.Drawing.Size(698, 71);
			this.sourcetextBox.TabIndex = 0;
			this.sourcetextBox.WordWrap = false;
			this.sourcetextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SourcetextBoxKeyUp);
			// 
			// itemsdataGridView
			// 
			this.itemsdataGridView.AllowUserToAddRows = false;
			this.itemsdataGridView.AllowUserToDeleteRows = false;
			this.itemsdataGridView.AllowUserToResizeRows = false;
			this.itemsdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.itemsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.itemsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.tp,
									this.ID,
									this.Src,
									this.Transl});
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.itemsdataGridView.DefaultCellStyle = dataGridViewCellStyle1;
			this.itemsdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.itemsdataGridView.GridColor = System.Drawing.Color.Red;
			this.itemsdataGridView.Location = new System.Drawing.Point(0, 0);
			this.itemsdataGridView.MultiSelect = false;
			this.itemsdataGridView.Name = "itemsdataGridView";
			this.itemsdataGridView.RowHeadersVisible = false;
			this.itemsdataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.itemsdataGridView.RowTemplate.Height = 32;
			this.itemsdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.itemsdataGridView.ShowCellErrors = false;
			this.itemsdataGridView.ShowCellToolTips = false;
			this.itemsdataGridView.ShowEditingIcon = false;
			this.itemsdataGridView.ShowRowErrors = false;
			this.itemsdataGridView.Size = new System.Drawing.Size(713, 253);
			this.itemsdataGridView.TabIndex = 6;
			this.itemsdataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsdataGridViewRowEnter);
			this.itemsdataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemsdataGridViewKeyDown);
			// 
			// tp
			// 
			this.tp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.tp.HeaderText = "";
			this.tp.Name = "tp";
			this.tp.ReadOnly = true;
			this.tp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.tp.Width = 32;
			// 
			// ID
			// 
			this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.ID.HeaderText = "ID";
			this.ID.MaxInputLength = 10;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ID.Width = 50;
			// 
			// Src
			// 
			this.Src.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Src.HeaderText = "Source";
			this.Src.Name = "Src";
			this.Src.ReadOnly = true;
			this.Src.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Transl
			// 
			this.Transl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Transl.HeaderText = "Translation";
			this.Transl.Name = "Transl";
			this.Transl.ReadOnly = true;
			this.Transl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// translationStateIimagesList
			// 
			this.translationStateIimagesList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("translationStateIimagesList.ImageStream")));
			this.translationStateIimagesList.TransparentColor = System.Drawing.Color.White;
			this.translationStateIimagesList.Images.SetKeyName(0, "OkState.PNG");
			this.translationStateIimagesList.Images.SetKeyName(1, "ModifiedState.PNG");
			this.translationStateIimagesList.Images.SetKeyName(2, "ErrorState.PNG");
			// 
			// mainFormSplitContainer
			// 
			this.mainFormSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.mainFormSplitContainer.Location = new System.Drawing.Point(0, 27);
			this.mainFormSplitContainer.Name = "mainFormSplitContainer";
			this.mainFormSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// mainFormSplitContainer.Panel1
			// 
			this.mainFormSplitContainer.Panel1.Controls.Add(this.itemsdataGridView);
			// 
			// mainFormSplitContainer.Panel2
			// 
			this.mainFormSplitContainer.Panel2.Controls.Add(this.translationSplitContainer);
			this.mainFormSplitContainer.Size = new System.Drawing.Size(713, 470);
			this.mainFormSplitContainer.SplitterDistance = 253;
			this.mainFormSplitContainer.TabIndex = 7;
			// 
			// translationSplitContainer
			// 
			this.translationSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.translationSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.translationSplitContainer.Name = "translationSplitContainer";
			this.translationSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// translationSplitContainer.Panel1
			// 
			this.translationSplitContainer.Panel1.Controls.Add(this.sourceTextGroupBox);
			// 
			// translationSplitContainer.Panel2
			// 
			this.translationSplitContainer.Panel2.Controls.Add(this.translategroupBox);
			this.translationSplitContainer.Size = new System.Drawing.Size(713, 213);
			this.translationSplitContainer.SplitterDistance = 103;
			this.translationSplitContainer.TabIndex = 0;
			// 
			// mainFormStatusStrip
			// 
			this.mainFormStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel});
			this.mainFormStatusStrip.Location = new System.Drawing.Point(0, 500);
			this.mainFormStatusStrip.Name = "mainFormStatusStrip";
			this.mainFormStatusStrip.Size = new System.Drawing.Size(713, 22);
			this.mainFormStatusStrip.TabIndex = 8;
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(332, 17);
			this.toolStripStatusLabel.Text = "For moving through records you can use Shift + Up or Shift + Down";
			// 
			// LocalizationEditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(713, 522);
			this.Controls.Add(this.mainFormStatusStrip);
			this.Controls.Add(this.mainFormSplitContainer);
			this.Controls.Add(this.MainmenuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MainmenuStrip;
			this.Name = "LocalizationEditorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BUTranslate";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.MainmenuStrip.ResumeLayout(false);
			this.MainmenuStrip.PerformLayout();
			this.translategroupBox.ResumeLayout(false);
			this.translategroupBox.PerformLayout();
			this.sourceTextGroupBox.ResumeLayout(false);
			this.sourceTextGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemsdataGridView)).EndInit();
			this.mainFormSplitContainer.Panel1.ResumeLayout(false);
			this.mainFormSplitContainer.Panel2.ResumeLayout(false);
			this.mainFormSplitContainer.ResumeLayout(false);
			this.translationSplitContainer.Panel1.ResumeLayout(false);
			this.translationSplitContainer.Panel2.ResumeLayout(false);
			this.translationSplitContainer.ResumeLayout(false);
			this.mainFormStatusStrip.ResumeLayout(false);
			this.mainFormStatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.StatusStrip mainFormStatusStrip;
		private System.Windows.Forms.SplitContainer mainFormSplitContainer;
		private System.Windows.Forms.SplitContainer translationSplitContainer;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ImageList translationStateIimagesList;
		private System.Windows.Forms.DataGridViewTextBoxColumn Transl;
		private System.Windows.Forms.DataGridViewTextBoxColumn Src;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewImageColumn tp;
		private System.Windows.Forms.DataGridView itemsdataGridView;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openTranslationURLToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem releaseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reviewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem translationModeToolStripMenuItem;
		private System.Windows.Forms.MenuStrip MainmenuStrip;
		private System.Windows.Forms.ToolStripMenuItem prepareLetterForSendingToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.TextBox sourcetextBox;
		private System.Windows.Forms.GroupBox sourceTextGroupBox;
		private System.Windows.Forms.TextBox translationtextBox;
		private System.Windows.Forms.GroupBox translategroupBox;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem translationToolStripMenuItem;
	}
}
