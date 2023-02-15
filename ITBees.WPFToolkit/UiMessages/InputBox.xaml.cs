using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using CommunityToolkit.Mvvm.Input;
using ITBees.WPFToolkit;
using ITBees.WPFToolkit.UiMessages;

namespace ITBees.WpfToolkit.UiMessages
{
    /// <summary>
    /// Interaction logic for InputBox.xaml
    /// </summary>
    public partial class InputBox : Window, IInputBoxRequiredFields
    {
        public InputBox()
        {
            InitializeComponent();
        }

        public InputBox(string inputBoxTitle, string inputBoxMessage, string saveButtonTitle, string cancelButtonTitle,
            string defaultValue, BitmapFrame icon = null)
        {
            InitializeComponent();
            InputBoxTitle = inputBoxTitle;
            InputBoxMessage = inputBoxMessage;
            SaveButtonTitle = saveButtonTitle;
            CancelButtonTitle = cancelButtonTitle;
            InputValue = defaultValue;
            CancelButtonCommand = new RelayCommand(CancelButtonClicked, () => true);
            SaveButtonCommand = new RelayCommand(SaveButtonClicked, () => true);
            InputBoxKeyReturnCommand = new RelayCommand(InputBoxKeyReturnPressed, () => true);
            InputBoxKeyEscapeCommand = new RelayCommand(InputBoxKeyEscapePressed, () => true);
            this.DataContext = this;
            if (icon == null)
            {
                Icon = BitmapFrame.Create(new MemoryStream(Resource.Question));
            }
            else
            {
                Icon = icon;
            }
        }

        private void InputBoxKeyEscapePressed()
        {
            this.DialogResult = false;
        }

        private void InputBoxKeyReturnPressed()
        {
            if (string.IsNullOrEmpty(InputValue) == false)
            {
                this.DialogResult = true;
            }
        }

        private void SaveButtonClicked()
        {
            this.DialogResult = true;
        }

        private void CancelButtonClicked()
        {
            this.DialogResult = false;
        }

        public string InputBoxTitle { get; set; }
        public string SaveButtonTitle { get; set; }
        public string CancelButtonTitle { get; set; }
        public string InputBoxMessage { get; set; }
        public string InputValue { get; set; }
        public RelayCommand CancelButtonCommand { get; set; }
        public RelayCommand SaveButtonCommand { get; set; }
        public RelayCommand InputBoxKeyReturnCommand { get; set; }
        public RelayCommand InputBoxKeyEscapeCommand { get; set; }

        private void InputBox_OnActivated(object? sender, EventArgs e)
        {
            InputBoxValue.SelectAll();
            InputBoxValue.Focus();
        }
    }
}
