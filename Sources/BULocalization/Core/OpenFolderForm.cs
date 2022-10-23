using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

using BULocalization.Core;

namespace BULocalization.Core
{
	public partial class OpenFolderForm : Form
	{
		private const string _CreateDirQuestion = "Directory '{0}' does not exist.\n\nWould you like to create it?";

		private static string _recentProjectFolder = string.Empty;

		public OpenFolderForm()
		{
			InitializeComponent();
			
			projectFolderTextBox.Text = _recentProjectFolder;
		}
		
		public string SelectedPath
		{
			get 
			{
				_recentProjectFolder = projectFolderTextBox.Text;
				return _recentProjectFolder; 
			}
		}
				
		private void browseButtonClick(object sender, System.EventArgs e)
		{
			projectFolderBrowserDialog.SelectedPath = projectFolderTextBox.Text;

			if (projectFolderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				projectFolderTextBox.Text = projectFolderBrowserDialog.SelectedPath;
			}
		}
		
		private void OkButtonClick(object sender, EventArgs e)
		{
			string path = projectFolderTextBox.Text;
			if (!string.IsNullOrEmpty(path))
			{
				if (!Directory.Exists(path))
				{
					if (AppController.AskSomething(
						string.Format( _CreateDirQuestion, path)))
					{
						try
						{
							Directory.CreateDirectory(path);
						}
						catch (Exception exception)
						{
							DialogsUtil.ShowErrorMessage(exception.Message);
							return;
						}
					}
					else
					{
						return;
					}
				}
					
				this.DialogResult = DialogResult.OK;
			}
		}
		
		private void projectFolderTextBoxTextChanged(object sender, EventArgs e)
		{
			okButton.Enabled = !string.IsNullOrEmpty(projectFolderTextBox.Text);
		}
	}
}
