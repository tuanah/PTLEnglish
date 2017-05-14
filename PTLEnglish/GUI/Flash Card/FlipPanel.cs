using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTLEnglish.GUI.Flash_Card
{
    public partial class FlipPanel : Panel
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        public FlipPanel()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();
        }

        /// <summary>
        /// Cần 2 Bitmap để lưu lại 2 bức hình trước và sau: 
        /// </summary>
        private Bitmap bm_A;
        private Bitmap bm_B;

        /// <summary>
        /// Cần 2 Control trước và sau: 
        /// </summary>
        private Control front;
        private Control behind;

        /// <summary>
        /// Bỏ Phần này
        /// </summary>
        private Control h_Front;
        private Control h_Behind;


        /// <summary>
        /// Nếu flip ngang - đối xứng với trục Oy:
        ///  thì cần tọa độ x1 - x2 và biến y giống như góc xoay (cái này dùng hay không dùng cũng được)
        /// </summary>
        private int x1;
        private int x2;
        private float y;

        /// <summary>
        /// Nếu flip dọc - đối xứng với trục Ox:
        ///  thì cần tọa độ y1 - y2 và biến x giống như góc xoay (cái này dùng hay không dùng cũng được)
        /// </summary>
        private int y1;
        private int y2;
        private float x;

        ///<summary>
        /// Cần 1 biến quản lý dùng animation ngang hay dọc:
        ///</summary>
        private bool checkAnimation = true;

        ///<summary>
        /// Cần 1 biến quản lý sự thay đổi các tọa độ:
        ///</summary>
        private int ManageIncreament = 15;
        public int TimerInterval
        {
            get { return timer1.Interval; }
            set { timer1.Interval = value; }
        }

        #region Các hàm get - set:
        public Control Front
        {
            get { return front; }
            set { Controls.Add(value); front = value; }
        }
        public Control Behind
        {
            get { return behind; }
            set { Controls.Add(value); behind = value; }
        }

        public bool CheckAnimation { get => checkAnimation; set => checkAnimation = value; }
        public Control H_Front
        {
            get { return h_Front; }
            set { Controls.Add(value); h_Front = value; }
        }
        public Control H_Behind
        {
            get { return h_Behind; }
            set { Controls.Add(value); h_Behind = value; }
        }

        #endregion

        // Hàm lật: -> dùng bên ngoài chương trình:
        public void Flip()
        {
            CreateFlip();
            timer1.Enabled = true;
        }

        // Khởi tạo flip:
        void CreateFlip()
        {

            // Khởi tạo 2 Bitmap có độ dài bằng với Panel được khởi tạo:
            bm_A = new Bitmap(Width, Height);
            bm_B = new Bitmap(Width, Height);

            if (CheckAnimation)
            {
                y1 = 0;
                y2 = Height;
                x = 0;
                // Vẽ 2 control vào Bitmap:
                Front.DrawToBitmap(bm_A, new Rectangle(Front.Location, Front.Size));
                Behind.DrawToBitmap(bm_B, new Rectangle(Behind.Location, Behind.Size));
                bm_B.RotateFlip(RotateFlipType.RotateNoneFlipY);

                // Ẩn 2 control:
                Front.Visible = false;
                Behind.Visible = false;
            }
            else
            {
                x1 = 0;
                x2 = Width;
                y = 0;
                // Vẽ 2 control vào Bitmap:
                Front.DrawToBitmap(bm_A, new Rectangle(Front.Location, Front.Size));
                Behind.DrawToBitmap(bm_B, new Rectangle(Behind.Location, Behind.Size));
                bm_B.RotateFlip(RotateFlipType.RotateNoneFlipX);

                // Ẩn 2 control:
                Behind.Visible = false;
                Front.Visible = false;
 
            }
        }

        // Overdrive Hàm OnPaint 
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Mới đầu khởi tạo chương trình thì bm_A và bm_B chưa có:
            if (bm_A == null || bm_B == null)
                return;
            // StartFlipping(ref e);

            // Bật tính năng vẽ không có răng cưa:
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            if (CheckAnimation)
            {
                // Tạo 1 mảng gồm có tọa độ để định nghĩa 1 hình bình hành:            
                PointF[] _Point = { new Point(0,y1),
                                new Point(Width, y1),
                                new PointF(x, y2)

                              };
                /// <summary>
                /// Nếu y1 nhỏ hơn height/2 thì sẽ vẽ lại hình trong Bitmap A
                /// Ngược lại vẽ hình trong Bitmap B
                /// </summary>           
                if (y1 < Height / 2)
                {
                    e.Graphics.DrawImage(bm_A, _Point);
                    //x += 0.5f;

                }
                else
                {
                    e.Graphics.DrawImage(bm_B, _Point);
                    //x -= 0.5f;

                }

                // Dùng biến ManageIncreament để dịch chuyển tạo độ qua lại:
                y1 += ManageIncreament;
                y2 -= ManageIncreament;

                if (y2 < -1)
                {
                    timer1.Enabled = false;
                    Swap();
                    ResetFlip();

                    Front.Visible = true;
                    Behind.Visible = false;

                }

            }
            else
            {
                // Tạo 1 mảng gồm có tọa độ để định nghĩa 1 hình bình hành:
                PointF[] _Point1 = { new Point(x1, 0),
                                        new PointF(x2, y),
                                        new Point(x1, Height)
                                      };
                /// <summary>
                /// Nếu x nhỏ hơn width/2 thì sẽ vẽ lại hình trong Bitmap A
                /// Ngược lại vẽ hình trong Bitmap B
                /// </summary>           
                if (x1 < Width / 2)
                {
                    e.Graphics.DrawImage(bm_A, _Point1);
                    //  y += 0.5f;
                }
                else
                {
                    e.Graphics.DrawImage(bm_B, _Point1);
                    // y -= 0.5f;
                }

                // Dùng biến ManageIncreament để dịch chuyển tạo độ qua lại:
                x1 += ManageIncreament;
                x2 -= ManageIncreament;

                if (x2 < -1)
                {
                    timer1.Enabled = false;
                    Swap();
                    ResetFlip();

                    Front.Visible = true;
                    Behind.Visible = false;

                }
            }
        }
        // Hàm đổi chỗ 2 control:
        void Swap()
        {
                Control Temp = Front;
                Front = Behind;
                Behind = Temp;
          
        }

        // Tạo lại các tọa độ: 
        void ResetFlip()
        {
            if (CheckAnimation)
            {
                // Chỉnh lại tọa độ của các biến x1,x2,y để vẽ lại 1 lần nữa cho đúng tọa độ ban đầu:
                // Do luc vẽ nó bị lệch 1 ít.
                y1 = 0;
                y2 = Height;
                x = 0;
            }
            else
            {
                x1 = 0;
                x2 = Width;
                y = 0;
            }


        }
        private void timer_Tick(object sender, EventArgs e)
        {
            // Hàm này có tác dụng vẽ lại
            Invalidate();
        }

    }
}
