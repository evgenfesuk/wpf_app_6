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


namespace WpfApp_6._06
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
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

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            if ((nameTextBox.Text != "") && (snameTextBox.Text != "") && (salaryTextBox.Text != ""))
            {
                textBlock1.Text += nameTextBox.Text + " " + snameTextBox.Text + ". Зарплата: $" + salaryTextBox.Text + " Дата зачисления: " 
                                + calendar1.SelectedDate.ToString() + Environment.NewLine;
            }
            if (nameTextBox.Text == "") nameTextBox.Background = new SolidColorBrush(Colors.Red);
            if (snameTextBox.Text == "") snameTextBox.Background = new SolidColorBrush(Colors.Red);
            if (salaryTextBox.Text == "") salaryTextBox.Background = new SolidColorBrush(Colors.Red);
        }


        private void nameTextBox_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            nameTextBox.Background = new SolidColorBrush(Colors.White);
        }

        private void snameTextBox_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            snameTextBox.Background = new SolidColorBrush(Colors.White);
        }

        private void salaryTextBox_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            salaryTextBox.Background = new SolidColorBrush(Colors.White);
        }


    }
}
