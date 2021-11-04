
namespace VsiteCSharpKvadratnaJednadzbaGui
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.resultDisplay = new VsiteCSharpKvadratnaJednadzbaGui.ResultDisplay();
            this.SuspendLayout();
            // 
            // resultDisplay
            // 
            this.resultDisplay.Location = new System.Drawing.Point(12, 12);
            this.resultDisplay.Name = "resultDisplay";
            this.resultDisplay.Size = new System.Drawing.Size(258, 320);
            this.resultDisplay.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultDisplay);
            this.Name = "Form1";
            this.Text = "Quadratic Equation";
            this.ResumeLayout(false);

        }

        #endregion

        private ResultDisplay resultDisplay;
    }
}

