namespace ManagerStudentApp.GUI.UserControls
{
    partial class AddReportSemsterUserControl
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
            this.cbbHocKi = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLapBaoCao
            // 
            this.btnLapBaoCao.Location = new System.Drawing.Point(660, 96);
            this.btnLapBaoCao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLapBaoCao.Name = "btnLapBaoCao";
            this.btnLapBaoCao.Size = new System.Drawing.Size(114, 31);
            this.btnLapBaoCao.TabIndex = 1;
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
            this.lvTongKet.Location = new System.Drawing.Point(29, 139);
            this.lvTongKet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvTongKet.Name = "lvTongKet";
            this.lvTongKet.Size = new System.Drawing.Size(745, 432);
            this.lvTongKet.TabIndex = 2;
            this.lvTongKet.UseCompatibleStateImageBehavior = false;
            this.lvTongKet.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "STT";
            this.columnHeader20.Width = 82;
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
            // cbbHocKi
            // 
            this.cbbHocKi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHocKi.FormattingEnabled = true;
            this.cbbHocKi.Location = new System.Drawing.Point(86, 96);
            this.cbbHocKi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbHocKi.Name = "cbbHocKi";
            this.cbbHocKi.Size = new System.Drawing.Size(135, 24);
            this.cbbHocKi.TabIndex = 0;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(30, 100);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 17);
            this.label24.TabIndex = 47;
            this.label24.Text = "Học kì";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label25.Location = new System.Drawing.Point(217, 15);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(378, 39);
            this.label25.TabIndex = 45;
            this.label25.Text = "Báo cáo tổng kết học kỳ";
            // 
            // AddReportSemsterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLapBaoCao);
            this.Controls.Add(this.lvTongKet);
            this.Controls.Add(this.cbbHocKi);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddReportSemsterUserControl";
            this.Size = new System.Drawing.Size(806, 610);
            this.Load += new System.EventHandler(this.AddReportSemsterUserControl_Load);
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
        private System.Windows.Forms.ComboBox cbbHocKi;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
    }
}
