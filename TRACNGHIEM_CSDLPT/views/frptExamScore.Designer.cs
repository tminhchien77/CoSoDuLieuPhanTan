namespace TRACNGHIEM_CSDLPT.views
{
    partial class frptExamScore
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
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label tENMHLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbxBranch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dS = new TRACNGHIEM_CSDLPT.DS();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new TRACNGHIEM_CSDLPT.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new TRACNGHIEM_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.cbbxClass = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new TRACNGHIEM_CSDLPT.DSTableAdapters.MONHOCTableAdapter();
            this.cbbxSubj = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbxTimes = new System.Windows.Forms.ComboBox();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            tENLOPLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPreview);
            this.panelControl1.Controls.Add(this.cbbxTimes);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(tENMHLabel);
            this.panelControl1.Controls.Add(this.cbbxSubj);
            this.panelControl1.Controls.Add(tENLOPLabel);
            this.panelControl1.Controls.Add(this.cbbxClass);
            this.panelControl1.Controls.Add(this.cbbxBranch);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(987, 450);
            this.panelControl1.TabIndex = 0;
            // 
            // cbbxBranch
            // 
            this.cbbxBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxBranch.Enabled = false;
            this.cbbxBranch.FormattingEnabled = true;
            this.cbbxBranch.Location = new System.Drawing.Point(79, 22);
            this.cbbxBranch.Margin = new System.Windows.Forms.Padding(2);
            this.cbbxBranch.Name = "cbbxBranch";
            this.cbbxBranch.Size = new System.Drawing.Size(237, 21);
            this.cbbxBranch.TabIndex = 8;
            this.cbbxBranch.SelectedIndexChanged += new System.EventHandler(this.cbbxBranch_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cơ sở:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TRACNGHIEM_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(24, 76);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(49, 13);
            tENLOPLabel.TabIndex = 8;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // cbbxClass
            // 
            this.cbbxClass.DataSource = this.lOPBindingSource;
            this.cbbxClass.DisplayMember = "TENLOP";
            this.cbbxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxClass.FormattingEnabled = true;
            this.cbbxClass.Location = new System.Drawing.Point(79, 73);
            this.cbbxClass.Name = "cbbxClass";
            this.cbbxClass.Size = new System.Drawing.Size(197, 21);
            this.cbbxClass.TabIndex = 9;
            this.cbbxClass.ValueMember = "MALOP";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(346, 76);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(45, 13);
            tENMHLabel.TabIndex = 9;
            tENMHLabel.Text = "TENMH:";
            // 
            // cbbxSubj
            // 
            this.cbbxSubj.DataSource = this.mONHOCBindingSource;
            this.cbbxSubj.DisplayMember = "TENMH";
            this.cbbxSubj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxSubj.FormattingEnabled = true;
            this.cbbxSubj.Location = new System.Drawing.Point(397, 73);
            this.cbbxSubj.Name = "cbbxSubj";
            this.cbbxSubj.Size = new System.Drawing.Size(157, 21);
            this.cbbxSubj.TabIndex = 10;
            this.cbbxSubj.ValueMember = "MAMH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lần thi:";
            // 
            // cbbxTimes
            // 
            this.cbbxTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxTimes.FormattingEnabled = true;
            this.cbbxTimes.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbxTimes.Location = new System.Drawing.Point(653, 73);
            this.cbbxTimes.Name = "cbbxTimes";
            this.cbbxTimes.Size = new System.Drawing.Size(121, 21);
            this.cbbxTimes.TabIndex = 12;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(828, 70);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 13;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // frptExamScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.panelControl1);
            this.Name = "frptExamScore";
            this.Text = "frptExamScore";
            this.Load += new System.EventHandler(this.frptExamScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbxBranch;
        private System.Windows.Forms.Label label2;
        private DS dS;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbbxClass;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private System.Windows.Forms.ComboBox cbbxTimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbxSubj;
    }
}