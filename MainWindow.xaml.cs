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

namespace WPF_Tutorial
{

    public partial class MainWindow : Window
    {

        // Defining the varibles to hold our input

        string input = string.Empty;
        string operand_1 = string.Empty;
        string operand_2 = string.Empty;
        char operation;
        double result = 0.0;
        bool operator_is_set = false;
      
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Number_Button_Click(object sender, RoutedEventArgs e)
        {
            operator_is_set = false;
           
            Button b = new Button();
            b = sender as Button;
            string button_number = b.Content.ToString();
            
       switch(button_number)
            {

                case "0":
                    input += "0";
                    output_box.Text += "0";
                    break;
                case "1" : 
                    input += "1";
                    output_box.Text += "1";
                    break;

                case "2":
                    input += "2";
                    output_box.Text += "2";
                    break;

                case "3":
                    input += "3";
                    output_box.Text += "3";
                    break;

                case "4":
                    input += "4";
                    output_box.Text += "4";
                    break;

                case "5":
                    input += "5";
                    output_box.Text += "5";
                    break;

                case "6":
                    input += "6";
                    output_box.Text += "6";
                    break;

                case "7":
                    input += "7";
                    output_box.Text += "7";
                    break;

                case "8":
                    input += "8";
                    output_box.Text += "8";
                    break;

                case "9":
                    input += "9";
                    output_box.Text += "9";
                    break;

                default :
                    break;
                      
            }
            
        }
       


        private void Button_Click_Plus(object sender, RoutedEventArgs e)
       {
           
           
            if(operand_1.Length == 0)
            {
              operand_1 = input;
              input = string.Empty;
              operation = '+';
              output_box.Text += "+";

            }

            if(operand_1.Length !=0 && operator_is_set == false)
            {
                operand_2 = input;
                double num1, num2;
                double.TryParse(operand_1, out num1);
                double.TryParse(operand_2, out num2);
                
                switch(operation)
                {
                    case '+' :
                        result = num1 + num2;
                          break;
                    
                    case '-' :
                          result = num1 - num2;
                          break;

                    case '*':
                          result = num1 * num2;
                          break;

                    case '/':
                          result = num1 / num2;
                          break;
                    
                    default:
                          break;
                }

               
                operation = '+';
                output_box.Text = result.ToString() + operation;
                operand_1 = result.ToString();
                input = string.Empty;
                operator_is_set = true;
               
             }

              }

        private void Button_Click_Minus(object sender, RoutedEventArgs e)
        {
            
            

            if(operand_1.Length == 0)
            {
                operand_1 = input;
                input = string.Empty;
                operation = '-';
                output_box.Text += "-";
            }
            
            if (operand_1.Length != 0 && operator_is_set == false)
            {
                operand_2 = input;
                double num1, num2;
                double.TryParse(operand_1, out num1);
                double.TryParse(operand_2, out num2);

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;

                    case '-':
                        result = num1 - num2;
                        break;

                    case '*':
                        result = num1 * num2;
                        break;

                    case '/':
                        result = num1 / num2;
                        break;

                    default:
                        break;
                }
                operation = '-';
                output_box.Text = result.ToString() + operation;
                operand_1 = result.ToString();
                input = string.Empty;
                operator_is_set = true;
                
            }
        }

        private void Button_Click_Divide(object sender, RoutedEventArgs e)
        {

          
            if (operand_1.Length == 0)
            {
                operand_1 = input;
                input = string.Empty;
                operation = '/';
                output_box.Text += "/";
            }

            if (operand_1.Length != 0 && operator_is_set == false)
            {
                operand_2 = input;
                double num1, num2;
                double.TryParse(operand_1, out num1);
                double.TryParse(operand_2, out num2);

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;

                    case '-':
                        result = num1 - num2;
                        break;

                    case '*':
                        result = num1 * num2;
                        break;

                    case '/':
                         result = num1 / num2;
                        break;

                    default:
                        break;
                }
                
                operation = '/';
                output_box.Text = result.ToString() + operation;
                operand_1 = result.ToString();
                input = string.Empty;
                operator_is_set = true;

            }
        }

        private void Button_Click_Multiply(object sender, RoutedEventArgs e)
        {
            output_box.Text += "*";

            if (operand_1.Length == 0)
            {
                operand_1 = input;
                input = string.Empty;
                operation = '*';
            }

            else
            {
                operand_2 = input;
                double num1, num2;
                double.TryParse(operand_1, out num1);
                double.TryParse(operand_2, out num2);

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;

                    case '-':
                        result = num1 - num2;
                        break;
                    
                    case '*':
                        result = num1 * num2;
                        break;

                    case '/':
                        result = num1 / num2;
                        break;

                    default:
                        break;
                }
                operation = '*';
                output_box.Text = result.ToString() + operation;
                operand_1 = result.ToString();
                input = string.Empty;

            }
        }

        private void Result_click(object sender, RoutedEventArgs e)
        {
            double num1, num2;
            double.TryParse(operand_1, out num1);
            double.TryParse(input, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                output_box.Text = result.ToString();
            }

            if (operation == '-')
            {
                result = num1 - num2;
                output_box.Text = result.ToString();
            }

            if (operation == '/')
            {
                if(num2 != 0) 
                {
                 result = num1 / num2;
                 output_box.Text = result.ToString();
                }
              
                else
                {
                    output_box.Text = "Nan";
                }
            }

            if (operation == '*')
            {
                result = num1 * num2;
                output_box.Text = result.ToString();
            }

        }

        private void Off_Click_1(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("You clicked me at ");

        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {

            this.output_box.Text = "";
            this.input = string.Empty;
            this.operand_1 = string.Empty;
            this.operand_2 = string.Empty;
       }

        private void R_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("You clicked me at ");

        }


    }
}