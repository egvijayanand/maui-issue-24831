using System.Reflection;

namespace TitleBarApp.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
        VersionLabel.Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}";
    }
}
