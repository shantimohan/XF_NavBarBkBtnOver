using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_NavBarBkBtnOver
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //TODO: Changes as per JarvanZhang-MSFT in
            //https://docs.microsoft.com/en-us/answers/questions/401635/setting-toolbar-to-link-nav-bar-back-button-overri.html
            //MainPage = new NavigationPage(new MainPage());
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
