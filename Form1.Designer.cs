namespace PasswordManager
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
            PasswordLabel = new Label();
            PasswordLengthLabel = new Label();
            PasswordLengthSlider = new TrackBar();
            CopyPasswordButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PasswordLengthSlider).BeginInit();
            SuspendLayout();
            // 
            // PasswordLabel
            // 
            PasswordLabel.BorderStyle = BorderStyle.Fixed3D;
            PasswordLabel.Font = new Font("Arial", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(369, 141);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(527, 86);
            PasswordLabel.TabIndex = 0;
            PasswordLabel.Text = "label1";
            PasswordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordLengthLabel
            // 
            PasswordLengthLabel.Font = new Font("Arial", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PasswordLengthLabel.Location = new Point(482, 227);
            PasswordLengthLabel.Name = "PasswordLengthLabel";
            PasswordLengthLabel.Size = new Size(320, 86);
            PasswordLengthLabel.TabIndex = 1;
            PasswordLengthLabel.Text = "Password Length: 10";
            PasswordLengthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordLengthSlider
            // 
            PasswordLengthSlider.Location = new Point(482, 475);
            PasswordLengthSlider.Name = "PasswordLengthSlider";
            PasswordLengthSlider.Size = new Size(320, 45);
            PasswordLengthSlider.TabIndex = 2;
            PasswordLengthSlider.Scroll += PasswordLengthSlider_Scroll;
            // 
            // CopyPasswordButton
            // 
            CopyPasswordButton.BackColor = Color.FromArgb(23, 24, 29);
            CopyPasswordButton.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CopyPasswordButton.ForeColor = Color.White;
            CopyPasswordButton.Location = new Point(482, 526);
            CopyPasswordButton.Name = "CopyPasswordButton";
            CopyPasswordButton.Size = new Size(320, 49);
            CopyPasswordButton.TabIndex = 3;
            CopyPasswordButton.Text = "Copy Password";
            CopyPasswordButton.UseVisualStyleBackColor = false;
            CopyPasswordButton.Click += CopyPasswordButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1295, 789);
            Controls.Add(CopyPasswordButton);
            Controls.Add(PasswordLengthSlider);
            Controls.Add(PasswordLengthLabel);
            Controls.Add(PasswordLabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Password Generator";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PasswordLengthSlider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PasswordLabel;
        private Label PasswordLengthLabel;
        private TrackBar PasswordLengthSlider;
        private Button CopyPasswordButton;
    }
}
