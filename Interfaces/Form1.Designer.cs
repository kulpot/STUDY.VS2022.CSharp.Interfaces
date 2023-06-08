namespace Interfaces
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
            this.failListBox2 = new Interfaces.FailListBox();
            this.failButton2 = new Interfaces.FailButton();
            this.failListBox1 = new Interfaces.FailListBox();
            this.failButton1 = new Interfaces.FailButton();
            this.SuspendLayout();
            // 
            // failListBox2
            // 
            this.failListBox2.Fails = 0;
            this.failListBox2.FormattingEnabled = true;
            this.failListBox2.Location = new System.Drawing.Point(241, 121);
            this.failListBox2.Name = "failListBox2";
            this.failListBox2.Size = new System.Drawing.Size(120, 95);
            this.failListBox2.TabIndex = 3;
            // 
            // failButton2
            // 
            this.failButton2.Fails = 5;
            this.failButton2.Location = new System.Drawing.Point(241, 54);
            this.failButton2.Name = "failButton2";
            this.failButton2.Size = new System.Drawing.Size(75, 23);
            this.failButton2.TabIndex = 2;
            this.failButton2.Text = "failButton2";
            this.failButton2.UseVisualStyleBackColor = true;
            // 
            // failListBox1
            // 
            this.failListBox1.Fails = 0;
            this.failListBox1.FormattingEnabled = true;
            this.failListBox1.Location = new System.Drawing.Point(24, 121);
            this.failListBox1.Name = "failListBox1";
            this.failListBox1.Size = new System.Drawing.Size(120, 95);
            this.failListBox1.TabIndex = 1;
            // 
            // failButton1
            // 
            this.failButton1.Fails = 5;
            this.failButton1.Location = new System.Drawing.Point(24, 54);
            this.failButton1.Name = "failButton1";
            this.failButton1.Size = new System.Drawing.Size(75, 23);
            this.failButton1.TabIndex = 0;
            this.failButton1.Text = "failButton1";
            this.failButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 334);
            this.Controls.Add(this.failListBox2);
            this.Controls.Add(this.failButton2);
            this.Controls.Add(this.failListBox1);
            this.Controls.Add(this.failButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private FailButton failButton1;
        private FailListBox failListBox1;
        private FailButton failButton2;
        private FailListBox failListBox2;
    }
}

