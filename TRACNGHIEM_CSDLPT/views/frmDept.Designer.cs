
namespace TRACNGHIEM_CSDLPT.views
{
    partial class frmDept
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
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mACSLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedo = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.TN_CSDLPTDataSet = new TRACNGHIEM_CSDLPT.TN_CSDLPTDataSet();
            this.tableAdapterManager = new TRACNGHIEM_CSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.LOPTableAdapter = new TRACNGHIEM_CSDLPT.TN_CSDLPTDataSetTableAdapters.LOPTableAdapter();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbxBranch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dS = new TRACNGHIEM_CSDLPT.DS();
            this.bdsDept = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterDept = new TRACNGHIEM_CSDLPT.DSTableAdapters.KHOATableAdapter();
            this.tableAdapterManager1 = new TRACNGHIEM_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.gcDept = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.txtDept = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBranchId = new DevExpress.XtraEditors.TextEdit();
            mAKHLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mACSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDept.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(90, 74);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(41, 13);
            mAKHLabel.TabIndex = 2;
            mAKHLabel.Text = "MAKH:";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(376, 79);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(47, 13);
            tENKHLabel.TabIndex = 3;
            tENKHLabel.Text = "TENKH:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.btnSave,
            this.btnRefresh,
            this.btnUndo,
            this.btnRedo,
            this.btnCancel});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRedo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancel)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.Image = global::TRACNGHIEM_CSDLPT.Properties.Resources.icons8_plus;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Sửa";
            this.btnEdit.Id = 1;
            this.btnEdit.ImageOptions.Image = global::TRACNGHIEM_CSDLPT.Properties.Resources.icons8_pencil;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xoá";
            this.btnDelete.Id = 2;
            this.btnDelete.ImageOptions.Image = global::TRACNGHIEM_CSDLPT.Properties.Resources.icons8_trash;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Ghi";
            this.btnSave.Id = 3;
            this.btnSave.ImageOptions.Image = global::TRACNGHIEM_CSDLPT.Properties.Resources.icons8_save;
            this.btnSave.Name = "btnSave";
            this.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 4;
            this.btnRefresh.ImageOptions.Image = global::TRACNGHIEM_CSDLPT.Properties.Resources.icons8_refresh;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Id = 5;
            this.btnUndo.ImageOptions.Image = global::TRACNGHIEM_CSDLPT.Properties.Resources.icons8_undo_32;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnRedo
            // 
            this.btnRedo.Caption = "Redo";
            this.btnRedo.Id = 6;
            this.btnRedo.ImageOptions.Image = global::TRACNGHIEM_CSDLPT.Properties.Resources.icons8_redo_32;
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Cancel";
            this.btnCancel.Id = 7;
            this.btnCancel.ImageOptions.Image = global::TRACNGHIEM_CSDLPT.Properties.Resources.icons8_cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlTop.Size = new System.Drawing.Size(1010, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 570);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlBottom.Size = new System.Drawing.Size(1010, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 530);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1010, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 530);
            // 
            // bdsKhoa
            // 
            this.bdsKhoa.DataMember = "KHOA";
            this.bdsKhoa.DataSource = this.TN_CSDLPTDataSet;
            // 
            // TN_CSDLPTDataSet
            // 
            this.TN_CSDLPTDataSet.DataSetName = "TN_CSDLPTDataSet";
            this.TN_CSDLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.LOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.SP_DanhSachBoDeTableAdapter = null;
            this.tableAdapterManager.SP_DanhSachLopTheoKhoaVaCoSoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TRACNGHIEM_CSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "KHOA_LOP";
            this.bdsLop.DataSource = this.bdsKhoa;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbbxBranch);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 40);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1010, 62);
            this.panelControl1.TabIndex = 12;
            // 
            // cbbxBranch
            // 
            this.cbbxBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxBranch.Enabled = false;
            this.cbbxBranch.FormattingEnabled = true;
            this.cbbxBranch.Location = new System.Drawing.Point(87, 17);
            this.cbbxBranch.Margin = new System.Windows.Forms.Padding(2);
            this.cbbxBranch.Name = "cbbxBranch";
            this.cbbxBranch.Size = new System.Drawing.Size(237, 21);
            this.cbbxBranch.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cơ sở:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDept
            // 
            this.bdsDept.DataMember = "KHOA";
            this.bdsDept.DataSource = this.dS;
            // 
            // tableAdapterDept
            // 
            this.tableAdapterDept.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BANGDIEMTableAdapter = null;
            this.tableAdapterManager1.BODETableAdapter = null;
            this.tableAdapterManager1.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager1.GIAOVIENTableAdapter = null;
            this.tableAdapterManager1.KHOATableAdapter = this.tableAdapterDept;
            this.tableAdapterManager1.MONHOCTableAdapter = null;
            this.tableAdapterManager1.SINHVIENTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = TRACNGHIEM_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcDept
            // 
            this.gcDept.DataSource = this.bdsDept;
            this.gcDept.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDept.Location = new System.Drawing.Point(0, 102);
            this.gcDept.MainView = this.gridView1;
            this.gcDept.MenuManager = this.barManager1;
            this.gcDept.Name = "gcDept";
            this.gcDept.Size = new System.Drawing.Size(1010, 348);
            this.gcDept.TabIndex = 12;
            this.gcDept.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMACS});
            this.gridView1.GridControl = this.gcDept;
            this.gridView1.Name = "gridView1";
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            // 
            // colTENKH
            // 
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            // 
            // colMACS
            // 
            this.colMACS.FieldName = "MACS";
            this.colMACS.Name = "colMACS";
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(mACSLabel);
            this.groupInfo.Controls.Add(this.txtBranchId);
            this.groupInfo.Controls.Add(tENKHLabel);
            this.groupInfo.Controls.Add(this.txtDept);
            this.groupInfo.Controls.Add(mAKHLabel);
            this.groupInfo.Controls.Add(this.txtId);
            this.groupInfo.Controls.Add(this.label1);
            this.groupInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupInfo.Enabled = false;
            this.groupInfo.Location = new System.Drawing.Point(0, 450);
            this.groupInfo.Margin = new System.Windows.Forms.Padding(2);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Padding = new System.Windows.Forms.Padding(2);
            this.groupInfo.Size = new System.Drawing.Size(1010, 120);
            this.groupInfo.TabIndex = 23;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Thông tin";
            // 
            // txtDept
            // 
            this.txtDept.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDept, "TENKH", true));
            this.txtDept.Location = new System.Drawing.Point(429, 76);
            this.txtDept.MenuManager = this.barManager1;
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(100, 20);
            this.txtDept.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDept, "MAKH", true));
            this.txtId.Location = new System.Drawing.Point(137, 71);
            this.txtId.MenuManager = this.barManager1;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÔNG TIN KHOA";
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Location = new System.Drawing.Point(593, 76);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(40, 13);
            mACSLabel.TabIndex = 5;
            mACSLabel.Text = "MACS:";
            mACSLabel.Visible = false;
            // 
            // txtBranchId
            // 
            this.txtBranchId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDept, "MACS", true));
            this.txtBranchId.Location = new System.Drawing.Point(639, 73);
            this.txtBranchId.MenuManager = this.barManager1;
            this.txtBranchId.Name = "txtBranchId";
            this.txtBranchId.Size = new System.Drawing.Size(100, 20);
            this.txtBranchId.TabIndex = 6;
            this.txtBranchId.Visible = false;
            // 
            // frmDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 590);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.gcDept);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDept";
            this.Text = "frmDep";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDept.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnRedo;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsKhoa;
        private TN_CSDLPTDataSet TN_CSDLPTDataSet;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TN_CSDLPTDataSetTableAdapters.LOPTableAdapter LOPTableAdapter;
        private System.Windows.Forms.BindingSource bdsLop;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbxBranch;
        private System.Windows.Forms.Label label2;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsDept;
        private DSTableAdapters.KHOATableAdapter tableAdapterDept;
        private DSTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraGrid.GridControl gcDept;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtDept;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.TextEdit txtBranchId;
    }
}