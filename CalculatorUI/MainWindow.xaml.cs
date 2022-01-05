using System;
using System.Windows;
using nsCalculator;
using nsOperations;
using nsResultNumber;
using nsDisplayNumber;

namespace CalculatorUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeSymbols();
            InitializeCalculator();
        }

        public void InitializeSymbols()
        {
            BackspaceBtn.Content = "\u232B";
            PlusBtn.Content = new Sum().GetOperationData().symbol;
            MinusBtn.Content = new Substract().GetOperationData().symbol;
            DivideBtn.Content = new Division().GetOperationData().symbol;
            TimesBtn.Content = new Multiply().GetOperationData().symbol;
            SqrtBtn.Content = new Sqrt().GetOperationData().symbol;
            PowBtn.Content = new Pow().GetOperationData().symbol;
            EqualBtn.Content = new Equals().GetOperationData().symbol;
        }

        public void InitializeCalculator()
        {
            var textBoxResult = new ResultNumber();
            var displayNumber = new DisplayNumber();
            this._calculator = new Calculator(ref textBoxResult, ref displayNumber);
        }

        private void OneBtn_Click(object sender, RoutedEventArgs e)
        {
            PressChar(OneBtn.Content);
            UpdateTextBox();
        }

        private void TwoBtn_Click(object sender, RoutedEventArgs e)
        {
            PressChar(TwoBtn.Content);
            UpdateTextBox();
        }

        private void ThreeBtn_Click(object sender, RoutedEventArgs e)
        {
            PressChar(ThreeBtn.Content);
            UpdateTextBox();
        }

        private void FourBtn_Click(object sender, RoutedEventArgs e)
        {
            PressChar(FourBtn.Content);
            UpdateTextBox();
        }

        private void FiveBtn_Click(object sender, RoutedEventArgs e)
        {
            PressChar(FiveBtn.Content);
            UpdateTextBox();
        }

        private void SixBtn_Click(object sender, RoutedEventArgs e)
        {
            PressChar(SixBtn.Content);
            UpdateTextBox();
        }

        private void SevenBtn_Click(object sender, RoutedEventArgs e)
        {
            PressChar(SevenBtn.Content);
            UpdateTextBox();
        }

        private void EightBtn_Click(object sender, RoutedEventArgs e)
        {
            PressChar(EightBtn.Content);
            UpdateTextBox();
        }

        private void NineBtn_Click(object sender, RoutedEventArgs e)
        {
            PressChar(NineBtn.Content);
            UpdateTextBox();
        }

        private void ZeroBtn_Click(object sender, RoutedEventArgs e)
        {
            PressChar(ZeroBtn.Content);
            UpdateTextBox();
        }

        private void CommaBtn_Click(object sender, RoutedEventArgs e)
        {
            _calculator.DecimalComma();
            UpdateTextBox();
        }

        private void PressOperation(Operations operation)
        {
            var preResult = _calculator.GetResult();
            _calculator.Calculate(operation);
            var result = _calculator.GetResult();
            var displayNumber = _calculator.GetDisplayNumber();
            var display = operation.GetOperationData()._isResultAffected ? result : displayNumber;
            OutputTextBlock.Text = display;
            UpdateMemory(operation, preResult, result, displayNumber);
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            PressOperation(new Sum());
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            PressOperation(new Substract());
        }

        private void TimesBtn_Click(object sender, RoutedEventArgs e)
        {
            PressOperation(new Multiply());
        }

        private void DivideBtn_Click(object sender, RoutedEventArgs e)
        {
            PressOperation(new Division());
        }

        private void PowBtn_Click(object sender, RoutedEventArgs e)
        {
            PressOperation(new Pow());
        }

        private void SqrtBtn_Click(object sender, RoutedEventArgs e)
        {
            PressOperation(new Sqrt());
        }

        private void EqualBtn_Click(object sender, RoutedEventArgs e)
        {
            PressOperation(new Equals());
        }

        private void BackspaceBtn_Click(object sender, RoutedEventArgs e)
        {
            _calculator.DeleteLastNumber();
            UpdateTextBox();
        }

        private void CBtn_Click(object sender, RoutedEventArgs e)
        {
            _calculator.Reset();
            UpdateTextBox();
            ResetMemoryTextBox();
        }

        private void UpdateTextBox()
        {
            OutputTextBlock.Text = _calculator.GetDisplayNumber();
        }

        public void PressChar(object obj)
        {
            _calculator.PressChar(Convert.ToChar(obj));
        }

        private void ResetMemoryTextBox()
        {
            MemoryTextBox.Text = "";
        }

        private void UpdateMemory(Operations operation, string preResult, string result, string displayNumber)
        {
            if(operation == new Equals())
                MemoryTextBox.Text = preResult + displayNumber + operation.GetOperationData().symbol;
            else
                MemoryTextBox.Text = preResult + operation.GetOperationData().symbol;
        }

        private Calculator _calculator;
    }
}
