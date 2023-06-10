
namespace csharpproject
{
    partial class PilotDetails
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
            this.dataGridView_pilot = new System.Windows.Forms.DataGridView();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_pilotid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pilot)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_pilot
            // 
            this.dataGridView_pilot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_pilot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pilot.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_pilot.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView_pilot.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_pilot.Name = "dataGridView_pilot";
            this.dataGridView_pilot.Size = new System.Drawing.Size(800, 278);
            this.dataGridView_pilot.TabIndex = 0;
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.Green;
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_view.Location = new System.Drawing.Point(0, 284);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(139, 46);
            this.btn_view.TabIndex = 1;
            this.btn_view.Text = "View Details";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_delete.Location = new System.Drawing.Point(661, 284);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(139, 46);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Discard Pilot";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_pilotid
            // 
            this.txt_pilotid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pilotid.Location = new System.Drawing.Point(555, 292);
            this.txt_pilotid.Name = "txt_pilotid";
            this.txt_pilotid.Size = new System.Drawing.Size(100, 29);
            this.txt_pilotid.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // PilotDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pilotid);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.dataGridView_pilot);
            this.Name = "PilotDetails";
            this.Text = "PilotDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pilot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_pilot;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_pilotid;
        private System.Windows.Forms.Label label1;
    }
}