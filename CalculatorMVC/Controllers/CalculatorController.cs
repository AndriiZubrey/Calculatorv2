using CalculatorMVC.Models;
using System;

namespace CalculatorMVC.Controllers
{
    public class CalculatorController
    {
        private readonly CalculatorModel _model;

        public CalculatorController(CalculatorModel model)
        {
            _model = model;
        }

        // Виконує операцію відповідно до ключового слова "operation"
        public double PerformOperation(string operation, double a, double b)
        {
            return operation.ToLower() switch
            {
                "add" => _model.Add(a, b),
                "subtract" => _model.Subtract(a, b),
                "multiply" => _model.Multiply(a, b),
                "divide" => _model.Divide(a, b),
                _ => throw new InvalidOperationException("Невідома операція"),
            };
        }
    }
}
