using System.Windows.Forms;

namespace VsiteCSharpKvadratnaJednadzbaGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
            functionPanel1.Function = resultDisplay.qe.Y;
            this.resultDisplay.CoefficientChanged += ResultDisplay_CoefficientChanged;
        }

        private void ResultDisplay_CoefficientChanged(object sender, System.EventArgs e)
        {
            this.functionPanel1.Invalidate();
        }

        private void buttonEvaluate_Click(object sender, System.EventArgs e)
        {
            this.resultDisplay.FillResults();
        }

        private void resultDisplay_Load(object sender, System.EventArgs e)
        {

        }
    }
}
