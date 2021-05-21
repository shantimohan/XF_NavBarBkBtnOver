using System;
using Xamarin.Forms;

/*
 * Override Navigation Bar Back Button Click
 * Ref: https://theconfuzedsourcecode.wordpress.com/2017/03/12/lets-override-navigation-bar-back-button-click-in-xamarin-forms/comment-page-1/#comment-1167
 * 
 * In Common Project:
 * 1. Add this class, BackButtonCustomActionPage
 * 2. In the page where the nav bar's back button is to be caught:
 *     a) Define: xmlns:local="clr-namespace:<common-project-name>"
 *     b) Define the page as <local:BackButtonCustomActionPage></local:BackButtonCustomActionPage>
 *     c) Change the derived class in xaml.cs to ": BackButtonCustomActionPage"
 *     d) Set the page attribute EnableBackButtonOverride="True"
 * 
 * In Android Project:
 * 1. Add the following lines at the end of OnCreate method in MainActivity.cs:
            // Setup toolbar to link back button override action
            Android.Support.V7.Widget.Toolbar toolbar
                = this.FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
 * 2. Add the code of the following two override methods in MainActivity.cs:
 *     public override bool OnOptionsItemSelected(IMenuItem item) {...}
 *     public override void OnBackPressed() {...}
 * 
 * In iOS Project:
 * 1. Add the class BackButtonCustomActionPageRenderer
 * 2. Add the iosbackarrow@2x.png to Resoureces of iOS project
*/

namespace XF_NavBarBkBtnOver
{
    public class BackButtonCustomActionPage : ContentPage
    {
        // Gets or setsthe Back Button click override custom action
        public Action CustomBackButtonAction { get; set; }

        public static readonly BindableProperty EnableBackButtonOverrideProperty =
            BindableProperty.Create(
                nameof(EnableBackButtonOverride),
                typeof(bool),
                typeof(BackButtonCustomActionPage),
                false);

        // Gets or sets Custom Back Button Override state
        public bool EnableBackButtonOverride
        {
            get
            {
                return (bool)GetValue(EnableBackButtonOverrideProperty);
            }
            set
            {
                SetValue(EnableBackButtonOverrideProperty, value);
            }
        }

    }
}
