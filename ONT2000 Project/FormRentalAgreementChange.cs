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
    public partial class FormRentalAgreementChange : Form
    {
        public FormRentalAgreementChange()
        {
            InitializeComponent();
        }
        Business_Layer.RentalAgreements rental;
        Business_Layer.Venues shop;

        private void FormRentalAgreementChange_Load(object sender, EventArgs e)
        {
            rental = new RentalAgreements();
            shop = new Venues();

            comboBoxRentID.DataSource = rental.AllRentals();
            comboBoxRentID.DisplayMember = "RentalAgreementID";
            comboBoxRentID.ValueMember = "RentalAgreementID";

            comboBoxShopID.DataSource = shop.AllShops();
            comboBoxShopID.DisplayMember = "ShopName";
            comboBoxShopID.ValueMember = "ShopID";
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            rental = new RentalAgreements(comboBoxRentID.SelectedIndex.ToString(), comboBoxShopID.SelectedIndex.ToString(), textBoxRentDate.Text, textBoxRentDuration.Text);
            rental.AddRentals();

            FormRentalAgreement FrmRnt = new FormRentalAgreement();
            FrmRnt.Visible = true;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormRentalAgreement FrmRnt = new FormRentalAgreement();
            FrmRnt.Visible = true;
            this.Close();
        }
    }
}
