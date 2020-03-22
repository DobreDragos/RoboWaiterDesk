namespace RoboDesk
{
    partial class TablesFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablesFrm));
            this.lbl_Code = new MetroFramework.Controls.MetroLabel();
            this.tb_Search = new VIBlend.WinForms.Controls.vTextBox();
            this.detailsPanel = new MetroFramework.Controls.MetroPanel();
            this.tb_Code = new VIBlend.WinForms.Controls.vTextBox();
            this.dgv = new In.Sontx.SimpleDataGridViewPaging.DataGridViewPaging();
            this.btn_Delete = new VIBlend.WinForms.Controls.vCircularButton();
            this.btn_Cancel = new VIBlend.WinForms.Controls.vCircularButton();
            this.btn_Add = new VIBlend.WinForms.Controls.vCircularButton();
            this.btn_Edit = new VIBlend.WinForms.Controls.vCircularButton();
            this.btn_Save = new VIBlend.WinForms.Controls.vCircularButton();
            this.backArrowControl1 = new RoboDesk.CustomControls.BackArrowControl();
            this.detailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Code
            // 
            this.lbl_Code.AutoSize = true;
            this.lbl_Code.Location = new System.Drawing.Point(15, 24);
            this.lbl_Code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(42, 20);
            this.lbl_Code.TabIndex = 7;
            this.lbl_Code.Text = "Code";
            this.lbl_Code.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.tb_Search.Location = new System.Drawing.Point(31, 325);
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
            this.detailsPanel.Controls.Add(this.tb_Code);
            this.detailsPanel.Controls.Add(this.lbl_Code);
            this.detailsPanel.HorizontalScrollbarBarColor = true;
            this.detailsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.detailsPanel.HorizontalScrollbarSize = 12;
            this.detailsPanel.Location = new System.Drawing.Point(31, 121);
            this.detailsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(1041, 176);
            this.detailsPanel.TabIndex = 26;
            this.detailsPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.detailsPanel.VerticalScrollbarBarColor = true;
            this.detailsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.detailsPanel.VerticalScrollbarSize = 13;
            // 
            // tb_Code
            // 
            this.tb_Code.BackColor = System.Drawing.Color.White;
            this.tb_Code.BoundsOffset = new System.Drawing.Size(1, 1);
            this.tb_Code.ControlBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tb_Code.DefaultText = "";
            this.tb_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Code.Location = new System.Drawing.Point(145, 18);
            this.tb_Code.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Code.MaxLength = 50;
            this.tb_Code.MinimumSize = new System.Drawing.Size(133, 37);
            this.tb_Code.Name = "tb_Code";
            this.tb_Code.PasswordChar = '\0';
            this.tb_Code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Code.SelectionLength = 0;
            this.tb_Code.SelectionStart = 0;
            this.tb_Code.Size = new System.Drawing.Size(317, 37);
            this.tb_Code.TabIndex = 31;
            this.tb_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Code.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND;
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoHideNavigator = false;
            this.dgv.BackColor = System.Drawing.SystemColors.Control;
            this.dgv.DataSource = null;
            this.dgv.Location = new System.Drawing.Point(31, 362);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv.MaxRecords = 100;
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1041, 218);
            this.dgv.TabIndex = 28;
            // 
            // btn_Delete
            // 
            this.btn_Delete.AllowAnimations = true;
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Delete.HoverEffectsEnabled = true;
            this.btn_Delete.Location = new System.Drawing.Point(339, 24);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.RoundedCornersMask = ((byte)(15));
            this.btn_Delete.Size = new System.Drawing.Size(96, 89);
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
            this.btn_Cancel.Location = new System.Drawing.Point(827, 24);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.RoundedCornersMask = ((byte)(15));
            this.btn_Cancel.Size = new System.Drawing.Size(96, 89);
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
            this.btn_Add.Location = new System.Drawing.Point(669, 24);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.RoundedCornersMask = ((byte)(15));
            this.btn_Add.Size = new System.Drawing.Size(96, 89);
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
            this.btn_Edit.Location = new System.Drawing.Point(504, 24);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.RoundedCornersMask = ((byte)(15));
            this.btn_Edit.Size = new System.Drawing.Size(96, 89);
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
            this.btn_Save.Location = new System.Drawing.Point(178, 24);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.RoundedCornersMask = ((byte)(15));
            this.btn_Save.Size = new System.Drawing.Size(96, 89);
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
            this.backArrowControl1.Location = new System.Drawing.Point(989, 37);
            this.backArrowControl1.Margin = new System.Windows.Forms.Padding(5);
            this.backArrowControl1.Name = "backArrowControl1";
            this.backArrowControl1.Size = new System.Drawing.Size(85, 49);
            this.backArrowControl1.TabIndex = 2;
            // 
            // TablesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 609);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TablesFrm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Alergens";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.BackArrowControl backArrowControl1;
        private MetroFramework.Controls.MetroLabel lbl_Code;
        private VIBlend.WinForms.Controls.vTextBox tb_Search;
        private MetroFramework.Controls.MetroPanel detailsPanel;
        private In.Sontx.SimpleDataGridViewPaging.DataGridViewPaging dgv;
        private VIBlend.WinForms.Controls.vTextBox tb_Code;
        private VIBlend.WinForms.Controls.vCircularButton btn_Delete;
        private VIBlend.WinForms.Controls.vCircularButton btn_Cancel;
        private VIBlend.WinForms.Controls.vCircularButton btn_Add;
        private VIBlend.WinForms.Controls.vCircularButton btn_Edit;
        private VIBlend.WinForms.Controls.vCircularButton btn_Save;
    }
}