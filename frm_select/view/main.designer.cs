namespace frm_select.view
{
    partial class main
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
            DevExpress.XtraEditors.TileItemElement tileItemElement15 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            DevExpress.XtraEditors.TileItemElement tileItemElement16 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement17 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement18 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement19 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement20 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement21 = new DevExpress.XtraEditors.TileItemElement();
            this.menuControl = new DevExpress.XtraEditors.TileControl();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.BtnImport = new DevExpress.XtraEditors.TileItem();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.btnAtribut = new DevExpress.XtraEditors.TileItem();
            this.btnFrekuensi = new DevExpress.XtraEditors.TileItem();
            this.btnSorting = new DevExpress.XtraEditors.TileItem();
            this.btnCleaning = new DevExpress.XtraEditors.TileItem();
            this.tileGroup4 = new DevExpress.XtraEditors.TileGroup();
            this.btnAsosiasi = new DevExpress.XtraEditors.TileItem();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.lblMenu = new DevExpress.XtraEditors.LabelControl();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.BtnMenu = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.SuspendLayout();
            // 
            // menuControl
            // 
            this.menuControl.Groups.Add(this.tileGroup1);
            this.menuControl.Groups.Add(this.tileGroup3);
            this.menuControl.Groups.Add(this.tileGroup4);
            this.menuControl.Location = new System.Drawing.Point(36, 57);
            this.menuControl.MaxId = 17;
            this.menuControl.Name = "menuControl";
            this.menuControl.Size = new System.Drawing.Size(798, 346);
            this.menuControl.TabIndex = 0;
            this.menuControl.Text = "tileControl1";
            // 
            // tileGroup1
            // 
            this.tileGroup1.Items.Add(this.BtnImport);
            this.tileGroup1.Name = "tileGroup1";
            this.tileGroup1.Text = "tileGroup1";
            // 
            // BtnImport
            // 
            this.BtnImport.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnImport.AppearanceItem.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnImport.AppearanceItem.Normal.Options.UseBackColor = true;
            this.BtnImport.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement15.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement15.Image")));
            tileItemElement15.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement15.Text = "Import Data";
            this.BtnImport.Elements.Add(tileItemElement15);
            this.BtnImport.Id = 0;
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.BtnImport_ItemClick);
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.btnAtribut);
            this.tileGroup3.Items.Add(this.btnFrekuensi);
            this.tileGroup3.Items.Add(this.btnSorting);
            this.tileGroup3.Items.Add(this.btnCleaning);
            this.tileGroup3.Name = "tileGroup3";
            this.tileGroup3.Text = null;
            // 
            // btnAtribut
            // 
            this.btnAtribut.AppearanceItem.Normal.BackColor = System.Drawing.Color.Gray;
            this.btnAtribut.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement16.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement16.Image")));
            tileItemElement16.Text = "Preprocessing";
            this.btnAtribut.Elements.Add(tileItemElement16);
            this.btnAtribut.Id = 10;
            this.btnAtribut.IsLarge = true;
            this.btnAtribut.Name = "btnAtribut";
            this.btnAtribut.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btnAtribut_ItemClick);
            // 
            // btnFrekuensi
            // 
            this.btnFrekuensi.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFrekuensi.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement17.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement17.Image")));
            tileItemElement17.Text = "Kuantitas Produk";
            this.btnFrekuensi.Elements.Add(tileItemElement17);
            this.btnFrekuensi.Id = 12;
            this.btnFrekuensi.Name = "btnFrekuensi";
            this.btnFrekuensi.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btnFrekuensi_ItemClick);
            // 
            // btnSorting
            // 
            this.btnSorting.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSorting.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement18.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement18.Image")));
            tileItemElement18.Text = "Pengurutan";
            this.btnSorting.Elements.Add(tileItemElement18);
            this.btnSorting.Id = 16;
            this.btnSorting.Name = "btnSorting";
            this.btnSorting.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btnSorting_ItemClick);
            // 
            // btnCleaning
            // 
            this.btnCleaning.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCleaning.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement19.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement19.Image")));
            tileItemElement19.Text = "Cleaning";
            this.btnCleaning.Elements.Add(tileItemElement19);
            this.btnCleaning.Id = 14;
            this.btnCleaning.Name = "btnCleaning";
            this.btnCleaning.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btnCleaning_ItemClick);
            // 
            // tileGroup4
            // 
            this.tileGroup4.Items.Add(this.btnAsosiasi);
            this.tileGroup4.Name = "tileGroup4";
            this.tileGroup4.Text = null;
            // 
            // btnAsosiasi
            // 
            this.btnAsosiasi.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAsosiasi.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement20.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement20.Image")));
            tileItemElement20.Text = "Asosiasi Data";
            this.btnAsosiasi.Elements.Add(tileItemElement20);
            this.btnAsosiasi.Id = 9;
            this.btnAsosiasi.Name = "btnAsosiasi";
            this.btnAsosiasi.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btnAsosiasi_ItemClick);
            // 
            // tileItem4
            // 
            tileItemElement21.Text = "Pengurutan";
            this.tileItem4.Elements.Add(tileItemElement21);
            this.tileItem4.Id = 13;
            this.tileItem4.Name = "tileItem4";
            // 
            // lblMenu
            // 
            this.lblMenu.Location = new System.Drawing.Point(65, 67);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(51, 13);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = ":: Beranda";
            // 
            // panelControl
            // 
            this.panelControl.Location = new System.Drawing.Point(12, 55);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(860, 438);
            this.panelControl.TabIndex = 2;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.Location = new System.Drawing.Point(12, 12);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(40, 37);
            this.BtnMenu.TabIndex = 15;
            this.BtnMenu.Text = "Beranda";
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(55, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(40, 37);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Pengaturan";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(98, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(40, 37);
            this.simpleButton2.TabIndex = 15;
            this.simpleButton2.Text = "Cara Penggunaan";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 505);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.menuControl);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APLIKASI DATA MAINING CT-PRO";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TileControl menuControl;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileItem BtnImport;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem btnAtribut;
        private DevExpress.XtraEditors.TileItem btnFrekuensi;
        private DevExpress.XtraEditors.TileItem btnCleaning;
        private DevExpress.XtraEditors.TileGroup tileGroup4;
        private DevExpress.XtraEditors.TileItem btnAsosiasi;
        private DevExpress.XtraEditors.TileItem btnSorting;
        private DevExpress.XtraEditors.TileItem tileItem4;
        private DevExpress.XtraEditors.LabelControl lblMenu;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraEditors.SimpleButton BtnMenu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}