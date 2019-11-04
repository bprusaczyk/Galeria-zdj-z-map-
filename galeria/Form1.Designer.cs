namespace galeria
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wBazieDancychToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMapa = new System.Windows.Forms.Panel();
            this.duzyObraz = new System.Windows.Forms.PictureBox();
            this.daneExif = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.wszystkie = new System.Windows.Forms.RadioButton();
            this.pobierz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rok1 = new System.Windows.Forms.TextBox();
            this.rok2 = new System.Windows.Forms.TextBox();
            this.dzien2 = new System.Windows.Forms.TextBox();
            this.miesiac2 = new System.Windows.Forms.TextBox();
            this.miesiac1 = new System.Windows.Forms.TextBox();
            this.dzien1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duzyObraz)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1240, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wBazieDancychToolStripMenuItem});
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            // 
            // wBazieDancychToolStripMenuItem
            // 
            this.wBazieDancychToolStripMenuItem.Name = "wBazieDancychToolStripMenuItem";
            this.wBazieDancychToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.wBazieDancychToolStripMenuItem.Text = "W bazie dancych";
            this.wBazieDancychToolStripMenuItem.Click += new System.EventHandler(this.wBazieDancychToolStripMenuItem_Click);
            // 
            // panelMapa
            // 
            this.panelMapa.Location = new System.Drawing.Point(12, 27);
            this.panelMapa.Name = "panelMapa";
            this.panelMapa.Size = new System.Drawing.Size(660, 622);
            this.panelMapa.TabIndex = 1;
            // 
            // duzyObraz
            // 
            this.duzyObraz.Location = new System.Drawing.Point(678, 27);
            this.duzyObraz.Name = "duzyObraz";
            this.duzyObraz.Size = new System.Drawing.Size(550, 362);
            this.duzyObraz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.duzyObraz.TabIndex = 2;
            this.duzyObraz.TabStop = false;
            // 
            // daneExif
            // 
            this.daneExif.AutoSize = true;
            this.daneExif.Location = new System.Drawing.Point(695, 403);
            this.daneExif.Name = "daneExif";
            this.daneExif.Size = new System.Drawing.Size(0, 13);
            this.daneExif.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.wszystkie);
            this.groupBox1.Controls.Add(this.pobierz);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rok1);
            this.groupBox1.Controls.Add(this.rok2);
            this.groupBox1.Controls.Add(this.dzien2);
            this.groupBox1.Controls.Add(this.miesiac2);
            this.groupBox1.Controls.Add(this.miesiac1);
            this.groupBox1.Controls.Add(this.dzien1);
            this.groupBox1.Location = new System.Drawing.Point(678, 549);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pobierz z bazy danych";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "od";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // wszystkie
            // 
            this.wszystkie.AutoSize = true;
            this.wszystkie.Checked = true;
            this.wszystkie.Location = new System.Drawing.Point(7, 20);
            this.wszystkie.Name = "wszystkie";
            this.wszystkie.Size = new System.Drawing.Size(70, 17);
            this.wszystkie.TabIndex = 10;
            this.wszystkie.TabStop = true;
            this.wszystkie.Text = "wszystkie";
            this.wszystkie.UseVisualStyleBackColor = true;
            // 
            // pobierz
            // 
            this.pobierz.Location = new System.Drawing.Point(7, 68);
            this.pobierz.Name = "pobierz";
            this.pobierz.Size = new System.Drawing.Size(537, 23);
            this.pobierz.TabIndex = 9;
            this.pobierz.Text = "Pobierz";
            this.pobierz.UseVisualStyleBackColor = true;
            this.pobierz.Click += new System.EventHandler(this.pobierz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "do";
            // 
            // rok1
            // 
            this.rok1.Location = new System.Drawing.Point(150, 44);
            this.rok1.Name = "rok1";
            this.rok1.Size = new System.Drawing.Size(43, 20);
            this.rok1.TabIndex = 7;
            // 
            // rok2
            // 
            this.rok2.Location = new System.Drawing.Point(313, 44);
            this.rok2.Name = "rok2";
            this.rok2.Size = new System.Drawing.Size(43, 20);
            this.rok2.TabIndex = 6;
            // 
            // dzien2
            // 
            this.dzien2.Location = new System.Drawing.Point(215, 44);
            this.dzien2.Name = "dzien2";
            this.dzien2.Size = new System.Drawing.Size(43, 20);
            this.dzien2.TabIndex = 5;
            // 
            // miesiac2
            // 
            this.miesiac2.Location = new System.Drawing.Point(264, 44);
            this.miesiac2.Name = "miesiac2";
            this.miesiac2.Size = new System.Drawing.Size(43, 20);
            this.miesiac2.TabIndex = 4;
            // 
            // miesiac1
            // 
            this.miesiac1.Location = new System.Drawing.Point(101, 44);
            this.miesiac1.Name = "miesiac1";
            this.miesiac1.Size = new System.Drawing.Size(43, 20);
            this.miesiac1.TabIndex = 3;
            // 
            // dzien1
            // 
            this.dzien1.Location = new System.Drawing.Point(52, 44);
            this.dzien1.Name = "dzien1";
            this.dzien1.Size = new System.Drawing.Size(43, 20);
            this.dzien1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.daneExif);
            this.Controls.Add(this.duzyObraz);
            this.Controls.Add(this.panelMapa);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Galeria z mapą";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duzyObraz)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.Panel panelMapa;
        private System.Windows.Forms.PictureBox duzyObraz;
        private System.Windows.Forms.Label daneExif;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wBazieDancychToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox rok1;
        private System.Windows.Forms.TextBox rok2;
        private System.Windows.Forms.TextBox dzien2;
        private System.Windows.Forms.TextBox miesiac2;
        private System.Windows.Forms.TextBox miesiac1;
        private System.Windows.Forms.TextBox dzien1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pobierz;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton wszystkie;
    }
}

