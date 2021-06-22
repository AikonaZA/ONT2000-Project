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
    public partial class FormCallsAdd : Form
    {
        public FormCallsAdd()
        {
            InitializeComponent();
        }
        Business_Layer.Calls calls;
        Business_Layer.Staff staff;
        Business_Layer.Venues venues;

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormCalls FrmCall = new FormCalls();
            FrmCall.Visible = true;
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            calls = new Calls(textBoxCallID.Text, textBoxStatus.Text, comboBoxStaff.SelectedIndex.ToString(), comboBoxShop.SelectedIndex.ToString(), textBoxComment.Text);
            calls.AddCalls();

            FormCalls FrmCall = new FormCalls();
            FrmCall.Visible = true;
            this.Close();
        }

        private void FormCallsAdd_Load(object sender, EventArgs e)
        {
            staff = new Staff();
            venues = new Venues();

            comboBoxStaff.DataSource = staff.AllStaff();
            comboBoxStaff.DisplayMember = "StaffName";
            comboBoxStaff.ValueMember = "StaffID";

            comboBoxShop.DataSource = venues.AllShops();
            comboBoxShop.DisplayMember = "VenueName";
            comboBoxShop.ValueMember = "VenueID";


        }
    }
}
