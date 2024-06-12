using Microsoft.Maui.Controls;

namespace MauiApp2
{
    public partial class NewsDetailPage : ContentPage
    {
        public NewsDetailPage(string url)
        {
            InitializeComponent();
            webView.Source = url;
        }

        private async void ShareNews_Clicked(object sender, EventArgs e)
        {
            // Paylaþým iþlemleri
        }
    }
}
