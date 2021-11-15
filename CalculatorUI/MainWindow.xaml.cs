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
            _calculator.AddChar(Convert.ToChar(OneBtn.Content));
            OutputTextBlock.Text = _calculator.GetDisplayNumber();
        }

        private void TwoBtn_Click(object sender, RoutedEventArgs e)
        {
            _calculator.AddChar(Convert.ToChar(TwoBtn.Content));
            OutputTextBlock.Text = _calculator.GetDisplayNumber();
        }

        private void ThreeBtn_Click(object sender, RoutedEventArgs e)
        {
            _calculator.AddChar(Convert.ToChar(ThreeBtn.Content));
            OutputTextBlock.Text = _calculator.GetDisplayNumber();
        }

        private void FourBtn_Click(object sender, RoutedEventArgs e)
        {
            _calculator.AddChar(Convert.ToChar(FourBtn.Content));
            OutputTextBlock.Text = _calculator.GetDisplayNumber();
        }

        private void FiveBtn_Click(object sender, RoutedEventArgs e)
        {
            _calculator.AddChar(Convert.ToChar(FiveBtn.Content));
            OutputTextBlock.Text = _calculator.GetDisplayNumber();
        }

        private void SixBtn_Click(object sender, RoutedEventArgs e)
        {
            _calculator.AddChar(Convert.ToChar(SixBtn.Content));
            OutputTextBlock.Text = _calculator.GetDisplayNumber();
        }

        private void SevenBtn_Click(object sender, RoutedEventArgs e)
        {
            _calculator.AddChar(Convert.ToChar(SevenBtn.Content));
            OutputTextBlock.Text = _calculator.GetDisplayNumber();
        }

        private void EightBtn_Click(object sender, RoutedEventArgs e)
        {
            _calculator.AddChar(Convert.ToChar(EightBtn.Content));
            OutputTextBlock.Text = _calculator.GetDisplayNumber();
        }

        private void NinenBtn_Click(object sender, RoutedEventArgs e)
        {
            _calculator.AddChar(Convert.ToChar(NinenBtn.Content));
            OutputTextBlock.Text = _calculator.GetDisplayNumber();
        }

        private void ZeroBtn_Click(object sender, RoutedEventArgs e)
        {
            _calculator.AddChar(Convert.ToChar(ZeroBtn.Content));
            OutputTextBlock.Text = _calculator.GetDisplayNumber();
        }

        private void CommaBtn_Click(object sender, RoutedEventArgs e)
        {
            _calculator.DecimalComma();
            OutputTextBlock.Text = _calculator.GetDisplayNumber();
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
            OutputTextBlock.Text = _calculator.GetDisplayNumber();
        }

        private Calculator _calculator;

        private void CBtn_Click(object sender, RoutedEventArgs e)
        {
            _calculator.Reset();
            OutputTextBlock.Text = _calculator.GetDisplayNumber();
        }
    }
}
