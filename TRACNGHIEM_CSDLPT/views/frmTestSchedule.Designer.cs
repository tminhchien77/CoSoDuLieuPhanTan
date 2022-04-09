namespace TRACNGHIEM_CSDLPT.views
{
    partial class frmTestSchedule
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dS = new TRACNGHIEM_CSDLPT.DS();
            this.sP_TestScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_TestScheduleTableAdapter = new TRACNGHIEM_CSDLPT.DSTableAdapters.SP_TestScheduleTableAdapter();
            this.tableAdapterManager = new TRACNGHIEM_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.sP_TestScheduleGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewTestSchedule = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBtn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnStartExam = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_TestScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_TestScheduleGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTestSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartExam)).BeginInit();
            this.SuspendLayout();
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_TestScheduleBindingSource
            // 
            this.sP_TestScheduleBindingSource.DataMember = "SP_TestSchedule";
            this.sP_TestScheduleBindingSource.DataSource = this.dS;
            // 
            // sP_TestScheduleTableAdapter
            // 
            this.sP_TestScheduleTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TRACNGHIEM_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_TestScheduleGridControl
            // 
            this.sP_TestScheduleGridControl.DataSource = this.sP_TestScheduleBindingSource;
            this.sP_TestScheduleGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_TestScheduleGridControl.Location = new System.Drawing.Point(0, 0);
            this.sP_TestScheduleGridControl.MainView = this.gridViewTestSchedule;
            this.sP_TestScheduleGridControl.Name = "sP_TestScheduleGridControl";
            this.sP_TestScheduleGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnStartExam});
            this.sP_TestScheduleGridControl.Size = new System.Drawing.Size(800, 450);
            this.sP_TestScheduleGridControl.TabIndex = 2;
            this.sP_TestScheduleGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTestSchedule});
            // 
            // gridViewTestSchedule
            // 
            this.gridViewTestSchedule.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colMALOP,
            this.colTENLOP,
            this.colGV,
            this.colTRINHDO,
            this.colLAN,
            this.colNGAYTHI,
            this.colSOCAUTHI,
            this.colTHOIGIAN,
            this.colBtn,
            this.gridColumn1});
            this.gridViewTestSchedule.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewTestSchedule.GridControl = this.sP_TestScheduleGridControl;
            this.gridViewTestSchedule.Name = "gridViewTestSchedule";
            this.gridViewTestSchedule.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.AllowEdit = false;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 2;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.OptionsColumn.AllowEdit = false;
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 3;
            // 
            // colGV
            // 
            this.colGV.FieldName = "GV";
            this.colGV.Name = "colGV";
            this.colGV.OptionsColumn.AllowEdit = false;
            this.colGV.Visible = true;
            this.colGV.VisibleIndex = 4;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.OptionsColumn.AllowEdit = false;
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 5;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.Name = "colLAN";
            this.colLAN.OptionsColumn.AllowEdit = false;
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 6;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.DisplayFormat.FormatString = "\"dd/MM/yyyy HH:mm:ss\"";
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.OptionsColumn.AllowEdit = false;
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 7;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.OptionsColumn.AllowEdit = false;
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 8;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.OptionsColumn.AllowEdit = false;
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 9;
            // 
            // colBtn
            // 
            this.colBtn.ColumnEdit = this.btnStartExam;
            this.colBtn.FieldName = "BTN";
            this.colBtn.Name = "colBtn";
            this.colBtn.Visible = true;
            this.colBtn.VisibleIndex = 10;
            // 
            // btnStartExam
            // 
            this.btnStartExam.AutoHeight = false;
            serializableAppearanceObject1.BackColor = System.Drawing.Color.IndianRed;
            serializableAppearanceObject1.BackColor2 = System.Drawing.Color.RosyBrown;
            serializableAppearanceObject1.Options.UseBackColor = true;
            serializableAppearanceObject1.Options.UseTextOptions = true;
            this.btnStartExam.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Vào thi", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnStartExam.Name = "btnStartExam";
            this.btnStartExam.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnStartExam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnStartExam_ButtonClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 11;
            // 
            // frmTestSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sP_TestScheduleGridControl);
            this.Name = "frmTestSchedule";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTestSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_TestScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_TestScheduleGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTestSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartExam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource sP_TestScheduleBindingSource;
        private DSTableAdapters.SP_TestScheduleTableAdapter sP_TestScheduleTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_TestScheduleGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTestSchedule;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colGV;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private DevExpress.XtraGrid.Columns.GridColumn colBtn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnStartExam;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}