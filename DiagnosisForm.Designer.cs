namespace Loginregisterform
{
    partial class DiagnosisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosisForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogout = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DiagId = new System.Windows.Forms.TextBox();
            this.PatientIdCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PatientTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SymptomsTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DiagnosisTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MedicineTb = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.diagsummary = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Diagnosislbl = new System.Windows.Forms.Label();
            this.medicineslbl = new System.Windows.Forms.Label();
            this.Symptomslbl = new System.Windows.Forms.Label();
            this.PatientNamelbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DiagnosisGV = new System.Windows.Forms.DataGridView();
            this.diagIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symptomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicinesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosisTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalmanagementDataSet7 = new Loginregisterform.hospitalmanagementDataSet7();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.diagnosisTblTableAdapter = new Loginregisterform.hospitalmanagementDataSet7TableAdapters.DiagnosisTblTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).BeginInit();
            this.diagsummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmanagementDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBoxLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 87);
            this.panel1.TabIndex = 1;
            // 
            // pictureBoxLogout
            // 
            this.pictureBoxLogout.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogout.Image")));
            this.pictureBoxLogout.Location = new System.Drawing.Point(784, 42);
            this.pictureBoxLogout.Name = "pictureBoxLogout";
            this.pictureBoxLogout.Size = new System.Drawing.Size(42, 36);
            this.pictureBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogout.TabIndex = 17;
            this.pictureBoxLogout.TabStop = false;
            this.pictureBoxLogout.Click += new System.EventHandler(this.pictureBoxLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(317, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "DIAGNOSIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(110, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(616, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "DiagnosisId";
            // 
            // DiagId
            // 
            this.DiagId.Location = new System.Drawing.Point(132, 97);
            this.DiagId.Name = "DiagId";
            this.DiagId.Size = new System.Drawing.Size(134, 20);
            this.DiagId.TabIndex = 8;
            // 
            // PatientIdCb
            // 
            this.PatientIdCb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientIdCb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PatientIdCb.FormattingEnabled = true;
            this.PatientIdCb.Location = new System.Drawing.Point(24, 134);
            this.PatientIdCb.Name = "PatientIdCb";
            this.PatientIdCb.Size = new System.Drawing.Size(242, 26);
            this.PatientIdCb.TabIndex = 17;
            this.PatientIdCb.Text = "PatientId";
            this.PatientIdCb.SelectionChangeCommitted += new System.EventHandler(this.PatientIdCb_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Patientname";
            // 
            // PatientTb
            // 
            this.PatientTb.Enabled = false;
            this.PatientTb.Location = new System.Drawing.Point(139, 175);
            this.PatientTb.Name = "PatientTb";
            this.PatientTb.Size = new System.Drawing.Size(134, 20);
            this.PatientTb.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Symptoms";
            // 
            // SymptomsTb
            // 
            this.SymptomsTb.Location = new System.Drawing.Point(132, 208);
            this.SymptomsTb.Name = "SymptomsTb";
            this.SymptomsTb.Size = new System.Drawing.Size(134, 20);
            this.SymptomsTb.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Diagnosis";
            // 
            // DiagnosisTb
            // 
            this.DiagnosisTb.Location = new System.Drawing.Point(132, 238);
            this.DiagnosisTb.Name = "DiagnosisTb";
            this.DiagnosisTb.Size = new System.Drawing.Size(134, 20);
            this.DiagnosisTb.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Medicines";
            // 
            // MedicineTb
            // 
            this.MedicineTb.Location = new System.Drawing.Point(132, 268);
            this.MedicineTb.Name = "MedicineTb";
            this.MedicineTb.Size = new System.Drawing.Size(134, 20);
            this.MedicineTb.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(121, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 43);
            this.button3.TabIndex = 28;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(228, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 43);
            this.button2.TabIndex = 27;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 26;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // diagsummary
            // 
            this.diagsummary.Controls.Add(this.button4);
            this.diagsummary.Controls.Add(this.label15);
            this.diagsummary.Controls.Add(this.label14);
            this.diagsummary.Controls.Add(this.label13);
            this.diagsummary.Controls.Add(this.Diagnosislbl);
            this.diagsummary.Controls.Add(this.medicineslbl);
            this.diagsummary.Controls.Add(this.Symptomslbl);
            this.diagsummary.Controls.Add(this.PatientNamelbl);
            this.diagsummary.Controls.Add(this.label8);
            this.diagsummary.ForeColor = System.Drawing.Color.Navy;
            this.diagsummary.Location = new System.Drawing.Point(314, 97);
            this.diagsummary.Name = "diagsummary";
            this.diagsummary.Size = new System.Drawing.Size(512, 256);
            this.diagsummary.TabIndex = 30;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(395, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 43);
            this.button4.TabIndex = 29;
            this.button4.Text = "Print";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(175, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 23);
            this.label15.TabIndex = 11;
            this.label15.Text = "ByCodeSpace";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(110, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(279, 23);
            this.label14.TabIndex = 10;
            this.label14.Text = "HospitalManagementSystem";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(444, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 23);
            this.label13.TabIndex = 9;
            this.label13.Text = "Date";
            // 
            // Diagnosislbl
            // 
            this.Diagnosislbl.AutoSize = true;
            this.Diagnosislbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diagnosislbl.ForeColor = System.Drawing.Color.Navy;
            this.Diagnosislbl.Location = new System.Drawing.Point(219, 73);
            this.Diagnosislbl.Name = "Diagnosislbl";
            this.Diagnosislbl.Size = new System.Drawing.Size(104, 23);
            this.Diagnosislbl.TabIndex = 8;
            this.Diagnosislbl.Text = "Diagnosis";
            // 
            // medicineslbl
            // 
            this.medicineslbl.AutoSize = true;
            this.medicineslbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineslbl.ForeColor = System.Drawing.Color.Navy;
            this.medicineslbl.Location = new System.Drawing.Point(219, 111);
            this.medicineslbl.Name = "medicineslbl";
            this.medicineslbl.Size = new System.Drawing.Size(104, 23);
            this.medicineslbl.TabIndex = 7;
            this.medicineslbl.Text = "Medicines";
            // 
            // Symptomslbl
            // 
            this.Symptomslbl.AutoSize = true;
            this.Symptomslbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Symptomslbl.ForeColor = System.Drawing.Color.Navy;
            this.Symptomslbl.Location = new System.Drawing.Point(6, 111);
            this.Symptomslbl.Name = "Symptomslbl";
            this.Symptomslbl.Size = new System.Drawing.Size(111, 23);
            this.Symptomslbl.TabIndex = 6;
            this.Symptomslbl.Text = "Symptoms";
            this.Symptomslbl.Click += new System.EventHandler(this.label10_Click);
            // 
            // PatientNamelbl
            // 
            this.PatientNamelbl.AutoSize = true;
            this.PatientNamelbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNamelbl.ForeColor = System.Drawing.Color.Navy;
            this.PatientNamelbl.Location = new System.Drawing.Point(5, 73);
            this.PatientNamelbl.Name = "PatientNamelbl";
            this.PatientNamelbl.Size = new System.Drawing.Size(127, 23);
            this.PatientNamelbl.TabIndex = 5;
            this.PatientNamelbl.Text = "Patientname";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(140, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "DIAGNOSIS SUMMARY";
            // 
            // DiagnosisGV
            // 
            this.DiagnosisGV.AutoGenerateColumns = false;
            this.DiagnosisGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiagnosisGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diagIdDataGridViewTextBoxColumn,
            this.patIdDataGridViewTextBoxColumn,
            this.patNameDataGridViewTextBoxColumn,
            this.symptomsDataGridViewTextBoxColumn,
            this.diagnosisDataGridViewTextBoxColumn,
            this.medicinesDataGridViewTextBoxColumn});
            this.DiagnosisGV.DataSource = this.diagnosisTblBindingSource;
            this.DiagnosisGV.Location = new System.Drawing.Point(96, 450);
            this.DiagnosisGV.Name = "DiagnosisGV";
            this.DiagnosisGV.Size = new System.Drawing.Size(643, 161);
            this.DiagnosisGV.TabIndex = 25;
            this.DiagnosisGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiagnosisGV_CellClick);
            // 
            // diagIdDataGridViewTextBoxColumn
            // 
            this.diagIdDataGridViewTextBoxColumn.DataPropertyName = "DiagId";
            this.diagIdDataGridViewTextBoxColumn.HeaderText = "DiagId";
            this.diagIdDataGridViewTextBoxColumn.Name = "diagIdDataGridViewTextBoxColumn";
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
            // symptomsDataGridViewTextBoxColumn
            // 
            this.symptomsDataGridViewTextBoxColumn.DataPropertyName = "Symptoms";
            this.symptomsDataGridViewTextBoxColumn.HeaderText = "Symptoms";
            this.symptomsDataGridViewTextBoxColumn.Name = "symptomsDataGridViewTextBoxColumn";
            // 
            // diagnosisDataGridViewTextBoxColumn
            // 
            this.diagnosisDataGridViewTextBoxColumn.DataPropertyName = "Diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.HeaderText = "Diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.Name = "diagnosisDataGridViewTextBoxColumn";
            // 
            // medicinesDataGridViewTextBoxColumn
            // 
            this.medicinesDataGridViewTextBoxColumn.DataPropertyName = "Medicines";
            this.medicinesDataGridViewTextBoxColumn.HeaderText = "Medicines";
            this.medicinesDataGridViewTextBoxColumn.Name = "medicinesDataGridViewTextBoxColumn";
            // 
            // diagnosisTblBindingSource
            // 
            this.diagnosisTblBindingSource.DataMember = "DiagnosisTbl";
            this.diagnosisTblBindingSource.DataSource = this.hospitalmanagementDataSet7;
            // 
            // hospitalmanagementDataSet7
            // 
            this.hospitalmanagementDataSet7.DataSetName = "hospitalmanagementDataSet7";
            this.hospitalmanagementDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(262, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(320, 42);
            this.label9.TabIndex = 31;
            this.label9.Text = "DIAGNOSIS LIST";
            // 
            // diagnosisTblTableAdapter
            // 
            this.diagnosisTblTableAdapter.ClearBeforeFill = true;
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(838, 639);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DiagnosisGV);
            this.Controls.Add(this.diagsummary);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MedicineTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DiagnosisTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SymptomsTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PatientTb);
            this.Controls.Add(this.PatientIdCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DiagId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiagnosisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiagnosisForm";
            this.Load += new System.EventHandler(this.DiagnosisForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).EndInit();
            this.diagsummary.ResumeLayout(false);
            this.diagsummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmanagementDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DiagId;
        private System.Windows.Forms.ComboBox PatientIdCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PatientTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SymptomsTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DiagnosisTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MedicineTb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel diagsummary;
        private System.Windows.Forms.Label medicineslbl;
        private System.Windows.Forms.Label Symptomslbl;
        private System.Windows.Forms.Label PatientNamelbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Diagnosislbl;
        private System.Windows.Forms.PictureBox pictureBoxLogout;
        private System.Windows.Forms.DataGridView DiagnosisGV;
        private System.Windows.Forms.Button button4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label9;
        private hospitalmanagementDataSet7 hospitalmanagementDataSet7;
        private System.Windows.Forms.BindingSource diagnosisTblBindingSource;
        private hospitalmanagementDataSet7TableAdapters.DiagnosisTblTableAdapter diagnosisTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn symptomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicinesDataGridViewTextBoxColumn;
    }
}