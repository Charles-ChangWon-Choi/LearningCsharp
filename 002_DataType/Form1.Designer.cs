namespace _002_DataType
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
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblException = new System.Windows.Forms.Label();
            this.lblShort = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblDouble = new System.Windows.Forms.Label();
            this.btnToShort = new System.Windows.Forms.Button();
            this.btnToInt = new System.Windows.Forms.Button();
            this.btnToDouble = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(12, 12);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(490, 20);
            this.tbNumber.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(520, 12);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Short";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Int";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Double";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Exception";
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(89, 195);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(10, 13);
            this.lblException.TabIndex = 6;
            this.lblException.Text = "-";
            // 
            // lblShort
            // 
            this.lblShort.AutoSize = true;
            this.lblShort.Location = new System.Drawing.Point(89, 55);
            this.lblShort.Name = "lblShort";
            this.lblShort.Size = new System.Drawing.Size(13, 13);
            this.lblShort.TabIndex = 7;
            this.lblShort.Text = "0";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(89, 100);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(13, 13);
            this.lblInt.TabIndex = 8;
            this.lblInt.Text = "0";
            // 
            // lblDouble
            // 
            this.lblDouble.AutoSize = true;
            this.lblDouble.Location = new System.Drawing.Point(89, 142);
            this.lblDouble.Name = "lblDouble";
            this.lblDouble.Size = new System.Drawing.Size(13, 13);
            this.lblDouble.TabIndex = 9;
            this.lblDouble.Text = "0";
            // 
            // btnToShort
            // 
            this.btnToShort.Location = new System.Drawing.Point(240, 55);
            this.btnToShort.Name = "btnToShort";
            this.btnToShort.Size = new System.Drawing.Size(75, 23);
            this.btnToShort.TabIndex = 10;
            this.btnToShort.Text = "To Short";
            this.btnToShort.UseVisualStyleBackColor = true;
            this.btnToShort.Click += new System.EventHandler(this.btnToShort_Click);
            // 
            // btnToInt
            // 
            this.btnToInt.Location = new System.Drawing.Point(240, 100);
            this.btnToInt.Name = "btnToInt";
            this.btnToInt.Size = new System.Drawing.Size(75, 23);
            this.btnToInt.TabIndex = 11;
            this.btnToInt.Text = "To Int";
            this.btnToInt.UseVisualStyleBackColor = true;
            this.btnToInt.Click += new System.EventHandler(this.btnToInt_Click);
            // 
            // btnToDouble
            // 
            this.btnToDouble.Location = new System.Drawing.Point(240, 142);
            this.btnToDouble.Name = "btnToDouble";
            this.btnToDouble.Size = new System.Drawing.Size(75, 23);
            this.btnToDouble.TabIndex = 12;
            this.btnToDouble.Text = "To Double";
            this.btnToDouble.UseVisualStyleBackColor = true;
            this.btnToDouble.Click += new System.EventHandler(this.btnToDouble_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(520, 55);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 347);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnToDouble);
            this.Controls.Add(this.btnToInt);
            this.Controls.Add(this.btnToShort);
            this.Controls.Add(this.lblDouble);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.lblShort);
            this.Controls.Add(this.lblException);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.tbNumber);
            this.Name = "Form1";
            this.Text = "Int";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblException;
        private System.Windows.Forms.Label lblShort;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblDouble;
        private System.Windows.Forms.Button btnToShort;
        private System.Windows.Forms.Button btnToInt;
        private System.Windows.Forms.Button btnToDouble;
        private System.Windows.Forms.Button btnClear;
    }
}

