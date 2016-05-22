namespace ManagerStudentApp.GUI.UserControls
{
    partial class ListClassUserControl
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
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvDsHocSinh = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDsLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKhoiLop = new System.Windows.Forms.TextBox();
            this.txtTenGVHienTai = new System.Windows.Forms.TextBox();
            this.txtTenLopHienTai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSiSo
            // 
            this.txtSiSo.Location = new System.Drawing.Point(684, 182);
            this.txtSiSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.ReadOnly = true;
            this.txtSiSo.Size = new System.Drawing.Size(104, 22);
            this.txtSiSo.TabIndex = 66;
            this.txtSiSo.Text = "1";
            this.txtSiSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvDsHocSinh);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(33, 208);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(755, 502);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách học sinh";
            // 
            // lvDsHocSinh
            // 
            this.lvDsHocSinh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader1});
            this.lvDsHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDsHocSinh.FullRowSelect = true;
            this.lvDsHocSinh.GridLines = true;
            this.lvDsHocSinh.Location = new System.Drawing.Point(3, 19);
            this.lvDsHocSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvDsHocSinh.Name = "lvDsHocSinh";
            this.lvDsHocSinh.Size = new System.Drawing.Size(749, 481);
            this.lvDsHocSinh.TabIndex = 1;
            this.lvDsHocSinh.UseCompatibleStateImageBehavior = false;
            this.lvDsHocSinh.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "#";
            this.columnHeader7.Width = 98;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Họ tên";
            this.columnHeader8.Width = 121;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ngày sinh";
            this.columnHeader9.Width = 103;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Địa chỉ";
            this.columnHeader1.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(252, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 39);
            this.label2.TabIndex = 62;
            this.label2.Text = "Danh sách các lớp";
            // 
            // comboBoxDsLop
            // 
            this.comboBoxDsLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDsLop.FormattingEnabled = true;
            this.comboBoxDsLop.Location = new System.Drawing.Point(200, 92);
            this.comboBoxDsLop.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDsLop.Name = "comboBoxDsLop";
            this.comboBoxDsLop.Size = new System.Drawing.Size(178, 24);
            this.comboBoxDsLop.TabIndex = 77;
            this.comboBoxDsLop.SelectedIndexChanged += new System.EventHandler(this.comboBoxDsLop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 78;
            this.label1.Text = "Lớp";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(549, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 17);
            this.label12.TabIndex = 63;
            this.label12.Text = "Sỉ số hiện tại ";
            // 
            // txtKhoiLop
            // 
            this.txtKhoiLop.Location = new System.Drawing.Point(200, 122);
            this.txtKhoiLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKhoiLop.Name = "txtKhoiLop";
            this.txtKhoiLop.ReadOnly = true;
            this.txtKhoiLop.Size = new System.Drawing.Size(178, 22);
            this.txtKhoiLop.TabIndex = 79;
            // 
            // txtTenGVHienTai
            // 
            this.txtTenGVHienTai.Location = new System.Drawing.Point(200, 150);
            this.txtTenGVHienTai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenGVHienTai.Name = "txtTenGVHienTai";
            this.txtTenGVHienTai.ReadOnly = true;
            this.txtTenGVHienTai.Size = new System.Drawing.Size(178, 22);
            this.txtTenGVHienTai.TabIndex = 80;
            // 
            // txtTenLopHienTai
            // 
            this.txtTenLopHienTai.Location = new System.Drawing.Point(200, 179);
            this.txtTenLopHienTai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenLopHienTai.Name = "txtTenLopHienTai";
            this.txtTenLopHienTai.ReadOnly = true;
            this.txtTenLopHienTai.Size = new System.Drawing.Size(178, 22);
            this.txtTenLopHienTai.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 82;
            this.label4.Text = "Tên lớp hiện tại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 83;
            this.label5.Text = "Khối lớp hiện tại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 84;
            this.label3.Text = "GVCN hiện tại";
            // 
            // ListClassUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtKhoiLop);
            this.Controls.Add(this.txtTenGVHienTai);
            this.Controls.Add(this.txtTenLopHienTai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSiSo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDsLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListClassUserControl";
            this.Size = new System.Drawing.Size(819, 737);
            this.Load += new System.EventHandler(this.ListClassUserControl_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvDsHocSinh;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDsLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txtKhoiLop;
        private System.Windows.Forms.TextBox txtTenGVHienTai;
        private System.Windows.Forms.TextBox txtTenLopHienTai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;

    }
}
