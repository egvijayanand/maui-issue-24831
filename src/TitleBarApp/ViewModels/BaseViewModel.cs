namespace TitleBarApp.ViewModels;

public partial class BaseViewModel(IDialogService dialogService,
								   string title = "",
								   string subTitle = "") : ObservableObject
{
    [ObservableProperty]
    private string _title = title;

    [ObservableProperty]
    private string _subTitle = subTitle;

	[RelayCommand]
	private Task OpenAsync() => dialogService.DisplayAlert("Info", "Settings clicked", "OK");
}
