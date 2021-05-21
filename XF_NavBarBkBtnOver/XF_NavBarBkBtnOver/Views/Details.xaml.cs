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
    public partial class Details : BackButtonCustomActionPage
    {
        public Details()
        {
            InitializeComponent();

            if (EnableBackButtonOverride)
            {
                this.CustomBackButtonAction = async () =>
                {
                    var result = await this.DisplayAlert(null,
                        "Hey wait now! Are you sure you want to go back?",
                        "Yes go back", "Nope");

                    if (result)
                        //TODO: Changes as per JarvanZhang-MSFT in
                        //https://docs.microsoft.com/en-us/answers/questions/401635/setting-toolbar-to-link-nav-bar-back-button-overri.html
                        //await Navigation.PopAsync(true);
                        await Navigation.PopModalAsync();
                };
            }
        }

        //TODO: Changes as per JarvanZhang-MSFT in
        //https://docs.microsoft.com/en-us/answers/questions/401635/setting-toolbar-to-link-nav-bar-back-button-overri.html
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            this.CustomBackButtonAction.Invoke();
        }

        // This override handler is needed to cater to the hardware back button
        protected override bool OnBackButtonPressed()
        {
            this.CustomBackButtonAction.Invoke();
            return true;
        }
    }
}