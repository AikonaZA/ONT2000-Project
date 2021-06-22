namespace ONT2000_Project
{
    partial class FormVenuesAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenuesAdd));
            this.textBoxShopID = new System.Windows.Forms.TextBox();
            this.textBoxShopName = new System.Windows.Forms.TextBox();
            this.textBoxShopLocation = new System.Windows.Forms.TextBox();
            this.labelShopId = new System.Windows.Forms.Label();
            this.labelShopName = new System.Windows.Forms.Label();
            this.labelShopLocation = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxShopID
            // 
            this.textBoxShopID.Location = new System.Drawing.Point(218, 47);
            this.textBoxShopID.Name = "textBoxShopID";
            this.textBoxShopID.Size = new System.Drawing.Size(100, 20);
            this.textBoxShopID.TabIndex = 0;
            // 
            // textBoxShopName
            // 
            this.textBoxShopName.Location = new System.Drawing.Point(218, 100);
            this.textBoxShopName.Name = "textBoxShopName";
            this.textBoxShopName.Size = new System.Drawing.Size(100, 20);
            this.textBoxShopName.TabIndex = 1;
            // 
            // textBoxShopLocation
            // 
            this.textBoxShopLocation.Location = new System.Drawing.Point(218, 159);
            this.textBoxShopLocation.Name = "textBoxShopLocation";
            this.textBoxShopLocation.Size = new System.Drawing.Size(100, 20);
            this.textBoxShopLocation.TabIndex = 2;
            // 
            // labelShopId
            // 
            this.labelShopId.AutoSize = true;
            this.labelShopId.Location = new System.Drawing.Point(29, 50);
            this.labelShopId.Name = "labelShopId";
            this.labelShopId.Size = new System.Drawing.Size(49, 13);
            this.labelShopId.TabIndex = 3;
            this.labelShopId.Text = "Shop ID:";
            // 
            // labelShopName
            // 
            this.labelShopName.AutoSize = true;
            this.labelShopName.Location = new System.Drawing.Point(32, 103);
            this.labelShopName.Name = "labelShopName";
            this.labelShopName.Size = new System.Drawing.Size(66, 13);
            this.labelShopName.TabIndex = 4;
            this.labelShopName.Text = "Shop Name:";
            // 
            // labelShopLocation
            // 
            this.labelShopLocation.AutoSize = true;
            this.labelShopLocation.Location = new System.Drawing.Point(35, 162);
            this.labelShopLocation.Name = "labelShopLocation";
            this.labelShopLocation.Size = new System.Drawing.Size(79, 13);
            this.labelShopLocation.TabIndex = 5;
            this.labelShopLocation.Text = "Shop Location:";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(35, 264);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(243, 264);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormVenuesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 348);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelShopLocation);
            this.Controls.Add(this.labelShopName);
            this.Controls.Add(this.labelShopId);
            this.Controls.Add(this.textBoxShopLocation);
            this.Controls.Add(this.textBoxShopName);
            this.Controls.Add(this.textBoxShopID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVenuesAdd";
            this.Text = "Add Venue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxShopID;
        private System.Windows.Forms.TextBox textBoxShopName;
        private System.Windows.Forms.TextBox textBoxShopLocation;
        private System.Windows.Forms.Label labelShopId;
        private System.Windows.Forms.Label labelShopName;
        private System.Windows.Forms.Label labelShopLocation;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}