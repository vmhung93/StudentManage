namespace ManagerStudentApp.GUI.UserControls
{
    partial class ChangeSubjectUserControl
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
            this.lvSubjects = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnHoanTac = new System.Windows.Forms.Button();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuyMonHoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvSubjects
            // 
            this.lvSubjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11});
            this.lvSubjects.FullRowSelect = true;
            this.lvSubjects.GridLines = true;
            this.lvSubjects.Location = new System.Drawing.Point(77, 225);
            this.lvSubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvSubjects.MultiSelect = false;
            this.lvSubjects.Name = "lvSubjects";
            this.lvSubjects.Size = new System.Drawing.Size(505, 465);
            this.lvSubjects.TabIndex = 2;
            this.lvSubjects.UseCompatibleStateImageBehavior = false;
            this.lvSubjects.View = System.Windows.Forms.View.Details;
            this.lvSubjects.SelectedIndexChanged += new System.EventHandler(this.lvSubjects_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "#";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tên môn học";
            this.columnHeader11.Width = 300;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(74, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 17);
            this.label14.TabIndex = 36;
            this.label14.Text = "Danh sách môn học";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label17.Location = new System.Drawing.Point(147, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(294, 39);
            this.label17.TabIndex = 35;
            this.label17.Text = "Cập nhật môn học";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(407, 148);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(175, 31);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Location = new System.Drawing.Point(280, 148);
            this.btnHoanTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(112, 31);
            this.btnHoanTac.TabIndex = 3;
            this.btnHoanTac.Text = "Hoàn tác";
            this.btnHoanTac.UseVisualStyleBackColor = true;
            this.btnHoanTac.Click += new System.EventHandler(this.btnHoanTac_Click);
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(197, 94);
            this.txtSubjectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(383, 22);
            this.txtSubjectName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tên môn học";
            // 
            // btnHuyMonHoc
            // 
            this.btnHuyMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyMonHoc.Location = new System.Drawing.Point(77, 148);
            this.btnHuyMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuyMonHoc.Name = "btnHuyMonHoc";
            this.btnHuyMonHoc.Size = new System.Drawing.Size(112, 31);
            this.btnHuyMonHoc.TabIndex = 4;
            this.btnHuyMonHoc.Text = "Huỷ môn học";
            this.btnHuyMonHoc.UseVisualStyleBackColor = true;
            this.btnHuyMonHoc.Click += new System.EventHandler(this.btnHuyMonHoc_Click);
            // 
            // ChangeSubjectUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnHuyMonHoc);
            this.Controls.Add(this.btnHoanTac);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvSubjects);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label17);
            this.Name = "ChangeSubjectUserControl";
            this.Size = new System.Drawing.Size(644, 731);
            this.Load += new System.EventHandler(this.ChangeSubjectUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSubjects;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHuyMonHoc;
    }
}
