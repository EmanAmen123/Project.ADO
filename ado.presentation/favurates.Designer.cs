namespace ado.presentation
{
    partial class favurates
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgv_fav = new DataGridView();
            label1 = new Label();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgv_fav).BeginInit();
            SuspendLayout();
            // 
            // dgv_fav
            // 
            dgv_fav.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgv_fav.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_fav.Location = new Point(571, -3);
            dgv_fav.Name = "dgv_fav";
            dgv_fav.RowHeadersWidth = 51;
            dgv_fav.Size = new Size(291, 454);
            dgv_fav.TabIndex = 0;
            dgv_fav.CellContentClick += dataGridView1_CellContentClick;
            dgv_fav.RowHeaderMouseClick += dgv_fav_RowHeaderMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 224, 192);
            label1.Font = new Font("Pristina", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(202, 18);
            label1.Name = "label1";
            label1.Size = new Size(180, 61);
            label1.TabIndex = 1;
            label1.Text = "Favurites";
            // 
            // guna2Button2
            // 
            guna2Button2.BackColor = Color.FromArgb(255, 224, 192);
            guna2Button2.BorderColor = Color.Red;
            guna2Button2.BorderRadius = 25;
            guna2Button2.BorderThickness = 5;
            guna2Button2.CustomizableEdges = customizableEdges1;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Transparent;
            guna2Button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = Color.Red;
            guna2Button2.Location = new Point(650, 370);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(130, 57);
            guna2Button2.TabIndex = 84;
            guna2Button2.Text = "Delete";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // favurates
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logo;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(862, 450);
            Controls.Add(guna2Button2);
            Controls.Add(label1);
            Controls.Add(dgv_fav);
            FormBorderStyle = FormBorderStyle.None;
            Name = "favurates";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "favurates";
            Load += favurates_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_fav).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_fav;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}