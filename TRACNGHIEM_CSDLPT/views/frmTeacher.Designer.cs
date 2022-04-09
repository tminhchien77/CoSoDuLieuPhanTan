
namespace TRACNGHIEM_CSDLPT.views
{
    partial class frmTeacher
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
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
            this.bdsTeacher = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new TRACNGHIEM_CSDLPT.DS();
            this.bdsGVtheoKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.TN_CSDLPTDataSet = new TRACNGHIEM_CSDLPT.TN_CSDLPTDataSet();
            this.SP_DSGVTheoKhoaVaCoSoTableAdapter = new TRACNGHIEM_CSDLPT.TN_CSDLPTDataSetTableAdapters.SP_DSGVTheoKhoaVaCoSoTableAdapter();
            this.tableAdapterManager = new TRACNGHIEM_CSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.bdsGiaoVien = new System.Windows.Forms.BindingSource(this.components);
            this.GIAOVIENTableAdapter = new TRACNGHIEM_CSDLPT.TN_CSDLPTDataSetTableAdapters.GIAOVIENTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbxDept = new System.Windows.Forms.ComboBox();
            this.bdsDept = new System.Windows.Forms.BindingSource(this.components);
            this.cbbxBranch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableAdapterDept = new TRACNGHIEM_CSDLPT.DSTableAdapters.KHOATableAdapter();
            this.tableAdapterManager1 = new TRACNGHIEM_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.tableAdapterTeacher = new TRACNGHIEM_CSDLPT.DSTableAdapters.SP_TeacherTableTableAdapter();
            this.bdsQues = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterQuestions = new TRACNGHIEM_CSDLPT.DSTableAdapters.BODETableAdapter();
            this.bdsTeacherRegis = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterTeacherRegistrasion = new TRACNGHIEM_CSDLPT.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.sP_TeacherListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_TeacherListTableAdapter = new TRACNGHIEM_CSDLPT.DSTableAdapters.SP_TeacherListTableAdapter();
            this.gcTeacher = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.txtAddr = new DevExpress.XtraEditors.TextEdit();
            this.txtLName = new DevExpress.XtraEditors.TextEdit();
            this.txtFName = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVtheoKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsQues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeacherRegis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_TeacherListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(581, 17);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(47, 13);
            tENKHLabel.TabIndex = 8;
            tENKHLabel.Text = "TENKH:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(82, 73);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(77, 13);
            mAGVLabel.TabIndex = 2;
            mAGVLabel.Text = "Mã giảng viên:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(82, 119);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(24, 13);
            hOLabel.TabIndex = 3;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(448, 119);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(29, 13);
            tENLabel.TabIndex = 5;
            tENLabel.Text = "Tên:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(82, 166);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(43, 13);
            dIACHILabel.TabIndex = 7;
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
            this.barDockControlTop.Size = new System.Drawing.Size(866, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 543);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlBottom.Size = new System.Drawing.Size(866, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 503);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(866, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 503);
            // 
            // bdsTeacher
            // 
            this.bdsTeacher.DataMember = "SP_TeacherTable";
            this.bdsTeacher.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGVtheoKhoa
            // 
            this.bdsGVtheoKhoa.DataMember = "SP_DSGVTheoKhoaVaCoSo";
            this.bdsGVtheoKhoa.DataSource = this.TN_CSDLPTDataSet;
            // 
            // TN_CSDLPTDataSet
            // 
            this.TN_CSDLPTDataSet.DataSetName = "TN_CSDLPTDataSet";
            this.TN_CSDLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_DSGVTheoKhoaVaCoSoTableAdapter
            // 
            this.SP_DSGVTheoKhoaVaCoSoTableAdapter.ClearBeforeFill = true;
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
            // bdsGiaoVien
            // 
            this.bdsGiaoVien.DataMember = "GIAOVIEN";
            this.bdsGiaoVien.DataSource = this.TN_CSDLPTDataSet;
            // 
            // GIAOVIENTableAdapter
            // 
            this.GIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(tENKHLabel);
            this.panel1.Controls.Add(this.cbbxDept);
            this.panel1.Controls.Add(this.cbbxBranch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 54);
            this.panel1.TabIndex = 10;
            // 
            // cbbxDept
            // 
            this.cbbxDept.AllowDrop = true;
            this.cbbxDept.DataSource = this.bdsDept;
            this.cbbxDept.DisplayMember = "TENKH";
            this.cbbxDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxDept.Location = new System.Drawing.Point(634, 14);
            this.cbbxDept.Name = "cbbxDept";
            this.cbbxDept.Size = new System.Drawing.Size(121, 21);
            this.cbbxDept.TabIndex = 9;
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
            this.cbbxBranch.Location = new System.Drawing.Point(68, 14);
            this.cbbxBranch.Margin = new System.Windows.Forms.Padding(2);
            this.cbbxBranch.Name = "cbbxBranch";
            this.cbbxBranch.Size = new System.Drawing.Size(237, 21);
            this.cbbxBranch.TabIndex = 8;
            this.cbbxBranch.SelectedIndexChanged += new System.EventHandler(this.cbbxBranch_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cơ sở:";
            // 
            // tableAdapterDept
            // 
            this.tableAdapterDept.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            /*this.tableAdapterManager1.BAITHITableAdapter = null;*/
            this.tableAdapterManager1.BANGDIEMTableAdapter = null;
            this.tableAdapterManager1.BODETableAdapter = null;
            this.tableAdapterManager1.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager1.GIAOVIENTableAdapter = null;
            this.tableAdapterManager1.KHOATableAdapter = this.tableAdapterDept;
            this.tableAdapterManager1.MONHOCTableAdapter = null;
            this.tableAdapterManager1.SINHVIENTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = TRACNGHIEM_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterTeacher
            // 
            this.tableAdapterTeacher.ClearBeforeFill = true;
            // 
            // bdsQues
            // 
            this.bdsQues.DataMember = "FK_SP_TeacherTable_BODE";
            this.bdsQues.DataSource = this.bdsTeacher;
            // 
            // tableAdapterQuestions
            // 
            this.tableAdapterQuestions.ClearBeforeFill = true;
            // 
            // bdsTeacherRegis
            // 
            this.bdsTeacherRegis.DataMember = "FK_SP_TeacherTable_GIAOVIEN_DANGKY";
            this.bdsTeacherRegis.DataSource = this.bdsTeacher;
            // 
            // tableAdapterTeacherRegistrasion
            // 
            this.tableAdapterTeacherRegistrasion.ClearBeforeFill = true;
            // 
            // sP_TeacherListBindingSource
            // 
            this.sP_TeacherListBindingSource.DataMember = "SP_TeacherList";
            this.sP_TeacherListBindingSource.DataSource = this.dS;
            // 
            // sP_TeacherListTableAdapter
            // 
            this.sP_TeacherListTableAdapter.ClearBeforeFill = true;
            // 
            // gcTeacher
            // 
            this.gcTeacher.DataSource = this.bdsTeacher;
            this.gcTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTeacher.Location = new System.Drawing.Point(0, 94);
            this.gcTeacher.MainView = this.gridView1;
            this.gcTeacher.MenuManager = this.barManager1;
            this.gcTeacher.Name = "gcTeacher";
            this.gcTeacher.Size = new System.Drawing.Size(866, 220);
            this.gcTeacher.TabIndex = 14;
            this.gcTeacher.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gcTeacher;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(dIACHILabel);
            this.groupInfo.Controls.Add(this.txtAddr);
            this.groupInfo.Controls.Add(tENLabel);
            this.groupInfo.Controls.Add(this.txtLName);
            this.groupInfo.Controls.Add(hOLabel);
            this.groupInfo.Controls.Add(this.txtFName);
            this.groupInfo.Controls.Add(mAGVLabel);
            this.groupInfo.Controls.Add(this.txtId);
            this.groupInfo.Controls.Add(this.label1);
            this.groupInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupInfo.Enabled = false;
            this.groupInfo.Location = new System.Drawing.Point(0, 314);
            this.groupInfo.Margin = new System.Windows.Forms.Padding(2);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Padding = new System.Windows.Forms.Padding(2);
            this.groupInfo.Size = new System.Drawing.Size(866, 229);
            this.groupInfo.TabIndex = 23;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Thông tin";
            // 
            // txtAddr
            // 
            this.txtAddr.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTeacher, "DIACHI", true));
            this.txtAddr.Location = new System.Drawing.Point(177, 163);
            this.txtAddr.MenuManager = this.barManager1;
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(464, 20);
            this.txtAddr.TabIndex = 8;
            // 
            // txtLName
            // 
            this.txtLName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTeacher, "TEN", true));
            this.txtLName.Location = new System.Drawing.Point(497, 116);
            this.txtLName.MenuManager = this.barManager1;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(144, 20);
            this.txtLName.TabIndex = 6;
            // 
            // txtFName
            // 
            this.txtFName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTeacher, "HO", true));
            this.txtFName.Location = new System.Drawing.Point(177, 116);
            this.txtFName.MenuManager = this.barManager1;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(196, 20);
            this.txtFName.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTeacher, "MAGV", true));
            this.txtId.Location = new System.Drawing.Point(177, 70);
            this.txtId.MenuManager = this.barManager1;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 20);
            this.txtId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÔNG TIN GIẢNG VIÊN";
            // 
            // frmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 563);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.gcTeacher);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTeacher";
            this.Text = "frmTeacher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVtheoKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsQues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeacherRegis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_TeacherListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsGVtheoKhoa;
        private TN_CSDLPTDataSet TN_CSDLPTDataSet;
        private TN_CSDLPTDataSetTableAdapters.SP_DSGVTheoKhoaVaCoSoTableAdapter SP_DSGVTheoKhoaVaCoSoTableAdapter;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsGiaoVien;
        private TN_CSDLPTDataSetTableAdapters.GIAOVIENTableAdapter GIAOVIENTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbxBranch;
        private System.Windows.Forms.Label label4;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsDept;
        private DSTableAdapters.KHOATableAdapter tableAdapterDept;
        private DSTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource bdsTeacher;
        private DSTableAdapters.SP_TeacherTableTableAdapter tableAdapterTeacher;
        private System.Windows.Forms.BindingSource bdsQues;
        private DSTableAdapters.BODETableAdapter tableAdapterQuestions;
        private System.Windows.Forms.BindingSource bdsTeacherRegis;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter tableAdapterTeacherRegistrasion;
        private System.Windows.Forms.ComboBox cbbxDept;
        private System.Windows.Forms.BindingSource sP_TeacherListBindingSource;
        private DSTableAdapters.SP_TeacherListTableAdapter sP_TeacherListTableAdapter;
        private DevExpress.XtraGrid.GridControl gcTeacher;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupInfo;
        private DevExpress.XtraEditors.TextEdit txtAddr;
        private DevExpress.XtraEditors.TextEdit txtLName;
        private DevExpress.XtraEditors.TextEdit txtFName;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.Label label1;
    }
}