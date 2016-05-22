namespace ManagerStudentApp.GUI.UserControls
{
    partial class AddClassUserControl
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
            this.btnLapLop = new System.Windows.Forms.Button();
            this.btnHoanTac = new System.Windows.Forms.Button();
            this.btnSubtractAll = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvLopSelect = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvLop = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGVCN = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKhoiLop = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLapLop
            // 
            this.btnLapLop.Location = new System.Drawing.Point(599, 525);
            this.btnLapLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLapLop.Name = "btnLapLop";
            this.btnLapLop.Size = new System.Drawing.Size(175, 39);
            this.btnLapLop.TabIndex = 7;
            this.btnLapLop.Text = "Lập lớp";
            this.btnLapLop.UseVisualStyleBackColor = true;
            this.btnLapLop.Click += new System.EventHandler(this.btnLapLop_Click);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Location = new System.Drawing.Point(473, 525);
            this.btnHoanTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(112, 39);
            this.btnHoanTac.TabIndex = 8;
            this.btnHoanTac.Text = "Hoàn tác";
            this.btnHoanTac.UseVisualStyleBackColor = true;
            this.btnHoanTac.Click += new System.EventHandler(this.btnHoanTac_Click);
            // 
            // btnSubtractAll
            // 
            this.btnSubtractAll.Location = new System.Drawing.Point(370, 448);
            this.btnSubtractAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubtractAll.Name = "btnSubtractAll";
            this.btnSubtractAll.Size = new System.Drawing.Size(56, 68);
            this.btnSubtractAll.TabIndex = 6;
            this.btnSubtractAll.Text = "<<";
            this.btnSubtractAll.UseVisualStyleBackColor = true;
            this.btnSubtractAll.Click += new System.EventHandler(this.btnSubtractAll_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(370, 374);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(56, 68);
            this.btnSubtract.TabIndex = 5;
            this.btnSubtract.Text = "<";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(370, 300);
            this.btnAddAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(56, 68);
            this.btnAddAll.TabIndex = 4;
            this.btnAddAll.Text = ">>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(369, 226);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 68);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvLopSelect);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(431, 181);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(343, 340);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đã chọn";
            // 
            // lvLopSelect
            // 
            this.lvLopSelect.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvLopSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLopSelect.FullRowSelect = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvLop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(21, 181);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(343, 340);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách chưa có lớp";
            // 
            // lvLop
            // 
            this.lvLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLop.FullRowSelect = true;
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
            // txtSiSo
            // 
            this.txtSiSo.Location = new System.Drawing.Point(716, 155);
            this.txtSiSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.ReadOnly = true;
            this.txtSiSo.Size = new System.Drawing.Size(55, 22);
            this.txtSiSo.TabIndex = 17;
            this.txtSiSo.Text = "1";
            this.txtSiSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(592, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Sỉ số hiện tại ";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(174, 89);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(185, 22);
            this.txtTenLop.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tên lớp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label11.Location = new System.Drawing.Point(302, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 39);
            this.label11.TabIndex = 13;
            this.label11.Text = "Lập lớp mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Giáo viên chủ nhiệm";
            // 
            // comboBoxGVCN
            // 
            this.comboBoxGVCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGVCN.FormattingEnabled = true;
            this.comboBoxGVCN.Location = new System.Drawing.Point(174, 117);
            this.comboBoxGVCN.Name = "comboBoxGVCN";
            this.comboBoxGVCN.Size = new System.Drawing.Size(185, 24);
            this.comboBoxGVCN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Khối lớp";
            // 
            // comboBoxKhoiLop
            // 
            this.comboBoxKhoiLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKhoiLop.FormattingEnabled = true;
            this.comboBoxKhoiLop.Location = new System.Drawing.Point(173, 148);
            this.comboBoxKhoiLop.Name = "comboBoxKhoiLop";
            this.comboBoxKhoiLop.Size = new System.Drawing.Size(185, 24);
            this.comboBoxKhoiLop.TabIndex = 2;
            // 
            // AddClassUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxKhoiLop);
            this.Controls.Add(this.comboBoxGVCN);
            this.Controls.Add(this.btnLapLop);
            this.Controls.Add(this.btnHoanTac);
            this.Controls.Add(this.btnSubtractAll);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSiSo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddClassUserControl";
            this.Size = new System.Drawing.Size(796, 602);
            this.Load += new System.EventHandler(this.AddClassUserControl_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLapLop;
        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.Button btnSubtractAll;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvLopSelect;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvLop;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGVCN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKhoiLop;
    }
}
