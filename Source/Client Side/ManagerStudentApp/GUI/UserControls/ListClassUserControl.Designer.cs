namespace ManagerStudentApp.GUI.UserControls
{
    partial class ListClassUserControl
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
            this.changeClassUserControl1 = new ManagerStudentApp.GUI.UserControls.ChangeClassUserControl();
            this.SuspendLayout();
            // 
            // changeClassUserControl1
            // 
            this.changeClassUserControl1.Location = new System.Drawing.Point(3, 3);
            this.changeClassUserControl1.Name = "changeClassUserControl1";
            this.changeClassUserControl1.Size = new System.Drawing.Size(616, 535);
            this.changeClassUserControl1.TabIndex = 0;
            // 
            // ListClassUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.changeClassUserControl1);
            this.Name = "ListClassUserControl";
            this.Size = new System.Drawing.Size(614, 543);
            this.ResumeLayout(false);

        }

        #endregion

        private ChangeClassUserControl changeClassUserControl1;
    }
}
