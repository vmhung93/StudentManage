namespace ManagerStudentApp.GUI.UserControls
{
    partial class AddScoreUserControl
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
            this.btnCapNhatDiem = new System.Windows.Forms.Button();
            this.btnHoanTac = new System.Windows.Forms.Button();
            this.cbbMon = new System.Windows.Forms.ComboBox();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbbHocKi = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhatDiem
            // 
            this.btnCapNhatDiem.Location = new System.Drawing.Point(631, 594);
            this.btnCapNhatDiem.Name = "btnCapNhatDiem";
            this.btnCapNhatDiem.Size = new System.Drawing.Size(175, 40);
            this.btnCapNhatDiem.TabIndex = 36;
            this.btnCapNhatDiem.Text = "Cập nhật điểm";
            this.btnCapNhatDiem.UseVisualStyleBackColor = true;
            this.btnCapNhatDiem.Click += new System.EventHandler(this.btnCapNhatDiem_Click);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Location = new System.Drawing.Point(441, 594);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(175, 40);
            this.btnHoanTac.TabIndex = 37;
            this.btnHoanTac.Text = "Huỷ";
            this.btnHoanTac.UseVisualStyleBackColor = true;
            // 
            // cbbMon
            // 
            this.cbbMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMon.FormattingEnabled = true;
            this.cbbMon.Location = new System.Drawing.Point(441, 92);
            this.cbbMon.Name = "cbbMon";
            this.cbbMon.Size = new System.Drawing.Size(134, 24);
            this.cbbMon.TabIndex = 32;
            this.cbbMon.SelectedValueChanged += new System.EventHandler(this.cbbSelectedIndexChanged);
            // 
            // cbbLop
            // 
            this.cbbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(149, 92);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(134, 24);
            this.cbbLop.TabIndex = 33;
            this.cbbLop.SelectedIndexChanged += new System.EventHandler(this.cbbSelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(324, 92);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 17);
            this.label22.TabIndex = 29;
            this.label22.Text = "Chọn môn";
            // 
            // cbbHocKi
            // 
            this.cbbHocKi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHocKi.FormattingEnabled = true;
            this.cbbHocKi.Location = new System.Drawing.Point(149, 131);
            this.cbbHocKi.Name = "cbbHocKi";
            this.cbbHocKi.Size = new System.Drawing.Size(134, 24);
            this.cbbHocKi.TabIndex = 34;
            this.cbbHocKi.SelectedValueChanged += new System.EventHandler(this.cbbSelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(32, 92);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 17);
            this.label20.TabIndex = 30;
            this.label20.Text = "Chọn lớp";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(32, 131);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 17);
            this.label19.TabIndex = 31;
            this.label19.Text = "Học kì";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label21.Location = new System.Drawing.Point(205, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(319, 39);
            this.label21.TabIndex = 28;
            this.label21.Text = "Bảng điểm môn học";
            // 
            // dgvDiem
            // 
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDiem.Location = new System.Drawing.Point(35, 166);
            this.dgvDiem.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.Size = new System.Drawing.Size(771, 420);
            this.dgvDiem.TabIndex = 38;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã học sinh";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Điểm 15\'";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Điểm 1 tiết";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Điểm học kỳ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // AddScoreUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDiem);
            this.Controls.Add(this.btnCapNhatDiem);
            this.Controls.Add(this.btnHoanTac);
            this.Controls.Add(this.cbbMon);
            this.Controls.Add(this.cbbLop);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.cbbHocKi);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label21);
            this.Name = "AddScoreUserControl";
            this.Size = new System.Drawing.Size(830, 662);
            this.Load += new System.EventHandler(this.AddScoreUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhatDiem;
        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.ComboBox cbbMon;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbbHocKi;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
