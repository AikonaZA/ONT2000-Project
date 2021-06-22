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
    public partial class FormVenuesChange : Form
    {
        public FormVenuesChange()
        {
            InitializeComponent();
        }
        Business_Layer.Venues venues;

        private void FormVenuesChange_Load(object sender, EventArgs e)
        {
            venues = new Venues();

            comboBoxShopID.DataSource = venues.AllShops();
            comboBoxShopID.DisplayMember = "ShopID";
            comboBoxShopID.ValueMember = "ShopID";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormVenues FrmVen = new FormVenues();
            FrmVen.Visible = true;
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            venues = new Venues(comboBoxShopID.SelectedIndex.ToString(), textBoxShopName.Text, textBoxShopLocation.Text);
            venues.ChangeVenues();

            FormVenues FrmVen = new FormVenues();
            FrmVen.Visible = true;
            this.Close();
        }
    }
}
