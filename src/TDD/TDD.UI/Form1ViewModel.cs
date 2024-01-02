using System;

namespace TDD.UI
{
    public sealed class Form1ViewModel
    {
        //private System.Windows.Forms.Button CalculationButton;

        public string ATextBoxText { get; set; } = string.Empty;
        public string BTextBoxText { get; set; } = string.Empty;
        public string ResultLabelText { get; set; } = string.Empty;

        public void CalculationAction()
        {
            int a = Convert.ToInt32(ATextBoxText);
            int b = Convert.ToInt32(BTextBoxText);

            ResultLabelText = Calculation.Sum(a, b).ToString();
        }
    }
}
