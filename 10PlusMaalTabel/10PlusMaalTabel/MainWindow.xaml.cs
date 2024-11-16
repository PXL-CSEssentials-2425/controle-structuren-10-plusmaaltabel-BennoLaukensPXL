using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace _10PlusMaalTabel
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
        StringBuilder sb = new StringBuilder();

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(maximumValueTextBox.Text, out int maxValue);
            if (maxValue < 1 || maxValue > 20)
            {
                resultTextBox.Text = $"Geeft een getal tussen 1 en 20";
            }
            else
            {
                for (int row = 0; row <= maxValue; row++)
                {
                    for (int col = 0; col <= maxValue; col++)
                    {
                        if (row == 0)
                        {
                            if (col == 0)
                            {
                                sb.Append($"\t");
                            }
                            else
                            {
                                sb.Append($"{col}\t");
                            }
                        }
                        else if (col == 0)
                        {
                            sb.Append($"{row}\t");
                        }
                        else
                        {
                            sb.Append($"{row + col}\t");
                        }
                    }
                    sb.AppendLine();
                }
                resultTextBox.Text = sb.ToString();
                sb.Clear();
            }
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(maximumValueTextBox.Text, out int maxValue);
            if (maxValue < 1 || maxValue > 20)
            {
                resultTextBox.Text = $"Geeft een getal tussen 1 en 20";
            }
            else
            {
                for (int row = 0; row <= maxValue; row++)
                {
                    for (int col = 0; col <= maxValue; col++)
                    {
                        if (row == 0)
                        {
                            if (col == 0)
                            {
                                sb.Append($"\t");
                            }
                            else
                            {
                                sb.Append($"{col}\t");
                            }
                        }
                        else if (col == 0)
                        {
                            sb.Append($"{row}\t");
                        }
                        else
                        {
                            sb.Append($"{row*col}\t");
                        }
                    }
                    sb.AppendLine();
                }
                resultTextBox.Text = sb.ToString();
                sb.Clear();
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            maximumValueTextBox.Text = $"10";
            maximumValueTextBox.Focus();
            resultTextBox.Text = string.Empty;
            
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
