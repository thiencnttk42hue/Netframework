using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicWinform.Emtities;

namespace BasicWinform
{
    public partial class frmUser : Form
    {
        Person person;
        public frmUser(string idPerson = "1")
        {
            InitializeComponent();
            person = Person.Get(idPerson);
            if (person != null)
            {
                //Cách 1
                txtHoTen.Text = $"{person.LastName} {person.FirstName}";
                //Cách 2
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
            gridSinhVien.DataSource = historySVBindingSource;
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
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
               
            }
        } 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUser_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gridSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
