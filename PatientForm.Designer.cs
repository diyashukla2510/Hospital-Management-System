namespace Loginregisterform
{
    partial class PatientForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxLogout = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PatId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PatPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PatAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PatName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PatAge = new System.Windows.Forms.TextBox();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.BloodCb = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.PatientGV = new System.Windows.Forms.DataGridView();
            this.patIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patBloodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalmanagementDataSet5 = new Loginregisterform.hospitalmanagementDataSet5();
            this.patientTblTableAdapter = new Loginregisterform.hospitalmanagementDataSet5TableAdapters.PatientTblTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmanagementDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBoxLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 87);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(466, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "PATIENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(240, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(616, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // pictureBoxLogout
            // 
            this.pictureBoxLogout.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogout.Image")));
            this.pictureBoxLogout.Location = new System.Drawing.Point(1027, 45);
            this.pictureBoxLogout.Name = "pictureBoxLogout";
            this.pictureBoxLogout.Size = new System.Drawing.Size(42, 36);
            this.pictureBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogout.TabIndex = 22;
            this.pictureBoxLogout.TabStop = false;
            this.pictureBoxLogout.Click += new System.EventHandler(this.pictureBoxLogout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "PatientId";
            // 
            // PatId
            // 
            this.PatId.Location = new System.Drawing.Point(110, 149);
            this.PatId.Name = "PatId";
            this.PatId.Size = new System.Drawing.Size(134, 20);
            this.PatId.TabIndex = 6;
            this.PatId.TextChanged += new System.EventHandler(this.PatId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "PatientPhone";
            // 
            // PatPhone
            // 
            this.PatPhone.Location = new System.Drawing.Point(144, 262);
            this.PatPhone.Name = "PatPhone";
            this.PatPhone.Size = new System.Drawing.Size(100, 20);
            this.PatPhone.TabIndex = 8;
            this.PatPhone.TextChanged += new System.EventHandler(this.PatPhone_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "PatientAddress";
            // 
            // PatAd
            // 
            this.PatAd.Location = new System.Drawing.Point(165, 225);
            this.PatAd.Name = "PatAd";
            this.PatAd.Size = new System.Drawing.Size(100, 20);
            this.PatAd.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Patientname";
            // 
            // PatName
            // 
            this.PatName.Location = new System.Drawing.Point(144, 190);
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(100, 20);
            this.PatName.TabIndex = 12;
            this.PatName.TextChanged += new System.EventHandler(this.PatName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "PatientAge";
            // 
            // PatAge
            // 
            this.PatAge.Location = new System.Drawing.Point(138, 298);
            this.PatAge.Name = "PatAge";
            this.PatAge.Size = new System.Drawing.Size(100, 20);
            this.PatAge.TabIndex = 14;
            // 
            // GenderCb
            // 
            this.GenderCb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderCb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderCb.Location = new System.Drawing.Point(24, 333);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(121, 26);
            this.GenderCb.TabIndex = 16;
            this.GenderCb.Text = "Gender";
            // 
            // BloodCb
            // 
            this.BloodCb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodCb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BloodCb.FormattingEnabled = true;
            this.BloodCb.Items.AddRange(new object[] {
            "A+",
            "O+",
            "B+",
            "AB+",
            "A-",
            "O-",
            "AB-"});
            this.BloodCb.Location = new System.Drawing.Point(24, 365);
            this.BloodCb.Name = "BloodCb";
            this.BloodCb.Size = new System.Drawing.Size(121, 26);
            this.BloodCb.TabIndex = 17;
            this.BloodCb.Text = "BloodGroup";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(117, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 43);
            this.button3.TabIndex = 21;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(224, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 43);
            this.button2.TabIndex = 20;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(422, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 42);
            this.label8.TabIndex = 23;
            this.label8.Text = "PATIENT LIST";
            // 
            // PatientGV
            // 
            this.PatientGV.AutoGenerateColumns = false;
            this.PatientGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patIdDataGridViewTextBoxColumn,
            this.patNameDataGridViewTextBoxColumn,
            this.patAddressDataGridViewTextBoxColumn,
            this.patPhoneDataGridViewTextBoxColumn,
            this.patAgeDataGridViewTextBoxColumn,
            this.patGenderDataGridViewTextBoxColumn,
            this.patBloodDataGridViewTextBoxColumn});
            this.PatientGV.DataSource = this.patientTblBindingSource;
            this.PatientGV.Location = new System.Drawing.Point(334, 149);
            this.PatientGV.Name = "PatientGV";
            this.PatientGV.Size = new System.Drawing.Size(735, 313);
            this.PatientGV.TabIndex = 24;
            this.PatientGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientGV_CellClick);
            // 
            // patIdDataGridViewTextBoxColumn
            // 
            this.patIdDataGridViewTextBoxColumn.DataPropertyName = "PatId";
            this.patIdDataGridViewTextBoxColumn.HeaderText = "PatId";
            this.patIdDataGridViewTextBoxColumn.Name = "patIdDataGridViewTextBoxColumn";
            // 
            // patNameDataGridViewTextBoxColumn
            // 
            this.patNameDataGridViewTextBoxColumn.DataPropertyName = "PatName";
            this.patNameDataGridViewTextBoxColumn.HeaderText = "PatName";
            this.patNameDataGridViewTextBoxColumn.Name = "patNameDataGridViewTextBoxColumn";
            // 
            // patAddressDataGridViewTextBoxColumn
            // 
            this.patAddressDataGridViewTextBoxColumn.DataPropertyName = "PatAddress";
            this.patAddressDataGridViewTextBoxColumn.HeaderText = "PatAddress";
            this.patAddressDataGridViewTextBoxColumn.Name = "patAddressDataGridViewTextBoxColumn";
            // 
            // patPhoneDataGridViewTextBoxColumn
            // 
            this.patPhoneDataGridViewTextBoxColumn.DataPropertyName = "PatPhone";
            this.patPhoneDataGridViewTextBoxColumn.HeaderText = "PatPhone";
            this.patPhoneDataGridViewTextBoxColumn.Name = "patPhoneDataGridViewTextBoxColumn";
            // 
            // patAgeDataGridViewTextBoxColumn
            // 
            this.patAgeDataGridViewTextBoxColumn.DataPropertyName = "PatAge";
            this.patAgeDataGridViewTextBoxColumn.HeaderText = "PatAge";
            this.patAgeDataGridViewTextBoxColumn.Name = "patAgeDataGridViewTextBoxColumn";
            // 
            // patGenderDataGridViewTextBoxColumn
            // 
            this.patGenderDataGridViewTextBoxColumn.DataPropertyName = "PatGender";
            this.patGenderDataGridViewTextBoxColumn.HeaderText = "PatGender";
            this.patGenderDataGridViewTextBoxColumn.Name = "patGenderDataGridViewTextBoxColumn";
            // 
            // patBloodDataGridViewTextBoxColumn
            // 
            this.patBloodDataGridViewTextBoxColumn.DataPropertyName = "PatBlood";
            this.patBloodDataGridViewTextBoxColumn.HeaderText = "PatBlood";
            this.patBloodDataGridViewTextBoxColumn.Name = "patBloodDataGridViewTextBoxColumn";
            // 
            // patientTblBindingSource
            // 
            this.patientTblBindingSource.DataMember = "PatientTbl";
            this.patientTblBindingSource.DataSource = this.hospitalmanagementDataSet5;
            // 
            // hospitalmanagementDataSet5
            // 
            this.hospitalmanagementDataSet5.DataSetName = "hospitalmanagementDataSet5";
            this.hospitalmanagementDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTblTableAdapter
            // 
            this.patientTblTableAdapter.ClearBeforeFill = true;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1077, 477);
            this.Controls.Add(this.PatientGV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BloodCb);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PatAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PatAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PatPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PatId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmanagementDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PatId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PatPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PatAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PatName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PatAge;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.ComboBox BloodCb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxLogout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView PatientGV;
        private hospitalmanagementDataSet5 hospitalmanagementDataSet5;
        private System.Windows.Forms.BindingSource patientTblBindingSource;
        private hospitalmanagementDataSet5TableAdapters.PatientTblTableAdapter patientTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patBloodDataGridViewTextBoxColumn;
    }
}