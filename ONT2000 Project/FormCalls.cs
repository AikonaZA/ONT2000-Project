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
    public partial class FormCalls : Form
    {
        public FormCalls()
        {
            InitializeComponent();
        }
        Business_Layer.Calls call = new Calls();

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormCallsAdd FrmCallAdd = new FormCallsAdd();
            FrmCallAdd.Visible = true;
            this.Close();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            FormCallsChange FrmCallChange = new FormCallsChange();
            FrmCallChange.Visible = true;
            this.Close();
        }

        private void FormCalls_Load(object sender, EventArgs e)
        {
            dataGridViewCalls.DataSource = call.AllCalls();
        }
    }
}
