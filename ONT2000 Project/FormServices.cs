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
    public partial class FormServices : Form
    {
        public FormServices()
        {
            InitializeComponent();
        }
        Business_Layer.Services service;

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormServices_Load(object sender, EventArgs e)
        {
            dataGridViewSchedule.DataSource = service.AllSchedules();
            dataGridViewServices.DataSource = service.AllSchedules();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
