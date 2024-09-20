namespace TitleBarApp.ViewModels;

public partial class MainViewModel(IDialogService dialogService) 
	: BaseViewModel(dialogService, "TitleBarApp", "Preview")
{
	private int _count;

	[ObservableProperty]
	private string _countText = $"Current count: 0";

	[RelayCommand]
	private void Increment()
	{
		_count++;
		CountText = $"Current count: {_count}";
	}
}
