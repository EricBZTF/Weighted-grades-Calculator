namespace GradeCalc2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.gradeLabel = new System.Windows.Forms.Label();
            this.percLabel = new System.Windows.Forms.Label();
            this.gradeBox1 = new System.Windows.Forms.TextBox();
            this.percBox1 = new System.Windows.Forms.TextBox();
            this.gradeBox2 = new System.Windows.Forms.TextBox();
            this.percBox2 = new System.Windows.Forms.TextBox();
            this.gradeBox3 = new System.Windows.Forms.TextBox();
            this.percBox3 = new System.Windows.Forms.TextBox();
            this.gradeBox4 = new System.Windows.Forms.TextBox();
            this.percBox4 = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(242, 104);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(122, 37);
            this.gradeLabel.TabIndex = 0;
            this.gradeLabel.Text = "Grades";
            // 
            // percLabel
            // 
            this.percLabel.AutoSize = true;
            this.percLabel.Location = new System.Drawing.Point(557, 104);
            this.percLabel.Name = "percLabel";
            this.percLabel.Size = new System.Drawing.Size(179, 37);
            this.percLabel.TabIndex = 1;
            this.percLabel.Text = "Percentage";
            // 
            // gradeBox1
            // 
            this.gradeBox1.Location = new System.Drawing.Point(249, 180);
            this.gradeBox1.Name = "gradeBox1";
            this.gradeBox1.Size = new System.Drawing.Size(100, 44);
            this.gradeBox1.TabIndex = 2;
            // 
            // percBox1
            // 
            this.percBox1.Location = new System.Drawing.Point(564, 180);
            this.percBox1.Name = "percBox1";
            this.percBox1.Size = new System.Drawing.Size(100, 44);
            this.percBox1.TabIndex = 3;
            // 
            // gradeBox2
            // 
            this.gradeBox2.Location = new System.Drawing.Point(249, 259);
            this.gradeBox2.Name = "gradeBox2";
            this.gradeBox2.Size = new System.Drawing.Size(100, 44);
            this.gradeBox2.TabIndex = 4;
            // 
            // percBox2
            // 
            this.percBox2.Location = new System.Drawing.Point(564, 259);
            this.percBox2.Name = "percBox2";
            this.percBox2.Size = new System.Drawing.Size(100, 44);
            this.percBox2.TabIndex = 5;
            // 
            // gradeBox3
            // 
            this.gradeBox3.Location = new System.Drawing.Point(249, 328);
            this.gradeBox3.Name = "gradeBox3";
            this.gradeBox3.Size = new System.Drawing.Size(100, 44);
            this.gradeBox3.TabIndex = 6;
            // 
            // percBox3
            // 
            this.percBox3.Location = new System.Drawing.Point(564, 328);
            this.percBox3.Name = "percBox3";
            this.percBox3.Size = new System.Drawing.Size(100, 44);
            this.percBox3.TabIndex = 7;
            // 
            // gradeBox4
            // 
            this.gradeBox4.Location = new System.Drawing.Point(249, 406);
            this.gradeBox4.Name = "gradeBox4";
            this.gradeBox4.Size = new System.Drawing.Size(100, 44);
            this.gradeBox4.TabIndex = 8;
            // 
            // percBox4
            // 
            this.percBox4.Location = new System.Drawing.Point(564, 406);
            this.percBox4.Name = "percBox4";
            this.percBox4.Size = new System.Drawing.Size(100, 44);
            this.percBox4.TabIndex = 9;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(249, 539);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(201, 59);
            this.calcBtn.TabIndex = 10;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 71);
            this.button1.TabIndex = 11;
            this.button1.Text = "Needed grade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 680);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.percBox4);
            this.Controls.Add(this.gradeBox4);
            this.Controls.Add(this.percBox3);
            this.Controls.Add(this.gradeBox3);
            this.Controls.Add(this.percBox2);
            this.Controls.Add(this.gradeBox2);
            this.Controls.Add(this.percBox1);
            this.Controls.Add(this.gradeBox1);
            this.Controls.Add(this.percLabel);
            this.Controls.Add(this.gradeLabel);
            this.Name = "Form1";
            this.Text = "Grade caluclator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label percLabel;
        private System.Windows.Forms.TextBox gradeBox1;
        private System.Windows.Forms.TextBox percBox1;
        private System.Windows.Forms.TextBox gradeBox2;
        private System.Windows.Forms.TextBox percBox2;
        private System.Windows.Forms.TextBox gradeBox3;
        private System.Windows.Forms.TextBox percBox3;
        private System.Windows.Forms.TextBox gradeBox4;
        private System.Windows.Forms.TextBox percBox4;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button button1;
    }
}

