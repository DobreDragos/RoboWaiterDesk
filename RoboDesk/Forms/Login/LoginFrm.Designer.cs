namespace RoboDesk
{
    partial class LoginFrm
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
            VIBlend.WinForms.Controls.ListItem listItem1 = new VIBlend.WinForms.Controls.ListItem();
            VIBlend.WinForms.Controls.ListItem listItem2 = new VIBlend.WinForms.Controls.ListItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.btn_Login = new VIBlend.WinForms.Controls.vCircularButton();
            this.tb_User = new VIBlend.WinForms.Controls.vTextBox();
            this.tb_Pass = new VIBlend.WinForms.Controls.vTextBox();
            this.cbLanguage = new VIBlend.WinForms.Controls.vComboBox();
            this.pbLanguage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RoboDesk.Properties.Resources.android_3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(187, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 288);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_User
            // 
            this.lbl_User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_User.AutoSize = true;
            this.lbl_User.BackColor = System.Drawing.Color.Transparent;
            this.lbl_User.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_User.Location = new System.Drawing.Point(185, 376);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(52, 24);
            this.lbl_User.TabIndex = 2;
            this.lbl_User.Text = "User";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pass.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pass.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Pass.Location = new System.Drawing.Point(183, 426);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(97, 24);
            this.lbl_Pass.TabIndex = 3;
            this.lbl_Pass.Text = "Password";
            // 
            // btn_Login
            // 
            this.btn_Login.AllowAnimations = true;
            this.btn_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Login.HoverEffectsEnabled = true;
            this.btn_Login.Location = new System.Drawing.Point(487, 365);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.RoundedCornersMask = ((byte)(15));
            this.btn_Login.Size = new System.Drawing.Size(91, 85);
            this.btn_Login.StyleKey = "CircularButton";
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.btn_Login.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tb_User
            // 
            this.tb_User.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_User.BackColor = System.Drawing.Color.White;
            this.tb_User.BoundsOffset = new System.Drawing.Size(1, 1);
            this.tb_User.ControlBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tb_User.DefaultText = "Insert Username...";
            this.tb_User.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.tb_User.Location = new System.Drawing.Point(298, 376);
            this.tb_User.MaxLength = 50;
            this.tb_User.MinimumSize = new System.Drawing.Size(100, 30);
            this.tb_User.Name = "tb_User";
            this.tb_User.PasswordChar = '\0';
            this.tb_User.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_User.SelectionLength = 0;
            this.tb_User.SelectionStart = 0;
            this.tb_User.Size = new System.Drawing.Size(168, 30);
            this.tb_User.TabIndex = 7;
            this.tb_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_User.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND;
            // 
            // tb_Pass
            // 
            this.tb_Pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Pass.BackColor = System.Drawing.Color.White;
            this.tb_Pass.BoundsOffset = new System.Drawing.Size(1, 1);
            this.tb_Pass.ControlBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tb_Pass.DefaultText = "Insert Password...";
            this.tb_Pass.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.tb_Pass.Location = new System.Drawing.Point(298, 420);
            this.tb_Pass.MaxLength = 50;
            this.tb_Pass.MinimumSize = new System.Drawing.Size(100, 30);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.PasswordChar = '*';
            this.tb_Pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Pass.SelectionLength = 0;
            this.tb_Pass.SelectionStart = 0;
            this.tb_Pass.Size = new System.Drawing.Size(168, 30);
            this.tb_Pass.TabIndex = 8;
            this.tb_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Pass.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // cbLanguage
            // 
            this.cbLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLanguage.BackColor = System.Drawing.Color.White;
            this.cbLanguage.DisplayMember = "";
            this.cbLanguage.DropDownHeight = 100;
            this.cbLanguage.DropDownList = true;
            this.cbLanguage.DropDownMaximumSize = new System.Drawing.Size(1000, 1000);
            this.cbLanguage.DropDownMinimumSize = new System.Drawing.Size(10, 10);
            this.cbLanguage.DropDownResizeDirection = VIBlend.WinForms.Controls.SizingDirection.Vertical;
            this.cbLanguage.DropDownWidth = 68;
            this.cbLanguage.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Bold);
            listItem1.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Bold);
            listItem1.RoundedCornersMask = ((byte)(15));
            listItem1.Text = "RO";
            listItem2.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Bold);
            listItem2.ImageIndex = 0;
            listItem2.RoundedCornersMask = ((byte)(15));
            listItem2.Text = "EN";
            this.cbLanguage.Items.Add(listItem1);
            this.cbLanguage.Items.Add(listItem2);
            this.cbLanguage.Location = new System.Drawing.Point(360, 324);
            this.cbLanguage.MinimumSize = new System.Drawing.Size(50, 0);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.RoundedCornersMaskListItem = ((byte)(15));
            this.cbLanguage.SelectedIndex = 0;
            this.cbLanguage.Size = new System.Drawing.Size(68, 35);
            this.cbLanguage.TabIndex = 9;
            this.cbLanguage.Text = "RO";
            this.cbLanguage.UseThemeBackColor = false;
            this.cbLanguage.UseThemeDropDownArrowColor = true;
            this.cbLanguage.UseThemeFont = false;
            this.cbLanguage.UseThemeForeColor = true;
            this.cbLanguage.ValueMember = "";
            this.cbLanguage.VIBlendScrollBarsTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.cbLanguage.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // pbLanguage
            // 
            this.pbLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbLanguage.BackColor = System.Drawing.Color.Transparent;
            this.pbLanguage.BackgroundImage = global::RoboDesk.Properties.Resources.ro;
            this.pbLanguage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLanguage.Location = new System.Drawing.Point(321, 325);
            this.pbLanguage.Name = "pbLanguage";
            this.pbLanguage.Size = new System.Drawing.Size(32, 32);
            this.pbLanguage.TabIndex = 10;
            this.pbLanguage.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 534);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.pbLanguage);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.tb_User);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(788, 534);
            this.Name = "LoginFrm";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "RoboDesk";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Pass;
        private VIBlend.WinForms.Controls.vCircularButton btn_Login;
        private VIBlend.WinForms.Controls.vTextBox tb_User;
        private VIBlend.WinForms.Controls.vTextBox tb_Pass;
        private VIBlend.WinForms.Controls.vComboBox cbLanguage;
        private System.Windows.Forms.PictureBox pbLanguage;
    }
}

