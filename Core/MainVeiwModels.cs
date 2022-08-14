using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace IMGscan.WPF.UI.ViewModels
{
    public class MainVeiwModels : INotifyPropertyChanged
    {
        private string _mainDiskName;

        public string MainDiskName
        {
            get => _mainDiskName;
            set
            {
                _mainDiskName = value;
                OnPropertyChanged(nameof(MainDiskName));
            }
        }

        public MainVeiwModels()
        {
            MainDiskName = Environment.SystemDirectory;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}