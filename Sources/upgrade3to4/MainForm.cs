/*
 * (c)Cuchuk Sergey Alexandrovich, 2007
 * Cuchuk.Sergey@gmail.com
 * toCuchukSergey@yandex.ru
 * 
 * Developed in #Develop IDE
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using BUtil.UpgradeLocalization;

namespace upgrade3to4
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string path = @"\";
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ClosebuttonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void SelectbuttonClick(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				path = folderBrowserDialog.SelectedPath + @"\";
				LocalProjectLocationtextBox.Text = path;
			}
		}
		
		void UpgradebuttonClick(object sender, EventArgs e)
		{
			// step 0 - checking input
			if (path.Length <= 1)
			{
				MessageBox.Show("Please select your localization folder");
				return;
			}
			
			if (!DidBackupcheckBox.Checked)
			{
				MessageBox.Show("Please do backup of your localization data");
				return;
			}

			// step 1 - delete config file
			File.Delete(path + "LanguageOptions.xml");
			
			// step 2 - loading project file(version control included in class)
			BUtil.UpgradeLocalization.BULanguages bl = new BUtil.UpgradeLocalization.BULanguages();
			string projectLocation = "";
			try
			{
				projectLocation = Directory.GetFiles(path, "*.xml")[0];
				bl.LoadLocalizationDataFromFile(projectLocation);
			}
			catch(Exception ee)
			{
				MessageBox.Show("Could not load localization project: " + projectLocation + "\nin path: " + path + "\n" + ee.Message);
				return;
			}
			BUtil.UpgradeLocalization.BULanguages.Language[] languages = bl.languages;
			
			// step 3 - removing localization project file
			File.Delete(projectLocation);
			
			// step 4 - upgrading all localizations (including default one)
			BUtil.UpgradeLocalization.BUTranslation butr = new BUTranslation();
			
			for (int i = 0; i < languages.Length; i++)
			{
				string LocFileName = path + languages[i].Name + ".Language";
				try
				{
					butr.LoadFromFile(LocFileName);
					butr.IsSupported = true;
					butr.NaturalLanguageName = languages[i].SpecificName;
					butr.SaveToFile(LocFileName);
				}
				catch(Exception ee)
				{
					MessageBox.Show("Problems with localization: " + LocFileName + "\noccured: " + ee.Message);
				}
			}
			
			// step 6 - removing localization project file
			File.Delete(projectLocation);

			
			// step 5 - done
			MessageBox.Show("Done!!!");

			
		}
	}
}
