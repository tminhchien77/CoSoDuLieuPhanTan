
namespace TRACNGHIEM_CSDLPT.views
{
    partial class frmStudent
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
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label dIACHILabel;
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
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.TN_CSDLPTDataSet = new TRACNGHIEM_CSDLPT.TN_CSDLPTDataSet();
            this.bdsSVtheoLOP = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SP_DSSVTheoLopTableAdapter = new TRACNGHIEM_CSDLPT.TN_CSDLPTDataSetTableAdapters.SP_DSSVTheoLopTableAdapter();
            this.tableAdapterManager = new TRACNGHIEM_CSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.SINHVIENTableAdapter = new TRACNGHIEM_CSDLPT.TN_CSDLPTDataSetTableAdapters.SINHVIENTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbxClass = new System.Windows.Forms.ComboBox();
            this.bdsClass = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new TRACNGHIEM_CSDLPT.DS();
            this.cbbxDept = new System.Windows.Forms.ComboBox();
            this.bdsDept = new System.Windows.Forms.BindingSource(this.components);
            this.cbbxBranch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableAdapterDept = new TRACNGHIEM_CSDLPT.DSTableAdapters.KHOATableAdapter();
            this.tableAdapterManager1 = new TRACNGHIEM_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.tableAdapterClass = new TRACNGHIEM_CSDLPT.DSTableAdapters.SP_ClassListTableAdapter();
            this.bdsStudent = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterStudent = new TRACNGHIEM_CSDLPT.DSTableAdapters.SP_StudentTableTableAdapter();
            this.gcStudent = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.txtAddr = new DevExpress.XtraEditors.TextEdit();
            this.dateEditDOB = new DevExpress.XtraEditors.DateEdit();
            this.txtLName = new DevExpress.XtraEditors.TextEdit();
            this.txtFName = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.bdsScore = new System.Windows.Forms.BindingSource(this.components);
            this.bANGDIEMTableAdapter = new TRACNGHIEM_CSDLPT.DSTableAdapters.BANGDIEMTableAdapter();
            tENKHLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSVtheoLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsScore)).BeginInit();
            this.SuspendLayout();
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(391, 22);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(43, 13);
            tENKHLabel.TabIndex = 4;
            tENKHLabel.Text = "TENKH:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(628, 22);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(49, 13);
            tENLOPLabel.TabIndex = 5;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(97, 63);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(70, 13);
            mASVLabel.TabIndex = 2;
            mASVLabel.Text = "Mã sinh viên:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(97, 106);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(24, 13);
            hOLabel.TabIndex = 3;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(391, 102);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(29, 13);
            tENLabel.TabIndex = 5;
            tENLabel.Text = "Tên:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(97, 151);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(57, 13);
            nGAYSINHLabel.TabIndex = 7;
            nGAYSINHLabel.Text = "Ngày sinh:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(97, 186);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(43, 13);
            dIACHILabel.TabIndex = 9;
            dIACHILabel.Text = "Địa chỉ:";
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
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xoá";
            this.btnDelete.Id = 2;
            this.btnDelete.ImageOptions.Image = global::TRACNGHIEM_CSDLPT.Properties.Resources.icons8_trash;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
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
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(909, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 589);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlBottom.Size = new System.Drawing.Size(909, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 549);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(909, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 549);
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "SINHVIEN";
            this.bdsSinhVien.DataSource = this.TN_CSDLPTDataSet;
            // 
            // TN_CSDLPTDataSet
            // 
            this.TN_CSDLPTDataSet.DataSetName = "TN_CSDLPTDataSet";
            this.TN_CSDLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsSVtheoLOP
            // 
            this.bdsSVtheoLOP.DataMember = "SP_DSSVTheoLop";
            this.bdsSVtheoLOP.DataSource = this.TN_CSDLPTDataSet;
            // 
            // SP_DSSVTheoLopTableAdapter
            // 
            this.SP_DSSVTheoLopTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.SP_DanhSachBoDeTableAdapter = null;
            this.tableAdapterManager.SP_DanhSachLopTheoKhoaVaCoSoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TRACNGHIEM_CSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(tENLOPLabel);
            this.panelControl1.Controls.Add(this.cbbxClass);
            this.panelControl1.Controls.Add(tENKHLabel);
            this.panelControl1.Controls.Add(this.cbbxDept);
            this.panelControl1.Controls.Add(this.cbbxBranch);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 40);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(909, 57);
            this.panelControl1.TabIndex = 11;
            // 
            // cbbxClass
            // 
            this.cbbxClass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsClass, "TENLOP", true));
            this.cbbxClass.DataSource = this.bdsClass;
            this.cbbxClass.DisplayMember = "TENLOP";
            this.cbbxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxClass.FormattingEnabled = true;
            this.cbbxClass.Location = new System.Drawing.Point(683, 19);
            this.cbbxClass.Name = "cbbxClass";
            this.cbbxClass.Size = new System.Drawing.Size(201, 21);
            this.cbbxClass.TabIndex = 6;
            this.cbbxClass.ValueMember = "MALOP";
            this.cbbxClass.SelectedValueChanged += new System.EventHandler(this.cbbxClass_SelectedValueChanged);
            // 
            // bdsClass
            // 
            this.bdsClass.DataMember = "SP_ClassList";
            this.bdsClass.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbxDept
            // 
            this.cbbxDept.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDept, "TENKH", true));
            this.cbbxDept.DataSource = this.bdsDept;
            this.cbbxDept.DisplayMember = "TENKH";
            this.cbbxDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxDept.FormattingEnabled = true;
            this.cbbxDept.Location = new System.Drawing.Point(440, 19);
            this.cbbxDept.Name = "cbbxDept";
            this.cbbxDept.Size = new System.Drawing.Size(121, 21);
            this.cbbxDept.TabIndex = 5;
            this.cbbxDept.ValueMember = "MAKH";
            this.cbbxDept.SelectedValueChanged += new System.EventHandler(this.cbbxDept_SelectedValueChanged);
            // 
            // bdsDept
            // 
            this.bdsDept.DataMember = "KHOA";
            this.bdsDept.DataSource = this.dS;
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
            this.cbbxBranch.SelectedIndexChanged += new System.EventHandler(this.cbbxBranch_SelectedIndexChanged);
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
            // tableAdapterClass
            // 
            this.tableAdapterClass.ClearBeforeFill = true;
            // 
            // bdsStudent
            // 
            this.bdsStudent.DataMember = "SP_StudentTable";
            this.bdsStudent.DataSource = this.dS;
            // 
            // tableAdapterStudent
            // 
            this.tableAdapterStudent.ClearBeforeFill = true;
            // 
            // gcStudent
            // 
            this.gcStudent.DataSource = this.bdsStudent;
            this.gcStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcStudent.Location = new System.Drawing.Point(0, 97);
            this.gcStudent.MainView = this.gridView1;
            this.gcStudent.MenuManager = this.barManager1;
            this.gcStudent.Name = "gcStudent";
            this.gcStudent.Size = new System.Drawing.Size(909, 260);
            this.gcStudent.TabIndex = 16;
            this.gcStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colNGAYSINH,
            this.colDIACHI});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gcStudent;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.DisplayFormat.FormatString = "d";
            this.colNGAYSINH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 3;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(dIACHILabel);
            this.groupInfo.Controls.Add(this.txtAddr);
            this.groupInfo.Controls.Add(nGAYSINHLabel);
            this.groupInfo.Controls.Add(this.dateEditDOB);
            this.groupInfo.Controls.Add(tENLabel);
            this.groupInfo.Controls.Add(this.txtLName);
            this.groupInfo.Controls.Add(hOLabel);
            this.groupInfo.Controls.Add(this.txtFName);
            this.groupInfo.Controls.Add(mASVLabel);
            this.groupInfo.Controls.Add(this.txtId);
            this.groupInfo.Controls.Add(this.label1);
            this.groupInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupInfo.Enabled = false;
            this.groupInfo.Location = new System.Drawing.Point(0, 357);
            this.groupInfo.Margin = new System.Windows.Forms.Padding(2);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Padding = new System.Windows.Forms.Padding(2);
            this.groupInfo.Size = new System.Drawing.Size(909, 232);
            this.groupInfo.TabIndex = 21;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Thông tin";
            // 
            // txtAddr
            // 
            this.txtAddr.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsStudent, "DIACHI", true));
            this.txtAddr.Location = new System.Drawing.Point(173, 183);
            this.txtAddr.MenuManager = this.barManager1;
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(478, 20);
            this.txtAddr.TabIndex = 10;
            // 
            // dateEditDOB
            // 
            this.dateEditDOB.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsStudent, "NGAYSINH", true));
            this.dateEditDOB.EditValue = null;
            this.dateEditDOB.Location = new System.Drawing.Point(173, 148);
            this.dateEditDOB.MenuManager = this.barManager1;
            this.dateEditDOB.Name = "dateEditDOB";
            this.dateEditDOB.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dateEditDOB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDOB.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDOB.Size = new System.Drawing.Size(185, 20);
            this.dateEditDOB.TabIndex = 8;
            // 
            // txtLName
            // 
            this.txtLName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsStudent, "TEN", true));
            this.txtLName.Location = new System.Drawing.Point(466, 99);
            this.txtLName.MenuManager = this.barManager1;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(185, 20);
            this.txtLName.TabIndex = 6;
            // 
            // txtFName
            // 
            this.txtFName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsStudent, "HO", true));
            this.txtFName.Location = new System.Drawing.Point(173, 99);
            this.txtFName.MenuManager = this.barManager1;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(185, 20);
            this.txtFName.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsStudent, "MASV", true));
            this.txtId.Location = new System.Drawing.Point(173, 60);
            this.txtId.MenuManager = this.barManager1;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(185, 20);
            this.txtId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÔNG TIN SINH VIÊN";
            // 
            // bdsScore
            // 
            this.bdsScore.DataMember = "SP_StudentTable_BANGDIEM";
            this.bdsScore.DataSource = this.bdsStudent;
            // 
            // bANGDIEMTableAdapter
            // 
            this.bANGDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 609);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.gcStudent);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStudent";
            this.Text = "frmStudent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSVtheoLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsScore)).EndInit();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource bdsSVtheoLOP;
        private TN_CSDLPTDataSet TN_CSDLPTDataSet;
        private TN_CSDLPTDataSetTableAdapters.SP_DSSVTheoLopTableAdapter SP_DSSVTheoLopTableAdapter;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private TN_CSDLPTDataSetTableAdapters.SINHVIENTableAdapter SINHVIENTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbxBranch;
        private System.Windows.Forms.Label label2;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsDept;
        private DSTableAdapters.KHOATableAdapter tableAdapterDept;
        private DSTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox cbbxDept;
        private System.Windows.Forms.BindingSource bdsClass;
        private DSTableAdapters.SP_ClassListTableAdapter tableAdapterClass;
        private System.Windows.Forms.ComboBox cbbxClass;
        private System.Windows.Forms.BindingSource bdsStudent;
        private DSTableAdapters.SP_StudentTableTableAdapter tableAdapterStudent;
        private DevExpress.XtraGrid.GridControl gcStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupInfo;
        private DevExpress.XtraEditors.TextEdit txtAddr;
        private DevExpress.XtraEditors.DateEdit dateEditDOB;
        private DevExpress.XtraEditors.TextEdit txtLName;
        private DevExpress.XtraEditors.TextEdit txtFName;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private System.Windows.Forms.BindingSource bdsScore;
        private DSTableAdapters.BANGDIEMTableAdapter bANGDIEMTableAdapter;
    }
}