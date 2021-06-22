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
    public partial class FormStaffChange : Form
    {
        public FormStaffChange()
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

        private void buttonOk_Click(object sender, EventArgs e)
        {
            staff = new Staff(comboBoxStaffChange.SelectedIndex.ToString(), textBoxName.Text, textBoxDoB.Text, textBoxAddress.Text, textBoxPhoneNumber.Text);
            staff.ChangeStaff();

            FormStaff FrmStff = new FormStaff();
            FrmStff.Visible = true;
            this.Close();
        }

        private void FormStaffChange_Load(object sender, EventArgs e)
        {
            staff = new Staff();

            comboBoxStaffChange.DataSource = staff.AllStaff();
            comboBoxStaffChange.DisplayMember = "StaffName";
            comboBoxStaffChange.ValueMember = "StaffID";
        }
    }
}
