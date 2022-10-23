/*

This sample demonstrates usage of translation without
forms and can be used in

- service based applications
- console applications

Sample demonstrates getting translation info from translation
and entering data

*/

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Forms;

namespace BULocalization.Test
{
	class Program
	{
		public static void Main(string[] args)
		{
			// here you can also try "Russian"
			string languageSetting = "default";
			string localsPath = Path.Combine(Application.StartupPath, "locals");
			Translation translation = new Translation();
			List<string> namespacesToLoad = new List<string>();
			namespacesToLoad.Add("program");
			
			try
			{
				translation.Load(
					Path.Combine(localsPath, languageSetting + ".Language"),
					new ReadOnlyCollection<string>(namespacesToLoad));
			}
			catch(LocalizationGenericException e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine(e.Details);
				return;
			}

			Console.WriteLine("Current ranslation information:");
			Console.WriteLine("========================");
			Console.WriteLine("Copyright {0}", translation.Copyright );
			Console.WriteLine("Author Email {0}", translation.Email );
			Console.WriteLine("Author name {0}", translation.Author );
			Console.WriteLine("========================\n\n");
			Console.WriteLine("Translation usage sample:");
			Console.WriteLine("========================");			
			Console.WriteLine(translation[1]);
			string name = Console.ReadLine();
			Console.WriteLine(translation[2], name);
			Console.WriteLine("========================\n\n");			
			Console.Write("Press any key to quit . . . ");
			Console.ReadKey(true);
		}
	}
}
