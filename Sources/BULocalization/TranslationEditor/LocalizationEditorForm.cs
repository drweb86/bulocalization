using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

using BULocalization.Core;

namespace BULocalization.TranslationEditor
{
	public partial class LocalizationEditorForm : Form
	{
		private const string _HelpMessage = "\tWhen 'Review' checked and translation saved, you can test your translation in real programs you create translation for. In this case to every translation string will be added its translation id(so you easily can fix it).\n\t'Release' mode - is the default normal mode";
		private const string _SetNaturalLanguageName = @"Failled. Please go 'Translation\Info' and set natural language name!";
		private const string _SourceTextBoxFormatString = "Text to translate - Item №{0} - Namespace '{1}'";
		
		private BUTranslation _translation;
		private Item current_item;
		private int _previousItemIndex;

		private static LocalizationController _controller;

		public LocalizationEditorForm(string file)
		{
			if (string.IsNullOrEmpty(file))
			{
				throw new ArgumentNullException("file");
			}
			_controller = new LocalizationController();

			InitializeComponent();

			load(file);
		}
		
		private void load(string file)
		{
			if (!_controller.Load(file))
			{
				_translation = null;
				Close();
			}
			else
			{
				_translation = _controller.Translation;
				
				// Changes in interface
				_previousItemIndex = -1;
				
				for (int i = 0; i < _translation.Count(); i++)
				{
					itemsdataGridView.Rows.Add(itemToLine(_translation.GetItem(i)));
				}
				
				openTranslationURLToolStripMenuItem.Enabled = !string.IsNullOrEmpty(_translation.eWWW);
				bool reviewMode = _translation.TranslationModeIsReview == 1;
				reviewToolStripMenuItem.Checked = reviewMode;
				releaseToolStripMenuItem.Checked = !reviewMode;
				
				itemsdataGridView.Enabled = true;
				Text = _translation.eWWW + "  " + file + " -  BULocalization";
				if (itemsdataGridView.Rows.Count > 0)
				{
					itemsdataGridView.Rows[0].Selected = true;
					_previousItemIndex = -1;
					ItemsdataGridViewRowEnter(null, null);
				}
			}
		}
		
		private object[] itemToLine(Item item)
		{
			object[] ro = new object[4];
			
			switch (item.State)
			{
				case "0": 
					ro[0] = translationStateIimagesList.Images[0];
					break;
				case "1": 
					ro[0] = translationStateIimagesList.Images[1];
					break;
				default: 
					ro[0] = translationStateIimagesList.Images[2];
					break;			
			}
			
			ro[1] = item.id.ToString(CultureInfo.CurrentCulture);
			ro[2] = item.Source;
			ro[3] = item.Translation;
			
			return ro;
		}
		
		private bool Save()
		{
			// Setting the last edited item
			ItemsdataGridViewRowEnter(null, null);
			
			// Performing save task
			if (_translation.NaturalLanguageName.Length == 0)
			{
				DialogsUtil.ShowErrorMessage(_SetNaturalLanguageName);
				return false;
			}
			
			if (reviewToolStripMenuItem.Checked) 
				_translation.TranslationModeIsReview = 1;
			else 
				_translation.TranslationModeIsReview = 0;
			
			if (!_controller.Save())
			{
				return false;
			}
			
			return true;
		}
		
		void SaveToolStripMenuItemClick(object sender, EventArgs e)
		{
			Save();
		}
		
		private void VerifyTranslation()
		{
			if (string.IsNullOrEmpty(current_item.Translation.Trim()))
			{
				if (current_item.Source != string.Empty)
				{
					current_item.State = "2";
				}
				else
				{
					current_item.State = "0";
				}
			}
			else
			{
				current_item.State = "0";
			}
		}
		
		void PrepareLetterForSendingToolStripMenuItemClick(object sender, EventArgs e)
		{
			_controller.PrepareLetter();
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
		
		
		void TranslationtextBoxKeyUp(object sender, KeyEventArgs e)
		{
			KeysUp(e);
		}
		
		void HelpToolStripMenuItemClick(object sender, EventArgs e)
		{
			DialogsUtil.ShowInformationMessage(_HelpMessage);
		}
		
		void DebugToolStripMenuItemClick(object sender, EventArgs e)
		{
			releaseToolStripMenuItem.Checked = false;
			reviewToolStripMenuItem.Checked = true;
			_translation.TranslationModeIsReview = 1;
		}
		
		void ReleaseToolStripMenuItemClick(object sender, EventArgs e)
		{
			reviewToolStripMenuItem.Checked = false;
			releaseToolStripMenuItem.Checked = true;
			_translation.TranslationModeIsReview = 0;
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			_controller.HideSearchDialog();
			e.Cancel=false;
			
			if (string.IsNullOrEmpty(_controller.TranslationFile)) 
				return;
			
			switch (MessageBox.Show("Save?", "Exiting", 
			                        MessageBoxButtons.YesNoCancel, 
			                        MessageBoxIcon.Question,  
			                        MessageBoxDefaultButton.Button1,
			                        0))
			{
				case DialogResult.No: 
					_controller.Closing(); 
					break;
					
				case DialogResult.Cancel: 
					e.Cancel = true; 
					break;
					
				case DialogResult.Yes: 
					bool result = Save();
					e.Cancel = !result;
					
					if (result)
						_controller.Closing(); 
					
					break;
			}
		}
		
		
		private void KeysUp(KeyEventArgs e)
		{
			if (e.Shift)
			{
				if (e.KeyCode == Keys.Up) 
				{
					e.Handled = true;
					if (_previousItemIndex > 0)
					{
						for (int positionOfNotOkItem = (_previousItemIndex - 1); positionOfNotOkItem >= 0; positionOfNotOkItem--)
						{
							if (_translation.GetItem(positionOfNotOkItem).State != "0")
							{
								itemsdataGridView.Rows[positionOfNotOkItem].Selected=true;
								ItemsdataGridViewRowEnter(null, null);
								break;
							}
						}
					}
				}
				
				if (e.KeyCode == Keys.Down)
				{
					e.Handled = true;
					if (_previousItemIndex + 1 < _translation.Count()) 
					{
						for (int positionOfNotOkItem = (_previousItemIndex + 1); positionOfNotOkItem < _translation.Count(); positionOfNotOkItem++)
						{
							if (_translation.GetItem(positionOfNotOkItem).State != "0")
							{
								itemsdataGridView.Rows[positionOfNotOkItem].Selected=true;
								ItemsdataGridViewRowEnter(null, null);
								break;
							}
						}
					}
				}
			}
		}
		
		void SourcetextBoxKeyUp(object sender, KeyEventArgs e)
		{
			KeysUp(e);
		}
		
		void ItemslistBoxKeyUp(object sender, KeyEventArgs e)
		{
			KeysUp(e);
		}
		
		#region Web-browsing
		
		void OpenTranslationURLToolStripMenuItemClick(object sender, EventArgs e)
		{
			SupportManager.OpenUrl(_translation.eWWW);
		}
		
		void VisitHomepageToolStripMenuItemClick(object sender, EventArgs e)
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
		
		#endregion
		
		void DocumentationToolStripMenuItemClick(object sender, EventArgs e)
		{
			SupportManager.OpenHelp();
		}
		
		void FindReferencesToolStripMenuItemClick(object sender, EventArgs e)
		{
			_controller.Search();
		}
		
		void AboutToolStripMenuItem1Click(object sender, EventArgs e)
		{
			AssemblyName assemblyName = Assembly.GetExecutingAssembly().GetName();
			DialogsUtil.ShowAboutProgramMessage(assemblyName.Name, assemblyName.Version.ToString());
		}
		
		private void ItemsdataGridViewRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (itemsdataGridView.SelectedRows.Count < 1) return;
			//if (_previousItemIndex == itemsdataGridView.SelectedRows[0].Index) return;
			
			// Saving previous item
			// if editing in second time
			// if previous item is exists
			if (_previousItemIndex != -1)
			{
				// saving item and validating it
				current_item.Translation = BUTranslation.CreateFormattedText(translationtextBox.Lines);
				VerifyTranslation();
				_translation.UpdateItem(current_item, _previousItemIndex);
				itemsdataGridView.Rows[_previousItemIndex].SetValues(itemToLine(current_item));
			}

			// Loading new item
			current_item = _translation.GetItem(itemsdataGridView.SelectedRows[0].Index);
			string[] srce = BUTranslation.CreateEditableText(current_item.Source);
			string[] translation = BUTranslation.CreateEditableText(current_item.Translation);
			sourcetextBox.Lines = srce;
			translationtextBox.Lines = translation;
			sourceTextGroupBox.Text = string.Format(
				_SourceTextBoxFormatString,
				current_item.id,
				_translation.GetNamespace(current_item.N_ID)
				);

			_previousItemIndex = itemsdataGridView.SelectedRows[0].Index;
			if (current_item.State == "0") translationtextBox.BackColor = Color.LightGreen;
			if (current_item.State == "1") translationtextBox.BackColor = Color.Orange;
			if (current_item.State == "2") translationtextBox.BackColor = Color.Tomato;
			itemsdataGridView.Enabled = true;

		}
		
		private void SettingsToolStripMenuItemClick(object sender, EventArgs e)
		{
			_controller.Configure();
		}
		
		private void ItemsdataGridViewKeyDown(object sender, KeyEventArgs e)
		{
			KeysUp(e);
		}
	}
}
