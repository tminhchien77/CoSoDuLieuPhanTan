namespace TRACNGHIEM_CSDLPT.views
{
    partial class frmTeacherPermission
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbxDept = new System.Windows.Forms.ComboBox();
            this.bdsDept = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new TRACNGHIEM_CSDLPT.DS();
            this.cbbxBranch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bdsTeacherPermission = new System.Windows.Forms.BindingSource(this.components);
            this.sP_TeacherPermissionListTableAdapter = new TRACNGHIEM_CSDLPT.DSTableAdapters.SP_TeacherPermissionListTableAdapter();
            this.tableAdapterManager = new TRACNGHIEM_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.grControlTeacherPermission = new DevExpress.XtraGrid.GridControl();
            this.grvTeacherPermission = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPermission = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tblAdapterDept = new TRACNGHIEM_CSDLPT.DSTableAdapters.KHOATableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeacherPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grControlTeacherPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTeacherPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPermission)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbxDept);
            this.panel1.Controls.Add(this.cbbxBranch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 100);
            this.panel1.TabIndex = 0;
            // 
            // cbbxDept
            // 
            this.cbbxDept.DataSource = this.bdsDept;
            this.cbbxDept.DisplayMember = "TENKH";
            this.cbbxDept.FormattingEnabled = true;
            this.cbbxDept.Location = new System.Drawing.Point(668, 48);
            this.cbbxDept.Name = "cbbxDept";
            this.cbbxDept.Size = new System.Drawing.Size(300, 21);
            this.cbbxDept.TabIndex = 8;
            this.cbbxDept.ValueMember = "MAKH";
            this.cbbxDept.SelectedValueChanged += new System.EventHandler(this.cbbxDept_SelectedValueChanged);
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
            this.cbbxBranch.Enabled = false;
            this.cbbxBranch.FormattingEnabled = true;
            this.cbbxBranch.Location = new System.Drawing.Point(67, 36);
            this.cbbxBranch.Margin = new System.Windows.Forms.Padding(2);
            this.cbbxBranch.Name = "cbbxBranch";
            this.cbbxBranch.Size = new System.Drawing.Size(237, 21);
            this.cbbxBranch.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cơ sở:";
            // 
            // bdsTeacherPermission
            // 
            this.bdsTeacherPermission.DataMember = "SP_TeacherPermissionList";
            this.bdsTeacherPermission.DataSource = this.dS;
            // 
            // sP_TeacherPermissionListTableAdapter
            // 
            this.sP_TeacherPermissionListTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TRACNGHIEM_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // grControlTeacherPermission
            // 
            this.grControlTeacherPermission.DataSource = this.bdsTeacherPermission;
            this.grControlTeacherPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grControlTeacherPermission.Location = new System.Drawing.Point(0, 100);
            this.grControlTeacherPermission.MainView = this.grvTeacherPermission;
            this.grControlTeacherPermission.Name = "grControlTeacherPermission";
            this.grControlTeacherPermission.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnPermission});
            this.grControlTeacherPermission.Size = new System.Drawing.Size(988, 350);
            this.grControlTeacherPermission.TabIndex = 3;
            this.grControlTeacherPermission.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTeacherPermission});
            // 
            // grvTeacherPermission
            // 
            this.grvTeacherPermission.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colQUYEN});
            this.grvTeacherPermission.GridControl = this.grControlTeacherPermission;
            this.grvTeacherPermission.Name = "grvTeacherPermission";
            this.grvTeacherPermission.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.grvTeacherPermission_CustomRowCellEdit);
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
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
            // colQUYEN
            // 
            this.colQUYEN.FieldName = "QUYEN";
            this.colQUYEN.Name = "colQUYEN";
            this.colQUYEN.Visible = true;
            this.colQUYEN.VisibleIndex = 3;
            // 
            // btnPermission
            // 
            this.btnPermission.AutoHeight = false;
            this.btnPermission.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Cấp quyền", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnPermission.Name = "btnPermission";
            this.btnPermission.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnPermission.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnPermission_ButtonClick);
            // 
            // tblAdapterDept
            // 
            this.tblAdapterDept.ClearBeforeFill = true;
            // 
            // frmTeacherPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.grControlTeacherPermission);
            this.Controls.Add(this.panel1);
            this.Name = "frmTeacherPermission";
            this.Text = "frmTeacherPermission";
            this.Load += new System.EventHandler(this.frmTeacherPermission_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeacherPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grControlTeacherPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTeacherPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPermission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsTeacherPermission;
        private DSTableAdapters.SP_TeacherPermissionListTableAdapter sP_TeacherPermissionListTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl grControlTeacherPermission;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTeacherPermission;
        private System.Windows.Forms.ComboBox cbbxBranch;
        private System.Windows.Forms.Label label2;
        private DSTableAdapters.KHOATableAdapter tblAdapterDept;
        private System.Windows.Forms.ComboBox cbbxDept;
        private System.Windows.Forms.BindingSource bdsDept;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnPermission;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colQUYEN;
    }
}