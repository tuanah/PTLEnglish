using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTLEnglish.GUI
{
	public partial class RoundBtn : UserControl
	{
		public RoundBtn()
		{
			InitializeComponent();
		}

		public override string Text { get => lbl.Text; set => lbl.Text = value; }
	}
}
