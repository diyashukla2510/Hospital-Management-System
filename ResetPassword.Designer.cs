namespace Loginregisterform
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtresetpass = new System.Windows.Forms.TextBox();
            this.txtresetpassvery = new System.Windows.Forms.TextBox();
            this.resetbtn = new System.Windows.Forms.Button();
            this.resetloginbtn = new System.Windows.Forms.Button();
            this.comboBoxUserName = new System.Windows.Forms.ComboBox();
            this.pictureBoxLogout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conform Password";
            // 
            // txtresetpass
            // 
            this.txtresetpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresetpass.Location = new System.Drawing.Point(122, 123);
            this.txtresetpass.Name = "txtresetpass";
            this.txtresetpass.PasswordChar = '*';
            this.txtresetpass.Size = new System.Drawing.Size(224, 29);
            this.txtresetpass.TabIndex = 3;
            this.txtresetpass.TextChanged += new System.EventHandler(this.txtresetpass_TextChanged);
            // 
            // txtresetpassvery
            // 
            this.txtresetpassvery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresetpassvery.Location = new System.Drawing.Point(122, 214);
            this.txtresetpassvery.Name = "txtresetpassvery";
            this.txtresetpassvery.PasswordChar = '*';
            this.txtresetpassvery.Size = new System.Drawing.Size(224, 29);
            this.txtresetpassvery.TabIndex = 4;
            // 
            // resetbtn
            // 
            this.resetbtn.BackColor = System.Drawing.Color.Teal;
            this.resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.ForeColor = System.Drawing.Color.Black;
            this.resetbtn.Location = new System.Drawing.Point(68, 277);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(110, 47);
            this.resetbtn.TabIndex = 5;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = false;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // resetloginbtn
            // 
            this.resetloginbtn.BackColor = System.Drawing.Color.Teal;
            this.resetloginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetloginbtn.Location = new System.Drawing.Point(247, 277);
            this.resetloginbtn.Name = "resetloginbtn";
            this.resetloginbtn.Size = new System.Drawing.Size(118, 47);
            this.resetloginbtn.TabIndex = 6;
            this.resetloginbtn.Text = "Login";
            this.resetloginbtn.UseVisualStyleBackColor = false;
            this.resetloginbtn.Click += new System.EventHandler(this.resetloginbtn_Click);
            // 
            // comboBoxUserName
            // 
            this.comboBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUserName.FormattingEnabled = true;
            this.comboBoxUserName.Location = new System.Drawing.Point(271, 12);
            this.comboBoxUserName.Name = "comboBoxUserName";
            this.comboBoxUserName.Size = new System.Drawing.Size(178, 32);
            this.comboBoxUserName.TabIndex = 7;
            // 
            // pictureBoxLogout
            // 
            this.pictureBoxLogout.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogout.Image")));
            this.pictureBoxLogout.Location = new System.Drawing.Point(418, 288);
            this.pictureBoxLogout.Name = "pictureBoxLogout";
            this.pictureBoxLogout.Size = new System.Drawing.Size(31, 36);
            this.pictureBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogout.TabIndex = 17;
            this.pictureBoxLogout.TabStop = false;
            this.pictureBoxLogout.Click += new System.EventHandler(this.pictureBoxLogout_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 348);
            this.Controls.Add(this.pictureBoxLogout);
            this.Controls.Add(this.comboBoxUserName);
            this.Controls.Add(this.resetloginbtn);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.txtresetpassvery);
            this.Controls.Add(this.txtresetpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtresetpass;
        private System.Windows.Forms.TextBox txtresetpassvery;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Button resetloginbtn;
        private System.Windows.Forms.ComboBox comboBoxUserName;
        private System.Windows.Forms.PictureBox pictureBoxLogout;
    }
}