using BasicWinform.Emtities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWinform
{
    public partial class frmManageUser : Form
    {
        public frmManageUser()
        {
            InitializeComponent();
            var ls = Person.GetList();
            personBindingSource.DataSource = ls;
            gridSinhVien.DataSource = personBindingSource;
        }
        public Person selectedPerson
        {
            get
            {
                var p = personBindingSource.Current as Person;
                return p;
            }
        }
        private void gridSinhVien_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedPerson != null)
            {
                var f = new frmUser(selectedPerson.Id);
                f.Show();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(selectedPerson != null)
            {
                var result = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này không?","Chú ý",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if( result == DialogResult.OK)
                {
                   personBindingSource.RemoveCurrent();
                }
            }
        }
    }
}
