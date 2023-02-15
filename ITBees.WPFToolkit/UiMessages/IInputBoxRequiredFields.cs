using CommunityToolkit.Mvvm.Input;

namespace ITBees.WPFToolkit.UiMessages
{
    public interface IInputBoxRequiredFields
    {
        string InputBoxTitle { get; set; }
        string SaveButtonTitle { get; set; }
        string CancelButtonTitle { get; set; }
        string InputBoxMessage { get; set; }
        string InputValue { get; set; }
        RelayCommand CancelButtonCommand { get; set; }
        RelayCommand SaveButtonCommand { get; set; }
        RelayCommand InputBoxKeyReturnCommand { get; set; }
        RelayCommand InputBoxKeyEscapeCommand { get; set; }
    }
}