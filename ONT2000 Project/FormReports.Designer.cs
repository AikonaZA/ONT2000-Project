namespace ONT2000_Project
{
    partial class FormReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReports));
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonAllShops = new System.Windows.Forms.Button();
            this.buttonAllStaff = new System.Windows.Forms.Button();
            this.buttonAllCalls = new System.Windows.Forms.Button();
            this.buttonCallsNotClosed = new System.Windows.Forms.Button();
            this.buttonCallsForShops = new System.Windows.Forms.Button();
            this.buttonCallsForStaff = new System.Windows.Forms.Button();
            this.dataGridViewReports = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(362, 441);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(81, 28);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonAllShops
            // 
            this.buttonAllShops.Location = new System.Drawing.Point(9, 38);
            this.buttonAllShops.Name = "buttonAllShops";
            this.buttonAllShops.Size = new System.Drawing.Size(129, 28);
            this.buttonAllShops.TabIndex = 1;
            this.buttonAllShops.Text = "All Shops";
            this.buttonAllShops.UseVisualStyleBackColor = true;
            this.buttonAllShops.Click += new System.EventHandler(this.buttonAllShops_Click);
            // 
            // buttonAllStaff
            // 
            this.buttonAllStaff.Location = new System.Drawing.Point(144, 38);
            this.buttonAllStaff.Name = "buttonAllStaff";
            this.buttonAllStaff.Size = new System.Drawing.Size(129, 28);
            this.buttonAllStaff.TabIndex = 3;
            this.buttonAllStaff.Text = "All Staff";
            this.buttonAllStaff.UseVisualStyleBackColor = true;
            this.buttonAllStaff.Click += new System.EventHandler(this.buttonAllStaff_Click);
            // 
            // buttonAllCalls
            // 
            this.buttonAllCalls.Location = new System.Drawing.Point(279, 38);
            this.buttonAllCalls.Name = "buttonAllCalls";
            this.buttonAllCalls.Size = new System.Drawing.Size(129, 28);
            this.buttonAllCalls.TabIndex = 4;
            this.buttonAllCalls.Text = "All Calls";
            this.buttonAllCalls.UseVisualStyleBackColor = true;
            this.buttonAllCalls.Click += new System.EventHandler(this.buttonAllCalls_Click);
            // 
            // buttonCallsNotClosed
            // 
            this.buttonCallsNotClosed.Location = new System.Drawing.Point(414, 38);
            this.buttonCallsNotClosed.Name = "buttonCallsNotClosed";
            this.buttonCallsNotClosed.Size = new System.Drawing.Size(129, 28);
            this.buttonCallsNotClosed.TabIndex = 5;
            this.buttonCallsNotClosed.Text = "Calls not Closed";
            this.buttonCallsNotClosed.UseVisualStyleBackColor = true;
            this.buttonCallsNotClosed.Click += new System.EventHandler(this.buttonCallsNotClosed_Click);
            // 
            // buttonCallsForShops
            // 
            this.buttonCallsForShops.Location = new System.Drawing.Point(549, 38);
            this.buttonCallsForShops.Name = "buttonCallsForShops";
            this.buttonCallsForShops.Size = new System.Drawing.Size(129, 28);
            this.buttonCallsForShops.TabIndex = 6;
            this.buttonCallsForShops.Text = "Calls for Shops";
            this.buttonCallsForShops.UseVisualStyleBackColor = true;
            this.buttonCallsForShops.Click += new System.EventHandler(this.buttonCallsForShops_Click);
            // 
            // buttonCallsForStaff
            // 
            this.buttonCallsForStaff.Location = new System.Drawing.Point(684, 38);
            this.buttonCallsForStaff.Name = "buttonCallsForStaff";
            this.buttonCallsForStaff.Size = new System.Drawing.Size(129, 28);
            this.buttonCallsForStaff.TabIndex = 7;
            this.buttonCallsForStaff.Text = "Calls for Staff";
            this.buttonCallsForStaff.UseVisualStyleBackColor = true;
            this.buttonCallsForStaff.Click += new System.EventHandler(this.buttonCallsForStaff_Click);
            // 
            // dataGridViewReports
            // 
            this.dataGridViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReports.Location = new System.Drawing.Point(12, 90);
            this.dataGridViewReports.Name = "dataGridViewReports";
            this.dataGridViewReports.Size = new System.Drawing.Size(800, 333);
            this.dataGridViewReports.TabIndex = 8;
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 493);
            this.Controls.Add(this.dataGridViewReports);
            this.Controls.Add(this.buttonCallsForStaff);
            this.Controls.Add(this.buttonCallsForShops);
            this.Controls.Add(this.buttonCallsNotClosed);
            this.Controls.Add(this.buttonAllCalls);
            this.Controls.Add(this.buttonAllStaff);
            this.Controls.Add(this.buttonAllShops);
            this.Controls.Add(this.buttonHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonAllShops;
        private System.Windows.Forms.Button buttonAllStaff;
        private System.Windows.Forms.Button buttonAllCalls;
        private System.Windows.Forms.Button buttonCallsNotClosed;
        private System.Windows.Forms.Button buttonCallsForShops;
        private System.Windows.Forms.Button buttonCallsForStaff;
        private System.Windows.Forms.DataGridView dataGridViewReports;
    }
}