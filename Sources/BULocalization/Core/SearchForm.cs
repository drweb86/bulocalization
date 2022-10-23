using System;
using System.Windows.Forms;

namespace BULocalization.Core
{
	public delegate string Search(string pattern);
	
	public partial class SearchForm : Form
	{
		private const string _NothingMatchesSearchConditions = "Nothing found matching search conditions...";

		private bool _allowClose;
		private Search _searchDelegate;
		
		public bool AllowClose
		{
			set { _allowClose = value; }
			get { return _allowClose; }
		}
		
		public void Execute()
		{
			this.Show();
			this.Activate();
			this.Focus();
			textToSearchTextBox.Focus();
			textToSearchTextBox.SelectAll();
		}

		public SearchForm(Search searchDelegate)
		{
			if (searchDelegate == null)
				throw new ArgumentNullException("searchDelegate");
			
			_searchDelegate = searchDelegate;
			
			InitializeComponent();
		}
		
		private void SearchbuttonClick(object sender, EventArgs e)
		{
			string result = _searchDelegate(textToSearchTextBox.Text);
			if (string.IsNullOrEmpty(result))
			{
				resultsTextBox.Text = _NothingMatchesSearchConditions;
			}
			else
			{
				resultsTextBox.Text = result;
			}
		}
		
		private void ClosebuttonClick(object sender, EventArgs e)
		{
			Hide();
		}
		
		private void SearchFormFormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = !_allowClose;
			Hide();
		}
	}
}
