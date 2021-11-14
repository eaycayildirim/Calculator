using System;
using System.Windows;
using nsCalculator;
using nsOperations;
using nsTextBoxResult;
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

            DivideBtn.Content = "\u00F7";
            SqrtBtn.Content = "\u221A";
            PowBtn.Content = "x\u00B2";
            BackspaceBtn.Content = "\u232B";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.calculator = new Calculator(new TextBoxResult(), new DisplayNumber());
        }

        private void OneBtn_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddChar(Convert.ToChar(OneBtn.Content));
            OutputTextBlock.Text = calculator.GetDisplayNumber();
        }

        private void TwoBtn_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddChar(Convert.ToChar(TwoBtn.Content));
            OutputTextBlock.Text = calculator.GetDisplayNumber();
        }

        private void ThreeBtn_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddChar(Convert.ToChar(ThreeBtn.Content));
            OutputTextBlock.Text = calculator.GetDisplayNumber();
        }

        private void FourBtn_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddChar(Convert.ToChar(FourBtn.Content));
            OutputTextBlock.Text = calculator.GetDisplayNumber();
        }

        private void FiveBtn_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddChar(Convert.ToChar(FiveBtn.Content));
            OutputTextBlock.Text = calculator.GetDisplayNumber();
        }

        private void SixBtn_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddChar(Convert.ToChar(SixBtn.Content));
            OutputTextBlock.Text = calculator.GetDisplayNumber();
        }

        private void SevenBtn_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddChar(Convert.ToChar(SevenBtn.Content));
            OutputTextBlock.Text = calculator.GetDisplayNumber();
        }

        private void EightBtn_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddChar(Convert.ToChar(EightBtn.Content));
            OutputTextBlock.Text = calculator.GetDisplayNumber();
        }

        private void NinenBtn_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddChar(Convert.ToChar(NinenBtn.Content));
            OutputTextBlock.Text = calculator.GetDisplayNumber();
        }

        private void CommaBtn_Click(object sender, RoutedEventArgs e)
        {
            calculator.DecimalComma();
            OutputTextBlock.Text = calculator.GetDisplayNumber();
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            
            calculator.SetOperation(new Sum());
            calculator.Calculate();
            OutputTextBlock.Text = calculator.GetResult();
            //calculator.ResetFirstNumber();
        }

        private Calculator calculator;
    }
}
