using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PTLEnglish.GUI
{
	public partial class Hexagon : Label
	{
		public Hexagon()
		{
			InitializeComponent();
			this.Size = new Size(Cons.Size, Cons.Size);
			this.Font = new Font("Microsoft Yahei Light", 25F);
			this.TextAlign = ContentAlignment.MiddleCenter;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
			e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
			e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

			LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Orange, Color.Chocolate, 130);
			using (GraphicsPath gp = new GraphicsPath())
			{
				AddHexagon(gp, new Size(this.Size.Width - 2, Size.Height - 2));
				e.Graphics.FillPath(brush, gp);
			}
			using (GraphicsPath gp = new GraphicsPath())
			{
				AddHexagon(gp, this.Size);
				this.Region = new Region(gp);
			}
			AutoFontSize();
			base.OnPaint(e);
		}

		private void AddHexagon(GraphicsPath gp, Size size)
		{
			var x_0 = size.Width / 2;
			var y_0 = size.Height / 2;
			var r = size.Width / 2 - 1;

			var shape = new PointF[6];
			//create 6 points
			for (int a = 0; a < 6; a++)
			{
				shape[a] = new PointF(
					x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
					y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
			}

			gp.AddPolygon(shape);
		}

		private void AutoFontSize()
		{
			SizeF stringSize = new SizeF();
			//Get Size của tất cả các chữ
			stringSize = TextRenderer.MeasureText(this.Text, this.Font);
			while (stringSize.Width > this.Width - 10)
			{
				float emSize = this.Font.Size;
				emSize--;
				this.Font = new Font(this.Font.Name, emSize);
				stringSize = TextRenderer.MeasureText(this.Text, this.Font);
			}
		}
	}
}
