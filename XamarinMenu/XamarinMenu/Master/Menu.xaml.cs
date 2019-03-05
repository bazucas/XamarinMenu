using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMenu.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void GoProfilePage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pages.Profile1());
            IsPresented = false;
        }

        private void GoXamarinPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pages.Xamarin());
            IsPresented = false;
        }
    }
}