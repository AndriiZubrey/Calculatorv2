using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorMVC.Controllers;
using CalculatorMVC.Models;

namespace CalculatorMVC.Views
{
    public partial class MainForm : Form
    {
        private readonly CalculatorController _controller;
        public MainForm()
        {
            InitializeComponent();
            CalculatorModel model = new CalculatorModel();
            _controller = new CalculatorController(model);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CalculateAndDisplayResult("add");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            CalculateAndDisplayResult("subtract");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            CalculateAndDisplayResult("multiply");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            CalculateAndDisplayResult("divide");
        }

        private void CalculateAndDisplayResult(string operation)
        {
            try
            {
                double a = Convert.ToDouble(txtValueA.Text);
                double b = Convert.ToDouble(txtValueB.Text);
                double result = _controller.PerformOperation(operation, a, b);
                lblResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введіть числові значення!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }
    }
}
