using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

using BULocalization.Core;
using BULocalization.TranslationEditor;

namespace BULocalization
{
	internal class AppController
	{
		private const string _CouldNotLoadOptionsFS = "Could not load BULocalization options:\n\n{0}";
		private const string _CouldNotSaveOptions = "Could not save BULocalization options:\n\n{0}";
		private const string _UpdateFailled = "During upgrading of translations an error occured:\n{0}";
		private const string _FolderDoesNotFit = "This folder contains files/folders! Localization can be created in empty directory";
		private const string _CouldCopyTemplateFile = "Could copy template file as a default file {0}";
		private const string _NotUnique = "Specified item is not unique!";
		private const string _NotSpecified = "<Not specified>";
		private const string _SendLetters = "Would you like to send letters to all translators?";
	
		private BULanguages _languages = new BULanguages();
		private readonly Settings _settings = new Settings();
		private string _currentProjectDir = string.Empty;
		
		public string ProjectDir
		{
			get { return _currentProjectDir; }
		}
		
		public BULanguages Languages
		{
			get { return _languages; }
		}
		
		public void CloseProject()
		{
			_currentProjectDir = string.Empty;
			_languages = new BULanguages();
		}
		
		public AppController()
		{
			if (File.Exists(_settings._settingsFile))
			{
				try
				{
					_settings.Load();
				}
				catch (Exception exc)
				{
					DialogsUtil.ShowErrorMessage(string.Format(CultureInfo.CurrentCulture, _CouldNotLoadOptionsFS, exc.Message));
					ConfigureSettings(true);
            	}
			}
			else
			{
				ConfigureSettings(true);
			}
		}
		
		public void ConfigureSettings(bool exitIfCancelled)
		{
			using (SettingsForm form = new SettingsForm(this))
			{
				if (form.ShowDialog() != DialogResult.OK)
				{
					if (exitIfCancelled)
						Environment.Exit(-1);
				}
			}
		}
		
		public static bool AskSomething(string question)
		{
			return (MessageBox.Show(question, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 0) == DialogResult.Yes);
		}
		
		public void UpdateTemplateTranslation()
		{
			bool requiredUpdate = false;
			
			using (ChangeDefaultLanguage form = new ChangeDefaultLanguage(this.ProjectDir + @"default.Language"))
			{
				form.ShowDialog();
				requiredUpdate = form.Commited;
			}
			
			if (_languages.languages.Length > 1)
			{
				if (requiredUpdate)
				{
					UpgradeAllTranslations();
				
					if (AskSomething(_SendLetters))
					{
						SendLettersWithRequestToUpgradeTranslations();
					}
				}
			}
		}
		
		public bool OpenProject(string projectFolder)
		{
			while (projectFolder.EndsWith(@"\", StringComparison.Ordinal))
			{
				projectFolder = projectFolder.Remove(projectFolder.Length - 1, 1);
			}
			
			bool result = true;
			try
			{
				_currentProjectDir = projectFolder + @"\";
				_languages = new BULanguages();
				_languages.LoadLocalizationData(_currentProjectDir);
				Settings.AddOpenedProject(projectFolder);
			}
			catch(Exception e)
			{
				DialogsUtil.ShowErrorMessage(e.Message);
				CloseProject();
				result = false;
			}
			
			return result;
		}
		
		public bool SaveSettings()
		{
			try
			{
				_settings.Save();
			}
			catch (Exception e)
			{
				DialogsUtil.ShowErrorMessage(string.Format(CultureInfo.InvariantCulture, _CouldNotSaveOptions, e.Message));
				return false;
           	}
			
			return true;
		}
		
		public static void OpenLocalizationEditor(string file)
		{
			using (LocalizationEditorForm form = new LocalizationEditorForm(file))
			{
				form.ShowDialog();
			}
		}
		
		public void UpgradeAllTranslations()
		{
			try
			{
				_languages.UpdateAllTranslations(_currentProjectDir);
			}
			catch (Exception e)
			{
				DialogsUtil.ShowErrorMessage(string.Format(CultureInfo.InvariantCulture, _UpdateFailled, e.Message));
			}
		}
		
		public void SendLettersWithRequestToUpgradeTranslations()
		{
			string translator = "$translator";
			string translationEnglishName = "$translation_english_name";
			
			LanguageInfo currentlang;

			string from = string.Empty;
			for (int i = 0; i < _languages.Count; i++)
			{
				currentlang = _languages.GetLanguage(i);
				if (currentlang.Name == "default")
				{
					BUTranslation templateTranslation = new BUTranslation();
					templateTranslation.LoadFromFile(currentlang.File);
					
					from = templateTranslation.LocalizationProducerEmail;
				}
			}
			for (int i = 0; i < _languages.Count; i++)
			{
				currentlang = _languages.GetLanguage(i);
				if (currentlang.Name == "default") continue;
				if (currentlang.IsSupported == false) continue;
				
				string subject = Settings.LetterSubject;
				string body = BUTranslation.RestoreLineBreakes(Settings.LetterBody);
				
				//replacing all data
				//$translator
				subject = subject.Replace(translator, currentlang.Author);
				body = body.Replace(translator, currentlang.Author);
				//$translation_english_name
				subject = subject.Replace(translationEnglishName, currentlang.Name);
				body = body.Replace(translationEnglishName, currentlang.Name);
				
				ThreadPool.QueueUserWorkItem(
					sendMail, 
					new SenderForm(
						from, 
						currentlang.AuthorEmail, 
						subject, 
						body, 
						currentlang.File));
			}		
		}
		
		private void sendMail(object form)
		{
			((Form)form).ShowDialog();
		}
		
		public void DeleteItem(LanguageInfo item)
		{
			File.Delete(item.File);
			_languages.DeleteItem(item);
		}
		
		public bool CreateNewProject(string location)
		{
			if ((Directory.GetFiles(location).Length > 0) || (Directory.GetDirectories(location).Length > 0))
			{
				DialogsUtil.ShowErrorMessage(_FolderDoesNotFit);
				return false;
			}
			
			try
			{
				File.Copy(_settings._defaultTemplateFile, Path.Combine(location, "default.LANGUAGE"));
			}
			catch(Exception e)
			{
				DialogsUtil.ShowErrorMessage(string.Format(CultureInfo.InvariantCulture, _CouldCopyTemplateFile, e.Message));
				return false;
			}
				
			return OpenProject(location);
		}
		
		public bool ModifyLanguage(int index)
		{
			LanguageInfo language = _languages.GetLanguage(index);
			string oldName = language.Name;

			if (language.Name == "default")
				return false;
			
			using(AddModifyLanguageForm form = new AddModifyLanguageForm(language))
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					language = form.Language;
					
					if (!_languages.CheckUniqueWithoutNextItem(language, index))
					{
						DialogsUtil.ShowErrorMessage(_NotUnique);
						return false;
					}
					
					if (language.Name == oldName)
					{
						return false;
					}
					
					string sourceFile = _currentProjectDir + oldName + ".Language";
					string destFile = _currentProjectDir + language.Name + ".Language";
					
					File.Move(sourceFile, destFile);
				}
			}
			return true;
		}
		
		public bool AddNewLanguage()
		{
			LanguageInfo languageInfo = new LanguageInfo();
			
			using (AddModifyLanguageForm form = new AddModifyLanguageForm(languageInfo))
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					languageInfo = form.Language;
					
					if (!_languages.CheckUnique(languageInfo))
					{
						DialogsUtil.ShowErrorMessage(_NotUnique);
						return false;
					}
					
					string destFile = _currentProjectDir + languageInfo.Name + ".LANGUAGE";
					string templateFile = _currentProjectDir + "default.LANGUAGE";
					
					BUTranslation t = new BUTranslation();
					t.LoadFromFile(templateFile);
					t.AuthorFullName = _NotSpecified;
					t.AuthorCopyright = _NotSpecified;
					t.AuthorEmail = _NotSpecified;
					t.IsSupported = false;
					t.NaturalLanguageName = string.Empty;
					
					t.SaveToFile(destFile);
				}
			}
			
			return true;
		}
	}
}
