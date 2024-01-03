using System;
using System.ComponentModel;

namespace TDD.UI
{
    public sealed class Form1ViewModel : INotifyPropertyChanged
    {
        private IDB _db;

        private string _aTextBoxText = string.Empty;
        public Form1ViewModel(IDB db)
        {
            _db = db;
        }

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
                OnPropertyChanged(nameof(ATextBoxText));
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
                OnPropertyChanged(nameof(BTextBoxText));
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
                OnPropertyChanged(nameof(ResultLabelText));
            }
        }

        private string _productIdTextBoxText = string.Empty;
        public string ProductIdTextBoxText
        {
            get { return _productIdTextBoxText; }
            set
            {
                if (_productIdTextBoxText == value)
                {
                    return;
                }

                _productIdTextBoxText = value;
                OnPropertyChanged(nameof(ProductIdTextBoxText));
            }
        }

        private string _productNameTextBoxText = string.Empty;
        public string ProductNameTextBoxText
        {
            get { return _productNameTextBoxText; }
            set
            {
                if (_productNameTextBoxText == value)
                {
                    return;
                }

                _productNameTextBoxText = value;
                OnPropertyChanged(nameof(ProductNameTextBoxText));
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

            int dbValue = _db.GetDBValue();
            ResultLabelText = (Calculation.Sum(a, b) + dbValue).ToString();
        }

        public void ProductCommand()
        {
            var p = _db.GetProduct();
            ProductIdTextBoxText = p.ProductId.ToString();
            ProductNameTextBoxText = p.ProductName;
        }
    }
}
