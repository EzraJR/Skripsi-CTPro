namespace frm_select.view
{
    partial class form_asosiasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_asosiasi));
            this.teConfidence = new DevExpress.XtraEditors.TextEdit();
            this.btnProses = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gvAsosiasi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcAsosiasi = new DevExpress.XtraGrid.GridControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.teRules = new System.Windows.Forms.RichTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.teSupport = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.teConfidence.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAsosiasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAsosiasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teSupport.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // teConfidence
            // 
            this.teConfidence.Location = new System.Drawing.Point(430, 101);
            this.teConfidence.Name = "teConfidence";
            this.teConfidence.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.teConfidence.Properties.Appearance.Options.UseFont = true;
            this.teConfidence.Size = new System.Drawing.Size(110, 20);
            this.teConfidence.TabIndex = 11;
            // 
            // btnProses
            // 
            this.btnProses.Image = ((System.Drawing.Image)(resources.GetObject("btnProses.Image")));
            this.btnProses.Location = new System.Drawing.Point(430, 127);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(97, 25);
            this.btnProses.TabIndex = 9;
            this.btnProses.Text = "Asosiasi";
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(29, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = ":: Proses Asosiasi Data";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(320, 105);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Minimum Confidence";
            // 
            // gvAsosiasi
            // 
            this.gvAsosiasi.GridControl = this.gcAsosiasi;
            this.gvAsosiasi.Name = "gvAsosiasi";
            // 
            // gcAsosiasi
            // 
            this.gcAsosiasi.Location = new System.Drawing.Point(29, 171);
            this.gcAsosiasi.MainView = this.gvAsosiasi;
            this.gcAsosiasi.Name = "gcAsosiasi";
            this.gcAsosiasi.Size = new System.Drawing.Size(388, 234);
            this.gcAsosiasi.TabIndex = 8;
            this.gcAsosiasi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAsosiasi});
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(546, 105);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(11, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "%";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.teRules);
            this.groupControl1.Location = new System.Drawing.Point(444, 171);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(382, 234);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Rules";
            // 
            // teRules
            // 
            this.teRules.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.teRules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teRules.Location = new System.Drawing.Point(2, 21);
            this.teRules.Name = "teRules";
            this.teRules.ReadOnly = true;
            this.teRules.Size = new System.Drawing.Size(378, 211);
            this.teRules.TabIndex = 0;
            this.teRules.Text = "";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(320, 79);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Minimum Support";
            // 
            // teSupport
            // 
            this.teSupport.Location = new System.Drawing.Point(430, 75);
            this.teSupport.Name = "teSupport";
            this.teSupport.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.teSupport.Properties.Appearance.Options.UseFont = true;
            this.teSupport.Size = new System.Drawing.Size(127, 20);
            this.teSupport.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(397, 46);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(79, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Input Parameter";
            // 
            // form_asosiasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.teSupport);
            this.Controls.Add(this.teConfidence);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.gcAsosiasi);
            this.Name = "form_asosiasi";
            this.Size = new System.Drawing.Size(1070, 626);
            this.Load += new System.EventHandler(this.form_asosiasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teConfidence.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAsosiasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAsosiasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teSupport.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teConfidence;
        private DevExpress.XtraEditors.SimpleButton btnProses;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAsosiasi;
        private DevExpress.XtraGrid.GridControl gcAsosiasi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RichTextBox teRules;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit teSupport;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}
