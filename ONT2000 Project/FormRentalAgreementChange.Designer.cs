namespace ONT2000_Project
{
    partial class FormRentalAgreementChange
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
            this.textBoxRentDuration = new System.Windows.Forms.TextBox();
            this.labelRentalDuration = new System.Windows.Forms.Label();
            this.labelRentDate = new System.Windows.Forms.Label();
            this.textBoxRentDate = new System.Windows.Forms.TextBox();
            this.labelRentID = new System.Windows.Forms.Label();
            this.labelShopID = new System.Windows.Forms.Label();
            this.comboBoxShopID = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.comboBoxRentID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxRentDuration
            // 
            this.textBoxRentDuration.Location = new System.Drawing.Point(217, 211);
            this.textBoxRentDuration.Name = "textBoxRentDuration";
            this.textBoxRentDuration.Size = new System.Drawing.Size(100, 20);
            this.textBoxRentDuration.TabIndex = 19;
            // 
            // labelRentalDuration
            // 
            this.labelRentalDuration.AutoSize = true;
            this.labelRentalDuration.Location = new System.Drawing.Point(64, 211);
            this.labelRentalDuration.Name = "labelRentalDuration";
            this.labelRentalDuration.Size = new System.Drawing.Size(76, 13);
            this.labelRentalDuration.TabIndex = 18;
            this.labelRentalDuration.Text = "Date Duration:";
            // 
            // labelRentDate
            // 
            this.labelRentDate.AutoSize = true;
            this.labelRentDate.Location = new System.Drawing.Point(64, 167);
            this.labelRentDate.Name = "labelRentDate";
            this.labelRentDate.Size = new System.Drawing.Size(67, 13);
            this.labelRentDate.TabIndex = 17;
            this.labelRentDate.Text = "Date Issued:";
            // 
            // textBoxRentDate
            // 
            this.textBoxRentDate.Location = new System.Drawing.Point(217, 167);
            this.textBoxRentDate.Name = "textBoxRentDate";
            this.textBoxRentDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxRentDate.TabIndex = 16;
            // 
            // labelRentID
            // 
            this.labelRentID.AutoSize = true;
            this.labelRentID.Location = new System.Drawing.Point(61, 50);
            this.labelRentID.Name = "labelRentID";
            this.labelRentID.Size = new System.Drawing.Size(109, 13);
            this.labelRentID.TabIndex = 14;
            this.labelRentID.Text = "Rental Agreement ID:";
            // 
            // labelShopID
            // 
            this.labelShopID.AutoSize = true;
            this.labelShopID.Location = new System.Drawing.Point(58, 109);
            this.labelShopID.Name = "labelShopID";
            this.labelShopID.Size = new System.Drawing.Size(83, 13);
            this.labelShopID.TabIndex = 13;
            this.labelShopID.Text = "Choose a Shop:";
            // 
            // comboBoxShopID
            // 
            this.comboBoxShopID.FormattingEnabled = true;
            this.comboBoxShopID.Location = new System.Drawing.Point(217, 102);
            this.comboBoxShopID.Name = "comboBoxShopID";
            this.comboBoxShopID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShopID.TabIndex = 12;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(233, 275);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(71, 275);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // comboBoxRentID
            // 
            this.comboBoxRentID.FormattingEnabled = true;
            this.comboBoxRentID.Location = new System.Drawing.Point(217, 50);
            this.comboBoxRentID.Name = "comboBoxRentID";
            this.comboBoxRentID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRentID.TabIndex = 20;
            // 
            // FormRentalAgreementChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 349);
            this.Controls.Add(this.comboBoxRentID);
            this.Controls.Add(this.textBoxRentDuration);
            this.Controls.Add(this.labelRentalDuration);
            this.Controls.Add(this.labelRentDate);
            this.Controls.Add(this.textBoxRentDate);
            this.Controls.Add(this.labelRentID);
            this.Controls.Add(this.labelShopID);
            this.Controls.Add(this.comboBoxShopID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Name = "FormRentalAgreementChange";
            this.Text = "FormRentalAgreementChange";
            this.Load += new System.EventHandler(this.FormRentalAgreementChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRentDuration;
        private System.Windows.Forms.Label labelRentalDuration;
        private System.Windows.Forms.Label labelRentDate;
        private System.Windows.Forms.TextBox textBoxRentDate;
        private System.Windows.Forms.Label labelRentID;
        private System.Windows.Forms.Label labelShopID;
        private System.Windows.Forms.ComboBox comboBoxShopID;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ComboBox comboBoxRentID;
    }
}