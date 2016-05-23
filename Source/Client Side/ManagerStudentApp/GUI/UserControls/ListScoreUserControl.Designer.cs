namespace ManagerStudentApp.GUI.UserControls
{
    partial class ListScoreUserControl
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
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.cbbMon = new System.Windows.Forms.ComboBox();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbLop
            // 
            this.cbbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(137, 74);
            this.cbbLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(135, 24);
            this.cbbLop.TabIndex = 0;
            this.cbbLop.SelectedIndexChanged += new System.EventHandler(this.cbbSelectedIndexChanged);
            // 
            // cbbMon
            // 
            this.cbbMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMon.FormattingEnabled = true;
            this.cbbMon.Location = new System.Drawing.Point(429, 74);
            this.cbbMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMon.Name = "cbbMon";
            this.cbbMon.Size = new System.Drawing.Size(135, 24);
            this.cbbMon.TabIndex = 1;
            this.cbbMon.SelectedIndexChanged += new System.EventHandler(this.cbbSelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(312, 74);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 17);
            this.label22.TabIndex = 39;
            this.label22.Text = "Chọn môn";
            // 
            // cbbHocKi
            // 
            this.cbbHocKi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHocKi.FormattingEnabled = true;
            this.cbbHocKi.Location = new System.Drawing.Point(137, 112);
            this.cbbHocKi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbHocKi.Name = "cbbHocKi";
            this.cbbHocKi.Size = new System.Drawing.Size(135, 24);
            this.cbbHocKi.TabIndex = 2;
            this.cbbHocKi.SelectedIndexChanged += new System.EventHandler(this.cbbSelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 17);
            this.label20.TabIndex = 40;
            this.label20.Text = "Chọn lớp";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 112);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 17);
            this.label19.TabIndex = 41;
            this.label19.Text = "Học kì";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label21.Location = new System.Drawing.Point(242, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(354, 39);
            this.label21.TabIndex = 38;
            this.label21.Text = "Tra cứu điểm môn học";
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
            this.dgvDiem.Location = new System.Drawing.Point(24, 161);
            this.dgvDiem.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.ReadOnly = true;
            this.dgvDiem.Size = new System.Drawing.Size(771, 420);
            this.dgvDiem.TabIndex = 3;
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
            // ListScoreUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDiem);
            this.Controls.Add(this.cbbLop);
            this.Controls.Add(this.cbbMon);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.cbbHocKi);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label21);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListScoreUserControl";
            this.Size = new System.Drawing.Size(823, 601);
            this.Load += new System.EventHandler(this.ListScoreUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.ComboBox cbbMon;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
