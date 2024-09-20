namespace TitleBarApp.Services;

public interface IDialogService
{
    Task DisplayAlert(string title, string message, string cancel);
}
