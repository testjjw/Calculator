namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbInsert1 = new TextBox();
            tbInsert2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // tbInsert1
            // 
            tbInsert1.Location = new Point(12, 12);
            tbInsert1.Name = "tbInsert1";
            tbInsert1.Size = new Size(66, 23);
            tbInsert1.TabIndex = 0;
            // 
            // tbInsert2
            // 
            tbInsert2.Location = new Point(12, 41);
            tbInsert2.Name = "tbInsert2";
            tbInsert2.Size = new Size(66, 23);
            tbInsert2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(66, 23);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(tbInsert2);
            Controls.Add(tbInsert1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbInsert1;
        private TextBox tbInsert2;
        private TextBox textBox1;
    }
}
