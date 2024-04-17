namespace LogProject
{
    partial class LoginForm
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
            label1 = new Label();
            txbLogin = new TextBox();
            button1 = new Button();
            label2 = new Label();
            txbPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // txbLogin
            // 
            txbLogin.Location = new Point(12, 33);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(210, 29);
            txbLogin.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.Location = new Point(0, 168);
            button1.Name = "button1";
            button1.Size = new Size(234, 61);
            button1.TabIndex = 2;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(12, 89);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(210, 29);
            txbPassword.TabIndex = 4;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 229);
            Controls.Add(txbPassword);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txbLogin);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "LoginForm";
            Text = "Form1";
            FormClosed += LoginForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbLogin;
        private Button button1;
        private Label label2;
        private TextBox txbPassword;
    }
}
