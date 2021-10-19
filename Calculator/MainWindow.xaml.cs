using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double Num1 = Convert.ToDouble(num1.Text);
            double Num2 = Convert.ToDouble(num2.Text);

            double answerMult = Num1 * Num2;
            MessageBox.Show("The answer is '" + answerMult + "'");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double Num1 = Convert.ToDouble(num1.Text);
            double Num2 = Convert.ToDouble(num2.Text);

            double answerDiv = Num1 / Num2;
            MessageBox.Show("The answer is '" + answerDiv + "'");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double Num1 = Convert.ToDouble(num1.Text);
            double Num2 = Convert.ToDouble(num2.Text);

            double answerAdd = Num1 + Num2;
            MessageBox.Show("The answer is '" + answerAdd + "'");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double Num1 = Convert.ToDouble(num1.Text);
            double Num2 = Convert.ToDouble(num2.Text);

            double answerSub = Num1 - Num2;
            MessageBox.Show("The answer is '" + answerSub + "'");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("test");
        }

        private void noPress_Click(object sender, RoutedEventArgs e)
        {
            bool a = true;
            while(a=true)
            {
                MessageBox.Show("Troll");
            }
        }
    }
}
