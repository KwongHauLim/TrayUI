using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using TrayUI;

namespace Sample;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private Window Window { get; set; }
    private void Application_Startup(object sender, StartupEventArgs e)
    {
        Window win = new Window();
        var Tray = new Icon();
        var uri = new Uri("pack://application:,,,/icon.png", UriKind.Absolute);
        Tray.SetIcon(uri);
        Tray.AddMenu("Menu Exit", new Image { Source = new BitmapImage(new Uri("pack://application:,,,/icon-exit.png", UriKind.Absolute)), Width = 16, Height = 16 }, Shutdown);

        win = NoWindow.Create(Tray);
    }
}
