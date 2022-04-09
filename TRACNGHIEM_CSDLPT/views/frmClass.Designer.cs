
namespace TRACNGHIEM_CSDLPT.views
{
    partial class frmClass
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label tENKHLabel;
            this.barManager3 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar8 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedo = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbxDept = new System.Windows.Forms.ComboBox();
            this.bdsDept = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new TRACNGHIEM_CSDLPT.DS();
            this.cbbxBranch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bdsClass = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterClass = new TRACNGHIEM_CSDLPT.DSTableAdapters.SP_ClassTableTableAdapter();
            this.tableAdapterManager = new TRACNGHIEM_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.gcClass = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupInfor = new System.Windows.Forms.GroupBox();
            this.txtClass = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterDept = new TRACNGHIEM_CSDLPT.DSTableAdapters.KHOATableAdapter();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(87, 79);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(47, 13);
            mALOPLabel.TabIndex = 2;
            mALOPLabel.Text = "MALOP:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(426, 84);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(53, 13);
            tENLOPLabel.TabIndex = 3;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(524, 20);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(43, 13);
            tENKHLabel.TabIndex = 4;
            tENKHLabel.Text = "TENKH:";
            // 
            // barManager3
            // 
            this.barManager3.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar8});
            this.barManager3.DockControls.Add(this.barDockControl5);
            this.barManager3.DockControls.Add(this.barDockControl6);
            this.barManager3.DockControls.Add(this.barDockControl8);
            this.barManager3.DockControls.Add(this.barDockControlRight);
            this.barManager3.Form = this;
            this.barManager3.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.btnSave,
            this.btnRefresh,
            this.btnUndo,
            this.btnRedo,
            this.btnCancel});
            this.barManager3.MainMenu = this.bar8;
            this.barManager3.MaxItemId = 8;
            // 
            // bar8
            // 
            this.bar8.BarName = "Main menu";
            this.bar8.DockCol = 0;
            this.bar8.DockRow = 0;
            this.bar8.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar8.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRedo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancel)});
            this.bar8.OptionsBar.MultiLine = true;
            this.bar8.OptionsBar.UseWholeRow = true;
            this.bar8.Text = "Main menu";
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
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl5.Location = new System.Drawing.Point(0, 0);
            this.barDockControl5.Manager = this.barManager3;
            this.barDockControl5.Size = new System.Drawing.Size(994, 40);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl6.Location = new System.Drawing.Point(0, 529);
            this.barDockControl6.Manager = this.barManager3;
            this.barDockControl6.Size = new System.Drawing.Size(994, 0);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl8.Location = new System.Drawing.Point(0, 40);
            this.barDockControl8.Manager = this.barManager3;
            this.barDockControl8.Size = new System.Drawing.Size(0, 489);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(994, 40);
            this.barDockControlRight.Manager = this.barManager3;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 489);
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
            this.panelControl1.Size = new System.Drawing.Size(994, 51);
            this.panelControl1.TabIndex = 12;
            // 
            // cbbxDept
            // 
            this.cbbxDept.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDept, "TENKH", true));
            this.cbbxDept.DataSource = this.bdsDept;
            this.cbbxDept.DisplayMember = "TENKH";
            this.cbbxDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxDept.FormattingEnabled = true;
            this.cbbxDept.Location = new System.Drawing.Point(573, 17);
            this.cbbxDept.Name = "cbbxDept";
            this.cbbxDept.Size = new System.Drawing.Size(121, 21);
            this.cbbxDept.TabIndex = 5;
            this.cbbxDept.ValueMember = "MAKH";
            this.cbbxDept.SelectedValueChanged += new System.EventHandler(this.cbbxDept_SelectedValueChanged_1);
            // 
            // bdsDept
            // 
            this.bdsDept.DataMember = "KHOA";
            this.bdsDept.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // bdsClass
            // 
            this.bdsClass.DataMember = "SP_ClassTable";
            this.bdsClass.DataSource = this.dS;
            // 
            // tableAdapterClass
            // 
            this.tableAdapterClass.ClearBeforeFill = true;
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
            // gcClass
            // 
            this.gcClass.DataSource = this.bdsClass;
            this.gcClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcClass.Location = new System.Drawing.Point(0, 91);
            this.gcClass.MainView = this.gridView1;
            this.gcClass.MenuManager = this.barManager3;
            this.gcClass.Name = "gcClass";
            this.gcClass.Size = new System.Drawing.Size(994, 290);
            this.gcClass.TabIndex = 18;
            this.gcClass.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP});
            this.gridView1.GridControl = this.gcClass;
            this.gridView1.Name = "gridView1";
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            // 
            // groupInfor
            // 
            this.groupInfor.Controls.Add(tENLOPLabel);
            this.groupInfor.Controls.Add(this.txtClass);
            this.groupInfor.Controls.Add(mALOPLabel);
            this.groupInfor.Controls.Add(this.txtId);
            this.groupInfor.Controls.Add(this.label1);
            this.groupInfor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupInfor.Enabled = false;
            this.groupInfor.Location = new System.Drawing.Point(0, 381);
            this.groupInfor.Margin = new System.Windows.Forms.Padding(2);
            this.groupInfor.Name = "groupInfor";
            this.groupInfor.Padding = new System.Windows.Forms.Padding(2);
            this.groupInfor.Size = new System.Drawing.Size(994, 148);
            this.groupInfor.TabIndex = 22;
            this.groupInfor.TabStop = false;
            this.groupInfor.Text = "Thông tin";
            // 
            // txtClass
            // 
            this.txtClass.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsClass, "TENLOP", true));
            this.txtClass.Location = new System.Drawing.Point(485, 81);
            this.txtClass.MenuManager = this.barManager3;
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 20);
            this.txtClass.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsClass, "MALOP", true));
            this.txtId.Location = new System.Drawing.Point(140, 76);
            this.txtId.MenuManager = this.barManager3;
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
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÔNG TIN LỚP";
            // 
            // tableAdapterDept
            // 
            this.tableAdapterDept.ClearBeforeFill = true;
            // 
            // frmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 529);
            this.Controls.Add(this.groupInfor);
            this.Controls.Add(this.gcClass);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmClass";
            this.Text = "frmClass";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupInfor.ResumeLayout(false);
            this.groupInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager3;
        private DevExpress.XtraBars.Bar bar8;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnRedo;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarDockControl barDockControl11;
        private DevExpress.XtraBars.BarDockControl barDockControl9;
        private DevExpress.XtraBars.BarDockControl barDockControl10;
        private DevExpress.XtraBars.BarDockControl barDockControl12;
        private DevExpress.XtraBars.BarDockControl barDockControl15;
        private DevExpress.XtraBars.BarDockControl barDockControl13;
        private DevExpress.XtraBars.BarDockControl barDockControl14;
        private DevExpress.XtraBars.BarDockControl barDockControl16;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbxBranch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bdsClass;
        private DS dS;
        private DSTableAdapters.SP_ClassTableTableAdapter tableAdapterClass;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcClass;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupInfor;
        private DevExpress.XtraEditors.TextEdit txtClass;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsDept;
        private DSTableAdapters.KHOATableAdapter tableAdapterDept;
        private System.Windows.Forms.ComboBox cbbxDept;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
    }
}