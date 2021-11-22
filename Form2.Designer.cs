namespace GradeCalc2
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grade1 = new System.Windows.Forms.TextBox();
            this.weight1 = new System.Windows.Forms.TextBox();
            this.grade2 = new System.Windows.Forms.TextBox();
            this.weight2 = new System.Windows.Forms.TextBox();
            this.grade3 = new System.Windows.Forms.TextBox();
            this.weight3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wantedGrade = new System.Windows.Forms.TextBox();
            this.calcFinalBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Existing grades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grades";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight";
            // 
            // grade1
            // 
            this.grade1.Location = new System.Drawing.Point(101, 179);
            this.grade1.Name = "grade1";
            this.grade1.Size = new System.Drawing.Size(100, 44);
            this.grade1.TabIndex = 3;
            // 
            // weight1
            // 
            this.weight1.Location = new System.Drawing.Point(445, 179);
            this.weight1.Name = "weight1";
            this.weight1.Size = new System.Drawing.Size(100, 44);
            this.weight1.TabIndex = 4;
            // 
            // grade2
            // 
            this.grade2.Location = new System.Drawing.Point(101, 251);
            this.grade2.Name = "grade2";
            this.grade2.Size = new System.Drawing.Size(100, 44);
            this.grade2.TabIndex = 5;
            // 
            // weight2
            // 
            this.weight2.Location = new System.Drawing.Point(445, 250);
            this.weight2.Name = "weight2";
            this.weight2.Size = new System.Drawing.Size(100, 44);
            this.weight2.TabIndex = 6;
            // 
            // grade3
            // 
            this.grade3.Location = new System.Drawing.Point(101, 328);
            this.grade3.Name = "grade3";
            this.grade3.Size = new System.Drawing.Size(100, 44);
            this.grade3.TabIndex = 7;
            // 
            // weight3
            // 
            this.weight3.Location = new System.Drawing.Point(445, 327);
            this.weight3.Name = "weight3";
            this.weight3.Size = new System.Drawing.Size(100, 44);
            this.weight3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "Final grade you want";
            // 
            // wantedGrade
            // 
            this.wantedGrade.Location = new System.Drawing.Point(108, 521);
            this.wantedGrade.Name = "wantedGrade";
            this.wantedGrade.Size = new System.Drawing.Size(100, 44);
            this.wantedGrade.TabIndex = 10;
            // 
            // calcFinalBtn
            // 
            this.calcFinalBtn.Location = new System.Drawing.Point(222, 623);
            this.calcFinalBtn.Name = "calcFinalBtn";
            this.calcFinalBtn.Size = new System.Drawing.Size(174, 50);
            this.calcFinalBtn.TabIndex = 11;
            this.calcFinalBtn.Text = "Calculate\r\n";
            this.calcFinalBtn.UseVisualStyleBackColor = true;
            this.calcFinalBtn.Click += new System.EventHandler(this.calcFinalBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 851);
            this.Controls.Add(this.calcFinalBtn);
            this.Controls.Add(this.wantedGrade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.weight3);
            this.Controls.Add(this.grade3);
            this.Controls.Add(this.weight2);
            this.Controls.Add(this.grade2);
            this.Controls.Add(this.weight1);
            this.Controls.Add(this.grade1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Calculate needed grades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox grade1;
        private System.Windows.Forms.TextBox weight1;
        private System.Windows.Forms.TextBox grade2;
        private System.Windows.Forms.TextBox weight2;
        private System.Windows.Forms.TextBox grade3;
        private System.Windows.Forms.TextBox weight3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox wantedGrade;
        private System.Windows.Forms.Button calcFinalBtn;
    }
}