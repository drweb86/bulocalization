using System;
using System.Xml;
using System.Windows.Forms;
using System.IO;

using BULocalization.Core;

namespace BULocalization.Core
{
	/// <summary>
	/// Class for easiest way of managing with language options
	/// </summary>
	public class BULanguagesManager
	{
		// Languages settings
		public string LanguageName = "default";
		private string pathToLocals = "";
		private string[] Namespaces;
		
		private BULanguages bulanguages;
		
		/// <param name="pathToLocals">c:\locals\. Last slash is required</param>
		public BULanguagesManager(string[] namespaces, string PathToLocals)
		{
			this.Namespaces = namespaces;
			pathToLocals = PathToLocals;
			
			// loading available languages
			bulanguages = new BULanguages();
			try
			{
				bulanguages.LoadLocalizationData(PathToLocals);
			}
			catch (Exception e)
			{
				throw new Exception("Could not get gather all data from directory:\n" + PathToLocals + "\ndue to: " + e.Message + Environment.NewLine + "Available languages list didn't loaded");
			}
		}

		/// <summary>
		/// Loads localization items into memory
		/// </summary>
		/// <returns>Opened localization</returns>
		public BUTranslation LoadLocalization()
		{
			if (Namespaces.Length > 0)	return LoadThisLocalization();
			else return LoadAllLocalization();
		}
		
		/// <summary>
		/// Loads localization when empty namespace
		/// </summary>
		BUTranslation LoadAllLocalization()
		{
			BUTranslation butranslation = new BUTranslation();
			try
			{
				butranslation.LoadFromFile(pathToLocals + LanguageName + ".Language");
			}
			catch (Exception e)
			{
				throw new Exception("Could not open localization file with " + LanguageName + " language due to: " + e.Message);
			}
			return butranslation;
		}
		
		
		/// <summary>
		/// Loads localization with some predefined namespaces, actual for projects with more than one program entity
		/// </summary>
		/// <param name="LanguageName">for example Russian</param>
		BUTranslation LoadThisLocalization()
		{
			BUTranslation butranslation = new BUTranslation();
			try
			{
				butranslation.LoadNamespacesFromFile(pathToLocals + LanguageName + ".Language", Namespaces);
			}
			catch (Exception e)
			{
				throw new Exception("Could not open localization file with " + LanguageName + " language due to: " + e.Message);
			}
			
			return butranslation;
		}
	}
}
