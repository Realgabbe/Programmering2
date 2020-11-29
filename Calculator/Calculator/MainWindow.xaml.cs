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

        long number1 = 0; // Ska lagra information tillfälligt för att sedan skickas till displayen
        long number2 = 0; // Ska lagra information tillfälligt för att sedan skickas till displayen 
        string operation = ""; // String för att lagra vilken typ av operation som användaren väljer. Operationer är t.ex "+", "-" & "x^2"
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Execute_Click(object sender, RoutedEventArgs e)
        {
            switch (operation) // Denna switchen är baserad på vad stringen "operation" har för värde. Om stringen "operation" t.ex har värdet "+" så kommer den att hoppa till + casen
            {
                case "+":
                    result_window.Text = (number1 + number2).ToString();
                    break;

                case "-":
                    result_window.Text = (number1 - number2).ToString();
                    break;

                case "*":
                    result_window.Text = (number1 + number2).ToString();
                    break;

                case "/":
                    result_window.Text = (number1 / number2).ToString();
                    break;

                case "x^2":
                    result_window.Text = (number1 * number1).ToString();
                    break;

                case "squareRoot":
                    result_window.Text = (Math.Sqrt(number1)).ToString();
                    break;

                case "numlock":
                    result_window.Text = "numlock";
                    break;
            }
        }

        private void button_Plus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            result_window.Text = "0";
        }

        private void button_Zero_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                result_window.Text = number1.ToString();
            }

            else
            {
                number2 = (number2 * 10);
                result_window.Text = number2.ToString();
            }

        }

        private void button_One_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                result_window.Text = number1.ToString();
            }

            else
            {
                number2 = (number2 * 10) + 1;
                result_window.Text = number2.ToString();
            }

        }

        private void button_Two_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                result_window.Text = number1.ToString();
            }

            else
            {
                number2 = (number2 * 10) + 2;
                result_window.Text = number2.ToString();
            }
        }

        private void button_Three_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                result_window.Text = number1.ToString();
            }

            else
            {
                number2 = (number2 * 10) + 3;
                result_window.Text = number2.ToString();
            }

        }

        private void button_Minus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            result_window.Text = "0";
        }

        private void button_Four_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                result_window.Text = number1.ToString();
            }

            else
            {
                number2 = (number2 * 10) + 4;
                result_window.Text = number2.ToString();
            }

        }

        private void button_Five_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                result_window.Text = number1.ToString();
            }

            else
            {
                number2 = (number2 * 10) + 5;
                result_window.Text = number2.ToString();
            }

        }

        private void button_Six_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                result_window.Text = number1.ToString();
            }

            else
            {
                number2 = (number2 * 10) + 6;
                result_window.Text = number2.ToString();
            }

        }

        private void button_Multiplication_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            result_window.Text = "0";
        }

        private void button_Seven_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                result_window.Text = number1.ToString();
            }

            else
            {
                number2 = (number2 * 10) + 7;
                result_window.Text = number2.ToString();
            }

        }

        private void button_Eight_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                result_window.Text = number1.ToString();
            }

            else
            {
                number2 = (number2 * 10) + 8;
                result_window.Text = number2.ToString();
            }

        }

        private void button_Nine_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                result_window.Text = number1.ToString();
            }

            else
            {
                number2 = (number2 * 10) + 9;
                result_window.Text = number2.ToString();
            }

        }

        private void button_Division_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            result_window.Text = "0";
        }

        private void button_Clear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            result_window.Text = "0";
        }

        private void button_squareRoot_Click(object sender, RoutedEventArgs e)
        {
            operation = "squareRoot";
        }

        private void button_PowerOf_Click(object sender, RoutedEventArgs e)
        {
            operation = "x^2";
        }

        private void button_Numlock_Click(object sender, RoutedEventArgs e)
        {
            operation = "numlock";
        }
    }
}
