namespace ONT2000_Project
{
    partial class FormCallsChange
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelAssign = new System.Windows.Forms.Label();
            this.labelShop = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelCallID = new System.Windows.Forms.Label();
            this.comboBoxShop = new System.Windows.Forms.ComboBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.comboBoxStaff = new System.Windows.Forms.ComboBox();
            this.textBoxComment = new System.Windows.Forms.RichTextBox();
            this.comboBoxCallID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(239, 300);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(98, 300);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 22;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelAssign
            // 
            this.labelAssign.AutoSize = true;
            this.labelAssign.Location = new System.Drawing.Point(76, 109);
            this.labelAssign.Name = "labelAssign";
            this.labelAssign.Size = new System.Drawing.Size(76, 13);
            this.labelAssign.TabIndex = 21;
            this.labelAssign.Text = "Assign to staff:";
            // 
            // labelShop
            // 
            this.labelShop.AutoSize = true;
            this.labelShop.Location = new System.Drawing.Point(76, 143);
            this.labelShop.Name = "labelShop";
            this.labelShop.Size = new System.Drawing.Size(35, 13);
            this.labelShop.TabIndex = 20;
            this.labelShop.Text = "Shop:";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(76, 181);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(59, 13);
            this.labelComment.TabIndex = 19;
            this.labelComment.Text = "Comments:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(76, 74);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 18;
            this.labelStatus.Text = "Status:";
            // 
            // labelCallID
            // 
            this.labelCallID.AutoSize = true;
            this.labelCallID.Location = new System.Drawing.Point(76, 38);
            this.labelCallID.Name = "labelCallID";
            this.labelCallID.Size = new System.Drawing.Size(41, 13);
            this.labelCallID.TabIndex = 17;
            this.labelCallID.Text = "Call ID:";
            // 
            // comboBoxShop
            // 
            this.comboBoxShop.FormattingEnabled = true;
            this.comboBoxShop.Location = new System.Drawing.Point(158, 140);
            this.comboBoxShop.Name = "comboBoxShop";
            this.comboBoxShop.Size = new System.Drawing.Size(164, 21);
            this.comboBoxShop.TabIndex = 15;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(158, 71);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(104, 20);
            this.textBoxStatus.TabIndex = 14;
            // 
            // comboBoxStaff
            // 
            this.comboBoxStaff.FormattingEnabled = true;
            this.comboBoxStaff.Location = new System.Drawing.Point(158, 106);
            this.comboBoxStaff.Name = "comboBoxStaff";
            this.comboBoxStaff.Size = new System.Drawing.Size(164, 21);
            this.comboBoxStaff.TabIndex = 13;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(158, 178);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(206, 96);
            this.textBoxComment.TabIndex = 12;
            this.textBoxComment.Text = "";
            // 
            // comboBoxCallID
            // 
            this.comboBoxCallID.FormattingEnabled = true;
            this.comboBoxCallID.Location = new System.Drawing.Point(158, 30);
            this.comboBoxCallID.Name = "comboBoxCallID";
            this.comboBoxCallID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCallID.TabIndex = 24;
            // 
            // FormCallsChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 380);
            this.Controls.Add(this.comboBoxCallID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelAssign);
            this.Controls.Add(this.labelShop);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelCallID);
            this.Controls.Add(this.comboBoxShop);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.comboBoxStaff);
            this.Controls.Add(this.textBoxComment);
            this.Name = "FormCallsChange";
            this.Text = "FormCallsChange";
            this.Load += new System.EventHandler(this.FormCallsChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelAssign;
        private System.Windows.Forms.Label labelShop;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelCallID;
        private System.Windows.Forms.ComboBox comboBoxShop;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxStaff;
        private System.Windows.Forms.RichTextBox textBoxComment;
        private System.Windows.Forms.ComboBox comboBoxCallID;
    }
}