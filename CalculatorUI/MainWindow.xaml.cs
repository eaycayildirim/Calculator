using System;
using System.Windows;
using nsCalculator;
using nsOperations;

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
            this.calculator = new Calculator();
        }

        private Calculator calculator;

        private void OneBtn_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddNumbers(OneBtn.Content.ToString());
            OutputTextBlock.Text = calculator.UpdateNumber();
        }

        private void TwoBtn_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddNumbers(TwoBtn.Content.ToString());
            OutputTextBlock.Text = calculator.UpdateNumber();
        }

        private void ThreeBtn_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddNumbers(ThreeBtn.Content.ToString());
            OutputTextBlock.Text = calculator.UpdateNumber();
        }

        private void FourBtn_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddNumbers(FourBtn.Content.ToString());
            OutputTextBlock.Text = calculator.UpdateNumber();
        }

        private void FiveBtn_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddNumbers(FiveBtn.Content.ToString());
            OutputTextBlock.Text = calculator.UpdateNumber();
        }

        private void SixBtn_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddNumbers(SixBtn.Content.ToString());
            OutputTextBlock.Text = calculator.UpdateNumber();
        }

        private void SevenBtn_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddNumbers(SevenBtn.Content.ToString());
            OutputTextBlock.Text = calculator.UpdateNumber();
        }

        private void EightBtn_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddNumbers(EightBtn.Content.ToString());
            OutputTextBlock.Text = calculator.UpdateNumber();
        }

        private void NinenBtn_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddNumbers(NinenBtn.Content.ToString());
            OutputTextBlock.Text = calculator.UpdateNumber();
        }

        private void CommaBtn_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddComma();
            OutputTextBlock.Text = calculator.UpdateNumber();
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            
            calculator.SetOperation(new Sum());
            calculator.Calculate();
            OutputTextBlock.Text = calculator.UpdateResult();
            calculator.ResetFirstNumber();
        }


        //TODO: At first it should start with zero
    }
}
