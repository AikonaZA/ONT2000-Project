namespace ONT2000_Project
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.buttonCalls = new System.Windows.Forms.Button();
            this.buttonRental = new System.Windows.Forms.Button();
            this.buttonServices = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.buttonVenues = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalls
            // 
            this.buttonCalls.Location = new System.Drawing.Point(26, 201);
            this.buttonCalls.Name = "buttonCalls";
            this.buttonCalls.Size = new System.Drawing.Size(110, 23);
            this.buttonCalls.TabIndex = 0;
            this.buttonCalls.Text = "Calls";
            this.buttonCalls.UseVisualStyleBackColor = true;
            this.buttonCalls.Click += new System.EventHandler(this.buttonCalls_Click);
            // 
            // buttonRental
            // 
            this.buttonRental.Location = new System.Drawing.Point(26, 247);
            this.buttonRental.Name = "buttonRental";
            this.buttonRental.Size = new System.Drawing.Size(110, 23);
            this.buttonRental.TabIndex = 1;
            this.buttonRental.Text = "Rental Agreements";
            this.buttonRental.UseVisualStyleBackColor = true;
            this.buttonRental.Click += new System.EventHandler(this.buttonRental_Click);
            // 
            // buttonServices
            // 
            this.buttonServices.Location = new System.Drawing.Point(165, 201);
            this.buttonServices.Name = "buttonServices";
            this.buttonServices.Size = new System.Drawing.Size(110, 23);
            this.buttonServices.TabIndex = 3;
            this.buttonServices.Text = "Services";
            this.buttonServices.UseVisualStyleBackColor = true;
            this.buttonServices.Click += new System.EventHandler(this.buttonServices_Click);
            // 
            // buttonStaff
            // 
            this.buttonStaff.Location = new System.Drawing.Point(165, 247);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(110, 23);
            this.buttonStaff.TabIndex = 4;
            this.buttonStaff.Text = "Staff";
            this.buttonStaff.UseVisualStyleBackColor = true;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // buttonVenues
            // 
            this.buttonVenues.Location = new System.Drawing.Point(165, 293);
            this.buttonVenues.Name = "buttonVenues";
            this.buttonVenues.Size = new System.Drawing.Size(110, 23);
            this.buttonVenues.TabIndex = 5;
            this.buttonVenues.Text = "Venues";
            this.buttonVenues.UseVisualStyleBackColor = true;
            this.buttonVenues.Click += new System.EventHandler(this.buttonVenues_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(26, 293);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(110, 23);
            this.buttonReport.TabIndex = 6;
            this.buttonReport.Text = "Reports";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 151);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(306, 413);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonVenues);
            this.Controls.Add(this.buttonStaff);
            this.Controls.Add(this.buttonServices);
            this.Controls.Add(this.buttonRental);
            this.Controls.Add(this.buttonCalls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.Text = "BayWest Application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCalls;
        private System.Windows.Forms.Button buttonRental;
        private System.Windows.Forms.Button buttonServices;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.Button buttonVenues;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

