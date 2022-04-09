
namespace TRACNGHIEM_CSDLPT.views.Teacher
{
    partial class frmRegisTest
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label sOCAUTHILabel;
            System.Windows.Forms.Label tHOIGIANLabel;
            System.Windows.Forms.Label mAGVLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.saveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.undoBtn = new DevExpress.XtraBars.BarButtonItem();
            this.redoBtn = new DevExpress.XtraBars.BarButtonItem();
            this.cancelBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.regisInforGroup = new System.Windows.Forms.GroupBox();
            this.teacherIdComboBox = new System.Windows.Forms.ComboBox();
            this.bdsRegis = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new TRACNGHIEM_CSDLPT.DS();
            this.teacherListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtExamTime = new DevExpress.XtraEditors.TextEdit();
            this.txtNumQues = new DevExpress.XtraEditors.TextEdit();
            this.cbbxTimes = new System.Windows.Forms.ComboBox();
            this.examDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.cbbxClass = new System.Windows.Forms.ComboBox();
            this.classListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbxSubj = new System.Windows.Forms.ComboBox();
            this.subjListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbbxBranch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbxDept = new System.Windows.Forms.ComboBox();
            this.deptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsKhoa = new TRACNGHIEM_CSDLPT.dsKhoa();
            this.tableAdapterManager = new TRACNGHIEM_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.sP_RegisListTableAdapter = new TRACNGHIEM_CSDLPT.DSTableAdapters.SP_RegisListTableAdapter();
            this.regisListGridControl = new DevExpress.XtraGrid.GridControl();
            this.regisListgridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deptTableAdapter = new TRACNGHIEM_CSDLPT.dsKhoaTableAdapters.KHOATableAdapter();
            this.tableAdapterManager1 = new TRACNGHIEM_CSDLPT.dsKhoaTableAdapters.TableAdapterManager();
            this.sP_TeacherListTableAdapter = new TRACNGHIEM_CSDLPT.DSTableAdapters.SP_TeacherListTableAdapter();
            this.sP_ClassListTableAdapter = new TRACNGHIEM_CSDLPT.DSTableAdapters.SP_ClassListTableAdapter();
            this.sP_SubjListTableAdapter = new TRACNGHIEM_CSDLPT.DSTableAdapters.SP_SubjListTableAdapter();
            this.bar1 = new DevExpress.XtraBars.Bar();
            tENKHLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            sOCAUTHILabel = new System.Windows.Forms.Label();
            tHOIGIANLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.regisInforGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRegis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExamTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumQues.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regisListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regisListgridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(649, 28);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(35, 13);
            tENKHLabel.TabIndex = 4;
            tENKHLabel.Text = "Khoa:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(63, 71);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(52, 13);
            mAMHLabel.TabIndex = 3;
            mAMHLabel.Text = "Môn học:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(362, 71);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(28, 13);
            mALOPLabel.TabIndex = 5;
            mALOPLabel.Text = "Lớp:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(340, 117);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(50, 13);
            tRINHDOLabel.TabIndex = 7;
            tRINHDOLabel.Text = "Trình độ:";
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Location = new System.Drawing.Point(63, 163);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(49, 13);
            nGAYTHILabel.TabIndex = 9;
            nGAYTHILabel.Text = "Ngày thi:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(650, 71);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(42, 13);
            lANLabel.TabIndex = 11;
            lANLabel.Text = "Lần thi:";
            // 
            // sOCAUTHILabel
            // 
            sOCAUTHILabel.AutoSize = true;
            sOCAUTHILabel.Location = new System.Drawing.Point(332, 163);
            sOCAUTHILabel.Name = "sOCAUTHILabel";
            sOCAUTHILabel.Size = new System.Drawing.Size(58, 13);
            sOCAUTHILabel.TabIndex = 13;
            sOCAUTHILabel.Text = "Số câu thi:";
            // 
            // tHOIGIANLabel
            // 
            tHOIGIANLabel.AutoSize = true;
            tHOIGIANLabel.Location = new System.Drawing.Point(602, 163);
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            tHOIGIANLabel.Size = new System.Drawing.Size(90, 13);
            tHOIGIANLabel.TabIndex = 15;
            tHOIGIANLabel.Text = "Thời gian làm bài:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(63, 117);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(55, 13);
            mAGVLabel.TabIndex = 16;
            mAGVLabel.Text = "Giáo viên:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.addBtn,
            this.editBtn,
            this.deleteBtn,
            this.saveBtn,
            this.btnRefresh,
            this.undoBtn,
            this.redoBtn,
            this.cancelBtn,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(273, 127);
            this.bar2.FloatSize = new System.Drawing.Size(656, 42);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.addBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.editBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.saveBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.undoBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.redoBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.cancelBtn)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // addBtn
            // 
            this.addBtn.Caption = "Thêm";
            this.addBtn.Id = 0;
            this.addBtn.ImageOptions.Image = global::TRACNGHIEM_CSDLPT.Properties.Resources.icons8_plus;
            this.addBtn.Name = "addBtn";
            this.addBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.addBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBtn_ItemClick);
            // 
            // editBtn
            // 
            this.editBtn.Caption = "Sửa";
            this.editBtn.Id = 1;
            this.editBtn.ImageOptions.Image = global::TRACNGHIEM_CSDLPT.Properties.Resources.icons8_pencil;
            this.editBtn.Name = "editBtn";
            this.editBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.editBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editBtn_ItemClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Xoá";
            this.deleteBtn.Id = 2;
            this.deleteBtn.ImageOptions.Image = global::TRACNGHIEM_CSDLPT.Properties.Resources.icons8_trash;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.deleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBtn_ItemClick);
            // 
            // saveBtn
            // 
            this.saveBtn.Caption = "Ghi";
            this.saveBtn.Id = 3;
            this.saveBtn.ImageOptions.Image = global::TRACNGHIEM_CSDLPT.Properties.Resources.icons8_save;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.saveBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveBtn_ItemClick);
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
            // undoBtn
            // 
            this.undoBtn.Caption = "Undo";
            this.undoBtn.Id = 5;
            this.undoBtn.ImageOptions.Image = global::TRACNGHIEM_CSDLPT.Properties.Resources.icons8_undo_32;
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // redoBtn
            // 
            this.redoBtn.Caption = "Redo";
            this.redoBtn.Id = 6;
            this.redoBtn.ImageOptions.Image = global::TRACNGHIEM_CSDLPT.Properties.Resources.icons8_redo_32;
            this.redoBtn.Name = "redoBtn";
            this.redoBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Caption = "Cancel";
            this.cancelBtn.Id = 7;
            this.cancelBtn.ImageOptions.Image = global::TRACNGHIEM_CSDLPT.Properties.Resources.icons8_cancel;
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.cancelBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlTop.Size = new System.Drawing.Size(989, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 585);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlBottom.Size = new System.Drawing.Size(989, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 545);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(989, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 545);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // regisInforGroup
            // 
            this.regisInforGroup.Controls.Add(mAGVLabel);
            this.regisInforGroup.Controls.Add(this.teacherIdComboBox);
            this.regisInforGroup.Controls.Add(tHOIGIANLabel);
            this.regisInforGroup.Controls.Add(this.txtExamTime);
            this.regisInforGroup.Controls.Add(sOCAUTHILabel);
            this.regisInforGroup.Controls.Add(this.txtNumQues);
            this.regisInforGroup.Controls.Add(lANLabel);
            this.regisInforGroup.Controls.Add(this.cbbxTimes);
            this.regisInforGroup.Controls.Add(nGAYTHILabel);
            this.regisInforGroup.Controls.Add(this.examDateEdit);
            this.regisInforGroup.Controls.Add(tRINHDOLabel);
            this.regisInforGroup.Controls.Add(this.levelComboBox);
            this.regisInforGroup.Controls.Add(mALOPLabel);
            this.regisInforGroup.Controls.Add(this.cbbxClass);
            this.regisInforGroup.Controls.Add(mAMHLabel);
            this.regisInforGroup.Controls.Add(this.cbbxSubj);
            this.regisInforGroup.Controls.Add(this.label1);
            this.regisInforGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regisInforGroup.Enabled = false;
            this.regisInforGroup.Location = new System.Drawing.Point(0, 326);
            this.regisInforGroup.Margin = new System.Windows.Forms.Padding(2);
            this.regisInforGroup.Name = "regisInforGroup";
            this.regisInforGroup.Padding = new System.Windows.Forms.Padding(2);
            this.regisInforGroup.Size = new System.Drawing.Size(989, 259);
            this.regisInforGroup.TabIndex = 4;
            this.regisInforGroup.TabStop = false;
            this.regisInforGroup.Text = "Thông tin";
            // 
            // teacherIdComboBox
            // 
            this.teacherIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsRegis, "MAGV", true));
            this.teacherIdComboBox.DataSource = this.teacherListBindingSource;
            this.teacherIdComboBox.DisplayMember = "HOTEN";
            this.teacherIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherIdComboBox.FormattingEnabled = true;
            this.teacherIdComboBox.Location = new System.Drawing.Point(142, 114);
            this.teacherIdComboBox.Name = "teacherIdComboBox";
            this.teacherIdComboBox.Size = new System.Drawing.Size(160, 21);
            this.teacherIdComboBox.TabIndex = 17;
            this.teacherIdComboBox.ValueMember = "MAGV";
            // 
            // bdsRegis
            // 
            this.bdsRegis.DataMember = "SP_RegisList";
            this.bdsRegis.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherListBindingSource
            // 
            this.teacherListBindingSource.DataMember = "SP_TeacherList";
            this.teacherListBindingSource.DataSource = this.DS;
            // 
            // txtExamTime
            // 
            this.txtExamTime.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsRegis, "THOIGIAN", true));
            this.txtExamTime.Location = new System.Drawing.Point(721, 160);
            this.txtExamTime.MenuManager = this.barManager1;
            this.txtExamTime.Name = "txtExamTime";
            this.txtExamTime.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtExamTime.Properties.MaskSettings.Set("mask", "d");
            this.txtExamTime.Properties.UseMaskAsDisplayFormat = true;
            this.txtExamTime.Size = new System.Drawing.Size(98, 20);
            this.txtExamTime.TabIndex = 16;
            // 
            // txtNumQues
            // 
            this.txtNumQues.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsRegis, "SOCAUTHI", true));
            this.txtNumQues.Location = new System.Drawing.Point(417, 160);
            this.txtNumQues.MenuManager = this.barManager1;
            this.txtNumQues.Name = "txtNumQues";
            this.txtNumQues.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtNumQues.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtNumQues.Properties.MaskSettings.Set("mask", "d");
            this.txtNumQues.Properties.UseMaskAsDisplayFormat = true;
            this.txtNumQues.Size = new System.Drawing.Size(121, 20);
            this.txtNumQues.TabIndex = 14;
            // 
            // cbbxTimes
            // 
            this.cbbxTimes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsRegis, "LAN", true));
            this.cbbxTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxTimes.FormattingEnabled = true;
            this.cbbxTimes.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbxTimes.Location = new System.Drawing.Point(721, 68);
            this.cbbxTimes.Name = "cbbxTimes";
            this.cbbxTimes.Size = new System.Drawing.Size(98, 21);
            this.cbbxTimes.TabIndex = 12;
            // 
            // examDateEdit
            // 
            this.examDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsRegis, "NGAYTHI", true));
            this.examDateEdit.EditValue = null;
            this.examDateEdit.Location = new System.Drawing.Point(142, 160);
            this.examDateEdit.MenuManager = this.barManager1;
            this.examDateEdit.Name = "examDateEdit";
            this.examDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.examDateEdit.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.examDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.examDateEdit.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "g");
            this.examDateEdit.Properties.DisplayFormat.FormatString = "g";
            this.examDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.examDateEdit.Properties.EditFormat.FormatString = "g";
            this.examDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.examDateEdit.Properties.MaskSettings.Set("mask", "g");
            this.examDateEdit.Size = new System.Drawing.Size(160, 20);
            this.examDateEdit.TabIndex = 10;
            // 
            // levelComboBox
            // 
            this.levelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsRegis, "TRINHDO", true));
            this.levelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.levelComboBox.Location = new System.Drawing.Point(417, 114);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(121, 21);
            this.levelComboBox.TabIndex = 8;
            // 
            // cbbxClass
            // 
            this.cbbxClass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsRegis, "MALOP", true));
            this.cbbxClass.DataSource = this.classListBindingSource;
            this.cbbxClass.DisplayMember = "MALOP";
            this.cbbxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxClass.FormattingEnabled = true;
            this.cbbxClass.Location = new System.Drawing.Point(417, 68);
            this.cbbxClass.Name = "cbbxClass";
            this.cbbxClass.Size = new System.Drawing.Size(181, 21);
            this.cbbxClass.TabIndex = 6;
            this.cbbxClass.ValueMember = "MALOP";
            // 
            // classListBindingSource
            // 
            this.classListBindingSource.DataMember = "SP_ClassList";
            this.classListBindingSource.DataSource = this.DS;
            // 
            // cbbxSubj
            // 
            this.cbbxSubj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsRegis, "MAMH", true));
            this.cbbxSubj.DataSource = this.subjListBindingSource;
            this.cbbxSubj.DisplayMember = "TENMH";
            this.cbbxSubj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxSubj.FormattingEnabled = true;
            this.cbbxSubj.Location = new System.Drawing.Point(142, 68);
            this.cbbxSubj.Name = "cbbxSubj";
            this.cbbxSubj.Size = new System.Drawing.Size(160, 21);
            this.cbbxSubj.TabIndex = 4;
            this.cbbxSubj.ValueMember = "MAMH";
            // 
            // subjListBindingSource
            // 
            this.subjListBindingSource.DataMember = "SP_SubjList";
            this.subjListBindingSource.DataSource = this.DS;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÔNG TIN ĐĂNG KÝ";
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
            this.cbbxBranch.EnabledChanged += new System.EventHandler(this.branchCombobox_EnabledChanged);
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(tENKHLabel);
            this.panelControl1.Controls.Add(this.cbbxDept);
            this.panelControl1.Controls.Add(this.cbbxBranch);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 40);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(989, 66);
            this.panelControl1.TabIndex = 10;
            // 
            // cbbxDept
            // 
            this.cbbxDept.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deptBindingSource, "TENKH", true));
            this.cbbxDept.DataSource = this.deptBindingSource;
            this.cbbxDept.DisplayMember = "TENKH";
            this.cbbxDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxDept.FormattingEnabled = true;
            this.cbbxDept.Location = new System.Drawing.Point(698, 25);
            this.cbbxDept.Name = "cbbxDept";
            this.cbbxDept.Size = new System.Drawing.Size(121, 21);
            this.cbbxDept.TabIndex = 5;
            this.cbbxDept.ValueMember = "MAKH";
            this.cbbxDept.SelectedValueChanged += new System.EventHandler(this.deptComboBox_SelectedValueChanged);
            // 
            // deptBindingSource
            // 
            this.deptBindingSource.DataMember = "KHOA";
            this.deptBindingSource.DataSource = this.dsKhoa;
            // 
            // dsKhoa
            // 
            this.dsKhoa.DataSetName = "dsKhoa";
            this.dsKhoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TRACNGHIEM_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_RegisListTableAdapter
            // 
            this.sP_RegisListTableAdapter.ClearBeforeFill = true;
            // 
            // regisListGridControl
            // 
            this.regisListGridControl.DataSource = this.bdsRegis;
            this.regisListGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.regisListGridControl.Location = new System.Drawing.Point(0, 106);
            this.regisListGridControl.MainView = this.regisListgridView;
            this.regisListGridControl.MenuManager = this.barManager1;
            this.regisListGridControl.Name = "regisListGridControl";
            this.regisListGridControl.Size = new System.Drawing.Size(989, 220);
            this.regisListGridControl.TabIndex = 15;
            this.regisListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.regisListgridView});
            // 
            // regisListgridView
            // 
            this.regisListgridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colMAMH,
            this.colMALOP,
            this.colTRINHDO,
            this.colNGAYTHI,
            this.colLAN,
            this.colSOCAUTHI,
            this.colTHOIGIAN});
            this.regisListgridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.regisListgridView.GridControl = this.regisListGridControl;
            this.regisListgridView.Name = "regisListgridView";
            this.regisListgridView.OptionsBehavior.Editable = false;
            this.regisListgridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.regisListgridView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.regisListgridView_SelectionChanged);
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 2;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 3;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 4;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 5;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 6;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 7;
            // 
            // deptTableAdapter
            // 
            this.deptTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.GIAOVIENTableAdapter = null;
            this.tableAdapterManager1.KHOATableAdapter = this.deptTableAdapter;
            this.tableAdapterManager1.LOPTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = TRACNGHIEM_CSDLPT.dsKhoaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_TeacherListTableAdapter
            // 
            this.sP_TeacherListTableAdapter.ClearBeforeFill = true;
            // 
            // sP_ClassListTableAdapter
            // 
            this.sP_ClassListTableAdapter.ClearBeforeFill = true;
            // 
            // sP_SubjListTableAdapter
            // 
            this.sP_SubjListTableAdapter.ClearBeforeFill = true;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(273, 127);
            this.bar1.FloatSize = new System.Drawing.Size(656, 42);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.addBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.editBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.saveBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.undoBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.redoBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.cancelBtn)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // frmRegisTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 585);
            this.Controls.Add(this.regisInforGroup);
            this.Controls.Add(this.regisListGridControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRegisTest";
            this.Text = "frmRegister";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.regisInforGroup.ResumeLayout(false);
            this.regisInforGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRegis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExamTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumQues.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regisListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regisListgridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem addBtn;
        private DevExpress.XtraBars.BarButtonItem editBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraBars.BarButtonItem saveBtn;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem undoBtn;
        private DevExpress.XtraBars.BarButtonItem redoBtn;
        private DevExpress.XtraBars.BarButtonItem cancelBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.GroupBox regisInforGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbxBranch;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DS DS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsRegis;
        private DSTableAdapters.SP_RegisListTableAdapter sP_RegisListTableAdapter;
        private DevExpress.XtraGrid.GridControl regisListGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView regisListgridView;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private dsKhoa dsKhoa;
        private System.Windows.Forms.BindingSource deptBindingSource;
        private dsKhoaTableAdapters.KHOATableAdapter deptTableAdapter;
        private dsKhoaTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox cbbxDept;
        private DevExpress.XtraEditors.TextEdit txtExamTime;
        private DevExpress.XtraEditors.TextEdit txtNumQues;
        private System.Windows.Forms.ComboBox cbbxTimes;
        private DevExpress.XtraEditors.DateEdit examDateEdit;
        private System.Windows.Forms.ComboBox levelComboBox;
        private System.Windows.Forms.ComboBox cbbxClass;
        private System.Windows.Forms.ComboBox cbbxSubj;
        private System.Windows.Forms.ComboBox teacherIdComboBox;
        private System.Windows.Forms.BindingSource teacherListBindingSource;
        private DSTableAdapters.SP_TeacherListTableAdapter sP_TeacherListTableAdapter;
        private System.Windows.Forms.BindingSource classListBindingSource;
        private DSTableAdapters.SP_ClassListTableAdapter sP_ClassListTableAdapter;
        private System.Windows.Forms.BindingSource subjListBindingSource;
        private DSTableAdapters.SP_SubjListTableAdapter sP_SubjListTableAdapter;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar1;
    }
}