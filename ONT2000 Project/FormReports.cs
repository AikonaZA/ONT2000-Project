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
    public partial class FormReports : Form
    {
        public FormReports()
        {
            InitializeComponent();
        }
        Business_Layer.Reports report;
        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAllShops_Click(object sender, EventArgs e)
        {
            report = new Reports();
            dataGridViewReports.DataSource = report.AllShops();
        }

        private void buttonFacilities_Click(object sender, EventArgs e)
        {
            report = new Reports();
            dataGridViewReports.DataSource = report.Facilities();
        }

        private void buttonAllStaff_Click(object sender, EventArgs e)
        {
            report = new Reports();
            dataGridViewReports.DataSource = report.AllStaff();
        }

        private void buttonAllCalls_Click(object sender, EventArgs e)
        {
            report = new Reports();
            dataGridViewReports.DataSource = report.AllCalls();
        }

        private void buttonCallsNotClosed_Click(object sender, EventArgs e)
        {
            report = new Reports();
            dataGridViewReports.DataSource = report.CallsNotClosed();
        }

        private void buttonCallsForShops_Click(object sender, EventArgs e)
        {
            report = new Reports();
            dataGridViewReports.DataSource = report.CallsForStaff();
        }

        private void buttonCallsForStaff_Click(object sender, EventArgs e)
        {
            report = new Reports();
            dataGridViewReports.DataSource = report.CallsForStaff();
        }
    }
}
