
namespace TRACNGHIEM_CSDLPT.views
{
    partial class frmQuestion
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
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label cAUHOILabel;
            System.Windows.Forms.Label nOIDUNGLabel;
            System.Windows.Forms.Label aLabel;
            System.Windows.Forms.Label bLabel;
            System.Windows.Forms.Label cLabel;
            System.Windows.Forms.Label dLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label dAP_ANLabel;
            System.Windows.Forms.Label lbl1;
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
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbxSubj = new System.Windows.Forms.ComboBox();
            this.bdsSubj = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new TRACNGHIEM_CSDLPT.DS();
            this.tableAdapterSubj = new TRACNGHIEM_CSDLPT.DSTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TRACNGHIEM_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.bdsQues = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterQues = new TRACNGHIEM_CSDLPT.DSTableAdapters.SP_QuestionTableTableAdapter();
            this.gcQues = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTeacherId = new System.Windows.Forms.Label();
            this.cbbxResult = new System.Windows.Forms.ComboBox();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.cbbxLevel = new System.Windows.Forms.ComboBox();
            this.txtD = new System.Windows.Forms.RichTextBox();
            this.txtC = new System.Windows.Forms.RichTextBox();
            this.txtB = new System.Windows.Forms.RichTextBox();
            this.txtA = new System.Windows.Forms.RichTextBox();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.txtQuesId = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            cAUHOILabel = new System.Windows.Forms.Label();
            nOIDUNGLabel = new System.Windows.Forms.Label();
            aLabel = new System.Windows.Forms.Label();
            bLabel = new System.Windows.Forms.Label();
            cLabel = new System.Windows.Forms.Label();
            dLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            dAP_ANLabel = new System.Windows.Forms.Label();
            lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSubj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsQues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcQues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuesId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(25, 18);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(45, 13);
            tENMHLabel.TabIndex = 0;
            tENMHLabel.Text = "TENMH:";
            // 
            // cAUHOILabel
            // 
            cAUHOILabel.AutoSize = true;
            cAUHOILabel.Location = new System.Drawing.Point(66, 60);
            cAUHOILabel.Name = "cAUHOILabel";
            cAUHOILabel.Size = new System.Drawing.Size(63, 13);
            cAUHOILabel.TabIndex = 2;
            cAUHOILabel.Text = "Mã câu hỏi:";
            // 
            // nOIDUNGLabel
            // 
            nOIDUNGLabel.AutoSize = true;
            nOIDUNGLabel.Location = new System.Drawing.Point(69, 102);
            nOIDUNGLabel.Name = "nOIDUNGLabel";
            nOIDUNGLabel.Size = new System.Drawing.Size(53, 13);
            nOIDUNGLabel.TabIndex = 3;
            nOIDUNGLabel.Text = "Nội dung:";
            // 
            // aLabel
            // 
            aLabel.AutoSize = true;
            aLabel.Location = new System.Drawing.Point(102, 174);
            aLabel.Name = "aLabel";
            aLabel.Size = new System.Drawing.Size(17, 13);
            aLabel.TabIndex = 5;
            aLabel.Text = "A:";
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.Location = new System.Drawing.Point(467, 177);
            bLabel.Name = "bLabel";
            bLabel.Size = new System.Drawing.Size(17, 13);
            bLabel.TabIndex = 7;
            bLabel.Text = "B:";
            // 
            // cLabel
            // 
            cLabel.AutoSize = true;
            cLabel.Location = new System.Drawing.Point(102, 226);
            cLabel.Name = "cLabel";
            cLabel.Size = new System.Drawing.Size(17, 13);
            cLabel.TabIndex = 9;
            cLabel.Text = "C:";
            // 
            // dLabel
            // 
            dLabel.AutoSize = true;
            dLabel.Location = new System.Drawing.Point(467, 226);
            dLabel.Name = "dLabel";
            dLabel.Size = new System.Drawing.Size(18, 13);
            dLabel.TabIndex = 11;
            dLabel.Text = "D:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(69, 276);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(50, 13);
            tRINHDOLabel.TabIndex = 13;
            tRINHDOLabel.Text = "Trình độ:";
            // 
            // dAP_ANLabel
            // 
            dAP_ANLabel.AutoSize = true;
            dAP_ANLabel.Location = new System.Drawing.Point(434, 276);
            dAP_ANLabel.Name = "dAP_ANLabel";
            dAP_ANLabel.Size = new System.Drawing.Size(45, 13);
            dAP_ANLabel.TabIndex = 17;
            dAP_ANLabel.Text = "Đáp án:";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new System.Drawing.Point(299, 60);
            lbl1.Name = "lbl1";
            lbl1.Size = new System.Drawing.Size(95, 13);
            lbl1.TabIndex = 19;
            lbl1.Text = "Giảng viên tạo đề:";
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlTop.Size = new System.Drawing.Size(1096, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 749);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlBottom.Size = new System.Drawing.Size(1096, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 709);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1096, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 709);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(tENMHLabel);
            this.panelControl1.Controls.Add(this.cbbxSubj);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 40);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1096, 46);
            this.panelControl1.TabIndex = 11;
            // 
            // cbbxSubj
            // 
            this.cbbxSubj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSubj, "TENMH", true));
            this.cbbxSubj.DataSource = this.bdsSubj;
            this.cbbxSubj.DisplayMember = "TENMH";
            this.cbbxSubj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxSubj.FormattingEnabled = true;
            this.cbbxSubj.Location = new System.Drawing.Point(76, 15);
            this.cbbxSubj.Name = "cbbxSubj";
            this.cbbxSubj.Size = new System.Drawing.Size(121, 21);
            this.cbbxSubj.TabIndex = 1;
            this.cbbxSubj.ValueMember = "MAMH";
            this.cbbxSubj.SelectedValueChanged += new System.EventHandler(this.tENMHComboBox_SelectedValueChanged);
            // 
            // bdsSubj
            // 
            this.bdsSubj.DataMember = "MONHOC";
            this.bdsSubj.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterSubj
            // 
            this.tableAdapterSubj.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.tableAdapterSubj;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TRACNGHIEM_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsQues
            // 
            this.bdsQues.DataMember = "SP_QuestionTable";
            this.bdsQues.DataSource = this.dS;
            // 
            // tableAdapterQues
            // 
            this.tableAdapterQues.ClearBeforeFill = true;
            // 
            // gcQues
            // 
            this.gcQues.DataSource = this.bdsQues;
            this.gcQues.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcQues.Location = new System.Drawing.Point(0, 86);
            this.gcQues.MainView = this.gridView1;
            this.gcQues.MenuManager = this.barManager1;
            this.gcQues.Name = "gcQues";
            this.gcQues.Size = new System.Drawing.Size(1096, 220);
            this.gcQues.TabIndex = 16;
            this.gcQues.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcQues;
            this.gridView1.Name = "gridView1";
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.label2);
            this.groupInfo.Controls.Add(lbl1);
            this.groupInfo.Controls.Add(this.lblTeacherId);
            this.groupInfo.Controls.Add(dAP_ANLabel);
            this.groupInfo.Controls.Add(this.cbbxResult);
            this.groupInfo.Controls.Add(this.lblTeacherName);
            this.groupInfo.Controls.Add(tRINHDOLabel);
            this.groupInfo.Controls.Add(this.cbbxLevel);
            this.groupInfo.Controls.Add(dLabel);
            this.groupInfo.Controls.Add(this.txtD);
            this.groupInfo.Controls.Add(cLabel);
            this.groupInfo.Controls.Add(this.txtC);
            this.groupInfo.Controls.Add(bLabel);
            this.groupInfo.Controls.Add(this.txtB);
            this.groupInfo.Controls.Add(aLabel);
            this.groupInfo.Controls.Add(this.txtA);
            this.groupInfo.Controls.Add(nOIDUNGLabel);
            this.groupInfo.Controls.Add(this.txtContent);
            this.groupInfo.Controls.Add(cAUHOILabel);
            this.groupInfo.Controls.Add(this.txtQuesId);
            this.groupInfo.Controls.Add(this.label1);
            this.groupInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupInfo.Enabled = false;
            this.groupInfo.Location = new System.Drawing.Point(0, 306);
            this.groupInfo.Margin = new System.Windows.Forms.Padding(2);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Padding = new System.Windows.Forms.Padding(2);
            this.groupInfo.Size = new System.Drawing.Size(1096, 443);
            this.groupInfo.TabIndex = 17;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "-";
            // 
            // lblTeacherId
            // 
            this.lblTeacherId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsQues, "MAGV", true));
            this.lblTeacherId.Location = new System.Drawing.Point(417, 60);
            this.lblTeacherId.Name = "lblTeacherId";
            this.lblTeacherId.Size = new System.Drawing.Size(100, 23);
            this.lblTeacherId.TabIndex = 20;
            this.lblTeacherId.Text = "label2";
            // 
            // cbbxResult
            // 
            this.cbbxResult.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsQues, "DAP_AN", true));
            this.cbbxResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxResult.FormattingEnabled = true;
            this.cbbxResult.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbbxResult.Location = new System.Drawing.Point(507, 273);
            this.cbbxResult.Name = "cbbxResult";
            this.cbbxResult.Size = new System.Drawing.Size(121, 21);
            this.cbbxResult.TabIndex = 18;
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsQues, "TENGV", true));
            this.lblTeacherName.Location = new System.Drawing.Point(528, 60);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(100, 23);
            this.lblTeacherName.TabIndex = 16;
            this.lblTeacherName.Text = "label2";
            // 
            // cbbxLevel
            // 
            this.cbbxLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsQues, "TRINHDO", true));
            this.cbbxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxLevel.FormattingEnabled = true;
            this.cbbxLevel.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbbxLevel.Location = new System.Drawing.Point(144, 273);
            this.cbbxLevel.Name = "cbbxLevel";
            this.cbbxLevel.Size = new System.Drawing.Size(121, 21);
            this.cbbxLevel.TabIndex = 14;
            // 
            // txtD
            // 
            this.txtD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsQues, "D", true));
            this.txtD.Location = new System.Drawing.Point(507, 225);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(229, 25);
            this.txtD.TabIndex = 12;
            this.txtD.Text = "";
            // 
            // txtC
            // 
            this.txtC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsQues, "C", true));
            this.txtC.Location = new System.Drawing.Point(144, 226);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(235, 24);
            this.txtC.TabIndex = 10;
            this.txtC.Text = "";
            // 
            // txtB
            // 
            this.txtB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsQues, "B", true));
            this.txtB.Location = new System.Drawing.Point(507, 174);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(229, 29);
            this.txtB.TabIndex = 8;
            this.txtB.Text = "";
            // 
            // txtA
            // 
            this.txtA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsQues, "A", true));
            this.txtA.Location = new System.Drawing.Point(144, 171);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(235, 28);
            this.txtA.TabIndex = 6;
            this.txtA.Text = "";
            this.txtA.Enter += new System.EventHandler(this.txtA_Enter);
            // 
            // txtContent
            // 
            this.txtContent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsQues, "NOIDUNG", true));
            this.txtContent.Location = new System.Drawing.Point(144, 99);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(592, 59);
            this.txtContent.TabIndex = 4;
            this.txtContent.Text = "";
            // 
            // txtQuesId
            // 
            this.txtQuesId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsQues, "CAUHOI", true));
            this.txtQuesId.Location = new System.Drawing.Point(144, 58);
            this.txtQuesId.MenuManager = this.barManager1;
            this.txtQuesId.Name = "txtQuesId";
            this.txtQuesId.Size = new System.Drawing.Size(100, 20);
            this.txtQuesId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÔNG TIN CÂU HỎI";
            // 
            // frmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1096, 749);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.gcQues);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuestion";
            this.Text = "frmQuestion";
            this.Load += new System.EventHandler(this.frmQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSubj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsQues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcQues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuesId.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource bdsSubj;
        private DS dS;
        private DSTableAdapters.MONHOCTableAdapter tableAdapterSubj;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbbxSubj;
        private System.Windows.Forms.BindingSource bdsQues;
        private DSTableAdapters.SP_QuestionTableTableAdapter tableAdapterQues;
        private DevExpress.XtraGrid.GridControl gcQues;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.RichTextBox txtD;
        private System.Windows.Forms.RichTextBox txtC;
        private System.Windows.Forms.RichTextBox txtB;
        private System.Windows.Forms.RichTextBox txtA;
        private System.Windows.Forms.RichTextBox txtContent;
        private DevExpress.XtraEditors.TextEdit txtQuesId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbxLevel;
        private System.Windows.Forms.ComboBox cbbxResult;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label lblTeacherId;
        private System.Windows.Forms.Label label2;
    }
}