using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTLEnglish.DAL;

namespace PTLEnglish.GUI.Listen
{
    public partial class uctrlMain : UserControl
    {
        // Hàm lấy hàm từ form khác
        // Lưu ý form này trong form khác phải dc khởi tạo r
        public object GetControl
        {
            set;
            get;
        }
        
        public uctrlMain()
        {            
            InitializeComponent();
            Manage.ThisCourse = "Source\\Economic";
            Manage.ThisTopic = "\\Job";
            string filePath = Cons.Path + "\\" + Manage.TopicData.TopicName + ".xml";

            //---------------------------------------------
            uctrlProgressBar _Progress = new uctrlProgressBar(filePath);
            //uctrlListen1 u1 = new uctrlListen1(filePath);
            //uctrlListen1.fpnMain = fpnMain;
            //uctrlListen2 u2 = new uctrlListen2(filePath);
            //uctrlListen2.fpnMain = fpnMain;
            //u2.GetControlClick = this;
            //u2.GetControlProgressbar = _Progress;
            //u1.GetControlClick = this;
            //u1.GetControlProgressbar=_Progress;

            //pnMainListen.Controls.Add(u1);

            uctrlListen3 u3 = new uctrlListen3(filePath);
            uctrlListen3.fpnMain = fpnMain;
            u3.GetControlClick = this;
            u3.GetControlProgressbar = _Progress;
            pnProgress.Controls.Add(_Progress);
            pnMainListen.Controls.Add(u3);
            u3.Location = new Point(79, 92);
        }
    }
}
