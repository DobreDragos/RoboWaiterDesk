namespace RoboDesk
{
    partial class ProductsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsFrm));
            this.lbl_Name = new MetroFramework.Controls.MetroLabel();
            this.lbl_Code = new MetroFramework.Controls.MetroLabel();
            this.lbl_Family = new MetroFramework.Controls.MetroLabel();
            this.tb_Name = new VIBlend.WinForms.Controls.vTextBox();
            this.cb_Family = new VIBlend.WinForms.Controls.vComboBox();
            this.btn_Save = new VIBlend.WinForms.Controls.vCircularButton();
            this.tb_Search = new VIBlend.WinForms.Controls.vTextBox();
            this.detailsPanel = new MetroFramework.Controls.MetroPanel();
            this.lbl_Product_Picture = new MetroFramework.Controls.MetroLabel();
            this.pb_Product_Image = new System.Windows.Forms.PictureBox();
            this.btn_Product_Remove_Picture = new VIBlend.WinForms.Controls.GalleryButton();
            this.btn_Product_Picture = new VIBlend.WinForms.Controls.GalleryButton();
            this.cb_DiscountIntervalType = new VIBlend.WinForms.Controls.vComboBox();
            this.lbl_DiscountInterval = new MetroFramework.Controls.MetroLabel();
            this.tb_DiscountInterval = new VIBlend.WinForms.Controls.vTextBox();
            this.cb_Enabled = new VIBlend.WinForms.Controls.vCheckBox();
            this.lbl_Enabled = new MetroFramework.Controls.MetroLabel();
            this.tb_Alergens = new VIBlend.WinForms.Controls.vTextBox();
            this.lbl_Alergens = new MetroFramework.Controls.MetroLabel();
            this.tb_Code = new VIBlend.WinForms.Controls.vTextBox();
            this.tb_Discount = new VIBlend.WinForms.Controls.vTextBox();
            this.tb_Price = new VIBlend.WinForms.Controls.vTextBox();
            this.tb_Description = new VIBlend.WinForms.Controls.vTextBox();
            this.lbl_Discount = new MetroFramework.Controls.MetroLabel();
            this.lbl_Price = new MetroFramework.Controls.MetroLabel();
            this.lbl_Description = new MetroFramework.Controls.MetroLabel();
            this.cb_Language = new VIBlend.WinForms.Controls.vComboBox();
            this.dgv = new In.Sontx.SimpleDataGridViewPaging.DataGridViewPaging();
            this.btn_Edit = new VIBlend.WinForms.Controls.vCircularButton();
            this.btn_Add = new VIBlend.WinForms.Controls.vCircularButton();
            this.btn_Cancel = new VIBlend.WinForms.Controls.vCircularButton();
            this.btn_Delete = new VIBlend.WinForms.Controls.vCircularButton();
            this.ToolTip = new MetroFramework.Components.MetroToolTip();
            this.backArrowControl1 = new RoboDesk.CustomControls.BackArrowControl();
            this.detailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Product_Image)).BeginInit();
            this.btn_Edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.White;
            this.lbl_Name.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Name.Location = new System.Drawing.Point(13, 11);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(47, 20);
            this.lbl_Name.Style = MetroFramework.MetroColorStyle.White;
            this.lbl_Name.TabIndex = 6;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbl_Name.UseStyleColors = true;
            // 
            // lbl_Code
            // 
            this.lbl_Code.AutoSize = true;
            this.lbl_Code.BackColor = System.Drawing.Color.White;
            this.lbl_Code.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Code.Location = new System.Drawing.Point(13, 65);
            this.lbl_Code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(42, 20);
            this.lbl_Code.Style = MetroFramework.MetroColorStyle.White;
            this.lbl_Code.TabIndex = 7;
            this.lbl_Code.Text = "Code";
            this.lbl_Code.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbl_Code.UseStyleColors = true;
            // 
            // lbl_Family
            // 
            this.lbl_Family.AutoSize = true;
            this.lbl_Family.BackColor = System.Drawing.Color.White;
            this.lbl_Family.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Family.Location = new System.Drawing.Point(13, 123);
            this.lbl_Family.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Family.Name = "lbl_Family";
            this.lbl_Family.Size = new System.Drawing.Size(47, 20);
            this.lbl_Family.Style = MetroFramework.MetroColorStyle.White;
            this.lbl_Family.TabIndex = 8;
            this.lbl_Family.Text = "Family";
            this.lbl_Family.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbl_Family.UseStyleColors = true;
            // 
            // tb_Name
            // 
            this.tb_Name.BackColor = System.Drawing.Color.White;
            this.tb_Name.BoundsOffset = new System.Drawing.Size(1, 1);
            this.tb_Name.ControlBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tb_Name.DefaultText = "";
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Name.Location = new System.Drawing.Point(109, 11);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Name.MaxLength = 100;
            this.tb_Name.MinimumSize = new System.Drawing.Size(133, 37);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.PasswordChar = '\0';
            this.tb_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Name.SelectionLength = 0;
            this.tb_Name.SelectionStart = 0;
            this.tb_Name.Size = new System.Drawing.Size(339, 37);
            this.tb_Name.TabIndex = 19;
            this.tb_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Name.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND;
            this.tb_Name.TextChanged += new System.EventHandler(this.tb_Name_TextChanged);
            // 
            // cb_Family
            // 
            this.cb_Family.BackColor = System.Drawing.Color.White;
            this.cb_Family.DisplayMember = "";
            this.cb_Family.DropDownMaximumSize = new System.Drawing.Size(1000, 1000);
            this.cb_Family.DropDownMinimumSize = new System.Drawing.Size(10, 10);
            this.cb_Family.DropDownResizeDirection = VIBlend.WinForms.Controls.SizingDirection.Both;
            this.cb_Family.DropDownWidth = 339;
            this.cb_Family.Location = new System.Drawing.Point(109, 126);
            this.cb_Family.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Family.Name = "cb_Family";
            this.cb_Family.RoundedCornersMaskListItem = ((byte)(15));
            this.cb_Family.Size = new System.Drawing.Size(339, 36);
            this.cb_Family.TabIndex = 21;
            this.cb_Family.UseThemeBackColor = false;
            this.cb_Family.UseThemeDropDownArrowColor = true;
            this.cb_Family.ValueMember = "";
            this.cb_Family.VIBlendScrollBarsTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.cb_Family.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // btn_Save
            // 
            this.btn_Save.AllowAnimations = true;
            this.btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Save.HoverEffectsEnabled = true;
            this.btn_Save.Location = new System.Drawing.Point(176, 25);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.RoundedCornersMask = ((byte)(15));
            this.btn_Save.Size = new System.Drawing.Size(96, 89);
            this.btn_Save.StyleKey = "CircularButton";
            this.btn_Save.TabIndex = 23;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE;
            // 
            // tb_Search
            // 
            this.tb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Search.BackColor = System.Drawing.Color.White;
            this.tb_Search.BoundsOffset = new System.Drawing.Size(1, 1);
            this.tb_Search.ControlBorderColor = System.Drawing.Color.DimGray;
            this.tb_Search.DefaultText = "Search by name";
            this.tb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Search.Location = new System.Drawing.Point(51, 69);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Search.MaxLength = 50;
            this.tb_Search.MinimumSize = new System.Drawing.Size(133, 37);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.PasswordChar = '\0';
            this.tb_Search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Search.SelectionLength = 0;
            this.tb_Search.SelectionStart = 0;
            this.tb_Search.Size = new System.Drawing.Size(416, 37);
            this.tb_Search.TabIndex = 20;
            this.tb_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Search.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND;
            this.tb_Search.Visible = false;
            // 
            // detailsPanel
            // 
            this.detailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.detailsPanel.Controls.Add(this.lbl_Product_Picture);
            this.detailsPanel.Controls.Add(this.pb_Product_Image);
            this.detailsPanel.Controls.Add(this.btn_Product_Remove_Picture);
            this.detailsPanel.Controls.Add(this.btn_Product_Picture);
            this.detailsPanel.Controls.Add(this.cb_DiscountIntervalType);
            this.detailsPanel.Controls.Add(this.lbl_DiscountInterval);
            this.detailsPanel.Controls.Add(this.tb_DiscountInterval);
            this.detailsPanel.Controls.Add(this.cb_Enabled);
            this.detailsPanel.Controls.Add(this.lbl_Enabled);
            this.detailsPanel.Controls.Add(this.tb_Alergens);
            this.detailsPanel.Controls.Add(this.lbl_Alergens);
            this.detailsPanel.Controls.Add(this.tb_Code);
            this.detailsPanel.Controls.Add(this.tb_Discount);
            this.detailsPanel.Controls.Add(this.tb_Price);
            this.detailsPanel.Controls.Add(this.tb_Description);
            this.detailsPanel.Controls.Add(this.lbl_Discount);
            this.detailsPanel.Controls.Add(this.lbl_Price);
            this.detailsPanel.Controls.Add(this.lbl_Description);
            this.detailsPanel.Controls.Add(this.lbl_Name);
            this.detailsPanel.Controls.Add(this.lbl_Code);
            this.detailsPanel.Controls.Add(this.lbl_Family);
            this.detailsPanel.Controls.Add(this.tb_Name);
            this.detailsPanel.Controls.Add(this.cb_Family);
            this.detailsPanel.HorizontalScrollbarBarColor = true;
            this.detailsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.detailsPanel.HorizontalScrollbarSize = 12;
            this.detailsPanel.Location = new System.Drawing.Point(31, 121);
            this.detailsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(1022, 301);
            this.detailsPanel.TabIndex = 26;
            this.detailsPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.detailsPanel.VerticalScrollbarBarColor = true;
            this.detailsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.detailsPanel.VerticalScrollbarSize = 13;
            // 
            // lbl_Product_Picture
            // 
            this.lbl_Product_Picture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Product_Picture.AutoSize = true;
            this.lbl_Product_Picture.BackColor = System.Drawing.Color.White;
            this.lbl_Product_Picture.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Product_Picture.Location = new System.Drawing.Point(487, 178);
            this.lbl_Product_Picture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Product_Picture.Name = "lbl_Product_Picture";
            this.lbl_Product_Picture.Size = new System.Drawing.Size(47, 20);
            this.lbl_Product_Picture.Style = MetroFramework.MetroColorStyle.White;
            this.lbl_Product_Picture.TabIndex = 41;
            this.lbl_Product_Picture.Text = "Image";
            this.lbl_Product_Picture.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbl_Product_Picture.UseStyleColors = true;
            // 
            // pb_Product_Image
            // 
            this.pb_Product_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Product_Image.BackColor = System.Drawing.Color.Transparent;
            this.pb_Product_Image.BackgroundImage = global::RoboDesk.Properties.Resources.noimage;
            this.pb_Product_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Product_Image.Location = new System.Drawing.Point(633, 178);
            this.pb_Product_Image.Name = "pb_Product_Image";
            this.pb_Product_Image.Size = new System.Drawing.Size(146, 89);
            this.pb_Product_Image.TabIndex = 40;
            this.pb_Product_Image.TabStop = false;
            // 
            // btn_Product_Remove_Picture
            // 
            this.btn_Product_Remove_Picture.AllowAnimations = true;
            this.btn_Product_Remove_Picture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Product_Remove_Picture.BackColor = System.Drawing.Color.Transparent;
            this.btn_Product_Remove_Picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product_Remove_Picture.Location = new System.Drawing.Point(806, 230);
            this.btn_Product_Remove_Picture.Name = "btn_Product_Remove_Picture";
            this.btn_Product_Remove_Picture.PaintDefaultStateFill = true;
            this.btn_Product_Remove_Picture.RoundedCornersMask = ((byte)(15));
            this.btn_Product_Remove_Picture.Size = new System.Drawing.Size(139, 37);
            this.btn_Product_Remove_Picture.TabIndex = 39;
            this.btn_Product_Remove_Picture.Text = "Remove picture";
            this.btn_Product_Remove_Picture.UseVisualStyleBackColor = true;
            this.btn_Product_Remove_Picture.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.btn_Product_Remove_Picture.Click += new System.EventHandler(this.btn_Product_Remove_Picture_Click);
            // 
            // btn_Product_Picture
            // 
            this.btn_Product_Picture.AllowAnimations = true;
            this.btn_Product_Picture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Product_Picture.BackColor = System.Drawing.Color.Transparent;
            this.btn_Product_Picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product_Picture.Location = new System.Drawing.Point(806, 178);
            this.btn_Product_Picture.Name = "btn_Product_Picture";
            this.btn_Product_Picture.PaintDefaultStateFill = true;
            this.btn_Product_Picture.RoundedCornersMask = ((byte)(15));
            this.btn_Product_Picture.Size = new System.Drawing.Size(139, 37);
            this.btn_Product_Picture.TabIndex = 38;
            this.btn_Product_Picture.Text = "Get picture";
            this.btn_Product_Picture.UseVisualStyleBackColor = true;
            this.btn_Product_Picture.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.btn_Product_Picture.Click += new System.EventHandler(this.btn_Product_Picture_Click);
            // 
            // cb_DiscountIntervalType
            // 
            this.cb_DiscountIntervalType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_DiscountIntervalType.BackColor = System.Drawing.Color.White;
            this.cb_DiscountIntervalType.DisplayMember = "";
            this.cb_DiscountIntervalType.DropDownMaximumSize = new System.Drawing.Size(1000, 1000);
            this.cb_DiscountIntervalType.DropDownMinimumSize = new System.Drawing.Size(10, 10);
            this.cb_DiscountIntervalType.DropDownResizeDirection = VIBlend.WinForms.Controls.SizingDirection.Both;
            this.cb_DiscountIntervalType.DropDownWidth = 118;
            this.cb_DiscountIntervalType.Location = new System.Drawing.Point(827, 67);
            this.cb_DiscountIntervalType.Margin = new System.Windows.Forms.Padding(4);
            this.cb_DiscountIntervalType.Name = "cb_DiscountIntervalType";
            this.cb_DiscountIntervalType.RoundedCornersMaskListItem = ((byte)(15));
            this.cb_DiscountIntervalType.Size = new System.Drawing.Size(118, 36);
            this.cb_DiscountIntervalType.TabIndex = 36;
            this.cb_DiscountIntervalType.UseThemeBackColor = false;
            this.cb_DiscountIntervalType.UseThemeDropDownArrowColor = true;
            this.cb_DiscountIntervalType.ValueMember = "";
            this.cb_DiscountIntervalType.VIBlendScrollBarsTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.cb_DiscountIntervalType.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // lbl_DiscountInterval
            // 
            this.lbl_DiscountInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DiscountInterval.AutoSize = true;
            this.lbl_DiscountInterval.BackColor = System.Drawing.Color.White;
            this.lbl_DiscountInterval.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_DiscountInterval.Location = new System.Drawing.Point(487, 65);
            this.lbl_DiscountInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DiscountInterval.Name = "lbl_DiscountInterval";
            this.lbl_DiscountInterval.Size = new System.Drawing.Size(113, 20);
            this.lbl_DiscountInterval.Style = MetroFramework.MetroColorStyle.White;
            this.lbl_DiscountInterval.TabIndex = 35;
            this.lbl_DiscountInterval.Text = "Discount Interval";
            this.lbl_DiscountInterval.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbl_DiscountInterval.UseStyleColors = true;
            // 
            // tb_DiscountInterval
            // 
            this.tb_DiscountInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_DiscountInterval.BackColor = System.Drawing.Color.White;
            this.tb_DiscountInterval.BoundsOffset = new System.Drawing.Size(1, 1);
            this.tb_DiscountInterval.ControlBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tb_DiscountInterval.DefaultText = "";
            this.tb_DiscountInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_DiscountInterval.Location = new System.Drawing.Point(633, 66);
            this.tb_DiscountInterval.Margin = new System.Windows.Forms.Padding(4);
            this.tb_DiscountInterval.MaxLength = 50;
            this.tb_DiscountInterval.MinimumSize = new System.Drawing.Size(133, 37);
            this.tb_DiscountInterval.Name = "tb_DiscountInterval";
            this.tb_DiscountInterval.PasswordChar = '\0';
            this.tb_DiscountInterval.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_DiscountInterval.SelectionLength = 0;
            this.tb_DiscountInterval.SelectionStart = 0;
            this.tb_DiscountInterval.Size = new System.Drawing.Size(183, 37);
            this.tb_DiscountInterval.TabIndex = 34;
            this.tb_DiscountInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ToolTip.SetToolTip(this.tb_DiscountInterval, " 08:05 - 13:30");
            this.tb_DiscountInterval.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND;
            // 
            // cb_Enabled
            // 
            this.cb_Enabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Enabled.AutoSize = true;
            this.cb_Enabled.BackColor = System.Drawing.Color.Transparent;
            this.cb_Enabled.Location = new System.Drawing.Point(917, 129);
            this.cb_Enabled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Enabled.Name = "cb_Enabled";
            this.cb_Enabled.Size = new System.Drawing.Size(18, 17);
            this.cb_Enabled.TabIndex = 33;
            this.cb_Enabled.UseVisualStyleBackColor = true;
            this.cb_Enabled.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // lbl_Enabled
            // 
            this.lbl_Enabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Enabled.AutoSize = true;
            this.lbl_Enabled.BackColor = System.Drawing.Color.White;
            this.lbl_Enabled.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Enabled.Location = new System.Drawing.Point(829, 126);
            this.lbl_Enabled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Enabled.Name = "lbl_Enabled";
            this.lbl_Enabled.Size = new System.Drawing.Size(59, 20);
            this.lbl_Enabled.Style = MetroFramework.MetroColorStyle.White;
            this.lbl_Enabled.TabIndex = 32;
            this.lbl_Enabled.Text = "Enabled";
            this.lbl_Enabled.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbl_Enabled.UseStyleColors = true;
            // 
            // tb_Alergens
            // 
            this.tb_Alergens.BackColor = System.Drawing.Color.White;
            this.tb_Alergens.BoundsOffset = new System.Drawing.Size(1, 1);
            this.tb_Alergens.ControlBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tb_Alergens.DefaultText = "";
            this.tb_Alergens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Alergens.Location = new System.Drawing.Point(109, 178);
            this.tb_Alergens.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Alergens.MaxLength = 50;
            this.tb_Alergens.MinimumSize = new System.Drawing.Size(133, 37);
            this.tb_Alergens.Name = "tb_Alergens";
            this.tb_Alergens.PasswordChar = '\0';
            this.tb_Alergens.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Alergens.SelectionLength = 0;
            this.tb_Alergens.SelectionStart = 0;
            this.tb_Alergens.Size = new System.Drawing.Size(339, 37);
            this.tb_Alergens.TabIndex = 31;
            this.tb_Alergens.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Alergens.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND;
            this.tb_Alergens.TextChanged += new System.EventHandler(this.tb_Alergens_TextChanged);
            // 
            // lbl_Alergens
            // 
            this.lbl_Alergens.AutoSize = true;
            this.lbl_Alergens.BackColor = System.Drawing.Color.White;
            this.lbl_Alergens.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Alergens.Location = new System.Drawing.Point(13, 180);
            this.lbl_Alergens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Alergens.Name = "lbl_Alergens";
            this.lbl_Alergens.Size = new System.Drawing.Size(64, 20);
            this.lbl_Alergens.Style = MetroFramework.MetroColorStyle.White;
            this.lbl_Alergens.TabIndex = 30;
            this.lbl_Alergens.Text = "Alergens";
            this.lbl_Alergens.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbl_Alergens.UseStyleColors = true;
            // 
            // tb_Code
            // 
            this.tb_Code.BackColor = System.Drawing.Color.White;
            this.tb_Code.BoundsOffset = new System.Drawing.Size(1, 1);
            this.tb_Code.ControlBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tb_Code.DefaultText = "";
            this.tb_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Code.Location = new System.Drawing.Point(109, 66);
            this.tb_Code.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Code.MaxLength = 100;
            this.tb_Code.MinimumSize = new System.Drawing.Size(133, 37);
            this.tb_Code.Name = "tb_Code";
            this.tb_Code.PasswordChar = '\0';
            this.tb_Code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Code.SelectionLength = 0;
            this.tb_Code.SelectionStart = 0;
            this.tb_Code.Size = new System.Drawing.Size(339, 37);
            this.tb_Code.TabIndex = 28;
            this.tb_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Code.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND;
            // 
            // tb_Discount
            // 
            this.tb_Discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Discount.BackColor = System.Drawing.Color.White;
            this.tb_Discount.BoundsOffset = new System.Drawing.Size(1, 1);
            this.tb_Discount.ControlBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tb_Discount.DefaultText = "";
            this.tb_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Discount.Location = new System.Drawing.Point(633, 16);
            this.tb_Discount.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Discount.MaxLength = 50;
            this.tb_Discount.MinimumSize = new System.Drawing.Size(133, 37);
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.PasswordChar = '\0';
            this.tb_Discount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Discount.SelectionLength = 0;
            this.tb_Discount.SelectionStart = 0;
            this.tb_Discount.Size = new System.Drawing.Size(309, 37);
            this.tb_Discount.TabIndex = 25;
            this.tb_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Discount.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND;
            // 
            // tb_Price
            // 
            this.tb_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Price.BackColor = System.Drawing.Color.White;
            this.tb_Price.BoundsOffset = new System.Drawing.Size(1, 1);
            this.tb_Price.ControlBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tb_Price.DefaultText = "";
            this.tb_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Price.Location = new System.Drawing.Point(633, 123);
            this.tb_Price.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Price.MaxLength = 50;
            this.tb_Price.MinimumSize = new System.Drawing.Size(133, 37);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.PasswordChar = '\0';
            this.tb_Price.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Price.SelectionLength = 0;
            this.tb_Price.SelectionStart = 0;
            this.tb_Price.Size = new System.Drawing.Size(133, 37);
            this.tb_Price.TabIndex = 26;
            this.tb_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Price.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND;
            // 
            // tb_Description
            // 
            this.tb_Description.BackColor = System.Drawing.Color.White;
            this.tb_Description.BoundsOffset = new System.Drawing.Size(1, 1);
            this.tb_Description.ControlBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tb_Description.DefaultText = "";
            this.tb_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Description.Location = new System.Drawing.Point(109, 239);
            this.tb_Description.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Description.MaxLength = 250;
            this.tb_Description.MinimumSize = new System.Drawing.Size(133, 37);
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.PasswordChar = '\0';
            this.tb_Description.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Description.SelectionLength = 0;
            this.tb_Description.SelectionStart = 0;
            this.tb_Description.Size = new System.Drawing.Size(339, 37);
            this.tb_Description.TabIndex = 27;
            this.tb_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Description.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND;
            this.tb_Description.TextChanged += new System.EventHandler(this.tb_Description_TextChanged);
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.BackColor = System.Drawing.Color.White;
            this.lbl_Discount.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Discount.Location = new System.Drawing.Point(487, 11);
            this.lbl_Discount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(63, 20);
            this.lbl_Discount.Style = MetroFramework.MetroColorStyle.White;
            this.lbl_Discount.TabIndex = 24;
            this.lbl_Discount.Text = "Discount";
            this.lbl_Discount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbl_Discount.UseStyleColors = true;
            // 
            // lbl_Price
            // 
            this.lbl_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.BackColor = System.Drawing.Color.White;
            this.lbl_Price.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Price.Location = new System.Drawing.Point(487, 123);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(40, 20);
            this.lbl_Price.Style = MetroFramework.MetroColorStyle.White;
            this.lbl_Price.TabIndex = 23;
            this.lbl_Price.Text = "Price";
            this.lbl_Price.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbl_Price.UseStyleColors = true;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.BackColor = System.Drawing.Color.White;
            this.lbl_Description.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Description.Location = new System.Drawing.Point(13, 247);
            this.lbl_Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(79, 20);
            this.lbl_Description.Style = MetroFramework.MetroColorStyle.White;
            this.lbl_Description.TabIndex = 22;
            this.lbl_Description.Text = "Description";
            this.lbl_Description.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbl_Description.UseStyleColors = true;
            // 
            // cb_Language
            // 
            this.cb_Language.BackColor = System.Drawing.Color.White;
            this.cb_Language.DisplayMember = "";
            this.cb_Language.DropDownList = true;
            this.cb_Language.DropDownMaximumSize = new System.Drawing.Size(1000, 1000);
            this.cb_Language.DropDownMinimumSize = new System.Drawing.Size(10, 10);
            this.cb_Language.DropDownResizeDirection = VIBlend.WinForms.Controls.SizingDirection.Both;
            this.cb_Language.DropDownWidth = 84;
            this.cb_Language.Location = new System.Drawing.Point(31, 66);
            this.cb_Language.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Language.Name = "cb_Language";
            this.cb_Language.RoundedCornersMaskListItem = ((byte)(15));
            this.cb_Language.Size = new System.Drawing.Size(84, 36);
            this.cb_Language.TabIndex = 29;
            this.cb_Language.UseThemeBackColor = false;
            this.cb_Language.UseThemeDropDownArrowColor = true;
            this.cb_Language.ValueMember = "";
            this.cb_Language.VIBlendScrollBarsTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.cb_Language.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.cb_Language.SelectedItemChanged += new System.EventHandler(this.cb_Language_SelectedItemChanged);
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoHideNavigator = false;
            this.dgv.BackColor = System.Drawing.SystemColors.Control;
            this.dgv.DataSource = null;
            this.dgv.Location = new System.Drawing.Point(31, 457);
            this.dgv.Margin = new System.Windows.Forms.Padding(5);
            this.dgv.MaxRecords = 20;
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1020, 123);
            this.dgv.TabIndex = 28;
            // 
            // btn_Edit
            // 
            this.btn_Edit.AllowAnimations = true;
            this.btn_Edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Edit.Controls.Add(this.tb_Search);
            this.btn_Edit.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Edit.HoverEffectsEnabled = true;
            this.btn_Edit.Location = new System.Drawing.Point(501, 25);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.RoundedCornersMask = ((byte)(15));
            this.btn_Edit.Size = new System.Drawing.Size(96, 89);
            this.btn_Edit.StyleKey = "CircularButton";
            this.btn_Edit.TabIndex = 29;
            this.btn_Edit.Text = "EDIT";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE;
            // 
            // btn_Add
            // 
            this.btn_Add.AllowAnimations = true;
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Add.HoverEffectsEnabled = true;
            this.btn_Add.Location = new System.Drawing.Point(667, 25);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.RoundedCornersMask = ((byte)(15));
            this.btn_Add.Size = new System.Drawing.Size(96, 89);
            this.btn_Add.StyleKey = "CircularButton";
            this.btn_Add.TabIndex = 30;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AllowAnimations = true;
            this.btn_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Cancel.HoverEffectsEnabled = true;
            this.btn_Cancel.Location = new System.Drawing.Point(825, 25);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.RoundedCornersMask = ((byte)(15));
            this.btn_Cancel.Size = new System.Drawing.Size(96, 89);
            this.btn_Cancel.StyleKey = "CircularButton";
            this.btn_Cancel.TabIndex = 31;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE;
            // 
            // btn_Delete
            // 
            this.btn_Delete.AllowAnimations = true;
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Delete.HoverEffectsEnabled = true;
            this.btn_Delete.Location = new System.Drawing.Point(337, 25);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.RoundedCornersMask = ((byte)(15));
            this.btn_Delete.Size = new System.Drawing.Size(96, 89);
            this.btn_Delete.StyleKey = "CircularButton";
            this.btn_Delete.TabIndex = 32;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE;
            // 
            // ToolTip
            // 
            this.ToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.ToolTip.StyleManager = null;
            this.ToolTip.Theme = MetroFramework.MetroThemeStyle.Default;
            // 
            // backArrowControl1
            // 
            this.backArrowControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backArrowControl1.BackColor = System.Drawing.Color.Transparent;
            this.backArrowControl1.Location = new System.Drawing.Point(968, 37);
            this.backArrowControl1.Margin = new System.Windows.Forms.Padding(5);
            this.backArrowControl1.Name = "backArrowControl1";
            this.backArrowControl1.Size = new System.Drawing.Size(85, 49);
            this.backArrowControl1.TabIndex = 2;
            // 
            // ProductsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 609);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.cb_Language);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.backArrowControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductsFrm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Products";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Product_Image)).EndInit();
            this.btn_Edit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.BackArrowControl backArrowControl1;
        private MetroFramework.Controls.MetroLabel lbl_Name;
        private MetroFramework.Controls.MetroLabel lbl_Code;
        private MetroFramework.Controls.MetroLabel lbl_Family;
        private VIBlend.WinForms.Controls.vTextBox tb_Name;
        private VIBlend.WinForms.Controls.vComboBox cb_Family;
        private VIBlend.WinForms.Controls.vCircularButton btn_Save;
        private VIBlend.WinForms.Controls.vTextBox tb_Search;
        private MetroFramework.Controls.MetroPanel detailsPanel;
        private VIBlend.WinForms.Controls.vTextBox tb_Discount;
        private VIBlend.WinForms.Controls.vTextBox tb_Price;
        private VIBlend.WinForms.Controls.vTextBox tb_Description;
        private MetroFramework.Controls.MetroLabel lbl_Discount;
        private MetroFramework.Controls.MetroLabel lbl_Price;
        private MetroFramework.Controls.MetroLabel lbl_Description;
        private In.Sontx.SimpleDataGridViewPaging.DataGridViewPaging dgv;
        private VIBlend.WinForms.Controls.vTextBox tb_Code;
        private VIBlend.WinForms.Controls.vComboBox cb_Language;
        private VIBlend.WinForms.Controls.vCircularButton btn_Edit;
        private VIBlend.WinForms.Controls.vCircularButton btn_Add;
        private VIBlend.WinForms.Controls.vCircularButton btn_Cancel;
        private VIBlend.WinForms.Controls.vCircularButton btn_Delete;
        private VIBlend.WinForms.Controls.vTextBox tb_Alergens;
        private MetroFramework.Controls.MetroLabel lbl_Alergens;
        private VIBlend.WinForms.Controls.vCheckBox cb_Enabled;
        private MetroFramework.Controls.MetroLabel lbl_Enabled;
        private MetroFramework.Controls.MetroLabel lbl_DiscountInterval;
        private VIBlend.WinForms.Controls.vTextBox tb_DiscountInterval;
        private MetroFramework.Components.MetroToolTip ToolTip;
        private VIBlend.WinForms.Controls.vComboBox cb_DiscountIntervalType;
        private VIBlend.WinForms.Controls.GalleryButton btn_Product_Picture;
        private VIBlend.WinForms.Controls.GalleryButton btn_Product_Remove_Picture;
        private System.Windows.Forms.PictureBox pb_Product_Image;
        private MetroFramework.Controls.MetroLabel lbl_Product_Picture;
    }
}