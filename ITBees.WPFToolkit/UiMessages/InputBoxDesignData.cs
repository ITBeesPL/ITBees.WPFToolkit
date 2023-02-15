using CommunityToolkit.Mvvm.Input;

namespace ITBees.WPFToolkit.UiMessages
{
    public class InputBoxDesignData : IInputBoxRequiredFields
    {
        public string InputBoxTitle { get; set; } = "Entering default value";
        public string SaveButtonTitle { get; set; } = "Save";
        public string CancelButtonTitle { get; set; } = "Cancel";
        public string InputBoxMessage { get; set; } = "Please enter default value for selected field";
        public string InputValue { get; set; } = "123";
        public RelayCommand CancelButtonCommand { get; set; }
        public RelayCommand SaveButtonCommand { get; set; }
        public RelayCommand InputBoxKeyReturnCommand { get; set; }
        public RelayCommand InputBoxKeyEscapeCommand { get; set; }
        public object Icon { get; }
    }
}