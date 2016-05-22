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
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.listView6 = new System.Windows.Forms.ListView();
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(333, 452);
            this.button15.Margin = new System.Windows.Forms.Padding(2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(131, 32);
            this.button15.TabIndex = 51;
            this.button15.Text = "Huỷ";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(467, 452);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(131, 32);
            this.button14.TabIndex = 52;
            this.button14.Text = "Lưu báo cáo";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(452, 57);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(131, 32);
            this.button13.TabIndex = 53;
            this.button13.Text = "Lập báo cáo";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // listView6
            // 
            this.listView6.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24});
            this.listView6.GridLines = true;
            this.listView6.Location = new System.Drawing.Point(27, 113);
            this.listView6.Margin = new System.Windows.Forms.Padding(2);
            this.listView6.Name = "listView6";
            this.listView6.Size = new System.Drawing.Size(572, 324);
            this.listView6.TabIndex = 50;
            this.listView6.UseCompatibleStateImageBehavior = false;
            this.listView6.View = System.Windows.Forms.View.Details;
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
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(74, 61);
            this.comboBox7.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(102, 21);
            this.comboBox7.TabIndex = 49;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(32, 64);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 13);
            this.label24.TabIndex = 47;
            this.label24.Text = "Học kì";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label25.Location = new System.Drawing.Point(145, 12);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(303, 31);
            this.label25.TabIndex = 45;
            this.label25.Text = "Báo cáo tổng kết học kỳ";
            // 
            // AddReportSemsterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.listView6);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Name = "AddReportSemsterUserControl";
            this.Size = new System.Drawing.Size(629, 496);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ListView listView6;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
    }
}
