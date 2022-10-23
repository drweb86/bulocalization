using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Reflection;

using BULocalization.Core;

namespace BULocalization
{
	public partial class MainForm : Form
	{
		private const string _AreYouSure = "Do you want to send e-mails?";
		private const string _DeleteLocalization = "Are you sure you want delete localization?\n\nFile: {0}\nLocalization on: {1}?";
		private const string _NoSuchFile = "File with translation does not exists";
		private const string _CaptionFormatString = "{0} - BULocalization";
		private const string _DefaultCaption = "BULocalization";
		
		private static AppController _controller;
		
		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			_controller = new AppController();
			Application.Run(new MainForm());
		}
		
		private void refreshCaption()
		{
			if (string.IsNullOrEmpty(_controller.ProjectDir))
			{
				Text = _DefaultCaption;
			}
			else
			{
				Text = string.Format(_CaptionFormatString, _controller.ProjectDir);
			}
		}
		
		private void projectOpenedUiChange(bool opened)
		{
			languageItemsListView.Items.Clear();
			
			if (!opened)
			{
				_controller.CloseProject();
			}
			else
			{
				BULanguages languages = _controller.Languages;
				
				foreach (LanguageInfo item in languages.languages)
				{
					string[] row = new string[] 
					{ 
						item.Name, 
						item.SpecificName, 
						item.Author, 
						item.IsSupported ? "Yes" : "No"
					};
					
					ListViewItem newItem = new ListViewItem(row);
					newItem.ImageIndex = 0;
					newItem.Tag = item;
					languageItemsListView.Items.Add(newItem);
				}
			}
			
			refreshCaption();
			
			closeProjectToolStripMenuItem.Enabled = opened;
			_TranslationManagmentInIconsToolStrip.Enabled = opened;
			contextMenuStrip.Enabled = opened;
			askTranslatorsToUpgradeTheirTranslationsToolStripMenuItem1.Enabled = opened;
			updateTranslationsToolStripMenuItem.Enabled = opened;
		}
		
		public MainForm()
		{
			InitializeComponent();
			
			projectOpenedUiChange(false);

			reinitLastUsedFilesMenu();
		}
		
		private void reinitLastUsedFilesMenu()
		{
			string[] data = Settings.GetLastOpenedProjects();
			recentProjectsToolStripMenuItem.DropDownItems.Clear();
			foreach (string itemText in data)
			{
				if (!string.IsNullOrEmpty(itemText))
				{
					ToolStripMenuItem item = new ToolStripMenuItem(itemText);
					item.Click += recentFileSelected;
					recentProjectsToolStripMenuItem.DropDownItems.Insert(0, item);
				}
			}
		}
		
		private void recentFileSelected(object sender, EventArgs e)
		{
			ToolStripMenuItem item = sender as ToolStripMenuItem;
			if (!string.IsNullOrEmpty(item.Text))
				openProject(item.Text);
		}
		
		private void addNewLanguage()
		{
			if (_controller.AddNewLanguage())
				openProject(_controller.ProjectDir);
		}
		
		private void deleteItem()
		{
			int index = getSelectedItemIndex();
			if (index > -1)
			{
				LanguageInfo info = (LanguageInfo)languageItemsListView.Items[index].Tag;
				if (AppController.AskSomething(
					string.Format(CultureInfo.CurrentCulture,_DeleteLocalization, 
					              info.File,
					              info.Name)))
				{
					languageItemsListView.Items.RemoveAt(index);
					_controller.DeleteItem(info);
				}
			}
		}
		
		private void modifyLanguage()
		{
			int index = getSelectedItemIndex();
			
			if (index > -1) 
			{
				if (_controller.ModifyLanguage(index))
					openProject(_controller.ProjectDir);
			}
		}
		
		private void AdLangdataGridViewoolStripMenuItemClick(object sender, EventArgs e)
		{
			addNewLanguage();
		}
		
		
		private void ModifyToolStripMenuItemClick(object sender, EventArgs e)
		{
			modifyLanguage();
		}
		
		private void ModifyLanguagebuttonClick(object sender, EventArgs e)
		{
			modifyLanguage();
		}
		
		private void RemoveToolStripMenuItemClick(object sender, EventArgs e)
		{
			deleteItem();
		}
		
		private void openProject(string projectFolder)
		{
			if (!string.IsNullOrEmpty(projectFolder))
			{
				projectOpenedUiChange(false);
				if (_controller.OpenProject(projectFolder))
				{
					projectOpenedUiChange(true);
					reinitLastUsedFilesMenu();
				}
			}
		}

		private void LoadLangdataGridViewoolStripMenuItemClick(object sender, EventArgs e)
		{
			using (OpenFolderForm form = new OpenFolderForm())
			{
				if (form.ShowDialog() == DialogResult.OK)
				{ 
					openProject(form.SelectedPath);
				}
			}
		}
		
		private void changeDefaultTranslationHelper()
		{
			this.Hide();
			
			_controller.UpdateTemplateTranslation();
			openProject(_controller.ProjectDir);
			
			this.Show();
		}
		
		private void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			AssemblyName assemblyName = Assembly.GetExecutingAssembly().GetName();
			DialogsUtil.ShowAboutProgramMessage(assemblyName.Name, assemblyName.Version.ToString());
		}
		
		private void UpdateAllTranslationsToolStripMenuItemClick(object sender, EventArgs e)
		{
			_controller.UpgradeAllTranslations();
		}
		
		private void modifySelectedLanguage()
		{
			int index = getSelectedItemIndex();
			if (index > -1) 
			{
				LanguageInfo tempLanguageInfo = new LanguageInfo();
				tempLanguageInfo.Name = "default";

				if (((LanguageInfo)languageItemsListView.Items[index].Tag).Name == "default")
				{
					changeDefaultTranslationHelper();
				}
				else
				{
					string file = _controller.Languages.GetLanguage(index).File;
			
					if (!File.Exists(file))
					{
						DialogsUtil.ShowErrorMessage(_NoSuchFile);
					}
					else
					{
						this.Hide();
						AppController.OpenLocalizationEditor(file);
						openProject(_controller.ProjectDir);
						this.Show();
					}
				}
			}
		}
		
		void CurrentTranslationToolStripMenuItemClick(object sender, EventArgs e)
		{
			modifySelectedLanguage();
		}
		
		private int getSelectedItemIndex()
		{
			if (languageItemsListView.SelectedItems.Count > 0)
			{
				return languageItemsListView.Items.IndexOf(languageItemsListView.SelectedItems[0]);
			}
			else
				return -1;
		}
		
		void LanguageslistBoxClick(object sender, EventArgs e)
		{
			int index = getSelectedItemIndex();
			if (index > -1)
			{
				if ((string)languageItemsListView.Items[index].SubItems[0].Text != "default")
					modifySelectedLanguage();
				else 
					changeDefaultTranslationHelper();
			}
		}
		
		void EmailToolStripMenuItemClick(object sender, EventArgs e)
		{
			_controller.ConfigureSettings(false);
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void OpenWeblinkToolStripMenuItemClick(object sender, EventArgs e)
		{
			SupportManager.Open(ProgramUrls.Homepage);
		}
		
		void SupportRequestToolStripMenuItemClick(object sender, EventArgs e)
		{
			SupportManager.Open(ProgramUrls.Support);
		}
		
		void FeatureRequestToolStripMenuItemClick(object sender, EventArgs e)
		{
			SupportManager.Open(ProgramUrls.NewFeature);
		}
		
		void ReportABugToolStripMenuItemClick(object sender, EventArgs e)
		{
			SupportManager.Open(ProgramUrls.Bug);
		}
		
		void UpgradetoolStripButtonClick(object sender, EventArgs e)
		{
			_controller.UpgradeAllTranslations();
		}
		
		private void sendLetters()
		{
			if (languageItemsListView.Items.Count > 1)
			{
				_controller.UpgradeAllTranslations();
				
				if (AppController.AskSomething(_AreYouSure))
				{
					_controller.SendLettersWithRequestToUpgradeTranslations();
				}
			}
		}
		
		void LetterSenLangdataGridViewoolStripButtonClick(object sender, EventArgs e)
		{
			sendLetters();
		}
		
		void AddNewtoolStripButtonClick(object sender, EventArgs e)
		{
			addNewLanguage();
		}
		
		void DeltoolStripButtonClick(object sender, EventArgs e)
		{
			deleteItem();
		}
		
		void ModifytoolStripButtonClick(object sender, EventArgs e)
		{
			modifyLanguage();
		}
		
		void UpdateSimpleLanguagetoolStripButton1Click(object sender, EventArgs e)
		{
			modifySelectedLanguage();
		}
		
		void LangdataGridViewCellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			modifySelectedLanguage();
		}
		
		void LetterSendtoolStripButtonClick(object sender, EventArgs e)
		{
			sendLetters();
		}
				
		void AddToolStripMenuItemClick(object sender, EventArgs e)
		{
			addNewLanguage();
		}
		
		void AskTranslatorsToUpgradeTheirTranslationsToolStripMenuItemClick(object sender, EventArgs e)
		{
			sendLetters();
		}
		
		void DocumentationToolStripMenuItemClick(object sender, EventArgs e)
		{
			SupportManager.OpenHelp();
		}
		
		void CloseProjectToolStripMenuItemClick(object sender, EventArgs e)
		{
			projectOpenedUiChange(false);
			_controller.CloseProject();
		}
		
		void CreateNewToolStripMenuItemClick(object sender, EventArgs e)
		{
			projectOpenedUiChange(false);
			_controller.CloseProject();
			
			using (OpenFolderForm form = new OpenFolderForm())
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					if (_controller.CreateNewProject(form.SelectedPath))
					{
						projectOpenedUiChange(true);
					}
				}
			}
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			_controller.SaveSettings();
		}
		
		private void contextMenuStripOpening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			bool enable = (getSelectedItemIndex() > -1);
			modifyToolStripMenuItem.Enabled = enable;
			copyEmailToolStripMenuItem.Enabled = enable;
			updateToolStripMenuItem.Enabled = enable;
			writeEmailToTranslatorToolStripMenuItem.Enabled = enable;
			if (enable)
			{
				bool isDefaultLanguage = ((LanguageInfo)languageItemsListView.SelectedItems[0].Tag).Name == "default";
				modifyToolStripMenuItem.Enabled = !isDefaultLanguage;
				removeToolStripMenuItem.Enabled = !isDefaultLanguage;
			}
			else
			{
				modifyToolStripMenuItem.Enabled = false;
				removeToolStripMenuItem.Enabled = false;
			}
		}

		private void languageItemsListViewDoubleClick(object sender, EventArgs e)
		{
			modifySelectedLanguage();
		}

		private void copyEmailToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (languageItemsListView.SelectedItems.Count > 0)
			{
				LanguageInfo selectedLanguage = (LanguageInfo)languageItemsListView.SelectedItems[0].Tag;
				
				try
				{
					Clipboard.SetDataObject(selectedLanguage.AuthorEmail);
				}
				catch (System.Runtime.InteropServices.ExternalException) { ; }
			}
		}
		
		private void updateToolStripMenuItemClick(object sender, EventArgs e)
		{
			modifySelectedLanguage();
		}
		
		private void languageItemsListViewSelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateSimpleLanguagetoolStripButton1.Enabled = languageItemsListView.SelectedItems.Count > 0;
		}
		
		private void WriteEmailToTranslatorToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (languageItemsListView.SelectedItems.Count > 0)
			{
				LanguageInfo selectedLanguage = (LanguageInfo)languageItemsListView.SelectedItems[0].Tag;
				SupportManager.WriteEmail(selectedLanguage.AuthorEmail);
			}
		}
	}
}
