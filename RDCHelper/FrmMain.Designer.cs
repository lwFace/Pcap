namespace RDCHelper
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnOpenPcap = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnOpenXml = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.menuOpen = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barBtnSetRule = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonVersion = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonHelp = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barBtnLoadAnalysis = new DevExpress.XtraBars.BarButtonItem();
            this.gridControlPac = new DevExpress.XtraGrid.GridControl();
            this.gridViewPac = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.treeListPac = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.hexBoxPac = new Be.Windows.Forms.HexBox();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.splitterControl2 = new DevExpress.XtraEditors.SplitterControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListPac)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.AllowCustomization = false;
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.menuOpen,
            this.barBtnOpenPcap,
            this.barBtnOpenXml,
            this.barBtnLoadAnalysis,
            this.barSubItem2,
            this.barButtonVersion,
            this.barButtonHelp,
            this.barSubItem3,
            this.barBtnSetRule});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnOpenPcap),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnOpenXml)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.All;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barBtnOpenPcap
            // 
            this.barBtnOpenPcap.Caption = "打开pcap文件";
            this.barBtnOpenPcap.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnOpenPcap.Glyph")));
            this.barBtnOpenPcap.Id = 2;
            this.barBtnOpenPcap.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnOpenPcap.LargeGlyph")));
            this.barBtnOpenPcap.Name = "barBtnOpenPcap";
            this.barBtnOpenPcap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnOpenPcap_ItemClick);
            // 
            // barBtnOpenXml
            // 
            this.barBtnOpenXml.Caption = "载入规则文件";
            this.barBtnOpenXml.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnOpenXml.Glyph")));
            this.barBtnOpenXml.Id = 3;
            this.barBtnOpenXml.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnOpenXml.LargeGlyph")));
            this.barBtnOpenXml.Name = "barBtnOpenXml";
            this.barBtnOpenXml.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnOpenXml_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2)});
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "文件";
            this.barSubItem1.Id = 0;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.menuOpen)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // menuOpen
            // 
            this.menuOpen.Caption = "打开...";
            this.menuOpen.Id = 1;
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuOpen_ItemClick);
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "设置";
            this.barSubItem3.Id = 9;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnSetRule)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barBtnSetRule
            // 
            this.barBtnSetRule.Caption = "解析规则";
            this.barBtnSetRule.Id = 10;
            this.barBtnSetRule.Name = "barBtnSetRule";
            this.barBtnSetRule.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSetRule_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "关于";
            this.barSubItem2.Id = 5;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonVersion, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonHelp, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barButtonVersion
            // 
            this.barButtonVersion.Caption = "软件版本";
            this.barButtonVersion.Id = 6;
            this.barButtonVersion.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonVersion.LargeGlyph")));
            this.barButtonVersion.Name = "barButtonVersion";
            // 
            // barButtonHelp
            // 
            this.barButtonHelp.Caption = "帮助";
            this.barButtonHelp.Id = 7;
            this.barButtonHelp.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonHelp.LargeGlyph")));
            this.barButtonHelp.Name = "barButtonHelp";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(527, 54);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 489);
            this.barDockControlBottom.Size = new System.Drawing.Size(527, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 54);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 435);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(527, 54);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 435);
            // 
            // barBtnLoadAnalysis
            // 
            this.barBtnLoadAnalysis.Caption = "载入解析规则";
            this.barBtnLoadAnalysis.Id = 4;
            this.barBtnLoadAnalysis.Name = "barBtnLoadAnalysis";
            // 
            // gridControlPac
            // 
            this.gridControlPac.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlPac.Location = new System.Drawing.Point(0, 54);
            this.gridControlPac.MainView = this.gridViewPac;
            this.gridControlPac.MenuManager = this.barManager1;
            this.gridControlPac.Name = "gridControlPac";
            this.gridControlPac.Size = new System.Drawing.Size(527, 134);
            this.gridControlPac.TabIndex = 4;
            this.gridControlPac.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPac});
            // 
            // gridViewPac
            // 
            this.gridViewPac.GridControl = this.gridControlPac;
            this.gridViewPac.Name = "gridViewPac";
            this.gridViewPac.OptionsBehavior.Editable = false;
            this.gridViewPac.OptionsBehavior.ReadOnly = true;
            this.gridViewPac.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewPac.OptionsView.ShowGroupPanel = false;
            this.gridViewPac.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewPac_RowClick);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(0, 188);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(527, 12);
            this.splitterControl1.TabIndex = 6;
            this.splitterControl1.TabStop = false;
            // 
            // treeListPac
            // 
            this.treeListPac.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeListPac.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeListPac.Location = new System.Drawing.Point(0, 200);
            this.treeListPac.Name = "treeListPac";
            this.treeListPac.OptionsBehavior.Editable = false;
            this.treeListPac.OptionsBehavior.ReadOnly = true;
            this.treeListPac.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeListPac.OptionsView.ShowColumns = false;
            this.treeListPac.OptionsView.ShowHorzLines = false;
            this.treeListPac.OptionsView.ShowIndicator = false;
            this.treeListPac.OptionsView.ShowVertLines = false;
            this.treeListPac.Size = new System.Drawing.Size(232, 289);
            this.treeListPac.TabIndex = 7;
            this.treeListPac.Click += new System.EventHandler(this.treeListPac_Click);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "treeListColumn1";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // hexBoxPac
            // 
            this.hexBoxPac.BodyOffset = 0;
            this.hexBoxPac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexBoxPac.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexBoxPac.HeaderColor = System.Drawing.Color.Maroon;
            this.hexBoxPac.LineInfoVisible = true;
            this.hexBoxPac.Location = new System.Drawing.Point(232, 200);
            this.hexBoxPac.Name = "hexBoxPac";
            this.hexBoxPac.ReadOnly = true;
            this.hexBoxPac.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.hexBoxPac.SelectionLength = ((long)(0));
            this.hexBoxPac.SelectionStart = ((long)(-1));
            this.hexBoxPac.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBoxPac.Size = new System.Drawing.Size(295, 289);
            this.hexBoxPac.StringViewVisible = true;
            this.hexBoxPac.TabIndex = 9;
            this.hexBoxPac.UseFixedBytesPerLine = true;
            this.hexBoxPac.VScrollBarVisible = true;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            // 
            // splitterControl2
            // 
            this.splitterControl2.Location = new System.Drawing.Point(232, 200);
            this.splitterControl2.Name = "splitterControl2";
            this.splitterControl2.Size = new System.Drawing.Size(12, 289);
            this.splitterControl2.TabIndex = 14;
            this.splitterControl2.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 511);
            this.Controls.Add(this.splitterControl2);
            this.Controls.Add(this.hexBoxPac);
            this.Controls.Add(this.treeListPac);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.gridControlPac);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "RDC调试助手";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListPac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem menuOpen;
        private Be.Windows.Forms.HexBox hexBoxPac;
        private DevExpress.XtraTreeList.TreeList treeListPac;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraGrid.GridControl gridControlPac;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPac;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraBars.BarButtonItem barBtnOpenPcap;
        private DevExpress.XtraBars.BarButtonItem barBtnOpenXml;
        private DevExpress.XtraBars.BarButtonItem barBtnLoadAnalysis;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonVersion;
        private DevExpress.XtraBars.BarButtonItem barButtonHelp;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem barBtnSetRule;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SplitterControl splitterControl2;
    }
}