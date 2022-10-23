using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Globalization;
using System.Diagnostics;
using System.IO;

using BULocalization.Core;

namespace BULocalization
{
	internal partial class ChangeDefaultLanguage : Form
	{
		#region Messages
		
		private const string _PleaseSetNamespaceFirst = "Please, select namespace!";
		private const string _PleaseAddOneNamespaceFirst = "Please, add namespace on 'Namespaces' tab first!";
		private const string _RemoveItemConfirmation = "Please, confirm removal of item with id '{0}'\n\nText:\n{1}";
		private const string _CouldNotLoadDefaultTranslation = "Could not load default translation!\n\n{0}\n\nTo see how to repair it see documentation";
		private const string _CouldNotSaveDefaultTranslation = "Could not save default translation!\n\n{0}";
		private const string _NoNamespaces = "Empty namespaces list!";
		private const string _RemoveNamespace = "Please confirm removal of namespace '{0}'";
		private const string _NewNamespaceCaption = "New Namespace";
		private const string _NewNamespaceText = "Please, enter new namespace name:";
		private const string _RenamingNamespace = "Renaming namespace '{0}'";
		private const string _EnterNewNamespaceName = "Please, enter new name:";
		private const string _SelectedItem = "Selected Item - {0}";
		private const string _SelectedItemDefault = "Selected Item";

		#endregion
		
		#region Private fields
		
		private readonly BUTranslation _translation = new BUTranslation();
		private Item _currentItem;
		private readonly string _file;
		private readonly SearchForm _searchDialog;
		private bool _isCommited;
		
		#endregion
		
		public bool Commited
		{
			get { return _isCommited; }
		}
		
		public ChangeDefaultLanguage(string file)
		{
			_searchDialog = new SearchForm(onSearch);
			_file = file;
			_currentItem.id = -1;

			InitializeComponent();

			try
			{
				_translation.LoadFromFile(_file);
			}
			catch(IOException exception)
			{
				DialogsUtil.ShowErrorMessage(string.Format(CultureInfo.CurrentCulture, _CouldNotLoadDefaultTranslation, exception.Message));
				return;
			}

			string[] ns =_translation.GetNameSpaces();
			
			for (int i = 0; i < ns.Length; i++)
			{
				namespacesListBox.Items.Add(ns[i]);
			}	
			
			WhereTosendtextBox.Text =_translation.LocalizationProducerEmail;
			WWWtextBox.Text =_translation.eWWW;
			
			authtextBox.Text =_translation.AuthorFullName;
			emailtextBox.Text =_translation.AuthorEmail;
			copyrtextBox.Text =_translation.AuthorCopyright;
			natnametextBox.Text =_translation.NaturalLanguageName;
			refreshNamespacesAndItems();
			if (itemsListView.Items.Count > 0)
			{
				itemsListView.Items[0].Selected = true;
			}
		}
		
		private static ListViewItem produceListViewItem(Item languageItem)
		{
			ListViewItem newItem = 
				new ListViewItem(
					new string[]
					{
						string.Empty,
						languageItem.id.ToString(CultureInfo.CurrentCulture),
						languageItem.Source
					}
				);
			newItem.Tag = languageItem;
			newItem.ImageIndex = languageItem.N_ID == -1 ? 0 : 1;
			return newItem;
		}
				
		private string onSearch(string pattern)
		{
			StringBuilder builder = new StringBuilder();
			
			for (int i = 0; i <_translation.Count(); i++)
			{
				if (_translation.GetItem(i).Source.Contains(pattern))
				{
					builder.Append(_translation.GetItem(i).id.ToString(CultureInfo.CurrentCulture));
					builder.Append("; ");
				}
			}
			
			return builder.ToString();
		}

		private bool save()
		{
			try
			{
				_translation.LocalizationProducerEmail = WhereTosendtextBox.Text.Trim();
				_translation.eWWW = WWWtextBox.Text.Trim();
				_translation.IsSupported = false;
				_translation.AuthorFullName = authtextBox.Text.Trim();
				_translation.AuthorEmail = emailtextBox.Text.Trim();
				_translation.AuthorCopyright = copyrtextBox.Text.Trim();
				_translation.NaturalLanguageName = natnametextBox.Text.Trim();
				
				if (string.IsNullOrEmpty(_translation.NaturalLanguageName))
				{
					throw new CommonTranslationException("Empty natural language name!");
				}
				if (string.IsNullOrEmpty(_translation.AuthorEmail))
				{
					throw new CommonTranslationException("Empty author e-mail!");
				}			
				_translation.SaveToFile(_file);
				_isCommited = true;
				return true;
			}
			catch (CommonTranslationException exception)
			{
				DialogsUtil.ShowErrorMessage(string.Format(CultureInfo.CurrentCulture,_CouldNotSaveDefaultTranslation, exception.Message));
				return false;
			}
			catch (IOException exception)
			{
				DialogsUtil.ShowErrorMessage(string.Format(CultureInfo.CurrentCulture,_CouldNotSaveDefaultTranslation, exception.Message));
				return false;
			}
		}
		
		private void addLanguageItem()
		{
			if (_translation.NamespacesCount == 0)
			{
				DialogsUtil.ShowErrorMessage(_NoNamespaces);
				return;
			}
			
			_currentItem.id =_translation.GetNewID();
			_currentItem.Source = string.Empty;
			_currentItem.State = "1";
			_currentItem.Source = string.Empty;
			_currentItem.Translation = string.Empty;
			
			_translation.AddNewItem(_currentItem);
			ListViewItem newItem = produceListViewItem(_currentItem);
			itemsListView.Items.Add(newItem);
			itemsListView.FocusedItem = newItem;
			newItem.Selected = true;

			// if selected <Not Set> item, setting it first namespace to avoid errors by default
			if (namespacesComboBox.SelectedIndex < 1)
			{
				namespacesComboBox.SelectedIndex = 1;
			}
			
			sourceTextBox.Select();

			// auto past text from buffer feature
			if (AutoPastAndSetcheckBox.Checked)
			{
				sourceTextBox.Text = string.Empty;
				sourceTextBox.Paste();
				saveEditedItemState();
			}
		}
		
		private void itemsListBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			if (itemsListView.SelectedItems.Count < 1)
			{
				removeItemButton.Enabled = false;
				TranslationGroupBox.Text = _SelectedItemDefault;
				sourceTextBox.Text = string.Empty;
				TranslationGroupBox.Enabled = false;
				return;
			}
			removeItemButton.Enabled = true;
			TranslationGroupBox.Enabled = true;

			_currentItem = (Item)itemsListView.SelectedItems[0].Tag;
			TranslationGroupBox.Text = string.Format(CultureInfo.CurrentCulture, _SelectedItem, _currentItem.id);
			string[] formattedText = new string[1];
			string source = _currentItem.Source;
			if (source.Length > 1)
			{
				int count = 1;
				for (int i = 0; i < source.Length - 1; i++)
				{
					if ((source[i] == '\\') && (source[i + 1] == 'n'))
						count++;
				}
				formattedText = new string[count];
				
				for (int i = 0; i < count - 1; i++)
				{
					formattedText[i] = source.Substring(0, source.IndexOf("\\n", StringComparison.Ordinal));
					source = source.Remove(0, source.IndexOf("\\n", StringComparison.Ordinal) + 2);
				}				
				formattedText[count - 1] = source;
			}
			else
			{
				formattedText[0] = source;
			}
			
			sourceTextBox.Lines = formattedText;
			if (_currentItem.N_ID == -1) 
			{
				namespacesComboBox.SelectedItem = BUTranslation.DefaultNamespaceName;
			}
			else
			{
				namespacesComboBox.SelectedItem = _translation.GetNamespace(_currentItem.N_ID);
			}
			setItemStateButton.Enabled = false;
		}
		
		private void saveEditedItemState()
		{
			if (itemsListView.SelectedItems.Count > 0)
			{
				if (namespacesListBox.Items.Count < 1)
				{
					DialogsUtil.ShowInformationMessage(_PleaseAddOneNamespaceFirst);
					return;
				}
				if (namespacesComboBox.SelectedIndex < 1)
				{
					DialogsUtil.ShowInformationMessage(_PleaseSetNamespaceFirst);
					return;
				}

				int count = sourceTextBox.Lines.Length;

				if (count <= 1) 
				{
					_currentItem.Source = sourceTextBox.Text;
				}
				else
				{
					_currentItem.Source = string.Empty;
					for (int i = 0; i < count - 1; i++) _currentItem.Source += sourceTextBox.Lines[i] + @"\n";
					_currentItem.Source += sourceTextBox.Lines[count - 1];
				}
				
				_currentItem.N_ID =_translation.GetNamespaceIdByName( (string)namespacesComboBox.SelectedItem);
				
				int itemIndexInArray = itemsListView.SelectedItems[0].Index;
				_translation.UpdateItem(_currentItem, itemIndexInArray);
				itemsListView.Items[itemIndexInArray] = produceListViewItem (_currentItem);
				itemsListView.Items[itemIndexInArray].Selected = true;
			}
		}
		
		private void removeLanguageItem()
		{
			if (itemsListView.SelectedItems.Count > 0)
			{
				Item item = (Item)itemsListView.SelectedItems[0].Tag;
				if (AppController.AskSomething(
					string.Format(CultureInfo.CurrentCulture,
						_RemoveItemConfirmation,
						item.id,
						item.Source
					)))
				{
					int selectedItemIndex = itemsListView.SelectedItems[0].Index;
					_translation.DeleteItem(selectedItemIndex);
					itemsListView.Items.Remove(itemsListView.SelectedItems[0]);
				}
			}
		}
		
		private void saveButtonClick(object sender, EventArgs e)
		{
			save();
		}
		
		private void addNamespace(object sender, EventArgs e)
		{
			using (EnterValueForm form = new EnterValueForm(_NewNamespaceCaption, _NewNamespaceText, string.Empty))
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					string newname = form.Value;
					try
					{
						_translation.AddNamespace(newname);
					}
					catch(InvalidOperationException exception)
					{
						DialogsUtil.ShowErrorMessage(exception.Message);
						return;
					}
					namespacesListBox.Items.Add(newname);
					refreshNamespacesAndItems();
				}
			}
		}
		
		private void renameNamespace(object sender, EventArgs e)
		{
			if ((namespacesListBox.Items.Count < 1) || (namespacesListBox.SelectedIndex < 0)) return;
			string oldName = (string)namespacesListBox.Items[namespacesListBox.SelectedIndex];
			using (EnterValueForm form = 
			       new EnterValueForm(
			       	string.Format(CultureInfo.CurrentCulture,
			       		_RenamingNamespace, oldName),
			       		_EnterNewNamespaceName, 
			       		oldName))
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					string newname = form.Value;
					try
					{
						_translation.RenameNamespace((string)namespacesListBox.SelectedItem, newname);
					}
					catch(InvalidOperationException exception)
					{
						DialogsUtil.ShowErrorMessage(exception.Message);
						return;
					}
					
					namespacesListBox.Items[namespacesListBox.SelectedIndex] = newname;
					refreshNamespacesAndItems();
				}
			}
		}
		
		private void removeNamespace(object sender, EventArgs e)
		{
			if ((namespacesListBox.Items.Count < 1) || (namespacesListBox.SelectedIndex < 0)) return;
			
			string namespaceName = (string)namespacesListBox.Items[namespacesListBox.SelectedIndex];

			if (!AppController.AskSomething(string.Format(CultureInfo.CurrentCulture, _RemoveNamespace, namespaceName)))
				return;
			
			try
			{
				_translation.DeleteNamespace(namespaceName);
			}
			catch(InvalidOperationException exception)
			{
				DialogsUtil.ShowErrorMessage(exception.Message);
				return;
			}
			
			namespacesListBox.Items.Remove(namespacesListBox.Items[namespacesListBox.SelectedIndex]);
			refreshNamespacesAndItems();
		}
		
		private void refreshNamespacesAndItems()
		{
			namespacesComboBox.BeginUpdate();
			namespacesComboBox.Items.Clear();
			namespacesComboBox.Items.Add(BUTranslation.DefaultNamespaceName);

			foreach (string namespaceItem in namespacesListBox.Items)
			{
				namespacesComboBox.Items.Add(namespaceItem);
			}
			namespacesComboBox.EndUpdate();
	
			itemsListView.BeginUpdate();
			itemsListView.Items.Clear();

			for (int i = 0; i <_translation.Count(); i++)
			{
				_currentItem =_translation.GetItem(i);
				itemsListView.Items.Add(produceListViewItem(_currentItem));
			}
			itemsListView.EndUpdate();
		}
		
		private void changeDefaultLanguageFormClosing(object sender, FormClosingEventArgs e)
		{
			_searchDialog.Hide();
			switch (MessageBox.Show("Save?", "Exiting", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 0))
			{
				case DialogResult.Yes:
					if (!save())
					{
						e.Cancel = true;
						return;
					}
					
					_searchDialog.AllowClose = true;
					_searchDialog.Close();
					
					DialogResult = DialogResult.OK;
					
					break;
				case DialogResult.No:
					_searchDialog.AllowClose = true;
					_searchDialog.Close();
					
					DialogResult = DialogResult.Cancel;
					break;
					
				default: 
					e.Cancel = true;
					break;
					
			}
		}
		
		private void copyToClipboard()
		{
			sourceTextBox.SelectAll();
			sourceTextBox.Copy();
			sourceTextBox.Select(0,0);
		}
		
		private void setItemStateButtonClick(object sender, EventArgs e)
		{
			saveEditedItemState();
		}
		
		private void addNewItem(object sender, EventArgs e)
		{
			addLanguageItem();
		}
		
		private void copyItemSource(object sender, EventArgs e)
		{
			copyToClipboard();
		}
		
		private void search(object sender, EventArgs e)
		{
			_searchDialog.Execute();
		}
		
		private void itemsListContextMenuStripOpening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			bool enabled = itemsListView.SelectedItems.Count > 0;
			removeLanguageItemToolStripMenuItem.Enabled = enabled;
			copySourceItemToolStripMenuItem.Enabled = enabled;
			copyItemIdToolStripMenuItem.Enabled = enabled;
		}
		
		private void removeItem(object sender, EventArgs e)
		{
			removeLanguageItem();
		}
		
		private void namespacesListBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			bool enable = namespacesListBox.SelectedIndex > -1;
			renameNamespaceButton.Enabled = enable;
			removeNamespaceButton.Enabled = enable;
		}
		
		private void namespacesContextMenuStripOpening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			bool enable = namespacesListBox.SelectedIndex > -1;
			renameNamespaceToolStripMenuItem.Enabled = enable;
			removeNamespaceToolStripMenuItem.Enabled = enable;
		}
		
		private void namespacesListBoxMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int index = namespacesListBox.IndexFromPoint(e.Location);
			if (index < 0)
			{
				namespacesListBox.SelectedIndex = -1;
			}
			else
			{
				namespacesListBox.SelectedIndex = index;
			}
		}
		
		private void keyDownOnItems(object sender, KeyEventArgs e)
		{
			if (MaintabControl.SelectedIndex == 0)
			{
				if (e.Control)
				{
					if (e.KeyCode == Keys.A)
					{
						addLanguageItem();
					}
					else if (e.KeyCode == Keys.F)
					{
						_searchDialog.Execute();
					}
					else if (e.KeyCode == Keys.S)
					{
						if (setItemStateButton.Enabled)
						{
							saveEditedItemState();
						}
					}
				}
			}
		}
		
		private void checkForModifiedText()
		{
			if (itemsListView.SelectedItems.Count > 0)
			{
				if (string.Compare(_currentItem.Source, sourceTextBox.Text, false, CultureInfo.CurrentCulture) != 0)
				{
					if (!TranslationGroupBox.Text.EndsWith("*", StringComparison.Ordinal))
					{
						TranslationGroupBox.Text += " *";
						refreshSetButtonState();
					}
				}
			}
		}
		
		private void copyItemId(object sender, EventArgs e)
		{
			if (itemsListView.SelectedItems.Count > 0)
			{
				Item item = (Item)itemsListView.SelectedItems[0].Tag;
				try
				{
					Clipboard.SetDataObject(item.id.ToString(CultureInfo.CurrentCulture));
				}
				catch (System.Runtime.InteropServices.ExternalException) { ; }
			}
		}
		
		private void refreshSetButtonState()
		{
			bool newSetButtonState = !string.IsNullOrEmpty(sourceTextBox.Text);

			if (newSetButtonState)
			{
				newSetButtonState = namespacesComboBox.SelectedIndex != 0;
			}
			setItemStateButton.Enabled = newSetButtonState;
		}
		
		private void sourceTextBoxTextChanged(object sender, EventArgs e)
		{
			refreshSetButtonState();
		}
		
		private void sourceTextBoxKeyUp(object sender, KeyEventArgs e)
		{
			checkForModifiedText();
		}
		
		private void namespacesComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			refreshSetButtonState();
		}
		
		private void itemsListViewResize(object sender, EventArgs e)
		{
			textColumnHeader.Width = itemsListView.Width - 85;
		}
	}
}
