using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Layer;


namespace ONT2000_Project
{
    public partial class FormStaffAdd : Form
    {
        public FormStaffAdd()
        {
            InitializeComponent();
        }

        Business_Layer.Staff staff;

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormStaff FrmStff = new FormStaff();
            FrmStff.Visible = true;
            this.Close();
        }

        private void buttonOk_Click_1(object sender, EventArgs e)
        {
            staff = new Staff(textBoxStaffID.Text, textBoxName.Text, textBoxDoB.Text, textBoxAddress.Text, textBoxPhoneNumber.Text);
            staff.AddStaff();

            FormStaff FrmStff = new FormStaff();
            FrmStff.Visible = true;
            this.Close();
        }
    }
}
