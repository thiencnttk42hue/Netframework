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
    public partial class frmLopHoc : Form
    {
        bool flag = true;
        public frmLopHoc()
        {
            InitializeComponent();
            cmbKhoa.DataSource = Khoa.GetList();
            cmbKhoa.DisplayMember = "Name";
            cmbKhoa.ValueMember = "Id";

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cmbKhoa.SelectedIndex;
            var item = cmbKhoa.SelectedItem as Khoa;//unbox
            var lsPerson = Person.GetList(item.Id);
            personBindingSource.DataSource = lsPerson;
            gridDSSV.DataSource = personBindingSource;
        }

    }
}
