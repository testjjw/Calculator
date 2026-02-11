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
            tbInsert3 = new TextBox();
            SuspendLayout();
            // 
            // tbInsert1
            // 
            tbInsert1.Location = new Point(12, 12);
            tbInsert1.Name = "tbInsert1";
            tbInsert1.Size = new Size(66, 23);
            tbInsert1.TabIndex = 0;
            tbInsert1.Text = "5";
            // 
            // tbInsert2
            // 
            tbInsert2.Location = new Point(84, 12);
            tbInsert2.Name = "tbInsert2";
            tbInsert2.Size = new Size(66, 23);
            tbInsert2.TabIndex = 1;
            tbInsert2.Text = "5";
            // 
            // tbInsert3
            // 
            tbInsert3.Location = new Point(156, 12);
            tbInsert3.Name = "tbInsert3";
            tbInsert3.Size = new Size(66, 23);
            tbInsert3.TabIndex = 2;
            tbInsert3.Text = "5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbInsert3);
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
        private TextBox tbInsert3;
    }
}
