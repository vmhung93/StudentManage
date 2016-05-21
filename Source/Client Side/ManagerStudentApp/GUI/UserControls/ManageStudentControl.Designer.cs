﻿namespace ManagerStudentApp.GUI.UserControls
{
    partial class ManageStudentControl
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.detailStudent1 = new ManagerStudentApp.GUI.UserControls.DetailStudentUserControl();
            this.listStudentUserControl1 = new ManagerStudentApp.GUI.UserControls.ListStudentUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.detailStudent1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listStudentUserControl1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(778, 620);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.TabIndex = 0;
            // 
            // detailStudent1
            // 
            this.detailStudent1.Location = new System.Drawing.Point(0, 0);
            this.detailStudent1.Name = "detailStudent1";
            this.detailStudent1.Size = new System.Drawing.Size(776, 180);
            this.detailStudent1.TabIndex = 0;
            // 
            // listStudentUserControl1
            // 
            this.listStudentUserControl1.Location = new System.Drawing.Point(80, 2);
            this.listStudentUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.listStudentUserControl1.Name = "listStudentUserControl1";
            this.listStudentUserControl1.Size = new System.Drawing.Size(614, 443);
            this.listStudentUserControl1.TabIndex = 0;
            // 
            // ManageStudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "ManageStudentControl";
            this.Size = new System.Drawing.Size(778, 620);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DetailStudentUserControl detailStudent1;
        private ListStudentUserControl listStudentUserControl1;
    }
}
