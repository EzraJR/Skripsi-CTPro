namespace frm_select.view
{
    partial class Preprocessing_Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preprocessing_Data));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnCleaning = new DevExpress.XtraEditors.SimpleButton();
            this.gcCleaning = new DevExpress.XtraGrid.GridControl();
            this.gvCleaning = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAtribut = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnFrequency = new DevExpress.XtraEditors.SimpleButton();
            this.gcFreequency = new DevExpress.XtraGrid.GridControl();
            this.gvFreequency = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcAtribut = new DevExpress.XtraGrid.GridControl();
            this.gvAtribut = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCleaning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCleaning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFreequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFreequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAtribut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAtribut)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(29, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(119, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = ":: Preprocessing Data";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnCleaning);
            this.groupControl3.Controls.Add(this.gcCleaning);
            this.groupControl3.Location = new System.Drawing.Point(269, 49);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(225, 340);
            this.groupControl3.TabIndex = 15;
            this.groupControl3.Text = "Pembersihan Data";
            // 
            // btnCleaning
            // 
            this.btnCleaning.Image = ((System.Drawing.Image)(resources.GetObject("btnCleaning.Image")));
            this.btnCleaning.Location = new System.Drawing.Point(50, 25);
            this.btnCleaning.Name = "btnCleaning";
            this.btnCleaning.Size = new System.Drawing.Size(119, 23);
            this.btnCleaning.TabIndex = 1;
            this.btnCleaning.Text = "Cleanning";
            this.btnCleaning.Click += new System.EventHandler(this.btnCleaning_Click);
            // 
            // gcCleaning
            // 
            this.gcCleaning.Location = new System.Drawing.Point(5, 53);
            this.gcCleaning.MainView = this.gvCleaning;
            this.gcCleaning.Name = "gcCleaning";
            this.gcCleaning.Size = new System.Drawing.Size(215, 282);
            this.gcCleaning.TabIndex = 0;
            this.gcCleaning.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCleaning,
            this.gridView1});
            // 
            // gvCleaning
            // 
            this.gvCleaning.GridControl = this.gcCleaning;
            this.gvCleaning.Name = "gvCleaning";
            this.gvCleaning.OptionsView.ShowGroupPanel = false;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcCleaning;
            this.gridView1.Name = "gridView1";
            // 
            // btnAtribut
            // 
            this.btnAtribut.Image = ((System.Drawing.Image)(resources.GetObject("btnAtribut.Image")));
            this.btnAtribut.Location = new System.Drawing.Point(50, 25);
            this.btnAtribut.Name = "btnAtribut";
            this.btnAtribut.Size = new System.Drawing.Size(119, 23);
            this.btnAtribut.TabIndex = 1;
            this.btnAtribut.Text = "Seleksi Atribut";
            this.btnAtribut.Click += new System.EventHandler(this.btnAtribut_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnFrequency);
            this.groupControl2.Controls.Add(this.gcFreequency);
            this.groupControl2.Location = new System.Drawing.Point(500, 49);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(242, 340);
            this.groupControl2.TabIndex = 16;
            this.groupControl2.Text = "Hitung Frekuensi Kemunculan";
            // 
            // btnFrequency
            // 
            this.btnFrequency.Image = ((System.Drawing.Image)(resources.GetObject("btnFrequency.Image")));
            this.btnFrequency.Location = new System.Drawing.Point(57, 25);
            this.btnFrequency.Name = "btnFrequency";
            this.btnFrequency.Size = new System.Drawing.Size(119, 23);
            this.btnFrequency.TabIndex = 5;
            this.btnFrequency.Text = "Frekuensi";
            this.btnFrequency.Click += new System.EventHandler(this.btnFrequency_Click);
            // 
            // gcFreequency
            // 
            this.gcFreequency.Location = new System.Drawing.Point(5, 53);
            this.gcFreequency.MainView = this.gvFreequency;
            this.gcFreequency.Name = "gcFreequency";
            this.gcFreequency.Size = new System.Drawing.Size(232, 283);
            this.gcFreequency.TabIndex = 6;
            this.gcFreequency.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFreequency});
            // 
            // gvFreequency
            // 
            this.gvFreequency.GridControl = this.gcFreequency;
            this.gvFreequency.Name = "gvFreequency";
            this.gvFreequency.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcAtribut);
            this.groupControl1.Controls.Add(this.btnAtribut);
            this.groupControl1.Location = new System.Drawing.Point(29, 48);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(234, 341);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Pemilihan Atribut";
            // 
            // gcAtribut
            // 
            this.gcAtribut.Location = new System.Drawing.Point(5, 53);
            this.gcAtribut.MainView = this.gvAtribut;
            this.gcAtribut.Name = "gcAtribut";
            this.gcAtribut.Size = new System.Drawing.Size(224, 284);
            this.gcAtribut.TabIndex = 0;
            this.gcAtribut.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAtribut});
            // 
            // gvAtribut
            // 
            this.gvAtribut.GridControl = this.gcAtribut;
            this.gvAtribut.Name = "gvAtribut";
            this.gvAtribut.OptionsView.ShowGroupPanel = false;
            // 
            // Preprocessing_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "Preprocessing_Data";
            this.Size = new System.Drawing.Size(1070, 651);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCleaning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCleaning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFreequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFreequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAtribut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAtribut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnCleaning;
        private DevExpress.XtraGrid.GridControl gcCleaning;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCleaning;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnAtribut;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnFrequency;
        private DevExpress.XtraGrid.GridControl gcFreequency;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFreequency;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcAtribut;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAtribut;
    }
}
