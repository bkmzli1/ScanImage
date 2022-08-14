using IMGscan.WPF.UI.ViewModels;

namespace IMGscan.WPF.UI
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainVeiwModels();
        }
    }
}