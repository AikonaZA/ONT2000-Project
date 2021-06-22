namespace ONT2000_Project
{
    partial class FormRentalAgreementAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRentalAgreementAdd));
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxShopID = new System.Windows.Forms.ComboBox();
            this.labelShopID = new System.Windows.Forms.Label();
            this.labelRentID = new System.Windows.Forms.Label();
            this.textBoxRentID = new System.Windows.Forms.TextBox();
            this.textBoxRentDate = new System.Windows.Forms.TextBox();
            this.labelRentDate = new System.Windows.Forms.Label();
            this.labelRentalDuration = new System.Windows.Forms.Label();
            this.textBoxRentDuration = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(92, 272);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(254, 272);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxShopID
            // 
            this.comboBoxShopID.FormattingEnabled = true;
            this.comboBoxShopID.Location = new System.Drawing.Point(238, 99);
            this.comboBoxShopID.Name = "comboBoxShopID";
            this.comboBoxShopID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShopID.TabIndex = 2;
            // 
            // labelShopID
            // 
            this.labelShopID.AutoSize = true;
            this.labelShopID.Location = new System.Drawing.Point(79, 106);
            this.labelShopID.Name = "labelShopID";
            this.labelShopID.Size = new System.Drawing.Size(83, 13);
            this.labelShopID.TabIndex = 3;
            this.labelShopID.Text = "Choose a Shop:";
            // 
            // labelRentID
            // 
            this.labelRentID.AutoSize = true;
            this.labelRentID.Location = new System.Drawing.Point(82, 47);
            this.labelRentID.Name = "labelRentID";
            this.labelRentID.Size = new System.Drawing.Size(109, 13);
            this.labelRentID.TabIndex = 4;
            this.labelRentID.Text = "Rental Agreement ID:";
            // 
            // textBoxRentID
            // 
            this.textBoxRentID.Location = new System.Drawing.Point(238, 47);
            this.textBoxRentID.Name = "textBoxRentID";
            this.textBoxRentID.Size = new System.Drawing.Size(100, 20);
            this.textBoxRentID.TabIndex = 5;
            // 
            // textBoxRentDate
            // 
            this.textBoxRentDate.Location = new System.Drawing.Point(238, 164);
            this.textBoxRentDate.Name = "textBoxRentDate";
            this.textBoxRentDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxRentDate.TabIndex = 6;
            // 
            // labelRentDate
            // 
            this.labelRentDate.AutoSize = true;
            this.labelRentDate.Location = new System.Drawing.Point(85, 164);
            this.labelRentDate.Name = "labelRentDate";
            this.labelRentDate.Size = new System.Drawing.Size(67, 13);
            this.labelRentDate.TabIndex = 7;
            this.labelRentDate.Text = "Date Issued:";
            // 
            // labelRentalDuration
            // 
            this.labelRentalDuration.AutoSize = true;
            this.labelRentalDuration.Location = new System.Drawing.Point(85, 208);
            this.labelRentalDuration.Name = "labelRentalDuration";
            this.labelRentalDuration.Size = new System.Drawing.Size(76, 13);
            this.labelRentalDuration.TabIndex = 8;
            this.labelRentalDuration.Text = "Date Duration:";
            // 
            // textBoxRentDuration
            // 
            this.textBoxRentDuration.Location = new System.Drawing.Point(238, 208);
            this.textBoxRentDuration.Name = "textBoxRentDuration";
            this.textBoxRentDuration.Size = new System.Drawing.Size(100, 20);
            this.textBoxRentDuration.TabIndex = 9;
            // 
            // FormRentalAgreementAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 341);
            this.Controls.Add(this.textBoxRentDuration);
            this.Controls.Add(this.labelRentalDuration);
            this.Controls.Add(this.labelRentDate);
            this.Controls.Add(this.textBoxRentDate);
            this.Controls.Add(this.textBoxRentID);
            this.Controls.Add(this.labelRentID);
            this.Controls.Add(this.labelShopID);
            this.Controls.Add(this.comboBoxShopID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRentalAgreementAdd";
            this.Text = "Add Rental Agreement";
            this.Load += new System.EventHandler(this.FormRentalAgreementAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxShopID;
        private System.Windows.Forms.Label labelShopID;
        private System.Windows.Forms.Label labelRentID;
        private System.Windows.Forms.TextBox textBoxRentID;
        private System.Windows.Forms.TextBox textBoxRentDate;
        private System.Windows.Forms.Label labelRentDate;
        private System.Windows.Forms.Label labelRentalDuration;
        private System.Windows.Forms.TextBox textBoxRentDuration;
    }
}