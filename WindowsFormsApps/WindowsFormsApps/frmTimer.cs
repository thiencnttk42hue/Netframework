using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApps
{
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();

        }
        //Hàm này sẽ chạy sao 1ooo ms
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSeccond == 0)
            {
                timer1.Stop();
            }
            else
            {
                totalSeccond--;
                lblTimer.Text = $"{totalSeccond / 60: #00}:{totalSeccond % 60:#00}"; //:#00 định dạng k cho đồng hồ thụt ra vô

            }
        }
        int totalSeccond = 0;
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            var minute = (int)numTimer.Value;
            totalSeccond = minute * 60;
            timer1.Start();
        }

       
    }
}

