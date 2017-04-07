using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTLEnglish.GUI
{
	public static class Animation
	{
		public enum Direction
		{
			Vertical,
			Horizontal
		}
		public enum Duration
		{
			Normal,
			Fast,
			Immediately
		}
		public static void Transition(Control control, int lengthChange, Duration duration, Direction direction)
		{

			Timer time = new Timer();
			time.Start();
			int change = 10;
			switch (duration)
			{
				case Duration.Normal:
					change = 5;
					time.Interval = 20;
					break;
				case Duration.Fast:
					change = 10;
					time.Interval = 1;
					break;
				default:
					change = (int)(lengthChange / 4);
					time.Interval = 1;
					break;
			}
			if (change < 0) change *= -1;
			time.Tick += (sender, e) => TransitionTick(sender, e, control, direction, change, ref lengthChange);
		}

		private static void TransitionTick(object sender, EventArgs e, Control control, Direction direction, int change, ref int lengthChange)
		{
			if (lengthChange != 0)
			{
				switch (direction)
				{
					case Direction.Vertical:
						if (lengthChange > 0)
						{
							if (lengthChange > 0 && lengthChange < change)
							{
								control.Width += lengthChange;
								lengthChange = 0;
								break;
							}
							else if (lengthChange == 0) break;
							control.Width += change;
							lengthChange -= change;
						}
						else if (lengthChange < 0)
						{
							if (lengthChange < 0 && change > lengthChange * (-1))
							{
								control.Width += lengthChange;
								lengthChange = 0;
								break;
							}
							else if (lengthChange == 0)
								break;
							control.Width -= change;
							lengthChange += change;
						}
						break;
					default:
						if (lengthChange > 0)
						{
							if (lengthChange > 0 && lengthChange < change)
							{
								control.Height -= lengthChange;
								lengthChange = 0;
								break;
							}
							else if (lengthChange == 0) break;
							control.Height -= change;
							lengthChange -= change;
						}
						else if (lengthChange < 0)
						{
							if (lengthChange < 0 && change > lengthChange * (-1))
							{
								control.Height -= lengthChange;
								lengthChange = 0;
								break;
							}
							else if (lengthChange == 0)
								break;
							control.Height += change;
							lengthChange += change;
						}
						break;
				}
			}
			else
			{
				Timer time = sender as Timer;
				time.Stop();
			}

		}

	}
}
