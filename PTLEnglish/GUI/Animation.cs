using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
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

		/// <summary>
		/// Tăng giảm kích thước theo chiều ngang hoặc dọc
		/// </summary>
		/// <param name="control"></param>
		/// <param name="lengthChange"></param>
		/// <param name="duration"></param>
		/// <param name="direction"></param>
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
								//control.Height -= lengthChange;
								control.Height += lengthChange;
								lengthChange = 0;
								break;
							}
							else if (lengthChange == 0) break;
							//control.Height -= change;
							control.Height += change;
							lengthChange -= change;
						}
						else if (lengthChange < 0)
						{
							if (lengthChange < 0 && change > lengthChange * (-1))
							{
								//control.Height -= lengthChange;
								control.Height += lengthChange;
								lengthChange = 0;
								break;
							}
							else if (lengthChange == 0)
								break;
							//control.Height += change;
							control.Height -= change;
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

		/// <summary>
		/// Di chuyển vị trí 
		/// </summary>
		/// <param name="control"></param>
		/// <param name="newLocation"></param>
		/// <param name="duration"></param>
		public static void Move(Control control, Point newLocation, Duration duration)
		{
			Timer time = new Timer();
			time.Start();
			time.Interval = 100;
			int pointDistance = 50;
			//switch (duration)
			//{
			//	case Duration.Normal:
			//		pointDistance = 100; break;
			//	case Duration.Fast:
			//		pointDistance = 50; break;
			//	default:
			//		pointDistance = 10; break;
			//}

			time.Tick += (sender, e) => MoveTick(sender, e, control, newLocation, pointDistance);
		}

		private static void MoveTick(object sender, EventArgs e, Control control, Point newLocation, int pointDistance)
		{
			int dX = newLocation.X - control.Location.X;
			int dY = newLocation.Y - control.Location.Y;
			if (dX ==0 && dY== 0)
			{
				Timer time = sender as Timer;
				time.Stop();
			}
			else
			{
				control.Location = new Point(control.Location.X + dX, control.Location.Y + dY);
			}
		}
	}
}
