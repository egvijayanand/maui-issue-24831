namespace TitleBarApp.Services;

public partial class MauiDialogService : IDialogService
{
	public Task DisplayAlert(string title, string message, string cancel)
	{
		var page = Application.Current?.Windows?[0].Page;

		return page switch
		{
			Shell => Shell.Current.DisplayAlert(title, message, cancel),
			not null => page.DisplayAlert(title, message, cancel),
			_ => throw new Exception("Page is null.")
		};
	}
}
