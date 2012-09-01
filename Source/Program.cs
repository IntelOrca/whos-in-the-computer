////////////////////////////////////
// Who's in the Computer          //
// Copyright (C) Ted John 2012    //
// http://intelorca.co.uk         //
////////////////////////////////////

using System;
using System.Drawing;
using System.Windows.Forms;

namespace IntelOrca.WITC
{
	static class Program
	{
		public static string AppName = "Who's in the Computer";
		public static string AppVersion = "v3.0";
		public static string AppCopyright = "Copyright Ted John 2008 - 2012";
		public static string AppWebsite = "http://intelorca.co.uk";

		public static Settings Settings = new Settings();
		public static CardBank CardBank = new CardBank();
		public static Game Game = new Game();

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Settings.Load();
			CardBank.Load();
			// CardBank.CheckForDuplicates();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (GameWizard.Run())
				Application.Run(new MainForm());
		}

		public static Icon AppIcon
		{
			get
			{
				return IntelOrca.WITC.Properties.Resources.orca_icon;
			}
		}
	}
}
