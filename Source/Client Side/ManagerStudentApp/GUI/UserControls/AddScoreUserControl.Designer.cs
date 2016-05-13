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
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.listView5 = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(623, 555);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(175, 40);
            this.button12.TabIndex = 36;
            this.button12.Text = "Lập bảng điểm";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(441, 555);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(175, 40);
            this.button11.TabIndex = 37;
            this.button11.Text = "Huỷ";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // listView5
            // 
            this.listView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.listView5.GridLines = true;
            this.listView5.Location = new System.Drawing.Point(37, 182);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(761, 354);
            this.listView5.TabIndex = 35;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Mã học sinh";
            this.columnHeader12.Width = 128;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Họ tên";
            this.columnHeader16.Width = 147;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Điểm 15\'";
            this.columnHeader17.Width = 127;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Điểm 1 tiết";
            this.columnHeader18.Width = 161;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Điểm cuối HK";
            this.columnHeader19.Width = 181;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(441, 92);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(134, 24);
            this.comboBox4.TabIndex = 32;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(149, 92);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(134, 24);
            this.comboBox3.TabIndex = 33;
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(149, 131);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(134, 24);
            this.comboBox2.TabIndex = 34;
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
            this.label21.Location = new System.Drawing.Point(142, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(319, 39);
            this.label21.TabIndex = 28;
            this.label21.Text = "Bảng điểm môn học";
            // 
            // AddScoreUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.listView5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label21);
            this.Name = "AddScoreUserControl";
            this.Size = new System.Drawing.Size(830, 627);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
    }
}
