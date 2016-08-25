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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.menuOpen = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControlPac = new DevExpress.XtraGrid.GridControl();
            this.gridViewPac = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.treeListPac = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.splitterControl2 = new DevExpress.XtraEditors.SplitterControl();
            this.hexBoxPac = new Be.Windows.Forms.HexBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListPac)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
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
            this.menuOpen});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
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
            this.barDockControlTop.Size = new System.Drawing.Size(527, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 406);
            this.barDockControlBottom.Size = new System.Drawing.Size(527, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 53);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 353);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(527, 53);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 353);
            // 
            // gridControlPac
            // 
            this.gridControlPac.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlPac.Location = new System.Drawing.Point(0, 53);
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
            this.splitterControl1.Location = new System.Drawing.Point(0, 187);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(527, 5);
            this.splitterControl1.TabIndex = 6;
            this.splitterControl1.TabStop = false;
            // 
            // treeListPac
            // 
            this.treeListPac.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeListPac.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeListPac.Location = new System.Drawing.Point(0, 192);
            this.treeListPac.Name = "treeListPac";
            this.treeListPac.OptionsBehavior.Editable = false;
            this.treeListPac.OptionsBehavior.ReadOnly = true;
            this.treeListPac.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeListPac.OptionsView.ShowColumns = false;
            this.treeListPac.OptionsView.ShowHorzLines = false;
            this.treeListPac.OptionsView.ShowIndicator = false;
            this.treeListPac.OptionsView.ShowVertLines = false;
            this.treeListPac.Size = new System.Drawing.Size(527, 168);
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
            // splitterControl2
            // 
            this.splitterControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl2.Location = new System.Drawing.Point(0, 360);
            this.splitterControl2.Name = "splitterControl2";
            this.splitterControl2.Size = new System.Drawing.Size(527, 5);
            this.splitterControl2.TabIndex = 8;
            this.splitterControl2.TabStop = false;
            // 
            // hexBoxPac
            // 
            this.hexBoxPac.BodyOffset = 0;
            this.hexBoxPac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexBoxPac.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexBoxPac.HeaderColor = System.Drawing.Color.Maroon;
            this.hexBoxPac.LineInfoVisible = true;
            this.hexBoxPac.Location = new System.Drawing.Point(0, 365);
            this.hexBoxPac.Name = "hexBoxPac";
            this.hexBoxPac.ReadOnly = true;
            this.hexBoxPac.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.hexBoxPac.SelectionLength = ((long)(0));
            this.hexBoxPac.SelectionStart = ((long)(-1));
            this.hexBoxPac.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBoxPac.Size = new System.Drawing.Size(527, 41);
            this.hexBoxPac.StringViewVisible = true;
            this.hexBoxPac.TabIndex = 9;
            this.hexBoxPac.UseFixedBytesPerLine = true;
            this.hexBoxPac.VScrollBarVisible = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 429);
            this.Controls.Add(this.hexBoxPac);
            this.Controls.Add(this.splitterControl2);
            this.Controls.Add(this.treeListPac);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.gridControlPac);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private DevExpress.XtraEditors.SplitterControl splitterControl2;
        private DevExpress.XtraTreeList.TreeList treeListPac;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraGrid.GridControl gridControlPac;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPac;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
    }
}