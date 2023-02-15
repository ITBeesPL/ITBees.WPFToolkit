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
using ITBees.WpfToolkit.UiMessages;

namespace ITBees.WPFToolkit.Presentation
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Uri iconUri = new Uri("pack://application:,,,/ITBees.WPFToolkit.Presentation;component/ITBeesOOPLogo.ico");
            var icon = BitmapFrame.Create(iconUri);
            icon = null;

            var inputBox = new InputBox("Test title", "Test input box message", "Save", "Cancel", 123.42m.ToString(), icon);
            if (inputBox.ShowDialog() == true)
            {
                MessageBox.Show($"Dialog result = {inputBox.InputValue}");
            }
            else
            {
                MessageBox.Show($"Dialog result - cancel");
            }
        }
    }
}
