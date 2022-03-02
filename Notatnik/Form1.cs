using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik{
    public partial class Form1 : Form{
        bool isOpen = false;

        public Form1(){
            InitializeComponent();
        }

        private void plikZakoncz_Click(object sender, EventArgs e){
            Application.Exit();
        }

        private void plikNowy_Click(object sender, EventArgs e){
            string message = "Czy chcesz zapisac?";
            string caption = "Zapisywanie...";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes){
                if (saveFileDialog1.ShowDialog() == DialogResult.OK){
                    try{
                        FileStream fs = new FileStream(
                        saveFileDialog1.FileName,
                        FileMode.OpenOrCreate,
                        FileAccess.ReadWrite);

                        StreamWriter sw = new StreamWriter(fs);

                        sw.WriteLine(textBox.Text);
                        sw.Close();
                    }catch (Exception mess) { MessageBox.Show(mess.Message);}
                }
            }else{
                isOpen = false;
                textBox.Text = String.Empty;} 
        }

        private void plikZapisz_Click(object sender, EventArgs e){
            if ( saveFileDialog1.ShowDialog() == DialogResult.OK){
                try{
                    FileStream fs = new FileStream(
                    saveFileDialog1.FileName,
                    FileMode.OpenOrCreate,
                    FileAccess.ReadWrite);

                    StreamWriter sw = new StreamWriter(fs);

                    sw.WriteLine(textBox.Text);
                    sw.Close();
                }catch (Exception mess) {MessageBox.Show(mess.Message);}
            }
        }

        private void plikOtwórz_Click(object sender, EventArgs e){
            if( openFileDialog1.ShowDialog() == DialogResult.OK){
                try{
                    FileStream fs = new FileStream(
                    openFileDialog1.FileName,
                    FileMode.Open, 
                    FileAccess.ReadWrite);

                    StreamReader sr = new StreamReader(fs);

                    textBox.Text = sr.ReadToEnd();
                    sr.Close();
                }catch (Exception mess) {MessageBox.Show(mess.Message);}
            }
        }
        private void plikDrukuj_Click(object sender, EventArgs e){
            //Print document
            //Test v0.4

            /*System.Drawing.Printing.PrintDocument docToPrint = new System.Drawing.Printing.PrintDocument();
            printDialog1.AllowSomePages = true;
            printDialog1.ShowHelp = true;
            printDialog1.Document = docToPrint;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK){
                docToPrint.Print();}*/
        }

        private void formatCzcionka_Click(object sender, EventArgs e){
            FontDialog setfont = new FontDialog();
            setfont.Font = textBox.Font;
            if (setfont.ShowDialog() == DialogResult.OK)
                textBox.SelectionFont = setfont.Font;
        }
        private void textBox_TextChanged(object sender, EventArgs e){
            int column = 1 + textBox.GetLineFromCharIndex(textBox.GetFirstCharIndexOfCurrentLine());
            int line = 1 + textBox.SelectionStart - textBox.GetFirstCharIndexOfCurrentLine();
            labelKolumna.Text = column.ToString();
            labelLinia.Text = line.ToString();
        }

        private void buttonB_Click(object sender, EventArgs e){
            Color butColorG = Color.Gray;
            Color butColorT = Color.Transparent;
            if (textBox.SelectionFont != null){
                System.Drawing.Font currentFont = textBox.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (textBox.SelectionFont.Bold == true){
                    newFontStyle = FontStyle.Regular;
                    buttonB.BackColor = butColorT;
                }else{
                    newFontStyle = FontStyle.Bold;
                    buttonB.BackColor = butColorG;}

                textBox.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle);
            }
        }

        private void buttonU_Click(object sender, EventArgs e){
            Color butColorG = Color.Gray;
            Color butColorT = Color.Transparent;
            if (textBox.SelectionFont != null){
                System.Drawing.Font currentFont = textBox.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (textBox.SelectionFont.Underline == true){
                    newFontStyle = FontStyle.Regular;
                    buttonU.BackColor = butColorT;
                }else{
                    newFontStyle = FontStyle.Underline;
                    buttonU.BackColor = butColorG;}

                textBox.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle);
            }
        }

        private void buttonI_Click(object sender, EventArgs e){
            Color butColorG = Color.Gray;
            Color butColorT = Color.Transparent;
            if (textBox.SelectionFont != null){
                System.Drawing.Font currentFont = textBox.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (textBox.SelectionFont.Italic == true){
                    newFontStyle = FontStyle.Regular;
                    buttonI.BackColor = butColorT;
                }else{
                    newFontStyle = FontStyle.Italic;
                    buttonI.BackColor = butColorG;}

                textBox.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle);
            }
        }
        private void buttonLeft_Click(object sender, EventArgs e){
            Color butColorG = Color.Gray;
            Color butColorT = Color.Transparent;
            if(textBox.SelectionAlignment == HorizontalAlignment.Left){
                    buttonLeft.BackColor = butColorT;
                    textBox.SelectionAlignment = HorizontalAlignment.Left;
                }else{
                    buttonLeft.BackColor = butColorG;
                    textBox.SelectionAlignment = HorizontalAlignment.Left;}
        }
        private void buttonCenter_Click(object sender, EventArgs e){
            Color butColorG = Color.Gray;
            Color butColorT = Color.Transparent;
            if (textBox.SelectionAlignment == HorizontalAlignment.Center){
                    buttonCenter.BackColor = butColorT;
                    textBox.SelectionAlignment = HorizontalAlignment.Left;
                }else{
                    buttonCenter.BackColor = butColorG;
                    textBox.SelectionAlignment = HorizontalAlignment.Center;}
        }
        private void buttonRight_Click(object sender, EventArgs e){
            Color butColorG = Color.Gray;
            Color butColorT = Color.Transparent;
            if (textBox.SelectionAlignment == HorizontalAlignment.Right){
                    buttonRight.BackColor = butColorT;
                    textBox.SelectionAlignment = HorizontalAlignment.Left;
                }else{
                    buttonRight.BackColor = butColorG;
                    textBox.SelectionAlignment = HorizontalAlignment.Right;}
        }
        private void buttonColor_Click(object sender, EventArgs e){
            Color appwhite = Color.FromArgb(255, 255, 255);
            Color appblack = Color.FromArgb(0, 0, 0);
            ColorDialog setcolor = new ColorDialog();
            setcolor.AllowFullOpen = true;
            setcolor.Color = textBox.ForeColor;
            if (textBox.SelectionColor != null){
                if(textBox.SelectionColor == setcolor.Color){
                    if(widokDarkmode.Checked == true){textBox.ForeColor = appwhite; 
                    }else{textBox.ForeColor = appblack;}
                }else{
                    if (setcolor.ShowDialog() == DialogResult.OK)
                        textBox.SelectionColor = setcolor.Color;
                }
            }
        }

        private void widokDarkmode_Click(object sender, EventArgs e){
            Color app1dark = Color.FromArgb(36, 36, 36);
            Color app2dark = Color.FromArgb(46, 46, 46);
            Color appwhite = Color.FromArgb(255, 255, 255);
            Color appblack = Color.FromArgb(0, 0, 0);
            if (widokDarkmode.Checked == true){
                menu.BackColor = app1dark;
                menu.ForeColor = appwhite;
                textBox.BackColor = app2dark;
                textBox.ForeColor = appwhite;
                this.BackColor = app1dark;
                this.ForeColor = app1dark;
                labelKolumnaText.ForeColor = appwhite;
                labelKolumna.ForeColor = appwhite;
                labelLiniaText.ForeColor = appwhite;
                labelLinia.ForeColor = appwhite;
                buttonB.ForeColor = appwhite;
                buttonB.BackColor = app2dark;
                buttonI.ForeColor = appwhite;
                buttonI.BackColor = app2dark;
                buttonU.ForeColor = appwhite;
                buttonU.BackColor = app2dark;
                buttonLeft.ForeColor = appwhite;
                buttonLeft.BackColor = app2dark;
                buttonCenter.ForeColor = appwhite;
                buttonCenter.BackColor = app2dark;
                buttonRight.ForeColor = appwhite;
                buttonRight.BackColor = app2dark;
                buttonColor.ForeColor = appwhite;
                buttonColor.BackColor = app2dark;
            }else{
                menu.BackColor = appwhite;
                menu.ForeColor = appblack;
                textBox.BackColor = appwhite;
                textBox.ForeColor = appblack;
                this.BackColor = appwhite;
                this.ForeColor = appblack;
                labelKolumnaText.ForeColor = appblack;
                labelKolumna.ForeColor = appblack;
                labelLiniaText.ForeColor = appblack;
                labelLinia.ForeColor = appblack;
                buttonB.ForeColor = appblack;
                buttonB.BackColor = appwhite;
                buttonI.ForeColor = appblack;
                buttonI.BackColor = appwhite;
                buttonU.ForeColor = appblack;
                buttonU.BackColor = appwhite;
                buttonLeft.ForeColor = appblack;
                buttonLeft.BackColor = appwhite;
                buttonCenter.ForeColor = appblack;
                buttonCenter.BackColor = appwhite;
                buttonRight.ForeColor = appblack;
                buttonRight.BackColor = appwhite;
                buttonColor.ForeColor = appblack;
                buttonColor.BackColor = appwhite;}
        }

        private void pomocInformacje_Click(object sender, EventArgs e){
            const string message = "Wersja aplikacji: v1.1\nWersja plików: v1.2";
            const string caption = "Pomoc: Notatnik - informacje";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
        }

        private void pomocAutor_Click(object sender, EventArgs e){
            const string message = "Autor: WCode\nKontakt: GramySe.pl";
            const string caption = "Pomoc: Autor - informacje";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
        }
    }
}
