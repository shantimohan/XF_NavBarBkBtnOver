using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_NavBarBkBtnOver
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            //TODO: Changes as per JarvanZhang-MSFT in
            //https://docs.microsoft.com/en-us/answers/questions/401635/setting-toolbar-to-link-nav-bar-back-button-overri.html
            //NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}