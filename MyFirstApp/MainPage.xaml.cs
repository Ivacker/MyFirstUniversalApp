using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MyFirstApp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_Avanzar_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page2));
        }
    }
}
