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
    public partial class FormRentalAgreement : Form
    {
        public FormRentalAgreement()
        {
            InitializeComponent();
        }
        Business_Layer.RentalAgreements rental;

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRentalAgreement_Load(object sender, EventArgs e)
        {
            dataGridViewRental.DataSource = rental.AllRentals();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormRentalAgreementAdd FrmRntAdd = new FormRentalAgreementAdd();
            FrmRntAdd.Visible = true;
            this.Close();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            FormRentalAgreementChange FrmRntChng = new FormRentalAgreementChange();
            FrmRntChng.Visible = true;
            this.Close();
        }
    }
}
