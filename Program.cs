using System;
using System.Windows.Forms;

namespace Client
{

	static class Program
	{
		internal const string BASE_URL = "http://188.166.241.34/soa/uetlib/api";

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormSignIn());
		}
	}
}
