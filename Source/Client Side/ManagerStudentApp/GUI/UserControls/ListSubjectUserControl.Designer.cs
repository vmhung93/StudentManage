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
            this.lvSubjects = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvSubjects
            // 
            this.lvSubjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11});
            this.lvSubjects.FullRowSelect = true;
            this.lvSubjects.GridLines = true;
            this.lvSubjects.Location = new System.Drawing.Point(41, 98);
            this.lvSubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvSubjects.Name = "lvSubjects";
            this.lvSubjects.Size = new System.Drawing.Size(517, 430);
            this.lvSubjects.TabIndex = 34;
            this.lvSubjects.UseCompatibleStateImageBehavior = false;
            this.lvSubjects.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "#";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tên môn học";
            this.columnHeader11.Width = 250;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "Danh sách môn học";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label17.Location = new System.Drawing.Point(158, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(271, 39);
            this.label17.TabIndex = 27;
            this.label17.Text = "Tra cứu môn học";
            // 
            // ListSubjectUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvSubjects);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label17);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListSubjectUserControl";
            this.Size = new System.Drawing.Size(601, 559);
            this.Load += new System.EventHandler(this.ListSubjectUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSubjects;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
    }
}
