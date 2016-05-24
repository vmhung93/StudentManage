namespace ManagerStudentApp.GUI.UserControls
{
    partial class SettingUserControl
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
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThayDoi = new System.Windows.Forms.Button();
            this.numericMinAge = new System.Windows.Forms.NumericUpDown();
            this.numericMaxAge = new System.Windows.Forms.NumericUpDown();
            this.numericMaxNumberInClass = new System.Windows.Forms.NumericUpDown();
            this.numericPassScore = new System.Windows.Forms.NumericUpDown();
            this.btnHoanTac = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxNumberInClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPassScore)).BeginInit();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label17.Location = new System.Drawing.Point(117, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(153, 39);
            this.label17.TabIndex = 35;
            this.label17.Text = "Quy định";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 64;
            this.label8.Text = "Tuổi tối thiểu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Tuổi tối đa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Điểm chuẩn đạt môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Sỉ số tối đa của một lớp";
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.Location = new System.Drawing.Point(250, 270);
            this.btnThayDoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(106, 28);
            this.btnThayDoi.TabIndex = 67;
            this.btnThayDoi.Text = "Thay đổi";
            this.btnThayDoi.UseVisualStyleBackColor = true;
            this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click);
            // 
            // numericMinAge
            // 
            this.numericMinAge.Increment = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            this.numericMinAge.Location = new System.Drawing.Point(236, 83);
            this.numericMinAge.Name = "numericMinAge";
            this.numericMinAge.Size = new System.Drawing.Size(120, 22);
            this.numericMinAge.TabIndex = 68;
            this.numericMinAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericMaxAge
            // 
            this.numericMaxAge.Increment = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            this.numericMaxAge.Location = new System.Drawing.Point(236, 122);
            this.numericMaxAge.Name = "numericMaxAge";
            this.numericMaxAge.Size = new System.Drawing.Size(120, 22);
            this.numericMaxAge.TabIndex = 68;
            this.numericMaxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericMaxNumberInClass
            // 
            this.numericMaxNumberInClass.Location = new System.Drawing.Point(236, 168);
            this.numericMaxNumberInClass.Name = "numericMaxNumberInClass";
            this.numericMaxNumberInClass.Size = new System.Drawing.Size(120, 22);
            this.numericMaxNumberInClass.TabIndex = 68;
            this.numericMaxNumberInClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericPassScore
            // 
            this.numericPassScore.DecimalPlaces = 1;
            this.numericPassScore.Increment = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            this.numericPassScore.Location = new System.Drawing.Point(236, 212);
            this.numericPassScore.Name = "numericPassScore";
            this.numericPassScore.Size = new System.Drawing.Size(120, 22);
            this.numericPassScore.TabIndex = 68;
            this.numericPassScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Location = new System.Drawing.Point(138, 270);
            this.btnHoanTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(106, 28);
            this.btnHoanTac.TabIndex = 67;
            this.btnHoanTac.Text = "Hoàn tác";
            this.btnHoanTac.UseVisualStyleBackColor = true;
            this.btnHoanTac.Click += new System.EventHandler(this.btnHoanTac_Click);
            // 
            // SettingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericPassScore);
            this.Controls.Add(this.numericMaxNumberInClass);
            this.Controls.Add(this.numericMaxAge);
            this.Controls.Add(this.numericMinAge);
            this.Controls.Add(this.btnHoanTac);
            this.Controls.Add(this.btnThayDoi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label17);
            this.Name = "SettingUserControl";
            this.Size = new System.Drawing.Size(404, 350);
            this.Load += new System.EventHandler(this.SettingUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericMinAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxNumberInClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPassScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThayDoi;
        private System.Windows.Forms.NumericUpDown numericMinAge;
        private System.Windows.Forms.NumericUpDown numericMaxAge;
        private System.Windows.Forms.NumericUpDown numericMaxNumberInClass;
        private System.Windows.Forms.NumericUpDown numericPassScore;
        private System.Windows.Forms.Button btnHoanTac;
    }
}
