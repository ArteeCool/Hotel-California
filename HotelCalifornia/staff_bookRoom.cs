using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCalifornia
{
    public partial class staff_bookRoom : UserControl
    {
        public staff_bookRoom()
        {
            InitializeComponent();
        }

        private void bookRoom_scheduleNowBtn_Click(object sender, EventArgs e)
        {

        }

        private void bookRoom_BookBtn_Click(object sender, EventArgs e)
        {
            clientInfo clientInfo = new clientInfo();
            clientInfo.ShowDialog();

        }
    }
}
