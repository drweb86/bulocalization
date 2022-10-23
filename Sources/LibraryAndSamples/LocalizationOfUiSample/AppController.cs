using System;
using System.Collections.Generic;
using System.Text;
using BULocalization;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.IO;

namespace TestUi
{
    internal class AppController
    {
        private readonly LanguagesManager _localsManager;

        public LanguagesManager LocalizationManager
        {
            get { return _localsManager; }
        }

        public AppController()
        {
            ManagerBehaviorSettings settings = new ManagerBehaviorSettings();
            settings.RequestLanguageIfNotSpecified = true;
            settings.UseToolGeneratedConfigFile = false;

            _localsManager = new LanguagesManager
                (new ReadOnlyCollection<string>(new string[] { "program" }),
            	 Path.Combine(Application.StartupPath, "locals"),
                 "Sample of Localization of Ui",
                 settings);
        }
    }
}
