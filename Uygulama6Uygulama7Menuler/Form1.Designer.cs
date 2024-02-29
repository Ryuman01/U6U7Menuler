namespace Uygulama6Uygulama7Menuler
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AnaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAc = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuYazdır = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDuzen = new System.Windows.Forms.ToolStripMenuItem();
            this.DuzenKes = new System.Windows.Forms.ToolStripMenuItem();
            this.DuzenKopyala = new System.Windows.Forms.ToolStripMenuItem();
            this.DuzenYapıstır = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.SagTikMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmenuKes = new System.Windows.Forms.ToolStripMenuItem();
            this.CmenuKopyala = new System.Windows.Forms.ToolStripMenuItem();
            this.CmenuYapistir = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEditor = new System.Windows.Forms.RichTextBox();
            this.belge = new System.Windows.Forms.PrintDialog();
            this.menuStrip1.SuspendLayout();
            this.SagTikMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AnaMenu,
            this.MenuDuzen,
            this.MenuCikis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AnaMenu
            // 
            this.AnaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuYeni,
            this.MenuAc,
            this.MenuKaydet,
            this.MenuYazdır});
            this.AnaMenu.Name = "AnaMenu";
            this.AnaMenu.Size = new System.Drawing.Size(50, 20);
            this.AnaMenu.Text = "Menü";
            // 
            // MenuYeni
            // 
            this.MenuYeni.Name = "MenuYeni";
            this.MenuYeni.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuYeni.Size = new System.Drawing.Size(180, 22);
            this.MenuYeni.Text = "Yeni";
            // 
            // MenuAc
            // 
            this.MenuAc.Name = "MenuAc";
            this.MenuAc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuAc.Size = new System.Drawing.Size(180, 22);
            this.MenuAc.Text = "Aç";
            this.MenuAc.Click += new System.EventHandler(this.MenuAc_Click);
            // 
            // MenuKaydet
            // 
            this.MenuKaydet.Name = "MenuKaydet";
            this.MenuKaydet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuKaydet.Size = new System.Drawing.Size(180, 22);
            this.MenuKaydet.Text = "Kaydet";
            this.MenuKaydet.Click += new System.EventHandler(this.MenuKaydet_Click);
            // 
            // MenuYazdır
            // 
            this.MenuYazdır.Name = "MenuYazdır";
            this.MenuYazdır.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.MenuYazdır.Size = new System.Drawing.Size(180, 22);
            this.MenuYazdır.Text = "Yazdır";
            this.MenuYazdır.Click += new System.EventHandler(this.MenuYazdır_Click);
            // 
            // MenuDuzen
            // 
            this.MenuDuzen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DuzenKes,
            this.DuzenKopyala,
            this.DuzenYapıstır});
            this.MenuDuzen.Name = "MenuDuzen";
            this.MenuDuzen.Size = new System.Drawing.Size(52, 20);
            this.MenuDuzen.Text = "Düzen";
            // 
            // DuzenKes
            // 
            this.DuzenKes.Enabled = false;
            this.DuzenKes.Name = "DuzenKes";
            this.DuzenKes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.DuzenKes.Size = new System.Drawing.Size(158, 22);
            this.DuzenKes.Text = "Kes";
            this.DuzenKes.Click += new System.EventHandler(this.DuzenKes_Click);
            // 
            // DuzenKopyala
            // 
            this.DuzenKopyala.Enabled = false;
            this.DuzenKopyala.Name = "DuzenKopyala";
            this.DuzenKopyala.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.DuzenKopyala.Size = new System.Drawing.Size(158, 22);
            this.DuzenKopyala.Text = "Kopyala";
            this.DuzenKopyala.Click += new System.EventHandler(this.DuzenKopyala_Click);
            // 
            // DuzenYapıstır
            // 
            this.DuzenYapıstır.Enabled = false;
            this.DuzenYapıstır.Name = "DuzenYapıstır";
            this.DuzenYapıstır.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.DuzenYapıstır.Size = new System.Drawing.Size(158, 22);
            this.DuzenYapıstır.Text = "Yapıştır";
            this.DuzenYapıstır.Click += new System.EventHandler(this.DuzenYapıstır_Click);
            // 
            // MenuCikis
            // 
            this.MenuCikis.Name = "MenuCikis";
            this.MenuCikis.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuCikis.Size = new System.Drawing.Size(44, 20);
            this.MenuCikis.Text = "Çıkış";
            this.MenuCikis.Click += new System.EventHandler(this.MenuCikis_Click);
            // 
            // SagTikMenu
            // 
            this.SagTikMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmenuKes,
            this.CmenuKopyala,
            this.CmenuYapistir});
            this.SagTikMenu.Name = "SagTikMenu";
            this.SagTikMenu.Size = new System.Drawing.Size(117, 70);
            // 
            // CmenuKes
            // 
            this.CmenuKes.Name = "CmenuKes";
            this.CmenuKes.Size = new System.Drawing.Size(116, 22);
            this.CmenuKes.Text = "Kes";
            this.CmenuKes.Click += new System.EventHandler(this.CmenuKes_Click);
            // 
            // CmenuKopyala
            // 
            this.CmenuKopyala.Name = "CmenuKopyala";
            this.CmenuKopyala.Size = new System.Drawing.Size(116, 22);
            this.CmenuKopyala.Text = "Kopyala";
            this.CmenuKopyala.Click += new System.EventHandler(this.CmenuKopyala_Click);
            // 
            // CmenuYapistir
            // 
            this.CmenuYapistir.Name = "CmenuYapistir";
            this.CmenuYapistir.Size = new System.Drawing.Size(116, 22);
            this.CmenuYapistir.Text = "Yapıştır";
            this.CmenuYapistir.Click += new System.EventHandler(this.CmenuYapistir_Click);
            // 
            // txtEditor
            // 
            this.txtEditor.ContextMenuStrip = this.SagTikMenu;
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.Location = new System.Drawing.Point(0, 24);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(800, 426);
            this.txtEditor.TabIndex = 2;
            this.txtEditor.Text = "";
            // 
            // belge
            // 
            this.belge.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SagTikMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AnaMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuYeni;
        private System.Windows.Forms.ToolStripMenuItem MenuAc;
        private System.Windows.Forms.ToolStripMenuItem MenuKaydet;
        private System.Windows.Forms.ToolStripMenuItem MenuYazdır;
        private System.Windows.Forms.ToolStripMenuItem MenuDuzen;
        private System.Windows.Forms.ToolStripMenuItem DuzenKes;
        private System.Windows.Forms.ToolStripMenuItem DuzenKopyala;
        private System.Windows.Forms.ToolStripMenuItem DuzenYapıstır;
        private System.Windows.Forms.ToolStripMenuItem MenuCikis;
        private System.Windows.Forms.ContextMenuStrip SagTikMenu;
        private System.Windows.Forms.ToolStripMenuItem CmenuKes;
        private System.Windows.Forms.ToolStripMenuItem CmenuKopyala;
        private System.Windows.Forms.ToolStripMenuItem CmenuYapistir;
        private System.Windows.Forms.RichTextBox txtEditor;
        private System.Windows.Forms.PrintDialog belge;
    }
}

