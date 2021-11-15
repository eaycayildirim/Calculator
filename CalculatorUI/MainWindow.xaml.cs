using System;
using System.Windows;
using nsCalculator;
using nsOperations;
using nsTextBoxResult;
using nsDisplayNumber;
using nsIOperations;

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

            DivideBtn.Content = "\u00F7";
            SqrtBtn.Content = "\u221A";
            PowBtn.Content = "x\u00B2";
            BackspaceBtn.Content = "\u232B";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this._calculator = new Calculator(new TextBoxResult(), new DisplayNumber());
        }

        private void OneBtn_Click(object sender, RoutedEventArgs e)
        {
            AddChar(OneBtn.Content);
            UpdateTextBox();
        }

        private void TwoBtn_Click(object sender, RoutedEventArgs e)
        {
            AddChar(TwoBtn.Content);
            UpdateTextBox();
        }

        private void ThreeBtn_Click(object sender, RoutedEventArgs e)
        {
            AddChar(ThreeBtn.Content);
            UpdateTextBox();
        }

        private void FourBtn_Click(object sender, RoutedEventArgs e)
        {
            AddChar(FourBtn.Content);
            UpdateTextBox();
        }

        private void FiveBtn_Click(object sender, RoutedEventArgs e)
        {
            AddChar(FiveBtn.Content);
            UpdateTextBox();
        }

        private void SixBtn_Click(object sender, RoutedEventArgs e)
        {
            AddChar(SixBtn.Content);
            UpdateTextBox();
        }

        private void SevenBtn_Click(object sender, RoutedEventArgs e)
        {
            AddChar(SevenBtn.Content);
            UpdateTextBox();
        }

        private void EightBtn_Click(object sender, RoutedEventArgs e)
        {
            AddChar(EightBtn.Content);
            UpdateTextBox();
        }

        private void NineBtn_Click(object sender, RoutedEventArgs e)
        {
            AddChar(NineBtn.Content);
            UpdateTextBox();
        }

        private void ZeroBtn_Click(object sender, RoutedEventArgs e)
        {
            AddChar(ZeroBtn.Content);
            UpdateTextBox();
        }

        private void CommaBtn_Click(object sender, RoutedEventArgs e)
        {
            _calculator.DecimalComma();
            UpdateTextBox();
        }

        private void OperationChanged(IOperations operation)
        {
            _calculator.Calculate();
            _calculator.SetOperation(operation);
            OutputTextBlock.Text = _calculator.GetResult();
            _calculator.ResetDisplayNumber();
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            OperationChanged(new Sum());
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            OperationChanged(new Substract());
        }

        private void TimesBtn_Click(object sender, RoutedEventArgs e)
        {
            OperationChanged(new Multiply());
        }

        private void DivideBtn_Click(object sender, RoutedEventArgs e)
        {
            OperationChanged(new Division());
        }

        private void PowBtn_Click(object sender, RoutedEventArgs e)
        {
            OperationChanged(new Pow());
        }

        private void SqrtBtn_Click(object sender, RoutedEventArgs e)
        {
            OperationChanged(new Sqrt());
        }

        private void BackspaceBtn_Click(object sender, RoutedEventArgs e)
        {
            _calculator.Delete();
            UpdateTextBox();
        }

        private void CBtn_Click(object sender, RoutedEventArgs e)
        {
            _calculator.Reset();
            UpdateTextBox();
        }

        private void UpdateTextBox()
        {
            OutputTextBlock.Text = _calculator.GetDisplayNumber();
        }

        private void AddChar(object input)
        {
            _calculator.AddChar(Convert.ToChar(input));
        }

        private Calculator _calculator;
    }
}
