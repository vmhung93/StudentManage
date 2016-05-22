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
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLapLop = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
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
            this.label9.Location = new System.Drawing.Point(17, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "Tên lớp";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(133, 146);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(185, 22);
            this.txtTenLop.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(364, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 17);
            this.label12.TabIndex = 44;
            this.label12.Text = "Sỉ số hiện tại ";
            // 
            // txtSiSo
            // 
            this.txtSiSo.Location = new System.Drawing.Point(499, 146);
            this.txtSiSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(104, 22);
            this.txtSiSo.TabIndex = 47;
            this.txtSiSo.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Lớp";
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
            this.groupBox1.Location = new System.Drawing.Point(21, 233);
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
            this.label10.Location = new System.Drawing.Point(21, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "GVCV";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvLopSelect);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(432, 233);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(343, 340);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đã chọn";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 17);
            this.label13.TabIndex = 52;
            this.label13.Text = "Danh sách học sinh";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(369, 278);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 68);
            this.button4.TabIndex = 56;
            this.button4.Text = ">";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(371, 352);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 68);
            this.button5.TabIndex = 55;
            this.button5.Text = ">>";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(371, 426);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 68);
            this.button6.TabIndex = 54;
            this.button6.Text = "<";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(371, 500);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 68);
            this.button7.TabIndex = 53;
            this.button7.Text = "<<";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(469, 601);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 39);
            this.btnHuy.TabIndex = 58;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLapLop
            // 
            this.btnLapLop.Location = new System.Drawing.Point(596, 601);
            this.btnLapLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLapLop.Name = "btnLapLop";
            this.btnLapLop.Size = new System.Drawing.Size(175, 39);
            this.btnLapLop.TabIndex = 57;
            this.btnLapLop.Text = "Cập nhật";
            this.btnLapLop.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 65);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 59;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(133, 105);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 61;
            // 
            // ChangeClassUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtSiSo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLapLop);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangeClassUserControl";
            this.Size = new System.Drawing.Size(821, 658);
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLapLop;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;

    }
}
