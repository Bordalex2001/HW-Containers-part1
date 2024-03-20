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

namespace HW_Containers__part_1_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        private readonly Presenter _presenter;

        public MainWindow()
        {
            InitializeComponent();
            _presenter = new Presenter(new Model(), this);
        }

        public event EventHandler<string> IsCodeEntered;

        private void DigitBtn_Click(object sender, RoutedEventArgs e)
        {
            string digit = ((Button)sender).Content.ToString();
            codeTxtBox.Text += digit;
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            codeTxtBox.Text = string.Empty;
        }

        private void OKBtn_Click(object sender, RoutedEventArgs e)
        {
            _presenter.CheckCode(codeTxtBox.Text);
            codeTxtBox.Text = string.Empty;
        }

        public void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}