
namespace Helium
{
    partial class HeliumForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeliumForm));
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.TabControl = new Sunny.UI.UITabControl();
            this.Utility = new System.Windows.Forms.TabPage();
            this.HideNamesLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.HideNamesSwitch = new MetroSet_UI.Controls.MetroSetSwitch();
            this.uiImageButton3 = new Sunny.UI.UIImageButton();
            this.uiImageButton2 = new Sunny.UI.UIImageButton();
            this.uiImageButton1 = new Sunny.UI.UIImageButton();
            this.NoFogRenderLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.NoFogRenderSwitch = new MetroSet_UI.Controls.MetroSetSwitch();
            this.NoBobbingLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.NoRenderLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.NoDropLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.enableALL = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.NoRenderItemsSwitch = new MetroSet_UI.Controls.MetroSetSwitch();
            this.NoBobbingSwitch = new MetroSet_UI.Controls.MetroSetSwitch();
            this.NoDropAnimationSwitch = new MetroSet_UI.Controls.MetroSetSwitch();
            this.Information = new System.Windows.Forms.TabPage();
            this.HotKeysInfo = new MetroSet_UI.Controls.MetroSetLabel();
            this.Status = new MetroSet_UI.Controls.MetroSetLabel();
            this.getStatus = new MetroSet_UI.Controls.MetroSetLabel();
            this.Hispano = new MetroSet_UI.Controls.MetroSetLabel();
            this.proID = new MetroSet_UI.Controls.MetroSetLabel();
            this.procIDLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.HeliumWorker = new System.ComponentModel.BackgroundWorker();
            this.TabControl.SuspendLayout();
            this.Utility.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).BeginInit();
            this.Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.Silver;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(397, 11);
            this.metroSetControlBox1.MaximizeBox = false;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroDark";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Utility);
            this.TabControl.Controls.Add(this.Information);
            this.TabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.TabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabControl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TabControl.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.ItemSize = new System.Drawing.Size(120, 30);
            this.TabControl.Location = new System.Drawing.Point(15, 93);
            this.TabControl.MainPage = "";
            this.TabControl.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(482, 245);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TabControl.TabIndex = 1;
            this.TabControl.TabSelectedColor = System.Drawing.Color.Red;
            this.TabControl.TabSelectedForeColor = System.Drawing.Color.White;
            this.TabControl.TabSelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TabControl.TabSelectedHighColorSize = 2;
            this.TabControl.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // Utility
            // 
            this.Utility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Utility.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Utility.Controls.Add(this.HideNamesLabel);
            this.Utility.Controls.Add(this.HideNamesSwitch);
            this.Utility.Controls.Add(this.uiImageButton3);
            this.Utility.Controls.Add(this.uiImageButton2);
            this.Utility.Controls.Add(this.uiImageButton1);
            this.Utility.Controls.Add(this.NoFogRenderLabel);
            this.Utility.Controls.Add(this.NoFogRenderSwitch);
            this.Utility.Controls.Add(this.NoBobbingLabel);
            this.Utility.Controls.Add(this.NoRenderLabel);
            this.Utility.Controls.Add(this.NoDropLabel);
            this.Utility.Controls.Add(this.enableALL);
            this.Utility.Controls.Add(this.NoRenderItemsSwitch);
            this.Utility.Controls.Add(this.NoBobbingSwitch);
            this.Utility.Controls.Add(this.NoDropAnimationSwitch);
            this.Utility.ForeColor = System.Drawing.Color.White;
            this.Utility.Location = new System.Drawing.Point(0, 30);
            this.Utility.Name = "Utility";
            this.Utility.Size = new System.Drawing.Size(482, 215);
            this.Utility.TabIndex = 0;
            this.Utility.Text = "Utility";
            // 
            // HideNamesLabel
            // 
            this.HideNamesLabel.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideNamesLabel.IsDerivedStyle = true;
            this.HideNamesLabel.Location = new System.Drawing.Point(74, 150);
            this.HideNamesLabel.Name = "HideNamesLabel";
            this.HideNamesLabel.Size = new System.Drawing.Size(150, 22);
            this.HideNamesLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.HideNamesLabel.StyleManager = null;
            this.HideNamesLabel.TabIndex = 13;
            this.HideNamesLabel.Text = "HIDE ALL NAMES";
            this.HideNamesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HideNamesLabel.ThemeAuthor = "Narwin";
            this.HideNamesLabel.ThemeName = "MetroLite";
            // 
            // HideNamesSwitch
            // 
            this.HideNamesSwitch.BackColor = System.Drawing.Color.Transparent;
            this.HideNamesSwitch.BackgroundColor = System.Drawing.Color.Empty;
            this.HideNamesSwitch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.HideNamesSwitch.CheckColor = System.Drawing.Color.Red;
            this.HideNamesSwitch.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.HideNamesSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HideNamesSwitch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.HideNamesSwitch.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.HideNamesSwitch.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.HideNamesSwitch.IsDerivedStyle = true;
            this.HideNamesSwitch.Location = new System.Drawing.Point(10, 150);
            this.HideNamesSwitch.Name = "HideNamesSwitch";
            this.HideNamesSwitch.Size = new System.Drawing.Size(58, 22);
            this.HideNamesSwitch.Style = MetroSet_UI.Enums.Style.Custom;
            this.HideNamesSwitch.StyleManager = null;
            this.HideNamesSwitch.Switched = false;
            this.HideNamesSwitch.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.HideNamesSwitch.TabIndex = 12;
            this.HideNamesSwitch.Text = "DRP";
            this.HideNamesSwitch.ThemeAuthor = "Hispano";
            this.HideNamesSwitch.ThemeName = "Helium-Red";
            this.HideNamesSwitch.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // uiImageButton3
            // 
            this.uiImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.uiImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("uiImageButton3.Image")));
            this.uiImageButton3.Location = new System.Drawing.Point(225, 115);
            this.uiImageButton3.Name = "uiImageButton3";
            this.uiImageButton3.Size = new System.Drawing.Size(22, 22);
            this.uiImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.uiImageButton3.TabIndex = 11;
            this.uiImageButton3.TabStop = false;
            this.uiImageButton3.Text = null;
            this.uiImageButton3.Click += new System.EventHandler(this.InfoClick);
            // 
            // uiImageButton2
            // 
            this.uiImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.uiImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("uiImageButton2.Image")));
            this.uiImageButton2.Location = new System.Drawing.Point(190, 80);
            this.uiImageButton2.Name = "uiImageButton2";
            this.uiImageButton2.Size = new System.Drawing.Size(22, 22);
            this.uiImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.uiImageButton2.TabIndex = 10;
            this.uiImageButton2.TabStop = false;
            this.uiImageButton2.Text = null;
            this.uiImageButton2.Click += new System.EventHandler(this.InfoClick);
            // 
            // uiImageButton1
            // 
            this.uiImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.uiImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("uiImageButton1.Image")));
            this.uiImageButton1.Location = new System.Drawing.Point(175, 45);
            this.uiImageButton1.Name = "uiImageButton1";
            this.uiImageButton1.Size = new System.Drawing.Size(22, 22);
            this.uiImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.uiImageButton1.TabIndex = 9;
            this.uiImageButton1.TabStop = false;
            this.uiImageButton1.Text = null;
            this.uiImageButton1.Click += new System.EventHandler(this.InfoClick);
            // 
            // NoFogRenderLabel
            // 
            this.NoFogRenderLabel.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoFogRenderLabel.IsDerivedStyle = true;
            this.NoFogRenderLabel.Location = new System.Drawing.Point(74, 45);
            this.NoFogRenderLabel.Name = "NoFogRenderLabel";
            this.NoFogRenderLabel.Size = new System.Drawing.Size(98, 22);
            this.NoFogRenderLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.NoFogRenderLabel.StyleManager = null;
            this.NoFogRenderLabel.TabIndex = 8;
            this.NoFogRenderLabel.Text = "NO FOG RENDER";
            this.NoFogRenderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NoFogRenderLabel.ThemeAuthor = "Narwin";
            this.NoFogRenderLabel.ThemeName = "MetroLite";
            // 
            // NoFogRenderSwitch
            // 
            this.NoFogRenderSwitch.BackColor = System.Drawing.Color.Transparent;
            this.NoFogRenderSwitch.BackgroundColor = System.Drawing.Color.Empty;
            this.NoFogRenderSwitch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.NoFogRenderSwitch.CheckColor = System.Drawing.Color.Red;
            this.NoFogRenderSwitch.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.NoFogRenderSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoFogRenderSwitch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.NoFogRenderSwitch.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.NoFogRenderSwitch.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.NoFogRenderSwitch.IsDerivedStyle = true;
            this.NoFogRenderSwitch.Location = new System.Drawing.Point(10, 45);
            this.NoFogRenderSwitch.Name = "NoFogRenderSwitch";
            this.NoFogRenderSwitch.Size = new System.Drawing.Size(58, 22);
            this.NoFogRenderSwitch.Style = MetroSet_UI.Enums.Style.Custom;
            this.NoFogRenderSwitch.StyleManager = null;
            this.NoFogRenderSwitch.Switched = false;
            this.NoFogRenderSwitch.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.NoFogRenderSwitch.TabIndex = 7;
            this.NoFogRenderSwitch.Text = "DRP";
            this.NoFogRenderSwitch.ThemeAuthor = "Hispano";
            this.NoFogRenderSwitch.ThemeName = "Helium-Red";
            this.NoFogRenderSwitch.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // NoBobbingLabel
            // 
            this.NoBobbingLabel.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoBobbingLabel.IsDerivedStyle = true;
            this.NoBobbingLabel.Location = new System.Drawing.Point(74, 115);
            this.NoBobbingLabel.Name = "NoBobbingLabel";
            this.NoBobbingLabel.Size = new System.Drawing.Size(150, 22);
            this.NoBobbingLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.NoBobbingLabel.StyleManager = null;
            this.NoBobbingLabel.TabIndex = 6;
            this.NoBobbingLabel.Text = "NO BOBBING ANIMATION";
            this.NoBobbingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NoBobbingLabel.ThemeAuthor = "Narwin";
            this.NoBobbingLabel.ThemeName = "MetroLite";
            // 
            // NoRenderLabel
            // 
            this.NoRenderLabel.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoRenderLabel.IsDerivedStyle = true;
            this.NoRenderLabel.Location = new System.Drawing.Point(74, 80);
            this.NoRenderLabel.Name = "NoRenderLabel";
            this.NoRenderLabel.Size = new System.Drawing.Size(113, 22);
            this.NoRenderLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.NoRenderLabel.StyleManager = null;
            this.NoRenderLabel.TabIndex = 5;
            this.NoRenderLabel.Text = "NO ITEMS RENDER";
            this.NoRenderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NoRenderLabel.ThemeAuthor = "Narwin";
            this.NoRenderLabel.ThemeName = "MetroLite";
            // 
            // NoDropLabel
            // 
            this.NoDropLabel.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoDropLabel.IsDerivedStyle = true;
            this.NoDropLabel.Location = new System.Drawing.Point(74, 10);
            this.NoDropLabel.Name = "NoDropLabel";
            this.NoDropLabel.Size = new System.Drawing.Size(171, 22);
            this.NoDropLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.NoDropLabel.StyleManager = null;
            this.NoDropLabel.TabIndex = 4;
            this.NoDropLabel.Text = "NO DROP ANIMATION";
            this.NoDropLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NoDropLabel.ThemeAuthor = "Narwin";
            this.NoDropLabel.ThemeName = "MetroLite";
            // 
            // enableALL
            // 
            this.enableALL.BackColor = System.Drawing.Color.Transparent;
            this.enableALL.BackgroundColor = System.Drawing.Color.White;
            this.enableALL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.enableALL.Checked = false;
            this.enableALL.CheckSignColor = System.Drawing.Color.Red;
            this.enableALL.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.enableALL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enableALL.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.enableALL.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableALL.IsDerivedStyle = false;
            this.enableALL.Location = new System.Drawing.Point(10, 185);
            this.enableALL.Name = "enableALL";
            this.enableALL.SignStyle = MetroSet_UI.Enums.SignStyle.Shape;
            this.enableALL.Size = new System.Drawing.Size(88, 16);
            this.enableALL.Style = MetroSet_UI.Enums.Style.Custom;
            this.enableALL.StyleManager = null;
            this.enableALL.TabIndex = 3;
            this.enableALL.Text = "Enable All";
            this.enableALL.ThemeAuthor = "Hispano";
            this.enableALL.ThemeName = "Helium-Red-Red";
            this.enableALL.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.EnableALL_CheckedChanged);
            // 
            // NoRenderItemsSwitch
            // 
            this.NoRenderItemsSwitch.BackColor = System.Drawing.Color.Transparent;
            this.NoRenderItemsSwitch.BackgroundColor = System.Drawing.Color.Empty;
            this.NoRenderItemsSwitch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.NoRenderItemsSwitch.CheckColor = System.Drawing.Color.Red;
            this.NoRenderItemsSwitch.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.NoRenderItemsSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoRenderItemsSwitch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.NoRenderItemsSwitch.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.NoRenderItemsSwitch.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.NoRenderItemsSwitch.IsDerivedStyle = true;
            this.NoRenderItemsSwitch.Location = new System.Drawing.Point(10, 80);
            this.NoRenderItemsSwitch.Name = "NoRenderItemsSwitch";
            this.NoRenderItemsSwitch.Size = new System.Drawing.Size(58, 22);
            this.NoRenderItemsSwitch.Style = MetroSet_UI.Enums.Style.Custom;
            this.NoRenderItemsSwitch.StyleManager = null;
            this.NoRenderItemsSwitch.Switched = false;
            this.NoRenderItemsSwitch.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.NoRenderItemsSwitch.TabIndex = 2;
            this.NoRenderItemsSwitch.Text = "DRP";
            this.NoRenderItemsSwitch.ThemeAuthor = "Hispano";
            this.NoRenderItemsSwitch.ThemeName = "Helium-Red";
            this.NoRenderItemsSwitch.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // NoBobbingSwitch
            // 
            this.NoBobbingSwitch.BackColor = System.Drawing.Color.Transparent;
            this.NoBobbingSwitch.BackgroundColor = System.Drawing.Color.Empty;
            this.NoBobbingSwitch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.NoBobbingSwitch.CheckColor = System.Drawing.Color.Red;
            this.NoBobbingSwitch.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.NoBobbingSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoBobbingSwitch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.NoBobbingSwitch.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.NoBobbingSwitch.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.NoBobbingSwitch.IsDerivedStyle = true;
            this.NoBobbingSwitch.Location = new System.Drawing.Point(10, 115);
            this.NoBobbingSwitch.Name = "NoBobbingSwitch";
            this.NoBobbingSwitch.Size = new System.Drawing.Size(58, 22);
            this.NoBobbingSwitch.Style = MetroSet_UI.Enums.Style.Custom;
            this.NoBobbingSwitch.StyleManager = null;
            this.NoBobbingSwitch.Switched = false;
            this.NoBobbingSwitch.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.NoBobbingSwitch.TabIndex = 1;
            this.NoBobbingSwitch.Text = "DRP";
            this.NoBobbingSwitch.ThemeAuthor = "Hispano";
            this.NoBobbingSwitch.ThemeName = "Helium-Red";
            this.NoBobbingSwitch.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // NoDropAnimationSwitch
            // 
            this.NoDropAnimationSwitch.BackColor = System.Drawing.Color.Transparent;
            this.NoDropAnimationSwitch.BackgroundColor = System.Drawing.Color.Empty;
            this.NoDropAnimationSwitch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.NoDropAnimationSwitch.CheckColor = System.Drawing.Color.Red;
            this.NoDropAnimationSwitch.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.NoDropAnimationSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoDropAnimationSwitch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.NoDropAnimationSwitch.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.NoDropAnimationSwitch.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.NoDropAnimationSwitch.IsDerivedStyle = true;
            this.NoDropAnimationSwitch.Location = new System.Drawing.Point(10, 10);
            this.NoDropAnimationSwitch.Name = "NoDropAnimationSwitch";
            this.NoDropAnimationSwitch.Size = new System.Drawing.Size(58, 22);
            this.NoDropAnimationSwitch.Style = MetroSet_UI.Enums.Style.Custom;
            this.NoDropAnimationSwitch.StyleManager = null;
            this.NoDropAnimationSwitch.Switched = false;
            this.NoDropAnimationSwitch.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.NoDropAnimationSwitch.TabIndex = 0;
            this.NoDropAnimationSwitch.Text = "DRP";
            this.NoDropAnimationSwitch.ThemeAuthor = "Hispano";
            this.NoDropAnimationSwitch.ThemeName = "Helium-Red";
            this.NoDropAnimationSwitch.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // Information
            // 
            this.Information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Information.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Information.Controls.Add(this.HotKeysInfo);
            this.Information.Controls.Add(this.Status);
            this.Information.Controls.Add(this.getStatus);
            this.Information.Controls.Add(this.Hispano);
            this.Information.Controls.Add(this.proID);
            this.Information.Controls.Add(this.procIDLabel);
            this.Information.ForeColor = System.Drawing.Color.White;
            this.Information.Location = new System.Drawing.Point(0, 30);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(482, 215);
            this.Information.TabIndex = 1;
            this.Information.Text = "Information";
            // 
            // HotKeysInfo
            // 
            this.HotKeysInfo.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotKeysInfo.IsDerivedStyle = true;
            this.HotKeysInfo.Location = new System.Drawing.Point(268, 14);
            this.HotKeysInfo.Name = "HotKeysInfo";
            this.HotKeysInfo.Size = new System.Drawing.Size(200, 158);
            this.HotKeysInfo.Style = MetroSet_UI.Enums.Style.Light;
            this.HotKeysInfo.StyleManager = null;
            this.HotKeysInfo.TabIndex = 6;
            this.HotKeysInfo.Text = "HotKeys to toggle the utilities:\r\nF1 -> NO DROP ANIMATION\r\nF2 -> NO FOG RENDER\r\nF" +
    "3 -> NO ITEMS RENDER\r\nF4 -> NO BOBBING ANIMATION\r\nF5 -> HIDE ALL NAMES\r\nF6 -> EN" +
    "ABLE ALL\r\n";
            this.HotKeysInfo.ThemeAuthor = "Narwin";
            this.HotKeysInfo.ThemeName = "MetroLite";
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.IsDerivedStyle = true;
            this.Status.Location = new System.Drawing.Point(12, 37);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(77, 23);
            this.Status.Style = MetroSet_UI.Enums.Style.Light;
            this.Status.StyleManager = null;
            this.Status.TabIndex = 5;
            this.Status.Text = "STATUS:";
            this.Status.ThemeAuthor = "Narwin";
            this.Status.ThemeName = "MetroLite";
            // 
            // getStatus
            // 
            this.getStatus.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getStatus.IsDerivedStyle = true;
            this.getStatus.Location = new System.Drawing.Point(85, 37);
            this.getStatus.Name = "getStatus";
            this.getStatus.Size = new System.Drawing.Size(108, 23);
            this.getStatus.Style = MetroSet_UI.Enums.Style.Light;
            this.getStatus.StyleManager = null;
            this.getStatus.TabIndex = 4;
            this.getStatus.Text = "DISCONNECTED";
            this.getStatus.ThemeAuthor = "Narwin";
            this.getStatus.ThemeName = "MetroLite";
            // 
            // Hispano
            // 
            this.Hispano.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hispano.IsDerivedStyle = true;
            this.Hispano.Location = new System.Drawing.Point(94, 191);
            this.Hispano.Name = "Hispano";
            this.Hispano.Size = new System.Drawing.Size(293, 23);
            this.Hispano.Style = MetroSet_UI.Enums.Style.Light;
            this.Hispano.StyleManager = null;
            this.Hispano.TabIndex = 3;
            this.Hispano.Text = "Helium has been scripted and compiled by Hispano";
            this.Hispano.ThemeAuthor = "Narwin";
            this.Hispano.ThemeName = "MetroLite";
            // 
            // proID
            // 
            this.proID.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proID.IsDerivedStyle = true;
            this.proID.Location = new System.Drawing.Point(12, 14);
            this.proID.Name = "proID";
            this.proID.Size = new System.Drawing.Size(77, 23);
            this.proID.Style = MetroSet_UI.Enums.Style.Light;
            this.proID.StyleManager = null;
            this.proID.TabIndex = 2;
            this.proID.Text = "PROCESS:";
            this.proID.ThemeAuthor = "Narwin";
            this.proID.ThemeName = "MetroLite";
            // 
            // procIDLabel
            // 
            this.procIDLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procIDLabel.IsDerivedStyle = true;
            this.procIDLabel.Location = new System.Drawing.Point(85, 14);
            this.procIDLabel.Name = "procIDLabel";
            this.procIDLabel.Size = new System.Drawing.Size(108, 23);
            this.procIDLabel.Style = MetroSet_UI.Enums.Style.Light;
            this.procIDLabel.StyleManager = null;
            this.procIDLabel.TabIndex = 1;
            this.procIDLabel.Text = "DISCONNECTED";
            this.procIDLabel.ThemeAuthor = "Narwin";
            this.procIDLabel.ThemeName = "MetroLite";
            // 
            // HeliumWorker
            // 
            this.HeliumWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.HeliumWorker_DoWork);
            // 
            // HeliumForm
            // 
            this.AllowResize = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageTransparency = 0.1F;
            this.ClientSize = new System.Drawing.Size(512, 353);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.metroSetControlBox1);
            this.Font = new System.Drawing.Font("Impact", 13.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(512, 353);
            this.MinimumSize = new System.Drawing.Size(512, 353);
            this.Name = "HeliumForm";
            this.Opacity = 0.95D;
            this.Padding = new System.Windows.Forms.Padding(12, 90, 12, 12);
            this.ShowTitle = false;
            this.SmallLineColor1 = System.Drawing.Color.Red;
            this.SmallLineColor2 = System.Drawing.Color.Red;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Custom;
            this.Text = "Helium";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeAuthor = "Hispano";
            this.ThemeName = "Helium-Red";
            this.UseSlideAnimation = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.Utility.ResumeLayout(false);
            this.Utility.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).EndInit();
            this.Information.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private Sunny.UI.UITabControl TabControl;
        private System.Windows.Forms.TabPage Utility;
        private System.Windows.Forms.TabPage Information;
        private MetroSet_UI.Controls.MetroSetLabel procIDLabel;
        private MetroSet_UI.Controls.MetroSetLabel getStatus;
        private MetroSet_UI.Controls.MetroSetLabel Hispano;
        private MetroSet_UI.Controls.MetroSetLabel proID;
        private MetroSet_UI.Controls.MetroSetLabel Status;
        private MetroSet_UI.Controls.MetroSetSwitch NoRenderItemsSwitch;
        private MetroSet_UI.Controls.MetroSetSwitch NoBobbingSwitch;
        private MetroSet_UI.Controls.MetroSetCheckBox enableALL;
        private MetroSet_UI.Controls.MetroSetLabel NoBobbingLabel;
        private MetroSet_UI.Controls.MetroSetLabel NoRenderLabel;
        private MetroSet_UI.Controls.MetroSetLabel NoDropLabel;
        private System.ComponentModel.BackgroundWorker HeliumWorker;
        private MetroSet_UI.Controls.MetroSetSwitch NoFogRenderSwitch;
        private MetroSet_UI.Controls.MetroSetLabel NoFogRenderLabel;
        private Sunny.UI.UIImageButton uiImageButton1;
        private Sunny.UI.UIImageButton uiImageButton3;
        private Sunny.UI.UIImageButton uiImageButton2;
        private MetroSet_UI.Controls.MetroSetLabel HideNamesLabel;
        private MetroSet_UI.Controls.MetroSetSwitch HideNamesSwitch;
        private MetroSet_UI.Controls.MetroSetSwitch NoDropAnimationSwitch;
        private MetroSet_UI.Controls.MetroSetLabel HotKeysInfo;
    }
}

