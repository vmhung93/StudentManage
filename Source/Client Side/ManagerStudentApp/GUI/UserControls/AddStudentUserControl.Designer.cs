namespace ManagerStudentApp.GUI.UserControls
{
    partial class AddStudentUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHoanTac = new System.Windows.Forms.Button();
            this.lwLop = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.raBtnNu = new System.Windows.Forms.RadioButton();
            this.raBtnNam = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxLopChon = new System.Windows.Forms.TextBox();
            this.btnBoChonLop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(352, 482);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(175, 39);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm học sinh";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Location = new System.Drawing.Point(225, 482);
            this.btnHoanTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(112, 39);
            this.btnHoanTac.TabIndex = 10;
            this.btnHoanTac.Text = "Huỷ";
            this.btnHoanTac.UseVisualStyleBackColor = true;
            // 
            // lwLop
            // 
            this.lwLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lwLop.FullRowSelect = true;
            this.lwLop.GridLines = true;
            this.lwLop.Location = new System.Drawing.Point(144, 344);
            this.lwLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lwLop.Name = "lwLop";
            this.lwLop.Size = new System.Drawing.Size(383, 115);
            this.lwLop.TabIndex = 8;
            this.lwLop.UseCompatibleStateImageBehavior = false;
            this.lwLop.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên lớp";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sỉ số hiện tại";
            this.columnHeader3.Width = 162;
            // 
            // raBtnNu
            // 
            this.raBtnNu.AutoSize = true;
            this.raBtnNu.Location = new System.Drawing.Point(224, 169);
            this.raBtnNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.raBtnNu.Name = "raBtnNu";
            this.raBtnNu.Size = new System.Drawing.Size(47, 21);
            this.raBtnNu.TabIndex = 3;
            this.raBtnNu.TabStop = true;
            this.raBtnNu.Text = "Nữ";
            this.raBtnNu.UseVisualStyleBackColor = true;
            this.raBtnNu.CheckedChanged += new System.EventHandler(this.raBtnNu_CheckedChanged);
            // 
            // raBtnNam
            // 
            this.raBtnNam.AutoSize = true;
            this.raBtnNam.Checked = true;
            this.raBtnNam.Location = new System.Drawing.Point(144, 169);
            this.raBtnNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.raBtnNam.Name = "raBtnNam";
            this.raBtnNam.Size = new System.Drawing.Size(58, 21);
            this.raBtnNam.TabIndex = 2;
            this.raBtnNam.TabStop = true;
            this.raBtnNam.Text = "Nam";
            this.raBtnNam.UseVisualStyleBackColor = true;
            this.raBtnNam.CheckedChanged += new System.EventHandler(this.raBtnNam_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Chọn lớp";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(144, 249);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(383, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(144, 204);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(383, 22);
            this.txtDiaChi.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giới tính";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(144, 94);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(383, 22);
            this.txtHoTen.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(137, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thêm học sinh";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // textBoxLopChon
            // 
            this.textBoxLopChon.Location = new System.Drawing.Point(144, 292);
            this.textBoxLopChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLopChon.Name = "textBoxLopChon";
            this.textBoxLopChon.ReadOnly = true;
            this.textBoxLopChon.Size = new System.Drawing.Size(127, 22);
            this.textBoxLopChon.TabIndex = 6;
            // 
            // btnBoChonLop
            // 
            this.btnBoChonLop.Location = new System.Drawing.Point(304, 288);
            this.btnBoChonLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBoChonLop.Name = "btnBoChonLop";
            this.btnBoChonLop.Size = new System.Drawing.Size(94, 31);
            this.btnBoChonLop.TabIndex = 7;
            this.btnBoChonLop.Text = "Bỏ chọn";
            this.btnBoChonLop.UseVisualStyleBackColor = true;
            this.btnBoChonLop.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // AddStudentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnBoChonLop);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHoanTac);
            this.Controls.Add(this.lwLop);
            this.Controls.Add(this.raBtnNu);
            this.Controls.Add(this.raBtnNam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxLopChon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddStudentUserControl";
            this.Size = new System.Drawing.Size(559, 553);
            this.Load += new System.EventHandler(this.AddStudentUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.ListView lwLop;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.RadioButton raBtnNu;
        private System.Windows.Forms.RadioButton raBtnNam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxLopChon;
        private System.Windows.Forms.Button btnBoChonLop;

    }
}
