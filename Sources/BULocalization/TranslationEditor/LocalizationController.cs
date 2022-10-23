using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

using BULocalization.Core;

namespace BULocalization.TranslationEditor
{
	internal class LocalizationController
	{
		private readonly SearchForm _searchForm;
		
		// current translation
		private BUTranslation _translation;
		private string _openedFileWithTranslation = string.Empty;
		
		public string TranslationFile
		{
			get { return _openedFileWithTranslation; }
		}
		
		public string SendToEmail
		{
			get { return _translation.LocalizationProducerEmail; }
		}
		
		public BUTranslation Translation
		{
			get { return _translation; }
		}
		
		public bool LoadedLanguage
		{
			get { return _translation != null; }
		}
		
		public bool CurrentTranslationIsSupported
		{
			get { return _translation.IsSupported; }
			set { _translation.IsSupported = value; }
		}
		
		public string CurrentTranslationNaturalName
		{
			get { return _translation.NaturalLanguageName; }
			set { _translation.NaturalLanguageName = value; }
		}
		
		public LocalizationController()
		{
			_searchForm = new SearchForm(searchHelper);
		}
	
		public void Configure()
		{
			using (TranslationConfigurationForm form = new TranslationConfigurationForm(this))
			{
				form.ShowDialog();
			}
		}
		
		public bool Load(string file)
		{
			if (!File.Exists(file))
			{
				DialogsUtil.ShowErrorMessage("No such file");
				return false;
			}
			
			bool result = true;
			_openedFileWithTranslation = file;
			try
			{
				_translation = new BUTranslation();
				_translation.LoadFromFile(file);
			}
			catch(CommonTranslationException e)
			{
				DialogsUtil.ShowErrorMessage(
					string.Format(CultureInfo.CurrentCulture, 
					              "Could not load file\n\n{0}", 
					              e.Message));
				result = false;
				_translation = null;
				_openedFileWithTranslation = string.Empty;
			}
			
			return result;
		}
		
		public void HideSearchDialog()
		{
			_searchForm.Hide();
		}
		
		public bool Save()
		{
			bool result = true;
			try
			{
				_translation.AuthorCopyright = Settings.ProduceTranslatorsCopyright();
				_translation.AuthorEmail = Settings.Email;
				_translation.AuthorFullName = Settings.Name;
				
				_translation.SaveToFile(_openedFileWithTranslation);
			}
			catch(CommonTranslationException e)
			{
				DialogsUtil.ShowErrorMessage(
					string.Format(CultureInfo.CurrentCulture, 
					              "Could not save translation file\n\n{0}", 
					              e.Message));
				result = false;
			}	
		
			return (result);
		}
		
		public void PrepareLetter()
		{
			using (EmailForm form = new EmailForm(this, _openedFileWithTranslation))
			{
				form.ShowDialog();
			}
		}
		
		public void Closing()
		{
			_searchForm.AllowClose = true; 
		}
		
		public void Search()
		{
			_searchForm.Execute();
		}
		
		private string searchHelper(string pattern)
		{
			StringBuilder builder = new StringBuilder();
			if (!string.IsNullOrEmpty(pattern))
			{
				if (_translation.Count() > 0)
				{
					Item item;
					for (int i = 0; i < _translation.Count();i++)
					{
						item = _translation.GetItem(i);
						if ((item.Source.Contains(pattern)) ||(item.Translation.Contains(pattern)))
						{
							builder.Append(item.id);
							builder.Append("; ");
						}
					}
				}
			}
			return builder.ToString();
		}
	}
}
