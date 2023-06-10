
namespace csharpproject
{
    partial class AddCabinCrew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCabinCrew));
            this.btn_crew_recruit = new System.Windows.Forms.Button();
            this.txt_crewID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_crewShift = new System.Windows.Forms.ComboBox();
            this.comboBox_crewbloodGroup = new System.Windows.Forms.ComboBox();
            this.comboBox_crewgender = new System.Windows.Forms.ComboBox();
            this.txt_crewage = new System.Windows.Forms.TextBox();
            this.txt_crewname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_crew_recruit
            // 
            this.btn_crew_recruit.BackColor = System.Drawing.Color.Red;
            this.btn_crew_recruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crew_recruit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_crew_recruit.Location = new System.Drawing.Point(891, 479);
            this.btn_crew_recruit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_crew_recruit.Name = "btn_crew_recruit";
            this.btn_crew_recruit.Size = new System.Drawing.Size(136, 39);
            this.btn_crew_recruit.TabIndex = 27;
            this.btn_crew_recruit.Text = "Recruit";
            this.btn_crew_recruit.UseVisualStyleBackColor = false;
            this.btn_crew_recruit.Click += new System.EventHandler(this.btn_crew_recruit_Click);
            // 
            // txt_crewID
            // 
            this.txt_crewID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_crewID.Location = new System.Drawing.Point(292, 185);
            this.txt_crewID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_crewID.Multiline = true;
            this.txt_crewID.Name = "txt_crewID";
            this.txt_crewID.Size = new System.Drawing.Size(563, 29);
            this.txt_crewID.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 29);
            this.label7.TabIndex = 25;
            this.label7.Text = "ID";
            // 
            // comboBox_crewShift
            // 
            this.comboBox_crewShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_crewShift.FormattingEnabled = true;
            this.comboBox_crewShift.Items.AddRange(new object[] {
            "Day",
            "Night"});
            this.comboBox_crewShift.Location = new System.Drawing.Point(292, 416);
            this.comboBox_crewShift.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_crewShift.Name = "comboBox_crewShift";
            this.comboBox_crewShift.Size = new System.Drawing.Size(563, 33);
            this.comboBox_crewShift.TabIndex = 24;
            // 
            // comboBox_crewbloodGroup
            // 
            this.comboBox_crewbloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_crewbloodGroup.FormattingEnabled = true;
            this.comboBox_crewbloodGroup.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.comboBox_crewbloodGroup.Location = new System.Drawing.Point(292, 356);
            this.comboBox_crewbloodGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_crewbloodGroup.Name = "comboBox_crewbloodGroup";
            this.comboBox_crewbloodGroup.Size = new System.Drawing.Size(563, 33);
            this.comboBox_crewbloodGroup.TabIndex = 23;
            // 
            // comboBox_crewgender
            // 
            this.comboBox_crewgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_crewgender.FormattingEnabled = true;
            this.comboBox_crewgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_crewgender.Location = new System.Drawing.Point(292, 297);
            this.comboBox_crewgender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_crewgender.Name = "comboBox_crewgender";
            this.comboBox_crewgender.Size = new System.Drawing.Size(563, 33);
            this.comboBox_crewgender.TabIndex = 22;
            // 
            // txt_crewage
            // 
            this.txt_crewage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_crewage.Location = new System.Drawing.Point(292, 238);
            this.txt_crewage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_crewage.Multiline = true;
            this.txt_crewage.Name = "txt_crewage";
            this.txt_crewage.Size = new System.Drawing.Size(563, 29);
            this.txt_crewage.TabIndex = 21;
            // 
            // txt_crewname
            // 
            this.txt_crewname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_crewname.Location = new System.Drawing.Point(292, 130);
            this.txt_crewname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_crewname.Multiline = true;
            this.txt_crewname.Name = "txt_crewname";
            this.txt_crewname.Size = new System.Drawing.Size(563, 29);
            this.txt_crewname.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 297);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Blood Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 416);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Provide Shift";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Add Cabin Crew";
            // 
            // AddCabinCrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_crew_recruit);
            this.Controls.Add(this.txt_crewID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_crewShift);
            this.Controls.Add(this.comboBox_crewbloodGroup);
            this.Controls.Add(this.comboBox_crewgender);
            this.Controls.Add(this.txt_crewage);
            this.Controls.Add(this.txt_crewname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddCabinCrew";
            this.Text = "AddCabinCrew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_crew_recruit;
        private System.Windows.Forms.TextBox txt_crewID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_crewShift;
        private System.Windows.Forms.ComboBox comboBox_crewbloodGroup;
        private System.Windows.Forms.ComboBox comboBox_crewgender;
        private System.Windows.Forms.TextBox txt_crewage;
        private System.Windows.Forms.TextBox txt_crewname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}