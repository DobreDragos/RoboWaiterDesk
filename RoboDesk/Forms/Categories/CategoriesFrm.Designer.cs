namespace RoboDesk
{
    partial class CategoriesFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesFrm));
            this.lbl_CategoryCode = new MetroFramework.Controls.MetroLabel();
            this.tb_Search = new VIBlend.WinForms.Controls.vTextBox();
            this.detailsPanel = new MetroFramework.Controls.MetroPanel();
            this.lbl_CategoryName = new MetroFramework.Controls.MetroLabel();
            this.tb_CategoryName = new VIBlend.WinForms.Controls.vTextBox();
            this.tb_CategoryCode = new VIBlend.WinForms.Controls.vTextBox();
            this.dgv = new In.Sontx.SimpleDataGridViewPaging.DataGridViewPaging();
            this.btn_Delete = new VIBlend.WinForms.Controls.vCircularButton();
            this.btn_Cancel = new VIBlend.WinForms.Controls.vCircularButton();
            this.btn_Add = new VIBlend.WinForms.Controls.vCircularButton();
            this.btn_Edit = new VIBlend.WinForms.Controls.vCircularButton();
            this.btn_Save = new VIBlend.WinForms.Controls.vCircularButton();
            this.backArrowControl1 = new RoboDesk.CustomControls.BackArrowControl();
            this.cb_Language = new VIBlend.WinForms.Controls.vComboBox();
            this.detailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CategoryCode
            // 
            this.lbl_CategoryCode.AutoSize = true;
            this.lbl_CategoryCode.Location = new System.Drawing.Point(11, 20);
            this.lbl_CategoryCode.Name = "lbl_CategoryCode";
            this.lbl_CategoryCode.Size = new System.Drawing.Size(116, 19);
            this.lbl_CategoryCode.TabIndex = 7;
            this.lbl_CategoryCode.Text = "lbl_CategoryCode";
            this.lbl_CategoryCode.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.tb_Search.Location = new System.Drawing.Point(23, 264);
            this.tb_Search.MaxLength = 50;
            this.tb_Search.MinimumSize = new System.Drawing.Size(100, 30);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.PasswordChar = '\0';
            this.tb_Search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Search.SelectionLength = 0;
            this.tb_Search.SelectionStart = 0;
            this.tb_Search.Size = new System.Drawing.Size(312, 30);
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
            this.detailsPanel.Controls.Add(this.lbl_CategoryName);
            this.detailsPanel.Controls.Add(this.tb_CategoryName);
            this.detailsPanel.Controls.Add(this.tb_CategoryCode);
            this.detailsPanel.Controls.Add(this.lbl_CategoryCode);
            this.detailsPanel.HorizontalScrollbarBarColor = true;
            this.detailsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.detailsPanel.HorizontalScrollbarSize = 10;
            this.detailsPanel.Location = new System.Drawing.Point(23, 98);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(782, 144);
            this.detailsPanel.TabIndex = 26;
            this.detailsPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.detailsPanel.VerticalScrollbarBarColor = true;
            this.detailsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.detailsPanel.VerticalScrollbarSize = 10;
            // 
            // lbl_CategoryName
            // 
            this.lbl_CategoryName.AutoSize = true;
            this.lbl_CategoryName.Location = new System.Drawing.Point(11, 65);
            this.lbl_CategoryName.Name = "lbl_CategoryName";
            this.lbl_CategoryName.Size = new System.Drawing.Size(120, 19);
            this.lbl_CategoryName.TabIndex = 33;
            this.lbl_CategoryName.Text = "lbl_CategoryName";
            this.lbl_CategoryName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tb_CategoryName
            // 
            this.tb_CategoryName.BackColor = System.Drawing.Color.White;
            this.tb_CategoryName.BoundsOffset = new System.Drawing.Size(1, 1);
            this.tb_CategoryName.ControlBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tb_CategoryName.DefaultText = "";
            this.tb_CategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_CategoryName.Location = new System.Drawing.Point(166, 65);
            this.tb_CategoryName.MaxLength = 50;
            this.tb_CategoryName.MinimumSize = new System.Drawing.Size(100, 30);
            this.tb_CategoryName.Name = "tb_CategoryName";
            this.tb_CategoryName.PasswordChar = '\0';
            this.tb_CategoryName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_CategoryName.SelectionLength = 0;
            this.tb_CategoryName.SelectionStart = 0;
            this.tb_CategoryName.Size = new System.Drawing.Size(238, 30);
            this.tb_CategoryName.TabIndex = 32;
            this.tb_CategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_CategoryName.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND;
            this.tb_CategoryName.TextChanged += new System.EventHandler(this.tb_CategoryName_TextChanged);
            // 
            // tb_CategoryCode
            // 
            this.tb_CategoryCode.BackColor = System.Drawing.Color.White;
            this.tb_CategoryCode.BoundsOffset = new System.Drawing.Size(1, 1);
            this.tb_CategoryCode.ControlBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tb_CategoryCode.DefaultText = "";
            this.tb_CategoryCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_CategoryCode.Location = new System.Drawing.Point(166, 20);
            this.tb_CategoryCode.MaxLength = 50;
            this.tb_CategoryCode.MinimumSize = new System.Drawing.Size(100, 30);
            this.tb_CategoryCode.Name = "tb_CategoryCode";
            this.tb_CategoryCode.PasswordChar = '\0';
            this.tb_CategoryCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_CategoryCode.SelectionLength = 0;
            this.tb_CategoryCode.SelectionStart = 0;
            this.tb_CategoryCode.Size = new System.Drawing.Size(238, 30);
            this.tb_CategoryCode.TabIndex = 31;
            this.tb_CategoryCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_CategoryCode.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND;
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoHideNavigator = false;
            this.dgv.BackColor = System.Drawing.SystemColors.Control;
            this.dgv.DataSource = null;
            this.dgv.Location = new System.Drawing.Point(23, 294);
            this.dgv.MaxRecords = 100;
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(781, 177);
            this.dgv.TabIndex = 28;
            // 
            // btn_Delete
            // 
            this.btn_Delete.AllowAnimations = true;
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Delete.HoverEffectsEnabled = true;
            this.btn_Delete.Location = new System.Drawing.Point(254, 20);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.RoundedCornersMask = ((byte)(15));
            this.btn_Delete.Size = new System.Drawing.Size(72, 72);
            this.btn_Delete.StyleKey = "CircularButton";
            this.btn_Delete.TabIndex = 37;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AllowAnimations = true;
            this.btn_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Cancel.HoverEffectsEnabled = true;
            this.btn_Cancel.Location = new System.Drawing.Point(620, 20);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.RoundedCornersMask = ((byte)(15));
            this.btn_Cancel.Size = new System.Drawing.Size(72, 72);
            this.btn_Cancel.StyleKey = "CircularButton";
            this.btn_Cancel.TabIndex = 36;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE;
            // 
            // btn_Add
            // 
            this.btn_Add.AllowAnimations = true;
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Add.HoverEffectsEnabled = true;
            this.btn_Add.Location = new System.Drawing.Point(502, 20);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.RoundedCornersMask = ((byte)(15));
            this.btn_Add.Size = new System.Drawing.Size(72, 72);
            this.btn_Add.StyleKey = "CircularButton";
            this.btn_Add.TabIndex = 35;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE;
            // 
            // btn_Edit
            // 
            this.btn_Edit.AllowAnimations = true;
            this.btn_Edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Edit.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Edit.HoverEffectsEnabled = true;
            this.btn_Edit.Location = new System.Drawing.Point(378, 20);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.RoundedCornersMask = ((byte)(15));
            this.btn_Edit.Size = new System.Drawing.Size(72, 72);
            this.btn_Edit.StyleKey = "CircularButton";
            this.btn_Edit.TabIndex = 34;
            this.btn_Edit.Text = "EDIT";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE;
            // 
            // btn_Save
            // 
            this.btn_Save.AllowAnimations = true;
            this.btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Save.HoverEffectsEnabled = true;
            this.btn_Save.Location = new System.Drawing.Point(134, 20);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.RoundedCornersMask = ((byte)(15));
            this.btn_Save.Size = new System.Drawing.Size(72, 72);
            this.btn_Save.StyleKey = "CircularButton";
            this.btn_Save.TabIndex = 33;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE;
            // 
            // backArrowControl1
            // 
            this.backArrowControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backArrowControl1.BackColor = System.Drawing.Color.Transparent;
            this.backArrowControl1.Location = new System.Drawing.Point(742, 30);
            this.backArrowControl1.Margin = new System.Windows.Forms.Padding(4);
            this.backArrowControl1.Name = "backArrowControl1";
            this.backArrowControl1.Size = new System.Drawing.Size(64, 40);
            this.backArrowControl1.TabIndex = 2;
            // 
            // cb_Language
            // 
            this.cb_Language.BackColor = System.Drawing.Color.White;
            this.cb_Language.DisplayMember = "";
            this.cb_Language.DropDownList = true;
            this.cb_Language.DropDownMaximumSize = new System.Drawing.Size(1000, 1000);
            this.cb_Language.DropDownMinimumSize = new System.Drawing.Size(10, 10);
            this.cb_Language.DropDownResizeDirection = VIBlend.WinForms.Controls.SizingDirection.Both;
            this.cb_Language.DropDownWidth = 63;
            this.cb_Language.Location = new System.Drawing.Point(23, 54);
            this.cb_Language.Name = "cb_Language";
            this.cb_Language.RoundedCornersMaskListItem = ((byte)(15));
            this.cb_Language.Size = new System.Drawing.Size(63, 29);
            this.cb_Language.TabIndex = 29;
            this.cb_Language.UseThemeBackColor = false;
            this.cb_Language.UseThemeDropDownArrowColor = true;
            this.cb_Language.ValueMember = "";
            this.cb_Language.VIBlendScrollBarsTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.cb_Language.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.cb_Language.SelectedItemChanged += new System.EventHandler(this.cb_Language_SelectedItemChanged);
            // 
            // CategoriesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 495);
            this.Controls.Add(this.cb_Language);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.backArrowControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CategoriesFrm";
            this.Text = "title_Categories";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.BackArrowControl backArrowControl1;
        private MetroFramework.Controls.MetroLabel lbl_CategoryCode;
        private VIBlend.WinForms.Controls.vTextBox tb_Search;
        private MetroFramework.Controls.MetroPanel detailsPanel;
        private In.Sontx.SimpleDataGridViewPaging.DataGridViewPaging dgv;
        private VIBlend.WinForms.Controls.vTextBox tb_CategoryCode;
        private VIBlend.WinForms.Controls.vCircularButton btn_Delete;
        private VIBlend.WinForms.Controls.vCircularButton btn_Cancel;
        private VIBlend.WinForms.Controls.vCircularButton btn_Add;
        private VIBlend.WinForms.Controls.vCircularButton btn_Edit;
        private VIBlend.WinForms.Controls.vCircularButton btn_Save;
        private VIBlend.WinForms.Controls.vTextBox tb_CategoryName;
        private MetroFramework.Controls.MetroLabel lbl_CategoryName;
        private VIBlend.WinForms.Controls.vComboBox cb_Language;
    }
}