namespace TitleBarApp;

public partial class MainWindow : Window
{
    public MainWindow(IServiceProvider services)
    {
        InitializeComponent();
        BindingContext = services.GetService<MainViewModel>();
        //settings.BindingContext = BindingContext;
    }
}
