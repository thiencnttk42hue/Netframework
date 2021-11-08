using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemNguocTet
{
    public partial class frmDemNguocTet : Form
    {
        
        int flag = 1;
        public frmDemNguocTet()
        {
            InitializeComponent();
            
            if (flag == 1)
                picPhaoHoa.Visible = false;
            lblTet.Visible = false;
            lblDungTet.Visible = true;
            Load += frmDemNguocTet_Load;
            
        }


        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        DateTime tet = new DateTime(2022, 02, 01, 00, 00, 00);
        Timer timer2;

        private void frmDemNguocTet_Load(object sender, EventArgs e)
        {
            timer2 = new Timer();
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;

            TimeSpan ts = tet.Subtract(DateTime.Now); //Lấy ngày Tết trừ thời gian hiện tại
            lblDungTet.Text = ts.ToString("dd' Ngày 'hh' Giờ 'mm' Phút 'ss' Giây'");

            timer2.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            flag = 0;
            if (totalSeccond == 0 && flag != 1)
            {
                timer1.Stop();
                picPhaoHoa.Visible = true;
                player.URL = "D:\\Thien\\Workspace\\C#-NET\\NET#\\WindowsFormsApps\\DemNguocTet\\Images\\hny.mp3";
                player.controls.play();
            }

            else
            {
                totalSeccond--;
                lblTet.Text = $"{totalSeccond / 60: #00}:{totalSeccond % 60:#00}"; //:#00 định dạng k cho đồng hồ thụt ra vô

            }
        }
        int totalSeccond = 0;

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            flag = 0;
            var minute = (int)numTet.Value;
            totalSeccond = minute * 60;
            timer1.Start();
            if (flag != 1)
            {
                lblTet.Visible = true;
                lblDungTet.Visible = false;
            }

        }
        void timer2_Tick(object sender, EventArgs e)
        {

            TimeSpan ts = tet.Subtract(DateTime.Now); //Lấy ngày Tết trừ thời gian hiện tại
            lblDungTet.Text = ts.ToString("dd' Ngày 'hh' Giờ 'mm' Phút 'ss' Giây'");
            if (ts.TotalSeconds <= 0)
            {
                timer2.Stop();
                picPhaoHoa.Visible = true;
                player.URL = "D:\\Thien\\Workspace\\C#-NET\\Mon.Net\\DemNguocTetNguyenDan\\Image\\hny.mp3";
                player.controls.play();
            }
        }
    }
}

