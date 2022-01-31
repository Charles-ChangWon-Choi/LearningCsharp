namespace _005_Enumerator
{
    partial class Form1
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbDay = new System.Windows.Forms.ListBox();
            this.lbTime = new System.Windows.Forms.ListBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 0;
            // 
            // lbDay
            // 
            this.lbDay.FormattingEnabled = true;
            this.lbDay.Location = new System.Drawing.Point(12, 47);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(162, 173);
            this.lbDay.TabIndex = 1;
            // 
            // lbTime
            // 
            this.lbTime.FormattingEnabled = true;
            this.lbTime.Location = new System.Drawing.Point(195, 47);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(162, 173);
            this.lbTime.TabIndex = 2;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(12, 237);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(162, 23);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "Show Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(195, 237);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(162, 23);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Test String";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tbResult
            // 
            this.tbResult.Enabled = false;
            this.tbResult.Location = new System.Drawing.Point(12, 279);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(345, 80);
            this.tbResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 377);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbDay);
            this.Controls.Add(this.tbName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ListBox lbDay;
        private System.Windows.Forms.ListBox lbTime;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox tbResult;
    }
}

