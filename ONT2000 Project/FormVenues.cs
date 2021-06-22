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
    public partial class FormVenues : Form
    {
        public FormVenues()
        {
            InitializeComponent();
        }
        Business_Layer.Venues venues;

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormVenuesAdd FrmVenAdd = new FormVenuesAdd();
            FrmVenAdd.Visible = true;
            this.Close();
        }

        private void FormVenues_Load(object sender, EventArgs e)
        {
            dataGridViewVenues.DataSource = venues.AllShops();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            FormVenuesChange FrmVenChng = new FormVenuesChange();
            FrmVenChng.Visible = true;
            this.Close();
        }
    }
}
