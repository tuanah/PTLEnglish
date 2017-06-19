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
    public partial class uctrlProgressBar : UserControl
    {
        string filePath;
        public uctrlProgressBar(string FilePath)
        {
            InitializeComponent();
            filePath = FilePath;
            //-------------------------------
            Manage.TopicData = (Topic)Manage.DeserializeFromXML(Cons.Path + Manage.ThisTopic + ".xml");
            //Hiện ra tiến độ đã học được của của phần listen:          
            if (Manage.TopicData.Listen.Progress != -1)
            {
                pnCorrectRun.Width = Manage.TopicData.Listen.CorrectWords * 21; ;
                pnWrongRun.Width = Manage.TopicData.Listen.WrongWords * 21;
                int count = Manage.TopicData.Listen.Progress - 1;
                if (Manage.TopicData.Listen.FirstTimeOfWord)
                    pnProgressRun.Width = (count + 2) * 21;
                else
                    pnProgressRun.Width = (count + 1) * 21;
            }
        }

        public async Task IncreasingProgress()
        {

            // Tăng giá trị của progressRun - từ học được:
            int temp =  pnProgressRun.Width + 21;

            while (pnProgressRun.Width < temp)
            {
                await Task.Delay(1);
                pnProgressRun.Width += 1;
            }
        }

        public async Task IncreasingCorrect()
        {
            int temp = pnCorrectRun.Width + 21;
            while (pnCorrectRun.Width < temp)
            {
                await Task.Delay(1);
                pnCorrectRun.Width += 1;
            }
        }


        public async Task IncreasingWrong()
        {
            int temp = pnWrongRun.Width + 21;
            while (pnWrongRun.Width < temp)
            {
                await Task.Delay(1);
                pnWrongRun.Width += 1;
            }
        }

        private void uctrlProgressBar_Load(object sender, EventArgs e)
        {
            
        }
    }
}
