
namespace csharpproject
{
    partial class CrewDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_crewid = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.dataGridView_crew = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_crew)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // txt_crewid
            // 
            this.txt_crewid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_crewid.Location = new System.Drawing.Point(555, 352);
            this.txt_crewid.Name = "txt_crewid";
            this.txt_crewid.Size = new System.Drawing.Size(100, 29);
            this.txt_crewid.TabIndex = 8;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_delete.Location = new System.Drawing.Point(661, 344);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(139, 46);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Discard Crew";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.Green;
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_view.Location = new System.Drawing.Point(0, 344);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(139, 46);
            this.btn_view.TabIndex = 6;
            this.btn_view.Text = "View Details";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // dataGridView_crew
            // 
            this.dataGridView_crew.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_crew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_crew.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_crew.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView_crew.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_crew.Name = "dataGridView_crew";
            this.dataGridView_crew.Size = new System.Drawing.Size(800, 278);
            this.dataGridView_crew.TabIndex = 5;
            // 
            // CrewDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_crewid);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.dataGridView_crew);
            this.Name = "CrewDetails";
            this.Text = "CrewDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_crew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_crewid;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.DataGridView dataGridView_crew;
    }
}