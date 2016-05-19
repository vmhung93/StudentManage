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
            this.btnHuy = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
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
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLapLop
            // 
            this.btnLapLop.Location = new System.Drawing.Point(472, 479);
            this.btnLapLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLapLop.Name = "btnLapLop";
            this.btnLapLop.Size = new System.Drawing.Size(131, 32);
            this.btnLapLop.TabIndex = 27;
            this.btnLapLop.Text = "Lập lớp";
            this.btnLapLop.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(377, 479);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 32);
            this.btnHuy.TabIndex = 28;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(303, 397);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(42, 55);
            this.button7.TabIndex = 23;
            this.button7.Text = "<<";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(303, 337);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(42, 55);
            this.button6.TabIndex = 24;
            this.button6.Text = "<";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(303, 277);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 55);
            this.button5.TabIndex = 25;
            this.button5.Text = ">>";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(302, 217);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 55);
            this.button4.TabIndex = 26;
            this.button4.Text = ">";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 148);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Danh sách học sinh";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvLopSelect);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(349, 180);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(257, 276);
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
            this.lvLopSelect.GridLines = true;
            this.lvLopSelect.Location = new System.Drawing.Point(2, 16);
            this.lvLopSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvLopSelect.Name = "lvLopSelect";
            this.lvLopSelect.Size = new System.Drawing.Size(253, 258);
            this.lvLopSelect.TabIndex = 1;
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
            this.groupBox1.Location = new System.Drawing.Point(41, 180);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(257, 276);
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
            this.lvLop.GridLines = true;
            this.lvLop.Location = new System.Drawing.Point(2, 16);
            this.lvLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvLop.Name = "lvLop";
            this.lvLop.Size = new System.Drawing.Size(253, 258);
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
            this.txtSiSo.Location = new System.Drawing.Point(399, 110);
            this.txtSiSo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(79, 20);
            this.txtSiSo.TabIndex = 17;
            this.txtSiSo.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(298, 110);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Sỉ số hiện tại ";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(125, 110);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(140, 20);
            this.txtTenLop.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tên lớp";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(125, 79);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(88, 20);
            this.txtMaLop.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 79);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Mã lớp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label11.Location = new System.Drawing.Point(120, 29);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 31);
            this.label11.TabIndex = 13;
            this.label11.Text = "Lập lớp mới";
            // 
            // AddClassUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLapLop);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSiSo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddClassUserControl";
            this.Size = new System.Drawing.Size(708, 587);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLapLop;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label13;
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
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
