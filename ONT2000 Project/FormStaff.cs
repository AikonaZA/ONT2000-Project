using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ONT2000_Project
{
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormStaffAdd FrmStaffAdd = new FormStaffAdd();
            FrmStaffAdd.Visible = true;
            this.Close();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            FormStaffChange FrmStaffChnge = new FormStaffChange();
            FrmStaffChnge.Visible = true;
            this.Close();
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
