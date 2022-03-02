namespace Notatnik
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuPlik = new System.Windows.Forms.ToolStripMenuItem();
            this.plikNowy = new System.Windows.Forms.ToolStripMenuItem();
            this.plikOtwórz = new System.Windows.Forms.ToolStripMenuItem();
            this.plikZapisz = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.plikDrukuj = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.plikZakoncz = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdytuj = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.formatCzcionka = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWidok = new System.Windows.Forms.ToolStripMenuItem();
            this.widokDarkmode = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPomoc = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.pomocInformacje = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonCenter = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.labelKolumnaText = new System.Windows.Forms.Label();
            this.labelLiniaText = new System.Windows.Forms.Label();
            this.labelKolumna = new System.Windows.Forms.Label();
            this.labelLinia = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.GripMargin = new System.Windows.Forms.Padding(0);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPlik,
            this.menuEdytuj,
            this.menuFormat,
            this.menuWidok,
            this.menuPomoc});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip";
            // 
            // menuPlik
            // 
            this.menuPlik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikNowy,
            this.plikOtwórz,
            this.plikZapisz,
            this.toolStripSeparator1,
            this.plikDrukuj,
            this.toolStripSeparator4,
            this.plikZakoncz});
            this.menuPlik.Name = "menuPlik";
            this.menuPlik.Size = new System.Drawing.Size(38, 20);
            this.menuPlik.Text = "&Plik";
            // 
            // plikNowy
            // 
            this.plikNowy.Name = "plikNowy";
            this.plikNowy.Size = new System.Drawing.Size(180, 22);
            this.plikNowy.Text = "Nowy";
            this.plikNowy.Click += new System.EventHandler(this.plikNowy_Click);
            // 
            // plikOtwórz
            // 
            this.plikOtwórz.Name = "plikOtwórz";
            this.plikOtwórz.Size = new System.Drawing.Size(180, 22);
            this.plikOtwórz.Text = "Otwórz";
            this.plikOtwórz.Click += new System.EventHandler(this.plikOtwórz_Click);
            // 
            // plikZapisz
            // 
            this.plikZapisz.Name = "plikZapisz";
            this.plikZapisz.Size = new System.Drawing.Size(180, 22);
            this.plikZapisz.Text = "Zapisz jako";
            this.plikZapisz.Click += new System.EventHandler(this.plikZapisz_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // plikDrukuj
            // 
            this.plikDrukuj.Name = "plikDrukuj";
            this.plikDrukuj.Size = new System.Drawing.Size(180, 22);
            this.plikDrukuj.Text = "Drukuj";
            this.plikDrukuj.Click += new System.EventHandler(this.plikDrukuj_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // plikZakoncz
            // 
            this.plikZakoncz.Name = "plikZakoncz";
            this.plikZakoncz.Size = new System.Drawing.Size(180, 22);
            this.plikZakoncz.Text = "Zakończ";
            this.plikZakoncz.Click += new System.EventHandler(this.plikZakoncz_Click);
            // 
            // menuEdytuj
            // 
            this.menuEdytuj.Name = "menuEdytuj";
            this.menuEdytuj.Size = new System.Drawing.Size(52, 20);
            this.menuEdytuj.Text = "&Edytuj";
            // 
            // menuFormat
            // 
            this.menuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatCzcionka});
            this.menuFormat.Name = "menuFormat";
            this.menuFormat.Size = new System.Drawing.Size(57, 20);
            this.menuFormat.Text = "For&mat";
            // 
            // formatCzcionka
            // 
            this.formatCzcionka.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.formatCzcionka.Name = "formatCzcionka";
            this.formatCzcionka.Size = new System.Drawing.Size(121, 22);
            this.formatCzcionka.Text = "Czcionka";
            this.formatCzcionka.Click += new System.EventHandler(this.formatCzcionka_Click);
            // 
            // menuWidok
            // 
            this.menuWidok.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.widokDarkmode});
            this.menuWidok.Name = "menuWidok";
            this.menuWidok.Size = new System.Drawing.Size(53, 20);
            this.menuWidok.Text = "&Widok";
            // 
            // widokDarkmode
            // 
            this.widokDarkmode.CheckOnClick = true;
            this.widokDarkmode.Name = "widokDarkmode";
            this.widokDarkmode.Size = new System.Drawing.Size(138, 22);
            this.widokDarkmode.Text = "Tryb ciemny";
            this.widokDarkmode.Click += new System.EventHandler(this.widokDarkmode_Click);
            // 
            // menuPomoc
            // 
            this.menuPomoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocAutor,
            this.toolStripSeparator3,
            this.pomocInformacje});
            this.menuPomoc.Name = "menuPomoc";
            this.menuPomoc.Size = new System.Drawing.Size(57, 20);
            this.menuPomoc.Text = "Pomo&c";
            // 
            // pomocAutor
            // 
            this.pomocAutor.Name = "pomocAutor";
            this.pomocAutor.Size = new System.Drawing.Size(188, 22);
            this.pomocAutor.Text = "Autor";
            this.pomocAutor.Click += new System.EventHandler(this.pomocAutor_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(185, 6);
            // 
            // pomocInformacje
            // 
            this.pomocInformacje.Name = "pomocInformacje";
            this.pomocInformacje.Size = new System.Drawing.Size(188, 22);
            this.pomocInformacje.Text = "Notatnik - Informacje";
            this.pomocInformacje.Click += new System.EventHandler(this.pomocInformacje_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.BackColor = System.Drawing.SystemColors.Window;
            this.textBox.Location = new System.Drawing.Point(0, 27);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(800, 406);
            this.textBox.TabIndex = 3;
            this.textBox.Text = "";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Pliki tekstowe|*.txt|Wszystkie|*.*";
            this.saveFileDialog1.Title = "Zapisz Plik";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Otwórz Plik";
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.Transparent;
            this.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonB.Location = new System.Drawing.Point(412, 0);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(26, 21);
            this.buttonB.TabIndex = 4;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonU
            // 
            this.buttonU.BackColor = System.Drawing.Color.Transparent;
            this.buttonU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonU.Location = new System.Drawing.Point(444, 0);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(26, 21);
            this.buttonU.TabIndex = 5;
            this.buttonU.Text = "U";
            this.buttonU.UseVisualStyleBackColor = false;
            this.buttonU.Click += new System.EventHandler(this.buttonU_Click);
            // 
            // buttonI
            // 
            this.buttonI.BackColor = System.Drawing.Color.Transparent;
            this.buttonI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonI.Location = new System.Drawing.Point(476, 0);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(26, 21);
            this.buttonI.TabIndex = 6;
            this.buttonI.Text = "I";
            this.buttonI.UseVisualStyleBackColor = false;
            this.buttonI.Click += new System.EventHandler(this.buttonI_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.Transparent;
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.Location = new System.Drawing.Point(531, 0);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(26, 21);
            this.buttonLeft.TabIndex = 7;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = false;
            // 
            // buttonCenter
            // 
            this.buttonCenter.BackColor = System.Drawing.Color.Transparent;
            this.buttonCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCenter.Location = new System.Drawing.Point(563, 0);
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.Size = new System.Drawing.Size(26, 21);
            this.buttonCenter.TabIndex = 8;
            this.buttonCenter.Text = "|";
            this.buttonCenter.UseVisualStyleBackColor = false;
            this.buttonCenter.Click += new System.EventHandler(this.buttonCenter_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.Transparent;
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRight.Location = new System.Drawing.Point(595, 0);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(26, 21);
            this.buttonRight.TabIndex = 9;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.Transparent;
            this.buttonColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColor.Location = new System.Drawing.Point(651, 0);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(41, 21);
            this.buttonColor.TabIndex = 10;
            this.buttonColor.Text = "Kolor";
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // labelKolumnaText
            // 
            this.labelKolumnaText.AutoSize = true;
            this.labelKolumnaText.BackColor = System.Drawing.Color.Transparent;
            this.labelKolumnaText.Location = new System.Drawing.Point(641, 436);
            this.labelKolumnaText.Name = "labelKolumnaText";
            this.labelKolumnaText.Size = new System.Drawing.Size(51, 13);
            this.labelKolumnaText.TabIndex = 11;
            this.labelKolumnaText.Text = "Kolumna:";
            // 
            // labelLiniaText
            // 
            this.labelLiniaText.AutoSize = true;
            this.labelLiniaText.BackColor = System.Drawing.Color.Transparent;
            this.labelLiniaText.Location = new System.Drawing.Point(731, 436);
            this.labelLiniaText.Name = "labelLiniaText";
            this.labelLiniaText.Size = new System.Drawing.Size(32, 13);
            this.labelLiniaText.TabIndex = 12;
            this.labelLiniaText.Text = "Linia:";
            // 
            // labelKolumna
            // 
            this.labelKolumna.AutoSize = true;
            this.labelKolumna.BackColor = System.Drawing.Color.Transparent;
            this.labelKolumna.Location = new System.Drawing.Point(694, 436);
            this.labelKolumna.Name = "labelKolumna";
            this.labelKolumna.Size = new System.Drawing.Size(13, 13);
            this.labelKolumna.TabIndex = 13;
            this.labelKolumna.Text = "0";
            // 
            // labelLinia
            // 
            this.labelLinia.AutoSize = true;
            this.labelLinia.BackColor = System.Drawing.Color.Transparent;
            this.labelLinia.Location = new System.Drawing.Point(769, 436);
            this.labelLinia.Name = "labelLinia";
            this.labelLinia.Size = new System.Drawing.Size(13, 13);
            this.labelLinia.TabIndex = 14;
            this.labelLinia.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLinia);
            this.Controls.Add(this.labelKolumna);
            this.Controls.Add(this.labelLiniaText);
            this.Controls.Add(this.labelKolumnaText);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonCenter);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonI);
            this.Controls.Add(this.buttonU);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Notatnik";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPlik;
        private System.Windows.Forms.ToolStripMenuItem plikNowy;
        private System.Windows.Forms.ToolStripMenuItem plikOtwórz;
        private System.Windows.Forms.ToolStripMenuItem plikZapisz;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem plikZakoncz;
        private System.Windows.Forms.ToolStripMenuItem menuEdytuj;
        private System.Windows.Forms.ToolStripMenuItem menuFormat;
        private System.Windows.Forms.ToolStripMenuItem menuWidok;
        private System.Windows.Forms.ToolStripMenuItem menuPomoc;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem plikDrukuj;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem formatCzcionka;
        private System.Windows.Forms.ToolStripMenuItem pomocAutor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem pomocInformacje;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.ToolStripMenuItem widokDarkmode;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonCenter;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label labelKolumnaText;
        private System.Windows.Forms.Label labelLiniaText;
        private System.Windows.Forms.Label labelKolumna;
        private System.Windows.Forms.Label labelLinia;
    }
}

