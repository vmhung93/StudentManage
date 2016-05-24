namespace ManagerStudentApp.GUI.UserControls
{
    partial class AddReportSubjectUserControl
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
            this.btnLapBaoCao = new System.Windows.Forms.Button();
            this.lvTongKet = new System.Windows.Forms.ListView();
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbbMon = new System.Windows.Forms.ComboBox();
            this.cbbHocKi = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLapBaoCao
            // 
            this.btnLapBaoCao.Location = new System.Drawing.Point(674, 85);
            this.btnLapBaoCao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLapBaoCao.Name = "btnLapBaoCao";
            this.btnLapBaoCao.Size = new System.Drawing.Size(114, 31);
            this.btnLapBaoCao.TabIndex = 44;
            this.btnLapBaoCao.Text = "Lập báo cáo";
            this.btnLapBaoCao.UseVisualStyleBackColor = true;
            this.btnLapBaoCao.Click += new System.EventHandler(this.btnLapBaoCao_Click);
            // 
            // lvTongKet
            // 
            this.lvTongKet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24});
            this.lvTongKet.FullRowSelect = true;
            this.lvTongKet.GridLines = true;
            this.lvTongKet.Location = new System.Drawing.Point(27, 127);
            this.lvTongKet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvTongKet.Name = "lvTongKet";
            this.lvTongKet.Size = new System.Drawing.Size(761, 439);
            this.lvTongKet.TabIndex = 41;
            this.lvTongKet.UseCompatibleStateImageBehavior = false;
            this.lvTongKet.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "STT";
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Lớp";
            this.columnHeader21.Width = 110;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Sỉ số";
            this.columnHeader22.Width = 127;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Số lượng đạt";
            this.columnHeader23.Width = 162;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Tỉ lệ";
            this.columnHeader24.Width = 181;
            // 
            // cbbMon
            // 
            this.cbbMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMon.FormattingEnabled = true;
            this.cbbMon.Location = new System.Drawing.Point(102, 89);
            this.cbbMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMon.Name = "cbbMon";
            this.cbbMon.Size = new System.Drawing.Size(135, 24);
            this.cbbMon.TabIndex = 39;
            // 
            // cbbHocKi
            // 
            this.cbbHocKi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHocKi.FormattingEnabled = true;
            this.cbbHocKi.Location = new System.Drawing.Point(347, 89);
            this.cbbHocKi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbHocKi.Name = "cbbHocKi";
            this.cbbHocKi.Size = new System.Drawing.Size(135, 24);
            this.cbbHocKi.TabIndex = 40;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(24, 92);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 17);
            this.label23.TabIndex = 37;
            this.label23.Text = "Chọn môn";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(291, 92);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 17);
            this.label24.TabIndex = 38;
            this.label24.Text = "Học kì";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label25.Location = new System.Drawing.Point(205, 15);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(346, 39);
            this.label25.TabIndex = 36;
            this.label25.Text = "Báo cáo tổng kết môn";
            // 
            // AddReportSubjectUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnLapBaoCao);
            this.Controls.Add(this.lvTongKet);
            this.Controls.Add(this.cbbMon);
            this.Controls.Add(this.cbbHocKi);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddReportSubjectUserControl";
            this.Size = new System.Drawing.Size(821, 599);
            this.Load += new System.EventHandler(this.AddReportSubjectUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLapBaoCao;
        private System.Windows.Forms.ListView lvTongKet;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ComboBox cbbMon;
        private System.Windows.Forms.ComboBox cbbHocKi;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
    }
}
