using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApps.Emtities;

namespace WindowsFormsApps
{
    public partial class frmUser : Form
    {
        Person person;
        public frmUser(string idPerson = "sv1")
        {
            InitializeComponent();
            person = Person.Get(idPerson);
            if (person != null)
            {
                txtHoTen.Text = person.FullName;
                dtpNgaySinh.Value = person.DOB;
                if (person.Sex == EGioiTinh.Nam)
                    rdNam.Checked = true;
                else if (person.Sex == EGioiTinh.Nu)
                    rdNu.Checked = true;
                else
                    rdKhac.Checked = true;
                txtQueQuan.Text = person.HomeTown;

            }
            var ds = HistorySV.GetList();
            historySVBindingSource.DataSource = ds;
            GridSv.DataSource = historySVBindingSource;
        }


        private void picAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "File ảnh(*.png, *.jpg)| *.png; *.jpg";
            dialog.Title = "Chọn ảnh đại diện";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = dialog.FileName;
                picAvatar.ImageLocation = fileName;
            }
        }

        private void btnDoiMau_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;

            }
        }
    }
}
