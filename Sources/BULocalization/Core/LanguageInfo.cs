using System;

namespace BULocalization.Core
{
	public class LanguageInfo
	{
		private string _name = string.Empty;
		private string _specificName = string.Empty;
		private string _file = string.Empty;
		private string _author = string.Empty;
		private string _authorEmail = string.Empty;
		private bool _isSupported;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Natural name of language
		/// </summary>
		public string SpecificName
		{
			get { return _specificName; } 
			set { _specificName = value; }
		}
		
		public string File
		{
			get { return _file; }
			set { _file = value; }
		}
		
		public string Author
		{
			get { return _author; }
			set { _author = value; }
		}

		public string AuthorEmail
		{
			get { return _authorEmail; }
			set { _authorEmail = value; }
		}

		/// <summary>
		/// Shows if author supports translation
		/// </summary>
		public bool IsSupported
		{
			get { return _isSupported; }
			set { _isSupported = value; }
		}
	}
}
