﻿using System;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Globalization;

namespace BULocalization
{
	internal class Settings
	{
		private const int _MaxLastUsedFilesToRemember = 5;
		
		private readonly string _binariesFolder = Application.StartupPath;
		private readonly string _installFolder;
		private readonly string _dataFolder;
		
		internal readonly string _defaultTemplateFile;
		internal readonly string _settingsFile;
		
		private readonly string _recentProjectsConfigFile;
		private static string _letterSubject = "Translation on $translation_english_name changed";
		private static string _letterBody = "$translator!\\n\\n" + 
			"Translation changed(see attachement), so could you please update it and send it back\\n\\n\\n"+
			"_____________________\\n" +
			"This e-mail was generated by BULocalization";
		private static string _smtpHost = "127.0.0.1";
		private static int _smtpPort = 25;
		private static readonly List<string> _lastOpenedProjects = new List<string>();

		private static string _name = string.Empty;
		private static string _email = string.Empty;
		private static string _otherContactInformation = string.Empty;

		public static string Name
		{
			get { return _name; }
			set
			{ 
				if (string.IsNullOrEmpty(value))
					throw new ArgumentNullException("value");
				
				_name = value;
			}
		}
		
		public static string Email
		{
			get { return _email; }
			set 
			{ 
				if (string.IsNullOrEmpty(value))
					throw new ArgumentNullException("value");
				
				_email = value; 
			}
		}
		
		public static string OtherContactInformation
		{
			get { return _otherContactInformation.Replace(@"\r", "\r").Replace(@"\n", "\n"); }
			set { _otherContactInformation = value.Replace("\r", @"\r").Replace("\n", @"\n"); }
		}

		public static string[] GetLastOpenedProjects()
		{
			return _lastOpenedProjects.ToArray();
		}

		public static string ProduceTranslatorsCopyright()
		{
			return (string.Format(CultureInfo.CurrentCulture, 
			                      "Copyright (c) {0} {1}, {2}", 
			                      DateTime.Now.Year.ToString(CultureInfo.CurrentCulture), _name, _email));
		}

		public static void AddOpenedProject(string folder)
		{
			if (!string.IsNullOrEmpty(folder))
			{
				if (_lastOpenedProjects.Contains(folder))
				{
					// moving on top it
					_lastOpenedProjects[_lastOpenedProjects.IndexOf(folder)] = _lastOpenedProjects[_lastOpenedProjects.Count - 1];
					_lastOpenedProjects[_lastOpenedProjects.Count - 1] = folder;
				}
				else
				{
					// moving
					_lastOpenedProjects.Add(folder);
					_lastOpenedProjects.RemoveAt(0);
				}
			}
		}
		
		public static string LetterBody
		{
			get { return _letterBody; }
			set { _letterBody = value; }
		}

		public static string LetterSubject 
		{
			get { return _letterSubject; }
			set { _letterSubject = value; }
		}
				
		public static int SmtpPort 
		{
			get { return _smtpPort; }
			set { _smtpPort = value; }
		}

		public static string SmtpHost
		{
			get { return _smtpHost; }
			set { _smtpHost = value; }
		}

		public Settings()
		{
			_installFolder = Directory.GetParent(_binariesFolder).FullName;
			_dataFolder = Path.Combine(
				_installFolder, 
				"data");
			_defaultTemplateFile = Path.Combine(
				_dataFolder, 
				"template.Language");
			string dir = Path.Combine( 
				Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), 
				"BULocalization");
			if (!Directory.Exists(dir))
				Directory.CreateDirectory(dir);
			
			#if DEBUG
			_settingsFile = Path.Combine(dir, "settings-debug.xml");
			_recentProjectsConfigFile = Path.Combine(dir, "recentProjects-debug.txt");
			#else
			_settingsFile = Path.Combine(dir, "settings.xml");
			_recentProjectsConfigFile = Path.Combine(dir, "recentProjects.txt");
			#endif

			for (int i = 0; i < _MaxLastUsedFilesToRemember; i++)
			{
				_lastOpenedProjects.Add(string.Empty);
			}
		}
		
		public void Save()
		{
			XmlWriterSettings settings = new XmlWriterSettings();
			settings.Indent = true;
			settings.Encoding = Encoding.Unicode;
			settings.IndentChars = ("    ");
			XmlWriter writer = null;
			
			try
			{
				writer = XmlWriter.Create(_settingsFile, settings);
				
				if (writer == null)
					throw new InvalidOperationException("Could not open file for writing: " + _settingsFile);
				
				writer.WriteStartElement("BULocalization");
				writer.WriteStartElement("EMail_template");
					writer.WriteElementString("SubjectTemplate", LetterSubject);
					writer.WriteElementString("BodyTemplate", LetterBody);
				writer.WriteEndElement();
				
				writer.WriteStartElement("SMPT_options");
					writer.WriteElementString("SMPTHost", SmtpHost);
					writer.WriteElementString("SMPTPort", SmtpPort.ToString(CultureInfo.CurrentCulture));
				writer.WriteEndElement();
				
				writer.WriteStartElement("Translator");
					writer.WriteElementString("FullName", _name);
					writer.WriteElementString("eMail", _email);
					writer.WriteElementString("Info", _otherContactInformation);
				writer.WriteEndElement();

				writer.WriteEndElement();
				
				writer.Flush();
				
				File.WriteAllLines(_recentProjectsConfigFile, _lastOpenedProjects.ToArray());
			}
			finally
			{
				if (writer != null)
					writer.Close();
			}
		}
		
		
		public void Load()
		{
			XmlReaderSettings settings = new XmlReaderSettings();
			settings.ConformanceLevel = ConformanceLevel.Fragment;
			settings.IgnoreWhitespace = true;
			settings.IgnoreComments = true;
			XmlReader reader = null;

			try
			{
				reader = XmlReader.Create(_settingsFile, settings);
				if (reader == null) 
					throw new InvalidOperationException("Could not open file for reading: " + _settingsFile);
				reader.ReadStartElement("BULocalization");
				reader.ReadStartElement("EMail_template");
					LetterSubject = reader.ReadElementString("SubjectTemplate");
					LetterBody = reader.ReadElementString("BodyTemplate");					
				reader.ReadEndElement();
				reader.ReadStartElement("SMPT_options");
					SmtpHost = reader.ReadElementString("SMPTHost");
					SmtpPort = Int32.Parse(reader.ReadElementString("SMPTPort"), CultureInfo.CurrentCulture);
				reader.ReadEndElement();
				
				reader.ReadStartElement("Translator");
					_name = reader.ReadElementString("FullName");
					_email = reader.ReadElementString("eMail");
					_otherContactInformation = reader.ReadElementString("Info");
				reader.ReadEndElement();

				reader.ReadEndElement();
				
				if (File.Exists(_recentProjectsConfigFile))
				{
					_lastOpenedProjects.Clear();
					_lastOpenedProjects.AddRange(File.ReadAllLines(_recentProjectsConfigFile));
				}
			}
			catch (InvalidOperationException)
			{
				throw;
			}
			catch (Exception e)
			{
				throw new InvalidOperationException("Cannot load settings from file", e);
			}
			finally
			{
				if (reader != null)
					reader.Close();
			}
		}
	}
}