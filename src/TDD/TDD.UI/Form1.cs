﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CalculationButton_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(ATextBox.Text);
            int b = Convert.ToInt32(BTextBox.Text);

            ResultLabel.Text = Calculation.Sum(a, b).ToString();
        }
    }
}
