namespace Emailverification
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
            EmailAddress = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // EmailAddress
            // 
            EmailAddress.Location = new Point(237, 77);
            EmailAddress.Name = "EmailAddress";
            EmailAddress.Size = new Size(249, 23);
            EmailAddress.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 85);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "EnterValid Email";
            // 
            // button1
            // 
            button1.Location = new Point(237, 129);
            button1.Name = "button1";
            button1.Size = new Size(126, 23);
            button1.TabIndex = 2;
            button1.Text = "Verify Email address";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(EmailAddress);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmailAddress;
        private Label label1;
        private Button button1;
    }
}
