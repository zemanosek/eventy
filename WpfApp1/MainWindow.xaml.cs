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

namespace WpfApp1
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

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Code to handle mouse double click event goes here
            ListBox listBox = (ListBox)sender;
            if (listBox.SelectedItem != null)
            {
                string selectedValue = listBox.SelectedItem.ToString();
                MessageBox.Show("Item double-clicked: " + selectedValue);
            }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Code to handle text changed event goes here
            TextBox textBox = (TextBox)sender;
            string newText = textBox.Text;
            MessageBox.Show("Text changed to: " + newText);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Code to handle button click event goes here
            MessageBox.Show("Button clicked!");
        }
    }
}
