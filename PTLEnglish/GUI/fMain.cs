using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTLEnglish.DAL;
using System.Reflection;

namespace PTLEnglish.GUI
{
	public partial class fMain : Form
	{
		/// <summary>
		/// Danh sách các Courses trên pnl bên trái màn hình
		/// </summary>
		public FlowLayoutPanel[] ListCourses = new FlowLayoutPanel[Cons.CourseDir.Length * 2];

		/// <summary>
		/// Tập hợp các hình lục giác bên phải màn hình
		/// </summary>
		public List<List<Hexagon>> HexagonGrid;

		public static fMain Current;

		public fMain()
		{
			Current = this;
			InitializeComponent();
			
			typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnl_Grid, new object[] { true });
			typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnl_SideBar, new object[] { true });
		}

		#region fMain
		private void fMain_Load(object sender, EventArgs e)
		{
			lbl_Name.Text = User.UserName;
			#region Set Rounded Border for pic_Avatar
			CirclePictureBox pic_Avatar = new CirclePictureBox();
			try
			{
				pic_Avatar.Image = Image.FromFile(User.UserAvaPath);
			}
			catch
			{
				pic_Avatar.Image = global::PTLEnglish.Properties.Resources.avatar_default;
			}

			pic_Avatar.Location = new Point(22, 6);
			pic_Avatar.Size = new Size(100, 100);
			pic_Avatar.SizeMode = PictureBoxSizeMode.Zoom;
			pnl_Info_Content.Controls.Add(pic_Avatar);
			pic_Avatar.Click += Pic_Avatar_Click;
			#endregion

			#region Hide ScrollBar
			fpnl_Course_Content.AutoScroll = false;
			fpnl_Course_Content.HorizontalScroll.Enabled = false;
			fpnl_Course_Content.HorizontalScroll.Visible = false;
			fpnl_Course_Content.HorizontalScroll.Maximum = 0;

			fpnl_Course_Content.VerticalScroll.Enabled = false;
			fpnl_Course_Content.VerticalScroll.Visible = false;
			fpnl_Course_Content.VerticalScroll.Maximum = 0;
			fpnl_Course_Content.AutoScroll = true;
			#endregion

			for (int i = 0; i < ListCourses.Length; i++)
			{
				//Tạo dannh sách các course và hiển thị.
				//Là môt cái list FlowLayoutPanel với i chẳn là tên course và i + 1 là list các Topic
				ListCourses[i] = new FlowLayoutPanel();
				for (int j = 0; j < Cons.CourseDir[i / 2].GetDirectories().Length; j++)
				{
					Label lbl = new Label();
					lbl.Name = (i / 2).ToString();
					lbl.ForeColor = SystemColors.ButtonFace;
					lbl.Font = new Font("Microsoft Yahei Light", 14F);
					lbl.AutoSize = false;
					lbl.TextAlign = ContentAlignment.MiddleLeft;
					lbl.Margin = new Padding(20, 0, 0, 0);
					lbl.Size = new Size(fpnl_Course_Content.Width - lbl.Margin.Left, 35);
					//Biến tag dùng để xác định cái flowLayoutPanel chứ các Topic
					lbl.Tag = i + 1;

					lbl.MouseEnter += LblCourse_Enter;
					lbl.MouseLeave += LblCourse_Leave;

					if (i % 2 == 0)
					{
						lbl.Text = Cons.CourseDir[i / 2].Name;
						ListCourses[i].Controls.Add(lbl);
						lbl.Click += Course_Clk;
						break;
					}
					else
					{
						lbl.Text = Cons.CourseDir[i / 2].GetDirectories()[j].Name;
						lbl.Margin = new Padding(40, 0, 0, 0);
						lbl.Click += Topic_Clk;
						ListCourses[i].Controls.Add(lbl);
					}
				}

				if (i % 2 != 0)
				{
					ListCourses[i].Visible = false;
				}

				//Set maxsize cho ListCourses[i] bằng số lượng phần tử * Height của mỗi phần tử
				ListCourses[i].MaximumSize = new Size(ListCourses[i].Width, ListCourses[i].Controls.Count * 35);
				//Set maxsize cho ListCourses[i] bằng Height của 1 phần tử
				ListCourses[i].MinimumSize = new Size(ListCourses[i].Width, 35);

				ListCourses[i].Margin = new Padding(0);
				ListCourses[i].Size = new Size(ListCourses[i].Width, 35);
				fpnl_Course_Content.Controls.Add(ListCourses[i]);
			}
			DrawHexagons(pnl_Grid);
			LoadTextToHexagon(sender, true);
		}

		private void fMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		#endregion

		#region Method for pnl_SideBar

		#region pnl_Info
		private void pnlInfo_Click(object sender, EventArgs e)
		{
			//Set các animation khi Click vào chữ Infomation
			if (pnl_SideBar.Width == 50)
				return;
			if (pnl_Info_Content.Height == 0)
			{
				//Show ra cái hình với tên
				Animation.Transition(pnl_Info_Content, 140, Animation.Duration.Fast, Animation.Direction.Horizontal);
				//Di chuyển cái khung Course
				Animation.Move(pnl_Course_Block, new Point(pnl_Course_Block.Location.X, pnl_Course_Block.Location.Y + 140), Animation.Duration.Normal);
				
				Animation.Transition(pnl_Course_Block, -140, Animation.Duration.Fast, Animation.Direction.Horizontal);
			}
			else
			{
				//Ẩn đi cái hình với tên
				Animation.Transition(pnl_Info_Content, -140, Animation.Duration.Fast, Animation.Direction.Horizontal);
				Animation.Move(pnl_Course_Block, new Point(pnl_Course_Block.Location.X, pnl_Course_Block.Location.Y - 140), Animation.Duration.Normal);
				Animation.Transition(pnl_Course_Block, 140, Animation.Duration.Fast, Animation.Direction.Horizontal);
			}
		}

		private void picAccount_MouseEnter(object sender, EventArgs e)
		{
			pnl_Info.BackColor = Cons.ColorHov;
			pic_Account.Image = global::PTLEnglish.Properties.Resources.account_icon;
			lbl_lnfo.ForeColor = Cons.ColorGray;
		}

		private void picAccount_MouseLeave(object sender, EventArgs e)
		{
			pnl_Info.BackColor = Color.Transparent;
			pic_Account.Image = global::PTLEnglish.Properties.Resources.account_def;
			lbl_lnfo.ForeColor = SystemColors.ButtonFace;
		}
		#endregion

		#region pnl_Info_Content
		/// <summary>
		/// Chọn hình
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Pic_Avatar_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "JPG (*.jpg)|*.jpg| PNG (*.png)|*.png";
			if (open.ShowDialog() == DialogResult.OK)
			{
				CirclePictureBox cp = sender as CirclePictureBox;
				cp.Image = Image.FromFile(open.FileName);
				User.UserAvaPath = open.FileName;
			}
		}

		private void picRenameBtn_Click(object sender, EventArgs e)
		{
			txt_Rename.Text = "";
			txt_Rename.Visible = true;
			txt_Rename.Focus();
		}

		private bool TestKeyValid(char keyPress)
		{
			if ((keyPress >= '1' && keyPress <= '9') ||
				(keyPress >= 'a' && keyPress <= 'z') ||
				(keyPress >= 'A' && keyPress <= 'Z') ||
				keyPress == (char)Keys.Back ||
				keyPress == (char)Keys.Enter)
			{
				return true;
			}
			return false;
		}

		/// <summary>
		/// hàm sửa tên
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtRename_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (TestKeyValid(e.KeyChar) && txt_Rename.Text.Length <= 8)
			{
				if (e.KeyChar == (char)Keys.Enter)
				{
					if (txt_Rename.Text != "")
					{
						User.UserName = txt_Rename.Text;
						lbl_Name.Text = txt_Rename.Text;
					}

					txt_Rename.Visible = false;
				}
			}
			else if (e.KeyChar == (char)Keys.Back && txt_Rename.Text != "")
				txt_Rename.Text = txt_Rename.Text.Remove(txt_Rename.Text.Length - 1, 1);
			else e.Handled = true;
		}
		#endregion

		#region pnl_Course

		private void pnl_Course_Click(object sender, EventArgs e)
		{
			//Manage.ThisCourse = "Source";
			DrawHexagons(pnl_Grid);
			LoadTextToHexagon(sender);

			//Ẩn đi cái Topic List đã hiện
			for (int i = 0; i < ListCourses.Length; i++)
			{
				if (i % 2 != 0)
				{
					if (ListCourses[i].Visible)
					{
						Animation.Transition(ListCourses[i], -ListCourses[i].Height, Animation.Duration.Fast, Animation.Direction.Horizontal);
						ListCourses[i].Visible = false;
						break; //Vì chỉ có duy nhất một cái hiện nên Break cho đỡ tốn thời gian
					}
				}
			}

		}

		private void picCourse_MouseEnter(object sender, EventArgs e)
		{
			pnl_Course.BackColor = Cons.ColorHov;
			pic_Course.Image = global::PTLEnglish.Properties.Resources.course;
			lbl_Course.ForeColor = Cons.ColorGray;
		}

		private void picCourse_MouseLeave(object sender, EventArgs e)
		{
			pnl_Course.BackColor = Color.Transparent;
			pic_Course.Image = global::PTLEnglish.Properties.Resources.course_def;
			lbl_Course.ForeColor = SystemColors.ButtonFace;
		}
		#endregion

		#region fpnl_Course_Content
		private void LblCourse_Leave(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			lbl.BackColor = Color.Transparent;
			lbl.ForeColor = SystemColors.ButtonFace;
		}

		private void LblCourse_Enter(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			lbl.BackColor = Cons.ColorHov;
			lbl.ForeColor = Cons.ColorGray;
		}

		private void Course_Clk(object sender, EventArgs e)
		{

			Label lbl = sender as Label;
			// Hiển thị và ẩn những cái tên khóa học 
			if(ListCourses[(int)(lbl.Tag)].Height == 35 )
			{
				ListCourses[(int)(lbl.Tag)].Visible = true;
				Animation.Transition(ListCourses[(int)(lbl.Tag)], ListCourses[(int)(lbl.Tag)].MaximumSize.Height, Animation.Duration.Fast, Animation.Direction.Horizontal);
			}
			else
			{
				ListCourses[(int)(lbl.Tag)].Size = new Size(ListCourses[(int)(lbl.Tag)].Width, 35);
				ListCourses[(int)(lbl.Tag)].Visible = false;
			}

			for (int i = 0; i < ListCourses.Length; i++)
			{
				if (i % 2 != 0 && i != (int)lbl.Tag)
				{
					if(ListCourses[i].Visible)
					{
						Animation.Transition(ListCourses[i], -ListCourses[i].Height, Animation.Duration.Fast, Animation.Direction.Horizontal);
						ListCourses[i].Visible = false;
						break;
					}
				}
			}

			Manage.ThisCourse ="Source\\" + lbl.Text;
			DrawHexagons(pnl_Grid);
			LoadTextToHexagon(sender);
		}

		private void Topic_Clk(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			Manage.ThisTopic= "\\"+ lbl.Text;
			fSub f = new fSub();
			this.Hide();
			f.ShowDialog();
		}


		#endregion
		#endregion

		#region Method for pnl_Content
		#region pnl_Panel
		private void lbl_Close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void lbl_Close_MouseEnter(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			lbl.BackColor = Color.DarkRed;
			lbl.ForeColor = SystemColors.ButtonFace;
		}

		private void lbl_Close_MouseLeave(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			lbl.BackColor = Color.Transparent;
			lbl.ForeColor = Color.Black;

		}

		private void lbl_Minimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void lbl_Minimize_MouseEnter(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			lbl.BackColor = Color.LightGray;
		}

		private void lbl_Minimize_MouseLeave(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			lbl.BackColor = Color.Transparent;
		}
		#endregion

		/// <summary>
		/// Vẽ hình tổ ông lên Control
		/// </summary>
		/// <param name="control"></param>
		private void DrawHexagons(Control control)
		{
			//----- Ý tưởng 
			//Khởi tạo 1 List 2 chiều chứa các hình
			//Tạo các hình theo thứ tự duyệt là vẽ theo hình dọc
			control.Controls.Clear();
			int move = 0;
			Point pointStart;
			Hexagon hexagon;
			HexagonGrid = new List<List<Hexagon>>();
			
			for (int i = 0; i < Cons.numOfCol; i++)
			{
				HexagonGrid.Add(new List<Hexagon>());
				// Set vị trí đầu tiên so le giữa các hàng với nhau
				if (i % 2 == 0)
				{
					pointStart = new Point(10 + move, 10);
				}
				else
				{
					pointStart = new Point(10 + move, Cons.Size / 2 + 1);
				}
				move += Cons.Size - 30;

				for (int j = 0; j < Cons.numOfRow; j++)
				{
					hexagon = new Hexagon();
					if (j == 0)
					{
						//Nếu nó là phần tử đầu tiên của cái cột, thì set vị trí nó bằng pointStart
						hexagon.Location = pointStart;
					}
					else
					{
						//Ngược lại thì vị trí được tính toán dựa trên vị trí của cái Hexagon phía trên
						hexagon.Location = new Point(HexagonGrid[i][j - 1].Location.X, HexagonGrid[i][j - 1].Location.Y + Cons.Size - 15);
					}
					HexagonGrid[i].Add(hexagon);
					control.Controls.Add(HexagonGrid[i][j]);
				}
			}
		}
		/// <summary>
		/// Load các tên Topic hay Course vào trong hình lục giác
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="Load"></param>
		private void LoadTextToHexagon(object sender, bool Load = false)
		{
			//---- Ý tưởng
			// Biến Load là để kiểm tra xem hàm này đươc gọi ở hàm fMain.Load hay không
			// List iRandom chứa lần lượt các giá trị từ 0 -> Cons.numOfRow*Cons.numOfCol đùng để tính toán vị trí random
			//		của cái Hexagon từ mảng 1 chiều
			//
			//Kiểm tra xem Hàm này được gọi ở đâu, nếu được Click từ chữ Course hoặc khi Load fMain thì sẽ Load tên các
			//	chủ đề lớn vào các hình lục giác
			//Ngược lại sẽ Load tên các Topic nhỏ trong chủ đề lớn vào hình lục giác
			Label lbl = new Label();
			int ran;
			int row, col;
			Label text;
			List<int> iRandom = new List<int>();

			if (!Load)
			{
				lbl = sender as Label;
			}

			for (int i = 0; i < Cons.numOfRow*Cons.numOfCol; i++)
			{
				iRandom.Add(i);
			}
			//Nếu được gọi từ khi Load hoặc Click vào chữ Course thì sẽ load các Course Name vào Hexagon
			if (lbl.Name == "lbl_Course" || Load)
			{
				for (int i = 0; i < Cons.CourseDir.Length; i++)
				{
					text = new Label();
					text.Text = Cons.CourseDir[i].Name;

					ran = Cons.rand.Next(iRandom.Count -1);
					row = iRandom[ran] % Cons.numOfRow;
					col = iRandom[ran] / Cons.numOfRow;

					iRandom.RemoveAt(ran);
					HexagonGrid[col][row].Text = text.Text;
					HexagonGrid[col][row].Cursor = Cursors.Hand;
					//Load các TopicName vào Hexagon khi Click vào Hexagon
					HexagonGrid[col][row].Click += Hexagon_Clk;
				}
			}
			else
			{
				//Ngược lại Load các Topic Name trong Course vào Hexagon chỉ khi Click vào các lable
				int k = int.Parse(lbl.Name);
				for (int i = 0; i < Cons.CourseDir[k].GetDirectories().Length; i++)
				{
					text = new Label();
					text.Text = Cons.CourseDir[k].GetDirectories()[i].Name;

					ran = Cons.rand.Next(iRandom.Count-1);
					row = iRandom[ran] % Cons.numOfRow;
					col = iRandom[ran] / Cons.numOfRow;
					iRandom.RemoveAt(ran);

					HexagonGrid[col][row].Text = text.Text;
					HexagonGrid[col][row].Cursor = Cursors.Hand;
					HexagonGrid[col][row].Click += HexClkShowNewForm;
				}
			}

		}

		private void HexClkShowNewForm(object sender, EventArgs e)
		{
			Topic_Clk(sender, e);
		}

		private void Hexagon_Clk(object sender, EventArgs e)
		{
			//---- Hàm để Gán tên của các Topic Name vào Hexagon
			//---------Ý tưởng 
			//Đầu tiên sẽ lấy thứ tự của cái Course trong mảng CourseDir
			//Sau đó tạo List iRandom chứa lần lượt các giá trị từ 0 -> Cons.numOfRow*Cons.numOfCol đùng để tính toán vị 
			//	trí random của cái Hexagon từ mảng 1 chiều
			//Load từng Topic Name vào vị trí random của hexagon

			Hexagon hexa = sender as Hexagon;
			Label text;
			int ran, i, row, col;
			List<int> iRandom = new List<int>();

			//Gán giá trị lại đề phòng trường hợp Click nhiều lần
			Manage.ThisCourse = "Source\\"+ hexa.Text;

			for (i = 0; i < Cons.CourseDir.Length; i++)
			{
				if(Cons.CourseDir[i].Name == hexa.Text)
					break;
			}

			DrawHexagons(pnl_Grid);
			for (int j = 0; j < Cons.numOfRow * Cons.numOfCol; j++)
			{
				iRandom.Add(j);
			}

			//Load từng Topic Name vào vị trí random của hexagon
			for (int j = 0; j < Cons.CourseDir[i].GetDirectories().Length; j++)
			{
				text = new Label();
				text.Text = Cons.CourseDir[i].GetDirectories()[j].Name;

				ran = Cons.rand.Next(iRandom.Count - 1);
				row = iRandom[ran] % Cons.numOfRow;
				col = iRandom[ran] / Cons.numOfRow;
				iRandom.RemoveAt(ran);

				HexagonGrid[col][row].Text = text.Text;
				HexagonGrid[col][row].Cursor = Cursors.Hand;
				HexagonGrid[col][row].Click += HexClkShowNewForm;
			}
		}

		#endregion
	}
}
