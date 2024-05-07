namespace PasswordManager
{
    partial class Form3
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
            listBox1 = new ListBox();
            txt_newPassword = new TextBox();
            btn_Add = new Button();
            btn_Save = new Button();
            btnSaved = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveCaption;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(262, 75);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(404, 559);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txt_newPassword
            // 
            txt_newPassword.BackColor = SystemColors.InactiveCaption;
            txt_newPassword.Location = new Point(710, 75);
            txt_newPassword.Name = "txt_newPassword";
            txt_newPassword.Size = new Size(332, 23);
            txt_newPassword.TabIndex = 1;
            txt_newPassword.TextChanged += txt_newPassword_TextChanged;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = SystemColors.InactiveCaption;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Location = new Point(710, 138);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(175, 71);
            btn_Add.TabIndex = 2;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = SystemColors.InactiveCaption;
            btn_Save.BackgroundImageLayout = ImageLayout.None;
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Location = new Point(710, 240);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(175, 71);
            btn_Save.TabIndex = 4;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // btnSaved
            // 
            btnSaved.BackColor = SystemColors.InactiveCaption;
            btnSaved.FlatStyle = FlatStyle.Flat;
            btnSaved.Location = new Point(710, 341);
            btnSaved.Name = "btnSaved";
            btnSaved.Size = new Size(175, 71);
            btnSaved.TabIndex = 5;
            btnSaved.Text = "Load Saved";
            btnSaved.UseVisualStyleBackColor = false;
            btnSaved.Click += btnSaved_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1357, 729);
            Controls.Add(btnSaved);
            Controls.Add(btn_Save);
            Controls.Add(btn_Add);
            Controls.Add(txt_newPassword);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Password Storage";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox txt_newPassword;
        private Button btn_Add;
        private Button btn_Save;
        private Button btnSaved;
    }
}