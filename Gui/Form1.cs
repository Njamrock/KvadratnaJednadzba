﻿using System.Windows.Forms;

namespace VsiteCSharpKvadratnaJednadzbaGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private void buttonEvaluate_Click(object sender, System.EventArgs e)
        {
            this.resultDisplay.FillResults();
        }
    }
}