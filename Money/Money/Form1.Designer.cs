namespace Money
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
            this.JoeLabel = new System.Windows.Forms.Label();
            this.BobLabel = new System.Windows.Forms.Label();
            this.BankLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JoeLabel
            // 
            this.JoeLabel.AutoSize = true;
            this.JoeLabel.Location = new System.Drawing.Point(12, 23);
            this.JoeLabel.Name = "JoeLabel";
            this.JoeLabel.Size = new System.Drawing.Size(35, 13);
            this.JoeLabel.TabIndex = 0;
            this.JoeLabel.Text = "label1";
            // 
            // BobLabel
            // 
            this.BobLabel.AutoSize = true;
            this.BobLabel.Location = new System.Drawing.Point(12, 57);
            this.BobLabel.Name = "BobLabel";
            this.BobLabel.Size = new System.Drawing.Size(35, 13);
            this.BobLabel.TabIndex = 1;
            this.BobLabel.Text = "label2";
            // 
            // BankLabel
            // 
            this.BankLabel.AutoSize = true;
            this.BankLabel.Location = new System.Drawing.Point(12, 94);
            this.BankLabel.Name = "BankLabel";
            this.BankLabel.Size = new System.Drawing.Size(35, 13);
            this.BankLabel.TabIndex = 2;
            this.BankLabel.Text = "label3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Receive $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Give $10 to Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 201);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BankLabel);
            this.Controls.Add(this.BobLabel);
            this.Controls.Add(this.JoeLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Fun with Joe and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JoeLabel;
        private System.Windows.Forms.Label BobLabel;
        private System.Windows.Forms.Label BankLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

