using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MyFirstApp
{ 
    public sealed partial class Page2 : Page
    {
        public Page2()
        {
            this.InitializeComponent();
        }

        private void btn_Volver_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
