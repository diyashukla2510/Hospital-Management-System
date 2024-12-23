namespace Loginregisterform
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogout = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DocId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DocName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DocExp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DocPass = new System.Windows.Forms.TextBox();
            this.DoctorGV = new System.Windows.Forms.DataGridView();
            this.docIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docExpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docPassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalmanagementDataSet6 = new Loginregisterform.hospitalmanagementDataSet6();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.doctorTblTableAdapter = new Loginregisterform.hospitalmanagementDataSet6TableAdapters.DoctorTblTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmanagementDataSet6)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(836, 87);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxLogout
            // 
            this.pictureBoxLogout.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogout.Image")));
            this.pictureBoxLogout.Location = new System.Drawing.Point(772, 45);
            this.pictureBoxLogout.Name = "pictureBoxLogout";
            this.pictureBoxLogout.Size = new System.Drawing.Size(42, 36);
            this.pictureBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogout.TabIndex = 16;
            this.pictureBoxLogout.TabStop = false;
            this.pictureBoxLogout.Click += new System.EventHandler(this.pictureBoxLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(364, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "DOCTOR";
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
            // DocId
            // 
            this.DocId.Location = new System.Drawing.Point(98, 147);
            this.DocId.Name = "DocId";
            this.DocId.Size = new System.Drawing.Size(213, 20);
            this.DocId.TabIndex = 4;
            this.DocId.TextChanged += new System.EventHandler(this.DocId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "DoctorId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Doctorname";
            // 
            // DocName
            // 
            this.DocName.Location = new System.Drawing.Point(126, 185);
            this.DocName.Name = "DocName";
            this.DocName.Size = new System.Drawing.Size(185, 20);
            this.DocName.TabIndex = 6;
            this.DocName.TextChanged += new System.EventHandler(this.DocName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "YearOfExperience";
            // 
            // DocExp
            // 
            this.DocExp.Location = new System.Drawing.Point(171, 221);
            this.DocExp.Name = "DocExp";
            this.DocExp.Size = new System.Drawing.Size(140, 20);
            this.DocExp.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password";
            // 
            // DocPass
            // 
            this.DocPass.Location = new System.Drawing.Point(105, 257);
            this.DocPass.Name = "DocPass";
            this.DocPass.Size = new System.Drawing.Size(206, 20);
            this.DocPass.TabIndex = 10;
            // 
            // DoctorGV
            // 
            this.DoctorGV.AutoGenerateColumns = false;
            this.DoctorGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.docIdDataGridViewTextBoxColumn,
            this.docNameDataGridViewTextBoxColumn,
            this.docExpDataGridViewTextBoxColumn,
            this.docPassDataGridViewTextBoxColumn});
            this.DoctorGV.DataSource = this.doctorTblBindingSource;
            this.DoctorGV.Location = new System.Drawing.Point(371, 115);
            this.DoctorGV.Name = "DoctorGV";
            this.DoctorGV.Size = new System.Drawing.Size(443, 284);
            this.DoctorGV.TabIndex = 12;
            this.DoctorGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorGV_CellClick);
            // 
            // docIdDataGridViewTextBoxColumn
            // 
            this.docIdDataGridViewTextBoxColumn.DataPropertyName = "DocId";
            this.docIdDataGridViewTextBoxColumn.HeaderText = "DocId";
            this.docIdDataGridViewTextBoxColumn.Name = "docIdDataGridViewTextBoxColumn";
            // 
            // docNameDataGridViewTextBoxColumn
            // 
            this.docNameDataGridViewTextBoxColumn.DataPropertyName = "DocName";
            this.docNameDataGridViewTextBoxColumn.HeaderText = "DocName";
            this.docNameDataGridViewTextBoxColumn.Name = "docNameDataGridViewTextBoxColumn";
            // 
            // docExpDataGridViewTextBoxColumn
            // 
            this.docExpDataGridViewTextBoxColumn.DataPropertyName = "DocExp";
            this.docExpDataGridViewTextBoxColumn.HeaderText = "DocExp";
            this.docExpDataGridViewTextBoxColumn.Name = "docExpDataGridViewTextBoxColumn";
            // 
            // docPassDataGridViewTextBoxColumn
            // 
            this.docPassDataGridViewTextBoxColumn.DataPropertyName = "DocPass";
            this.docPassDataGridViewTextBoxColumn.HeaderText = "DocPass";
            this.docPassDataGridViewTextBoxColumn.Name = "docPassDataGridViewTextBoxColumn";
            // 
            // doctorTblBindingSource
            // 
            this.doctorTblBindingSource.DataMember = "DoctorTbl";
            this.doctorTblBindingSource.DataSource = this.hospitalmanagementDataSet6;
            // 
            // hospitalmanagementDataSet6
            // 
            this.hospitalmanagementDataSet6.DataSetName = "hospitalmanagementDataSet6";
            this.hospitalmanagementDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(259, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 43);
            this.button2.TabIndex = 14;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(135, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 43);
            this.button3.TabIndex = 15;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // doctorTblTableAdapter
            // 
            this.doctorTblTableAdapter.ClearBeforeFill = true;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(836, 428);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DoctorGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DocPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DocExp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DocName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DocId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmanagementDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DocId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DocName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DocExp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DocPass;
        private System.Windows.Forms.DataGridView DoctorGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBoxLogout;
        private hospitalmanagementDataSet6 hospitalmanagementDataSet6;
        private System.Windows.Forms.BindingSource doctorTblBindingSource;
        private hospitalmanagementDataSet6TableAdapters.DoctorTblTableAdapter doctorTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn docIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docExpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docPassDataGridViewTextBoxColumn;
    }
}