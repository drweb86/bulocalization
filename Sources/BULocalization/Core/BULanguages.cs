using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BULocalization.Core
{
	/// <summary>
	/// Description of BULanguages.
	/// </summary>
	public class BULanguages
	{
		// Version. Required for modifications creating ans supporting format
		private const int Version = 4;
		private List<LanguageInfo> _languagesInformation = new List<LanguageInfo>();
		
		/// <summary>
		/// Returns readonly languages
		/// </summary>
		public LanguageInfo[] languages
		{
			get 
			{
				return _languagesInformation.ToArray();
			}
		}
		
		/// <summary>
		/// Checks whether name of specific name of language are unique
		/// </summary>
		/// <param name="item">Language item</param>
		/// <returns>true - if unique</returns>
		public bool CheckUnique(LanguageInfo item)
		{
			if (_languagesInformation.Count > 0)
			{
				foreach (LanguageInfo info in _languagesInformation)
				{
					if (info.Name == item.Name) return false;
					if ((info.SpecificName == item.SpecificName) && (item.SpecificName.Length > 0))return false;
				}
			}
			return true;
		}
		
		/// <summary>
		/// Updates all translations on the base of default translation
		/// </summary>
		/// <param name="Path">path to default translation like: c:\local\</param>
		public void UpdateAllTranslations(string Path)
		{
			BUTranslation but = new BUTranslation();
			but.LoadFromFile(Path + "default.Language");
			BUTranslation upt;
			Item item;
			Item olditem;
				
			for (int i = 0; i < _languagesInformation.Count; i++)
			{
				if (_languagesInformation[i].Name == "default") continue;
				upt = new BUTranslation();
				upt.LoadFromFile(_languagesInformation[i].File);
				
				but.AuthorCopyright = upt.AuthorCopyright;
				but.AuthorEmail = upt.AuthorEmail;
				but.AuthorFullName = upt.AuthorFullName;
				but.IsSupported = upt.IsSupported;
				but.NaturalLanguageName = upt.NaturalLanguageName;
				
				for (int l = 0; l < but.Count(); l++)
				{
					item = but.GetItem(l);
					try
					{
						olditem = upt.GetItemByID(item.id);
					}
					catch
					{
						item.State = "1";
						but.UpdateItem(item, l);
						continue;
					}
					
					item.Translation = olditem.Translation;
					
					if (item.Source == olditem.Source) item.State = olditem.State;
					else item.State = "1";
					
					but.UpdateItem(item, l);
				
				}
				
				but.SaveToFile(_languagesInformation[i].File);
				
				
			
			}
			
			
			
			
		
		
		}
		
		/// <summary>
		/// Returns number of languages
		/// </summary>
		public int Count
		{
			get {return _languagesInformation.Count;}
		}
		
		/// <summary>
		/// Check whether translation is unique without paying attention to translation with specified array index
		/// </summary>
		/// <param name="item">Language item</param>
		/// <param name="ItemNumber">Index in array</param>
		/// <returns></returns>
		public bool CheckUniqueWithoutNextItem(LanguageInfo item, int indexOfItem)
		{
			if (_languagesInformation.Count != 0)
			for (int i = 0; i < _languagesInformation.Count; i++)
			{
				if (i == indexOfItem) continue;
				// debug
				//if (Languages[i].LanguageFile == item.LanguageFile) return false;
				if (_languagesInformation[i].Name == item.Name) return false;
				if (_languagesInformation[i].SpecificName == item.SpecificName) return false;
			}
			return true;
		
		}
		
		/// <summary>
		/// Updates item
		/// </summary>
		/// <param name="item">Language item</param>
		/// <param name="ItemNumber">Index of item in array</param>
		public void UpdateItem(LanguageInfo item, int indexOfItem)
		{
			if (indexOfItem > _languagesInformation.Count) throw new Exception("Index out of bounds");
			if (!CheckUniqueWithoutNextItem(item, indexOfItem)) throw new Exception("Not unique");
			
			_languagesInformation[indexOfItem] = item;
		}
		
		/// <summary>
		/// Deletes language item
		/// </summary>
		/// <param name="index">Index of item in array</param>
		public void DeleteItem(LanguageInfo item)
		{
			_languagesInformation.Remove(item);
		}
		
		/// <summary>
		/// Gets language item by its index in array
		/// </summary>
		/// <param name="index">index in array</param>
		/// <returns>Language item</returns>
		public LanguageInfo GetLanguage(int index)
		{
			if ((index < 0) || (index > _languagesInformation.Count)) throw new Exception("Index out of bounds");
			return _languagesInformation[index];
		}
		
		/// <summary>
		/// Adds new unique language item
		/// </summary>
		/// <param name="Item">Language item</param>
		public void AddNewItem(LanguageInfo item)
		{
			if (!CheckUnique(item)) throw new Exception("Not unique item");
			_languagesInformation.Add(item);
		}
		
		/// <summary>
		/// Loads localization project from file
		/// </summary>
		/// <param name="PathToLocals">Directory. For example: c:\ slash is required</param>
		public void LoadLocalizationData(string pathToLocals)
		{
			_languagesInformation.Clear();
			if (pathToLocals.Length == 0) throw new Exception("Empty path");
			
			try
			{
				// step 1 - getting all directory data .language
				string[] Files = Directory.GetFiles(pathToLocals, "*.Language");
				
				// step 2 - loading major information
				BUTranslation butr = new BUTranslation();
				
				foreach (string file in Files)
				{
					LanguageInfo info = new LanguageInfo();
					info.File = file;
					info.Name = Path.GetFileNameWithoutExtension(file);
					butr.GetGeneralInformationAboutTranslation(file);
					info.Author = butr.AuthorFullName;
					info.AuthorEmail = butr.AuthorEmail;
					info.IsSupported = butr.IsSupported;
					info.SpecificName = butr.NaturalLanguageName; 	
					_languagesInformation.Add(info);
				}
			}
			catch (Exception e)
			{
				throw e;
			}
		}
	}
}
