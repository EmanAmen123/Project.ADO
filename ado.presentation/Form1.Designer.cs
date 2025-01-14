namespace ado.presentation
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            emailInput = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            label4 = new Label();
            passInput = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            label5 = new Label();
            showPass = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(-80, -128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(567, 763);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Pristina", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(102, 96);
            label1.Name = "label1";
            label1.Size = new Size(204, 47);
            label1.TabIndex = 1;
            label1.Text = " Welcome Back  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(615, 9);
            label2.Name = "label2";
            label2.Size = new Size(158, 52);
            label2.TabIndex = 2;
            label2.Text = "Sign In";
            // 
            // emailInput
            // 
            emailInput.BorderRadius = 15;
            emailInput.CustomizableEdges = customizableEdges1;
            emailInput.DefaultText = "";
            emailInput.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            emailInput.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            emailInput.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            emailInput.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            emailInput.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            emailInput.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailInput.ForeColor = Color.Black;
            emailInput.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            emailInput.Location = new Point(581, 147);
            emailInput.Margin = new Padding(3, 4, 3, 4);
            emailInput.Name = "emailInput";
            emailInput.PasswordChar = '\0';
            emailInput.PlaceholderForeColor = Color.Gray;
            emailInput.PlaceholderText = "enter your email";
            emailInput.SelectedText = "";
            emailInput.ShadowDecoration.CustomizableEdges = customizableEdges2;
            emailInput.Size = new Size(268, 45);
            emailInput.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(581, 118);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(581, 216);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // passInput
            // 
            passInput.BorderRadius = 15;
            passInput.CustomizableEdges = customizableEdges3;
            passInput.DefaultText = "";
            passInput.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            passInput.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            passInput.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            passInput.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            passInput.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            passInput.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passInput.ForeColor = Color.Black;
            passInput.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            passInput.Location = new Point(581, 245);
            passInput.Margin = new Padding(3, 4, 3, 4);
            passInput.Name = "passInput";
            passInput.PasswordChar = '*';
            passInput.PlaceholderForeColor = Color.Gray;
            passInput.PlaceholderText = "enter your password";
            passInput.SelectedText = "";
            passInput.ShadowDecoration.CustomizableEdges = customizableEdges4;
            passInput.Size = new Size(268, 45);
            passInput.TabIndex = 5;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderColor = Color.SaddleBrown;
            guna2Button1.BorderRadius = 25;
            guna2Button1.BorderThickness = 5;
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.SaddleBrown;
            guna2Button1.Location = new Point(599, 350);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(185, 56);
            guna2Button1.TabIndex = 7;
            guna2Button1.Text = "Sign In";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 10;
            guna2Button2.CustomizableEdges = customizableEdges7;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Transparent;
            guna2Button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = Color.SaddleBrown;
            guna2Button2.Location = new Point(663, 437);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button2.Size = new Size(121, 31);
            guna2Button2.TabIndex = 9;
            guna2Button2.Text = "Register";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(549, 437);
            label5.Name = "label5";
            label5.Size = new Size(124, 31);
            label5.TabIndex = 11;
            label5.Text = "New User?";
            // 
            // showPass
            // 
            showPass.Animated = true;
            showPass.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            showPass.CheckedState.BorderRadius = 0;
            showPass.CheckedState.BorderThickness = 0;
            showPass.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            showPass.CheckMarkColor = Color.SaddleBrown;
            showPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showPass.ForeColor = SystemColors.ControlDarkDark;
            showPass.Location = new Point(677, 297);
            showPass.Name = "showPass";
            showPass.Size = new Size(180, 33);
            showPass.TabIndex = 37;
            showPass.Text = "show password";
            showPass.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            showPass.UncheckedState.BorderRadius = 0;
            showPass.UncheckedState.BorderThickness = 0;
            showPass.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            showPass.CheckedChanged += showPass_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(917, 515);
            Controls.Add(showPass);
            Controls.Add(label5);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(label4);
            Controls.Add(passInput);
            Controls.Add(label3);
            Controls.Add(emailInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox emailInput;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox passInput;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Label label5;
        private Guna.UI2.WinForms.Guna2CheckBox showPass;
    }
}
