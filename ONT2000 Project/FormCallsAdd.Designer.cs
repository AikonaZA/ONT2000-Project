namespace ONT2000_Project
{
    partial class FormCallsAdd
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
            this.textBoxComment = new System.Windows.Forms.RichTextBox();
            this.comboBoxStaff = new System.Windows.Forms.ComboBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.comboBoxShop = new System.Windows.Forms.ComboBox();
            this.textBoxCallID = new System.Windows.Forms.TextBox();
            this.labelCallID = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.labelShop = new System.Windows.Forms.Label();
            this.labelAssign = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(109, 170);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(206, 96);
            this.textBoxComment.TabIndex = 0;
            this.textBoxComment.Text = "";
            // 
            // comboBoxStaff
            // 
            this.comboBoxStaff.FormattingEnabled = true;
            this.comboBoxStaff.Location = new System.Drawing.Point(109, 98);
            this.comboBoxStaff.Name = "comboBoxStaff";
            this.comboBoxStaff.Size = new System.Drawing.Size(164, 21);
            this.comboBoxStaff.TabIndex = 1;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(109, 63);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(104, 20);
            this.textBoxStatus.TabIndex = 2;
            this.textBoxStatus.Text = "Open";
            // 
            // comboBoxShop
            // 
            this.comboBoxShop.FormattingEnabled = true;
            this.comboBoxShop.Location = new System.Drawing.Point(109, 132);
            this.comboBoxShop.Name = "comboBoxShop";
            this.comboBoxShop.Size = new System.Drawing.Size(164, 21);
            this.comboBoxShop.TabIndex = 3;
            // 
            // textBoxCallID
            // 
            this.textBoxCallID.Location = new System.Drawing.Point(109, 27);
            this.textBoxCallID.Name = "textBoxCallID";
            this.textBoxCallID.Size = new System.Drawing.Size(104, 20);
            this.textBoxCallID.TabIndex = 4;
            // 
            // labelCallID
            // 
            this.labelCallID.AutoSize = true;
            this.labelCallID.Location = new System.Drawing.Point(27, 30);
            this.labelCallID.Name = "labelCallID";
            this.labelCallID.Size = new System.Drawing.Size(41, 13);
            this.labelCallID.TabIndex = 5;
            this.labelCallID.Text = "Call ID:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(27, 66);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Status:";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(27, 173);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(59, 13);
            this.labelComment.TabIndex = 7;
            this.labelComment.Text = "Comments:";
            // 
            // labelShop
            // 
            this.labelShop.AutoSize = true;
            this.labelShop.Location = new System.Drawing.Point(27, 135);
            this.labelShop.Name = "labelShop";
            this.labelShop.Size = new System.Drawing.Size(35, 13);
            this.labelShop.TabIndex = 8;
            this.labelShop.Text = "Shop:";
            // 
            // labelAssign
            // 
            this.labelAssign.AutoSize = true;
            this.labelAssign.Location = new System.Drawing.Point(27, 101);
            this.labelAssign.Name = "labelAssign";
            this.labelAssign.Size = new System.Drawing.Size(76, 13);
            this.labelAssign.TabIndex = 9;
            this.labelAssign.Text = "Assign to staff:";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(49, 292);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(190, 292);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormCallsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 346);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelAssign);
            this.Controls.Add(this.labelShop);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelCallID);
            this.Controls.Add(this.textBoxCallID);
            this.Controls.Add(this.comboBoxShop);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.comboBoxStaff);
            this.Controls.Add(this.textBoxComment);
            this.Name = "FormCallsAdd";
            this.Text = "FormCallsAdd";
            this.Load += new System.EventHandler(this.FormCallsAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxComment;
        private System.Windows.Forms.ComboBox comboBoxStaff;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxShop;
        private System.Windows.Forms.TextBox textBoxCallID;
        private System.Windows.Forms.Label labelCallID;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Label labelShop;
        private System.Windows.Forms.Label labelAssign;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;

    }
}