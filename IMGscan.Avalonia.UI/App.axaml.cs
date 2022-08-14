using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using IMGscan.Avalonia.UI.ViewModels;
using IMGscan.Avalonia.UI.Views;
using IMGscan.WPF.UI.ViewModels;

namespace IMGscan.Avalonia.UI
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainVeiwModels(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}