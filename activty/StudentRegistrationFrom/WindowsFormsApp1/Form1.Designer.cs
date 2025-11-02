namespace WindowsFormsApp1
{
    partial class FrmRegistration
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.texName = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxgender = new System.Windows.Forms.GroupBox();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.rdoFemal = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.IblSelectedColor = new System.Windows.Forms.Label();
            this.dtpBrithdate = new System.Windows.Forms.DateTimePicker();
            this.combCuntry = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.ibIResult = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnReset = new System.Windows.Forms.Button();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBoxgender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "lblName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "lblPassword";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "lblEmail";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "lblGender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "lblBrithdate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "lblColor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "lblCountry";
            // 
            // texName
            // 
            this.texName.Location = new System.Drawing.Point(150, 30);
            this.texName.Name = "texName";
            this.texName.Size = new System.Drawing.Size(200, 20);
            this.texName.TabIndex = 8;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(150, 70);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(200, 20);
            this.textEmail.TabIndex = 9;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(150, 110);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(200, 20);
            this.textPassword.TabIndex = 10;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(150, 140);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Gender";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBoxgender
            // 
            this.groupBoxgender.Controls.Add(this.rdoOther);
            this.groupBoxgender.Controls.Add(this.rdoFemal);
            this.groupBoxgender.Controls.Add(this.rdoMale);
            this.groupBoxgender.Location = new System.Drawing.Point(150, 140);
            this.groupBoxgender.Name = "groupBoxgender";
            this.groupBoxgender.Size = new System.Drawing.Size(200, 50);
            this.groupBoxgender.TabIndex = 12;
            this.groupBoxgender.TabStop = false;
            this.groupBoxgender.Text = "Gender";
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(140, 20);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(53, 17);
            this.rdoOther.TabIndex = 2;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // rdoFemal
            // 
            this.rdoFemal.AutoSize = true;
            this.rdoFemal.Location = new System.Drawing.Point(70, 20);
            this.rdoFemal.Name = "rdoFemal";
            this.rdoFemal.Size = new System.Drawing.Size(59, 17);
            this.rdoFemal.TabIndex = 1;
            this.rdoFemal.TabStop = true;
            this.rdoFemal.Text = "Female";
            this.rdoFemal.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(10, 20);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(47, 17);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // IblSelectedColor
            // 
            this.IblSelectedColor.AutoSize = true;
            this.IblSelectedColor.Location = new System.Drawing.Point(300, 190);
            this.IblSelectedColor.Name = "IblSelectedColor";
            this.IblSelectedColor.Size = new System.Drawing.Size(92, 13);
            this.IblSelectedColor.TabIndex = 13;
            this.IblSelectedColor.Text = "No Color Selected";
            // 
            // dtpBrithdate
            // 
            this.dtpBrithdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBrithdate.Location = new System.Drawing.Point(150, 230);
            this.dtpBrithdate.Name = "dtpBrithdate";
            this.dtpBrithdate.Size = new System.Drawing.Size(200, 20);
            this.dtpBrithdate.TabIndex = 14;
            // 
            // combCuntry
            // 
            this.combCuntry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combCuntry.FormattingEnabled = true;
            this.combCuntry.Location = new System.Drawing.Point(150, 270);
            this.combCuntry.Name = "combCuntry";
            this.combCuntry.Size = new System.Drawing.Size(121, 21);
            this.combCuntry.TabIndex = 16;
            this.combCuntry.SelectedIndexChanged += new System.EventHandler(this.combCuntry_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(150, 320);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Register";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ibIResult
            // 
            this.ibIResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibIResult.Location = new System.Drawing.Point(30, 400);
            this.ibIResult.Name = "ibIResult";
            this.ibIResult.Size = new System.Drawing.Size(500, 13);
            this.ibIResult.TabIndex = 18;
            this.ibIResult.Text = "(empty,will be used to show resulits";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            this.colorDialog1.ShowHelp = true;
            this.colorDialog1.SolidColorOnly = true;
            this.colorDialog1.HelpRequest += new System.EventHandler(this.colorDialog1_HelpRequest);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(260, 320);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // picStudent
            // 
            this.picStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStudent.Location = new System.Drawing.Point(400, 30);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(120, 120);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStudent.TabIndex = 20;
            this.picStudent.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(400, 160);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(100, 30);
            this.btnUpload.TabIndex = 21;
            this.btnUpload.Text = "Upload picture";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(260, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save Date";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(380, 360);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 30);
            this.btnLoad.TabIndex = 23;
            this.btnLoad.Text = "Load Date";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.picStudent);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.ibIResult);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.combCuntry);
            this.Controls.Add(this.dtpBrithdate);
            this.Controls.Add(this.IblSelectedColor);
            this.Controls.Add(this.groupBoxgender);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.texName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistration";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Student Registration Form";
            this.Load += new System.EventHandler(this.FrmRegistration_Load);
            this.groupBoxgender.ResumeLayout(false);
            this.groupBoxgender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox texName;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBoxgender;
        private System.Windows.Forms.RadioButton rdoFemal;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.Label IblSelectedColor;
        private System.Windows.Forms.DateTimePicker dtpBrithdate;
        private System.Windows.Forms.ComboBox combCuntry;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label ibIResult;
        public System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}

