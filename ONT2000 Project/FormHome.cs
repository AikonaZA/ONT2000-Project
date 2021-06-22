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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void buttonCalls_Click(object sender, EventArgs e)
        {
            FormCalls FrmCalls = new FormCalls();
            FrmCalls.Visible = true;
        }

        private void buttonRental_Click(object sender, EventArgs e)
        {
            FormRentalAgreement FrmRnt = new FormRentalAgreement();
            FrmRnt.Visible = true;
        }

        private void buttonServiceProvider_Click(object sender, EventArgs e)
        {
            //FormServiceProvider FrmSrvPrv = new FormServiceProvider();
            //FrmSrvPrv.Visible = true;
        }

        private void buttonServices_Click(object sender, EventArgs e)
        {
            FormServices FrmSrv = new FormServices();
            FrmSrv.Visible = true;
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            FormStaff FrmStff = new FormStaff();
            FrmStff.Visible = true;
        }

        private void buttonVenues_Click(object sender, EventArgs e)
        {
            FormVenues FrmVnu = new FormVenues();
            FrmVnu.Visible = true;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            FormReports FrmRpt = new FormReports();
            FrmRpt.Visible = true;
        }
    }
}
