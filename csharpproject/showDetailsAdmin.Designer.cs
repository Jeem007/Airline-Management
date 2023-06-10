
namespace csharpproject
{
    partial class showDetailsAdmin
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
            this.btn_shw_details = new System.Windows.Forms.Button();
            this.showDetailsGrid = new System.Windows.Forms.DataGridView();
            this.btn_dlt = new System.Windows.Forms.Button();
            this.txt_passportid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ticketCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provideScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.showDetailsGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_shw_details
            // 
            this.btn_shw_details.BackColor = System.Drawing.Color.Green;
            this.btn_shw_details.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_shw_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shw_details.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_shw_details.Location = new System.Drawing.Point(299, 44);
            this.btn_shw_details.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_shw_details.Name = "btn_shw_details";
            this.btn_shw_details.Size = new System.Drawing.Size(429, 44);
            this.btn_shw_details.TabIndex = 0;
            this.btn_shw_details.Text = "Show Passenger Details";
            this.btn_shw_details.UseVisualStyleBackColor = false;
            this.btn_shw_details.Click += new System.EventHandler(this.btn_shw_details_Click);
            // 
            // showDetailsGrid
            // 
            this.showDetailsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDetailsGrid.Location = new System.Drawing.Point(43, 121);
            this.showDetailsGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showDetailsGrid.Name = "showDetailsGrid";
            this.showDetailsGrid.RowHeadersWidth = 51;
            this.showDetailsGrid.Size = new System.Drawing.Size(980, 302);
            this.showDetailsGrid.TabIndex = 1;
            // 
            // btn_dlt
            // 
            this.btn_dlt.BackColor = System.Drawing.Color.Red;
            this.btn_dlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dlt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_dlt.Location = new System.Drawing.Point(763, 486);
            this.btn_dlt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_dlt.Name = "btn_dlt";
            this.btn_dlt.Size = new System.Drawing.Size(129, 53);
            this.btn_dlt.TabIndex = 2;
            this.btn_dlt.Text = "Delete";
            this.btn_dlt.UseVisualStyleBackColor = false;
            this.btn_dlt.Click += new System.EventHandler(this.btn_dlt_Click);
            // 
            // txt_passportid
            // 
            this.txt_passportid.Location = new System.Drawing.Point(272, 486);
            this.txt_passportid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_passportid.Multiline = true;
            this.txt_passportid.Name = "txt_passportid";
            this.txt_passportid.Size = new System.Drawing.Size(455, 52);
            this.txt_passportid.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 449);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "To Delete Passenger, Enter Passport ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketCategoryToolStripMenuItem,
            this.provideScheduleToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ticketCategoryToolStripMenuItem
            // 
            this.ticketCategoryToolStripMenuItem.Name = "ticketCategoryToolStripMenuItem";
            this.ticketCategoryToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.ticketCategoryToolStripMenuItem.Text = "Ticket Category";
            this.ticketCategoryToolStripMenuItem.Click += new System.EventHandler(this.ticketCategoryToolStripMenuItem_Click);
            // 
            // provideScheduleToolStripMenuItem
            // 
            this.provideScheduleToolStripMenuItem.Name = "provideScheduleToolStripMenuItem";
            this.provideScheduleToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.provideScheduleToolStripMenuItem.Text = "Provide Schedule";
            this.provideScheduleToolStripMenuItem.Click += new System.EventHandler(this.provideScheduleToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // showDetailsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_passportid);
            this.Controls.Add(this.btn_dlt);
            this.Controls.Add(this.showDetailsGrid);
            this.Controls.Add(this.btn_shw_details);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "showDetailsAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "showDetailsAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.showDetailsGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_shw_details;
        private System.Windows.Forms.DataGridView showDetailsGrid;
        private System.Windows.Forms.Button btn_dlt;
        private System.Windows.Forms.TextBox txt_passportid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ticketCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provideScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}