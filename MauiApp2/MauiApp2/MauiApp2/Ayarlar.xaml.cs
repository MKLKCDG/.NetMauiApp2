using Microsoft.Maui.Controls;

namespace MauiApp2
{
    public partial class Ayarlar : ContentPage
    {
        public AyarlarViewModel ViewModel { get; set; }

        public Ayarlar()
        {
            InitializeComponent();
            ViewModel = new AyarlarViewModel();
            BindingContext = ViewModel;
        }
    }

    public class AyarlarViewModel : BindableObject
    {
        private bool isDarkMode;

        public bool IsDarkMode
        {
            get => isDarkMode;
            set
            {
                if (isDarkMode != value)
                {
                    isDarkMode = value;
                    OnPropertyChanged();
                    ApplyTheme();
                }
            }
        }

        public AyarlarViewModel()
        {
            // Varsayýlan olarak tema ayarýný oku
            isDarkMode = Application.Current.UserAppTheme == AppTheme.Dark;
        }

        private void ApplyTheme()
        {
            Application.Current.UserAppTheme = IsDarkMode ? AppTheme.Dark : AppTheme.Light;
        }
    }
}
