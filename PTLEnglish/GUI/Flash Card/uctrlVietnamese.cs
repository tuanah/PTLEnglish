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

namespace PTLEnglish.GUI.Flash_Card
{
    public partial class uctrlVietnamese : UserControl
    {
        public uctrlVietnamese(int index)
        {
            InitializeComponent();
            uctrlFlashCard.pnVietnamese = pnVietnamese;
            uctrlMainFlashCard.pnVietnamese = pnVietnamese;
            Load(index);
        }

        void Load(int index)
        {
            lbVietnamese.Text = Manage.TopicData.WordList[index].Mean;
            

        }
    }
}
