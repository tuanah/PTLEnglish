using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Drawing;

namespace PTLEnglish.GUI
{
	//Class này khắc phục lỗi cho phần comments ở Login_Load();
	public static class myFonts
	{
		private static PrivateFontCollection pfc = new PrivateFontCollection();
		public static FontFamily f;
		public static void LoadFonts()
		{
			pfc.AddFontFile("Daisy's_Delights.ttf");
			f = pfc.Families[0];
		}
	}
}
