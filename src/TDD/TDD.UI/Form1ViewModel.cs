using System;
using System.ComponentModel;

namespace TDD.UI
{
    public sealed class Form1ViewModel : INotifyPropertyChanged
    {
        //private System.Windows.Forms.Button CalculationButton;

        private string _aTextBoxText = string.Empty;
        public string ATextBoxText
        {
            get { return _aTextBoxText; }
            set
            {
                if (_aTextBoxText == value)
                {
                    return;
                }

                _aTextBoxText = value;
                OnPropertyChanged("ATextBoxText");
            }
        }

        private string _bTextBoxText = string.Empty;
        public string BTextBoxText
        {
            get { return _bTextBoxText; }
            set
            {
                if (_bTextBoxText == value)
                {
                    return;
                }

                _bTextBoxText = value;
                OnPropertyChanged("BTextBoxText");
            }
        }

        private string _resultLabelText = string.Empty;
        public string ResultLabelText
        {
            get { return _resultLabelText; }
            set
            {
                if (_resultLabelText == value)
                {
                    return;
                }

                _resultLabelText = value;
                OnPropertyChanged("ResultLabelText");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void CalculationAction()
        {
            int a = Convert.ToInt32(ATextBoxText);
            int b = Convert.ToInt32(BTextBoxText);

            ResultLabelText = Calculation.Sum(a, b).ToString();
        }
    }
}
