namespace ManagerStudentApp.GUI.UserControls
{
    partial class ChangeClassUserControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvLop = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lvLopSelect = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnSubstractAll = new System.Windows.Forms.Button();
            this.btnHoanTac = new System.Windows.Forms.Button();
            this.btnCapNhatLop = new System.Windows.Forms.Button();
            this.comboBoxLop = new System.Windows.Forms.ComboBox();
            this.comboBoxGVCN = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenLopHienTai = new System.Windows.Forms.TextBox();
            this.txtTenGVHienTai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKhoiLopHienTai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxKhoiLop = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(281, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 39);
            this.label2.TabIndex = 42;
            this.label2.Text = "Cập nhật lớp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(466, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "Tên lớp mới";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(589, 71);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(185, 22);
            this.txtTenLop.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(466, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 17);
            this.label12.TabIndex = 44;
            this.label12.Text = "Sỉ số hiện tại ";
            // 
            // txtSiSo
            // 
            this.txtSiSo.Location = new System.Drawing.Point(670, 159);
            this.txtSiSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.ReadOnly = true;
            this.txtSiSo.Size = new System.Drawing.Size(104, 22);
            this.txtSiSo.TabIndex = 47;
            this.txtSiSo.Text = "1";
            this.txtSiSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Chọn lớp";
            // 
            // lvLop
            // 
            this.lvLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLop.GridLines = true;
            this.lvLop.Location = new System.Drawing.Point(3, 19);
            this.lvLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvLop.Name = "lvLop";
            this.lvLop.Size = new System.Drawing.Size(337, 319);
            this.lvLop.TabIndex = 0;
            this.lvLop.UseCompatibleStateImageBehavior = false;
            this.lvLop.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã học sinh";
            this.columnHeader4.Width = 78;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Họ tên";
            this.columnHeader5.Width = 92;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày sinh";
            this.columnHeader6.Width = 128;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvLop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(20, 189);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(343, 340);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách chưa có lớp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(466, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "GVCN mới";
            // 
            // lvLopSelect
            // 
            this.lvLopSelect.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvLopSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLopSelect.GridLines = true;
            this.lvLopSelect.Location = new System.Drawing.Point(3, 19);
            this.lvLopSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvLopSelect.Name = "lvLopSelect";
            this.lvLopSelect.Size = new System.Drawing.Size(337, 319);
            this.lvLopSelect.TabIndex = 0;
            this.lvLopSelect.UseCompatibleStateImageBehavior = false;
            this.lvLopSelect.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã học sinh";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvLopSelect);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(431, 189);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(343, 340);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đã chọn";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(370, 236);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 68);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(370, 308);
            this.btnAddAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(56, 68);
            this.btnAddAll.TabIndex = 8;
            this.btnAddAll.Text = ">>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(370, 382);
            this.btnSubstract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(56, 68);
            this.btnSubstract.TabIndex = 9;
            this.btnSubstract.Text = "<";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnSubstractAll
            // 
            this.btnSubstractAll.Location = new System.Drawing.Point(370, 456);
            this.btnSubstractAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubstractAll.Name = "btnSubstractAll";
            this.btnSubstractAll.Size = new System.Drawing.Size(56, 68);
            this.btnSubstractAll.TabIndex = 10;
            this.btnSubstractAll.Text = "<<";
            this.btnSubstractAll.UseVisualStyleBackColor = true;
            this.btnSubstractAll.Click += new System.EventHandler(this.btnSubstractAll_Click);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Location = new System.Drawing.Point(469, 533);
            this.btnHoanTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(112, 39);
            this.btnHoanTac.TabIndex = 12;
            this.btnHoanTac.Text = "Hoàn tác";
            this.btnHoanTac.UseVisualStyleBackColor = true;
            this.btnHoanTac.Click += new System.EventHandler(this.btnHoanTac_Click);
            // 
            // btnCapNhatLop
            // 
            this.btnCapNhatLop.Location = new System.Drawing.Point(596, 533);
            this.btnCapNhatLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatLop.Name = "btnCapNhatLop";
            this.btnCapNhatLop.Size = new System.Drawing.Size(175, 39);
            this.btnCapNhatLop.TabIndex = 11;
            this.btnCapNhatLop.Text = "Cập nhật";
            this.btnCapNhatLop.UseVisualStyleBackColor = true;
            this.btnCapNhatLop.Click += new System.EventHandler(this.btnCapNhatLop_Click);
            // 
            // comboBoxLop
            // 
            this.comboBoxLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLop.FormattingEnabled = true;
            this.comboBoxLop.Location = new System.Drawing.Point(185, 69);
            this.comboBoxLop.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLop.Name = "comboBoxLop";
            this.comboBoxLop.Size = new System.Drawing.Size(178, 24);
            this.comboBoxLop.TabIndex = 0;
            this.comboBoxLop.SelectedIndexChanged += new System.EventHandler(this.comboBoxLop_SelectedIndexChanged);
            // 
            // comboBoxGVCN
            // 
            this.comboBoxGVCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGVCN.FormattingEnabled = true;
            this.comboBoxGVCN.Location = new System.Drawing.Point(589, 128);
            this.comboBoxGVCN.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxGVCN.Name = "comboBoxGVCN";
            this.comboBoxGVCN.Size = new System.Drawing.Size(185, 24);
            this.comboBoxGVCN.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "GVCN hiện tại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Tên lớp hiện tại";
            // 
            // txtTenLopHienTai
            // 
            this.txtTenLopHienTai.Location = new System.Drawing.Point(185, 159);
            this.txtTenLopHienTai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenLopHienTai.Name = "txtTenLopHienTai";
            this.txtTenLopHienTai.ReadOnly = true;
            this.txtTenLopHienTai.Size = new System.Drawing.Size(178, 22);
            this.txtTenLopHienTai.TabIndex = 3;
            // 
            // txtTenGVHienTai
            // 
            this.txtTenGVHienTai.Location = new System.Drawing.Point(185, 130);
            this.txtTenGVHienTai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenGVHienTai.Name = "txtTenGVHienTai";
            this.txtTenGVHienTai.ReadOnly = true;
            this.txtTenGVHienTai.Size = new System.Drawing.Size(178, 22);
            this.txtTenGVHienTai.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Khối lớp hiện tại";
            // 
            // txtKhoiLopHienTai
            // 
            this.txtKhoiLopHienTai.Location = new System.Drawing.Point(185, 102);
            this.txtKhoiLopHienTai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKhoiLopHienTai.Name = "txtKhoiLopHienTai";
            this.txtKhoiLopHienTai.ReadOnly = true;
            this.txtKhoiLopHienTai.Size = new System.Drawing.Size(178, 22);
            this.txtKhoiLopHienTai.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Khối lớp mới";
            // 
            // comboBoxKhoiLop
            // 
            this.comboBoxKhoiLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKhoiLop.FormattingEnabled = true;
            this.comboBoxKhoiLop.Location = new System.Drawing.Point(589, 99);
            this.comboBoxKhoiLop.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxKhoiLop.Name = "comboBoxKhoiLop";
            this.comboBoxKhoiLop.Size = new System.Drawing.Size(185, 24);
            this.comboBoxKhoiLop.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Location = new System.Drawing.Point(20, 533);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 39);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Huỷ lớp";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ChangeClassUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxKhoiLop);
            this.Controls.Add(this.txtKhoiLopHienTai);
            this.Controls.Add(this.txtTenGVHienTai);
            this.Controls.Add(this.comboBoxGVCN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxLop);
            this.Controls.Add(this.txtSiSo);
            this.Controls.Add(this.txtTenLopHienTai);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapNhatLop);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnHoanTac);
            this.Controls.Add(this.btnSubstractAll);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangeClassUserControl";
            this.Size = new System.Drawing.Size(804, 611);
            this.Load += new System.EventHandler(this.ChangeClassUserControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvLop;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView lvLopSelect;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnSubstractAll;
        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.Button btnCapNhatLop;
        private System.Windows.Forms.ComboBox comboBoxLop;
        private System.Windows.Forms.ComboBox comboBoxGVCN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenLopHienTai;
        private System.Windows.Forms.TextBox txtTenGVHienTai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKhoiLopHienTai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxKhoiLop;
        private System.Windows.Forms.Button btnDelete;

    }
}
