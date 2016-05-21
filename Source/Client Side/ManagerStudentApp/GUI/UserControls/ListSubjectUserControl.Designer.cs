namespace ManagerStudentApp.GUI.UserControls
{
    partial class ListSubjectUserControl
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
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button10 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listView4.GridLines = true;
            this.listView4.Location = new System.Drawing.Point(21, 114);
            this.listView4.Margin = new System.Windows.Forms.Padding(2);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(572, 288);
            this.listView4.TabIndex = 34;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Mã môn học";
            this.columnHeader10.Width = 128;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tên môn học";
            this.columnHeader11.Width = 147;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Lớp";
            this.columnHeader13.Width = 127;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "TB Học kỳ 1";
            this.columnHeader14.Width = 161;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "TB Học kỳ 2";
            this.columnHeader15.Width = 181;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(453, 42);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(131, 32);
            this.button10.TabIndex = 33;
            this.button10.Text = "Tìm kiếm";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 83);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Danh sách môn học";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(92, 49);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(331, 20);
            this.textBox10.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 52);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Tên môn học";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label17.Location = new System.Drawing.Point(195, -1);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(216, 31);
            this.label17.TabIndex = 27;
            this.label17.Text = "Tra cứu môn học";
            // 
            // ListSubjectUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Name = "ListSubjectUserControl";
            this.Size = new System.Drawing.Size(624, 483);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}
