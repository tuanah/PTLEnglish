﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTLEnglish.GUI;
using PTLEnglish.DAL;

namespace PTLEnglish
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Cons.LoadDir();
			User.Init();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new Form1());
			//Application.Run(new Login());
			Application.Run(new fMain());
			User.Save();
		}
	}
}