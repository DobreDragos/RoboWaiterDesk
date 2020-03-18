namespace RoboDesk
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.vBubbleBar1 = new VIBlend.WinForms.Controls.vBubbleBar();
            this.btn_Tables = new VIBlend.WinForms.Controls.vButton();
            this.btn_Products = new VIBlend.WinForms.Controls.vButton();
            this.btn_Menus = new VIBlend.WinForms.Controls.vButton();
            this.btn_Alergens = new VIBlend.WinForms.Controls.vButton();
            this.btn_Settings = new VIBlend.WinForms.Controls.vButton();
            this.vImageReflectionControl = new VIBlend.WinForms.Controls.vImageReflectionControl();
            this.backArrowControl1 = new RoboDesk.CustomControls.BackArrowControl();
            this.vBubbleBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vBubbleBar1
            // 
            this.vBubbleBar1.AllowAnimations = true;
            this.vBubbleBar1.AutoAdjustBounds = true;
            this.vBubbleBar1.BackColor = System.Drawing.Color.Transparent;
            this.vBubbleBar1.BackgroundFillEnabled = false;
            this.vBubbleBar1.Controls.Add(this.btn_Tables);
            this.vBubbleBar1.Controls.Add(this.btn_Products);
            this.vBubbleBar1.Controls.Add(this.btn_Menus);
            this.vBubbleBar1.Controls.Add(this.btn_Alergens);
            this.vBubbleBar1.Controls.Add(this.btn_Settings);
            this.vBubbleBar1.DisplayBorder = false;
            this.vBubbleBar1.ItemsPosition = VIBlend.WinForms.Controls.BubbleBarPosition.Near;
            this.vBubbleBar1.ItemsSize = 90;
            this.vBubbleBar1.ItemsSpacing = 10;
            this.vBubbleBar1.Location = new System.Drawing.Point(64, 123);
            this.vBubbleBar1.Name = "vBubbleBar1";
            this.vBubbleBar1.Size = new System.Drawing.Size(702, 105);
            this.vBubbleBar1.TabIndex = 0;
            this.vBubbleBar1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // btn_Tables
            // 
            this.btn_Tables.AllowAnimations = true;
            this.btn_Tables.BackColor = System.Drawing.Color.Transparent;
            this.btn_Tables.Location = new System.Drawing.Point(0, 0);
            this.btn_Tables.Name = "btn_Tables";
            this.btn_Tables.RoundedCornersMask = ((byte)(15));
            this.btn_Tables.RoundedCornersRadius = 10;
            this.btn_Tables.Size = new System.Drawing.Size(90, 90);
            this.btn_Tables.TabIndex = 1;
            this.btn_Tables.Text = "btn_Tables";
            this.btn_Tables.UseVisualStyleBackColor = false;
            this.btn_Tables.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.btn_Tables.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Products
            // 
            this.btn_Products.AllowAnimations = true;
            this.btn_Products.BackColor = System.Drawing.Color.Transparent;
            this.btn_Products.Location = new System.Drawing.Point(100, 0);
            this.btn_Products.Name = "btn_Products";
            this.btn_Products.RoundedCornersMask = ((byte)(15));
            this.btn_Products.RoundedCornersRadius = 10;
            this.btn_Products.Size = new System.Drawing.Size(90, 90);
            this.btn_Products.TabIndex = 14;
            this.btn_Products.Text = "btn_Products";
            this.btn_Products.UseVisualStyleBackColor = false;
            this.btn_Products.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.btn_Products.Click += new System.EventHandler(this.btn_Products_Click);
            // 
            // btn_Menus
            // 
            this.btn_Menus.AllowAnimations = true;
            this.btn_Menus.BackColor = System.Drawing.Color.Transparent;
            this.btn_Menus.Location = new System.Drawing.Point(200, 0);
            this.btn_Menus.Name = "btn_Menus";
            this.btn_Menus.RoundedCornersMask = ((byte)(15));
            this.btn_Menus.RoundedCornersRadius = 10;
            this.btn_Menus.Size = new System.Drawing.Size(90, 90);
            this.btn_Menus.TabIndex = 13;
            this.btn_Menus.Text = "btn_Menus";
            this.btn_Menus.UseVisualStyleBackColor = false;
            this.btn_Menus.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.btn_Menus.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Alergens
            // 
            this.btn_Alergens.AllowAnimations = true;
            this.btn_Alergens.BackColor = System.Drawing.Color.Transparent;
            this.btn_Alergens.Location = new System.Drawing.Point(300, 0);
            this.btn_Alergens.Name = "btn_Alergens";
            this.btn_Alergens.RoundedCornersMask = ((byte)(15));
            this.btn_Alergens.RoundedCornersRadius = 10;
            this.btn_Alergens.Size = new System.Drawing.Size(90, 90);
            this.btn_Alergens.TabIndex = 12;
            this.btn_Alergens.Text = "btn_Alergens";
            this.btn_Alergens.UseVisualStyleBackColor = false;
            this.btn_Alergens.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.btn_Alergens.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.AllowAnimations = true;
            this.btn_Settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_Settings.Location = new System.Drawing.Point(400, 0);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.RoundedCornersMask = ((byte)(15));
            this.btn_Settings.RoundedCornersRadius = 10;
            this.btn_Settings.Size = new System.Drawing.Size(90, 90);
            this.btn_Settings.TabIndex = 11;
            this.btn_Settings.Text = "btn_Settings";
            this.btn_Settings.UseVisualStyleBackColor = false;
            this.btn_Settings.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // vImageReflectionControl
            // 
            this.vImageReflectionControl.Content = this.vBubbleBar1;
            this.vImageReflectionControl.DrawContentReflection = true;
            this.vImageReflectionControl.EnableOpacityEffect = true;
            this.vImageReflectionControl.Image = null;
            this.vImageReflectionControl.Location = new System.Drawing.Point(64, 252);
            this.vImageReflectionControl.Name = "vImageReflectionControl";
            this.vImageReflectionControl.ReflectionFactor = 130;
            this.vImageReflectionControl.Size = new System.Drawing.Size(702, 90);
            this.vImageReflectionControl.TabIndex = 1;
            this.vImageReflectionControl.Text = "vImageReflectionControl1";
            // 
            // backArrowControl1
            // 
            this.backArrowControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backArrowControl1.BackColor = System.Drawing.Color.Transparent;
            this.backArrowControl1.Location = new System.Drawing.Point(713, 26);
            this.backArrowControl1.Name = "backArrowControl1";
            this.backArrowControl1.Size = new System.Drawing.Size(106, 50);
            this.backArrowControl1.TabIndex = 2;
            this.backArrowControl1.Click += new System.EventHandler(this.backArrowControl1_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 500);
            this.Controls.Add(this.backArrowControl1);
            this.Controls.Add(this.vImageReflectionControl);
            this.Controls.Add(this.vBubbleBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Text = "Main";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.vBubbleBar1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private VIBlend.WinForms.Controls.vBubbleBar vBubbleBar1;
        private VIBlend.WinForms.Controls.vButton btn_Tables;
        private VIBlend.WinForms.Controls.vButton btn_Products;
        private VIBlend.WinForms.Controls.vButton btn_Menus;
        private VIBlend.WinForms.Controls.vButton btn_Alergens;
        private VIBlend.WinForms.Controls.vButton btn_Settings;
        private VIBlend.WinForms.Controls.vImageReflectionControl vImageReflectionControl;
        private CustomControls.BackArrowControl backArrowControl1;
    }
}