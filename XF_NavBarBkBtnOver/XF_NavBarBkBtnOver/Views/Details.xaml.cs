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
                        await Navigation.PopAsync(true);
                };
            }
        }
    }
}