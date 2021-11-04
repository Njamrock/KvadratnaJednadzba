using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KvadratnaJednadzba;

namespace VsiteCSharpKvadratnaJednadzbaGui
{
    public partial class ResultDisplay : UserControl
    {
        public ResultDisplay()
        {
            InitializeComponent();
        }

        private void ResultDisplay_Load(object sender, EventArgs e)
        {
        }

        public readonly QuadraticEquation qe = new QuadraticEquation();

        public void FillResults()
        {
            this.qe.A = (double) this.numericUpDownA.Value;
            this.qe.B = (double) this.numericUpDownB.Value;
            this.qe.C = (double) this.numericUpDownC.Value;

            double discriminant = this.qe.Discriminant;
            this.textBoxDiscriminant.Text = discriminant.ToString();

            this.textBoxRoot1.Text = this.qe.Roots[0].ToString();
            this.textBoxRoot2.Text = this.qe.Roots[1].ToString();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.FillResults();
        }
    }
}
