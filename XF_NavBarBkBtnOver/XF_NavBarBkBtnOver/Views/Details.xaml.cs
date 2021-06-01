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
    public partial class Details : ContentPage
    {
        public Details()
        {
            InitializeComponent();
        }

        //TODO: Changes as per JarvanZhang-MSFT in
        //https://docs.microsoft.com/en-us/answers/questions/401635/setting-toolbar-to-link-nav-bar-back-button-overri.html
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            CustomBackButtonAction();
        }

        private async void CustomBackButtonAction()
        {
            if (await DisplayAlert(null, "Hey wait now! Are you sure you want to go back?", "Yes go back", "Nope"))
                await Navigation.PopModalAsync();
        }

        // This override handler is needed to cater to the hardware back button
        protected override bool OnBackButtonPressed()
        {
            CustomBackButtonAction();
            return true;
        }
    }
}