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
	public partial class RoundBtn : Label
	{
		public RoundBtn()
		{
			InitializeComponent();
			this.BackgroundImage = global::PTLEnglish.Properties.Resources.frame;
		}
		[Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
	 DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public override Image BackgroundImage { get => base.BackgroundImage; set => base.BackgroundImage = value; }

	}
}
