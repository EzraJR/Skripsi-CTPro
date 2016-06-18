namespace frm_select.view
{
    partial class Import_Data
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import_Data));
            this.teFile = new DevExpress.XtraEditors.TextEdit();
            this.btnCari = new DevExpress.XtraEditors.SimpleButton();
            this.gvDT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcDT = new DevExpress.XtraGrid.GridControl();
            this.btnSimpan = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.teFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDT)).BeginInit();
            this.SuspendLayout();
            // 
            // teFile
            // 
            this.teFile.Location = new System.Drawing.Point(94, 59);
            this.teFile.Name = "teFile";
            this.teFile.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.teFile.Properties.Appearance.Options.UseFont = true;
            this.teFile.Size = new System.Drawing.Size(572, 20);
            this.teFile.TabIndex = 11;
            // 
            // btnCari
            // 
            this.btnCari.Image = ((System.Drawing.Image)(resources.GetObject("btnCari.Image")));
            this.btnCari.Location = new System.Drawing.Point(672, 57);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(157, 24);
            this.btnCari.TabIndex = 10;
            this.btnCari.Text = "Browse";
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // gvDT
            // 
            this.gvDT.GridControl = this.gcDT;
            this.gvDT.Name = "gvDT";
            // 
            // gcDT
            // 
            this.gcDT.Location = new System.Drawing.Point(26, 87);
            this.gcDT.MainView = this.gvDT;
            this.gcDT.Name = "gcDT";
            this.gcDT.Size = new System.Drawing.Size(803, 300);
            this.gcDT.TabIndex = 8;
            this.gcDT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDT});
            // 
            // btnSimpan
            // 
            this.btnSimpan.Image = ((System.Drawing.Image)(resources.GetObject("btnSimpan.Image")));
            this.btnSimpan.Location = new System.Drawing.Point(26, 393);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(173, 24);
            this.btnSimpan.TabIndex = 9;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(26, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = ":: Import Data";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Direktori File";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(388, 393);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(441, 22);
            this.progressBar1.TabIndex = 13;
            // 
            // Import_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.teFile);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.gcDT);
            this.Name = "Import_Data";
            this.Size = new System.Drawing.Size(1070, 509);
            this.Load += new System.EventHandler(this.Import_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teFile;
        private DevExpress.XtraEditors.SimpleButton btnCari;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDT;
        private DevExpress.XtraGrid.GridControl gcDT;
        private DevExpress.XtraEditors.SimpleButton btnSimpan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
