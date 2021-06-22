namespace ONT2000_Project
{
    partial class FormStaffChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStaffChange));
            this.comboBoxStaffChange = new System.Windows.Forms.ComboBox();
            this.labelSelectStaff = new System.Windows.Forms.Label();
            this.textBoxDoB = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelDoB = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxStaffChange
            // 
            this.comboBoxStaffChange.FormattingEnabled = true;
            this.comboBoxStaffChange.Location = new System.Drawing.Point(175, 35);
            this.comboBoxStaffChange.Name = "comboBoxStaffChange";
            this.comboBoxStaffChange.Size = new System.Drawing.Size(175, 21);
            this.comboBoxStaffChange.TabIndex = 0;
            // 
            // labelSelectStaff
            // 
            this.labelSelectStaff.AutoSize = true;
            this.labelSelectStaff.Location = new System.Drawing.Point(50, 38);
            this.labelSelectStaff.Name = "labelSelectStaff";
            this.labelSelectStaff.Size = new System.Drawing.Size(106, 13);
            this.labelSelectStaff.TabIndex = 1;
            this.labelSelectStaff.Text = "Select Staff Member:";
            // 
            // textBoxDoB
            // 
            this.textBoxDoB.Location = new System.Drawing.Point(175, 114);
            this.textBoxDoB.Name = "textBoxDoB";
            this.textBoxDoB.Size = new System.Drawing.Size(175, 20);
            this.textBoxDoB.TabIndex = 17;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(175, 142);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(175, 20);
            this.textBoxAddress.TabIndex = 16;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(175, 171);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(175, 20);
            this.textBoxPhoneNumber.TabIndex = 15;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(175, 88);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(175, 20);
            this.textBoxName.TabIndex = 14;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(50, 174);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.labelPhoneNumber.TabIndex = 13;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(50, 145);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 12;
            this.labelAddress.Text = "Address:";
            // 
            // labelDoB
            // 
            this.labelDoB.AutoSize = true;
            this.labelDoB.Location = new System.Drawing.Point(50, 117);
            this.labelDoB.Name = "labelDoB";
            this.labelDoB.Size = new System.Drawing.Size(69, 13);
            this.labelDoB.TabIndex = 11;
            this.labelDoB.Text = "Date of Birth:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(50, 91);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Name:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(255, 214);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(113, 214);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 18;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormStaffChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 261);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxDoB);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelDoB);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSelectStaff);
            this.Controls.Add(this.comboBoxStaffChange);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStaffChange";
            this.Text = "Staff Change";
            this.Load += new System.EventHandler(this.FormStaffChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStaffChange;
        private System.Windows.Forms.Label labelSelectStaff;
        private System.Windows.Forms.TextBox textBoxDoB;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelDoB;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}