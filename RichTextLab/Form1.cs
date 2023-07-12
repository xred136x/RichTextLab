using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RichTextLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBold_MouseClick(object sender, MouseEventArgs e)
        {
            if (rtbDoc.SelectedText != null)
            {
                if (((Button)sender).Text == "Жирный")
                {
                   
                    rtbDoc.SelectionFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                }
                else
                {
                    if (((Button)sender).Text == "Курсив")
                    {
                        rtbDoc.SelectionFont = new Font("Microsoft Sans Serif", 12, FontStyle.Italic);
                    }
                    else
                    {
                        rtbDoc.SelectionFont = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
                    }
                }
                
            }
        }

        private void btnSave_MouseClick(object sender, MouseEventArgs e)
        {
            rtbDoc.SaveFile("Dock.rtf");
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
