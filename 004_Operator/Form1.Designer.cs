namespace _004_Operator
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
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbResultAfter = new System.Windows.Forms.TextBox();
            this.tbResultBit = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbAndOr = new System.Windows.Forms.TextBox();
            this.btnShiftLeft = new System.Windows.Forms.Button();
            this.btnShiftRight = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnBitOr = new System.Windows.Forms.Button();
            this.btnBitAnd = new System.Windows.Forms.Button();
            this.btnIncreaseLater = new System.Windows.Forms.Button();
            this.btnIncreaseFirst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(12, 12);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(100, 20);
            this.tbResult.TabIndex = 0;
            this.tbResult.Text = "0";
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbResult.TextChanged += new System.EventHandler(this.tbResult_TextChanged);
            // 
            // tbResultAfter
            // 
            this.tbResultAfter.Location = new System.Drawing.Point(118, 12);
            this.tbResultAfter.Name = "tbResultAfter";
            this.tbResultAfter.Size = new System.Drawing.Size(100, 20);
            this.tbResultAfter.TabIndex = 1;
            this.tbResultAfter.Text = "0";
            this.tbResultAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbResultBit
            // 
            this.tbResultBit.Enabled = false;
            this.tbResultBit.Location = new System.Drawing.Point(12, 38);
            this.tbResultBit.Name = "tbResultBit";
            this.tbResultBit.Size = new System.Drawing.Size(100, 20);
            this.tbResultBit.TabIndex = 2;
            this.tbResultBit.Text = "0";
            this.tbResultBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(12, 97);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(100, 20);
            this.tbNumber.TabIndex = 3;
            this.tbNumber.Text = "0";
            this.tbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbAndOr
            // 
            this.tbAndOr.Enabled = false;
            this.tbAndOr.Location = new System.Drawing.Point(118, 97);
            this.tbAndOr.Name = "tbAndOr";
            this.tbAndOr.Size = new System.Drawing.Size(100, 20);
            this.tbAndOr.TabIndex = 4;
            this.tbAndOr.Text = "0";
            this.tbAndOr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnShiftLeft
            // 
            this.btnShiftLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShiftLeft.Location = new System.Drawing.Point(12, 134);
            this.btnShiftLeft.Name = "btnShiftLeft";
            this.btnShiftLeft.Size = new System.Drawing.Size(46, 46);
            this.btnShiftLeft.TabIndex = 5;
            this.btnShiftLeft.Text = "<<";
            this.btnShiftLeft.UseVisualStyleBackColor = true;
            this.btnShiftLeft.Click += new System.EventHandler(this.btnShiftLeft_Click);
            // 
            // btnShiftRight
            // 
            this.btnShiftRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShiftRight.Location = new System.Drawing.Point(66, 134);
            this.btnShiftRight.Name = "btnShiftRight";
            this.btnShiftRight.Size = new System.Drawing.Size(46, 46);
            this.btnShiftRight.TabIndex = 6;
            this.btnShiftRight.Text = ">>";
            this.btnShiftRight.UseVisualStyleBackColor = true;
            this.btnShiftRight.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(118, 134);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(46, 46);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Text = "+=";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(172, 134);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(46, 46);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-=";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnBitOr
            // 
            this.btnBitOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBitOr.Location = new System.Drawing.Point(172, 186);
            this.btnBitOr.Name = "btnBitOr";
            this.btnBitOr.Size = new System.Drawing.Size(46, 46);
            this.btnBitOr.TabIndex = 12;
            this.btnBitOr.Text = "||";
            this.btnBitOr.UseVisualStyleBackColor = true;
            this.btnBitOr.Click += new System.EventHandler(this.btnBitOr_Click);
            // 
            // btnBitAnd
            // 
            this.btnBitAnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBitAnd.Location = new System.Drawing.Point(118, 186);
            this.btnBitAnd.Name = "btnBitAnd";
            this.btnBitAnd.Size = new System.Drawing.Size(46, 46);
            this.btnBitAnd.TabIndex = 11;
            this.btnBitAnd.Text = "&&&&";
            this.btnBitAnd.UseVisualStyleBackColor = true;
            this.btnBitAnd.Click += new System.EventHandler(this.btnBitAnd_Click);
            // 
            // btnIncreaseLater
            // 
            this.btnIncreaseLater.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncreaseLater.Location = new System.Drawing.Point(66, 186);
            this.btnIncreaseLater.Name = "btnIncreaseLater";
            this.btnIncreaseLater.Size = new System.Drawing.Size(46, 46);
            this.btnIncreaseLater.TabIndex = 10;
            this.btnIncreaseLater.Text = "a++";
            this.btnIncreaseLater.UseVisualStyleBackColor = true;
            this.btnIncreaseLater.Click += new System.EventHandler(this.btnIncreaseLater_Click);
            // 
            // btnIncreaseFirst
            // 
            this.btnIncreaseFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncreaseFirst.Location = new System.Drawing.Point(12, 186);
            this.btnIncreaseFirst.Name = "btnIncreaseFirst";
            this.btnIncreaseFirst.Size = new System.Drawing.Size(46, 46);
            this.btnIncreaseFirst.TabIndex = 9;
            this.btnIncreaseFirst.Text = "++a";
            this.btnIncreaseFirst.UseVisualStyleBackColor = true;
            this.btnIncreaseFirst.Click += new System.EventHandler(this.btnIncreaseFirst_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 243);
            this.Controls.Add(this.btnBitOr);
            this.Controls.Add(this.btnBitAnd);
            this.Controls.Add(this.btnIncreaseLater);
            this.Controls.Add(this.btnIncreaseFirst);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnShiftRight);
            this.Controls.Add(this.btnShiftLeft);
            this.Controls.Add(this.tbAndOr);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.tbResultBit);
            this.Controls.Add(this.tbResultAfter);
            this.Controls.Add(this.tbResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox tbResultAfter;
        private System.Windows.Forms.TextBox tbResultBit;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbAndOr;
        private System.Windows.Forms.Button btnShiftLeft;
        private System.Windows.Forms.Button btnShiftRight;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnBitOr;
        private System.Windows.Forms.Button btnBitAnd;
        private System.Windows.Forms.Button btnIncreaseLater;
        private System.Windows.Forms.Button btnIncreaseFirst;
    }
}

