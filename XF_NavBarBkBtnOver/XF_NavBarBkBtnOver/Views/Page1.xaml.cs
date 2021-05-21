using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_NavBarBkBtnOver.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private  async void AddItem_Clicked(object sender, EventArgs e)
        {
            //TODO: Changes as per JarvanZhang-MSFT in
            //https://docs.microsoft.com/en-us/answers/questions/401635/setting-toolbar-to-link-nav-bar-back-button-overri.html
            //await Navigation.PushAsync(new Details());
            await Navigation.PushModalAsync(new NavigationPage(new Details()));
        }
    }
}