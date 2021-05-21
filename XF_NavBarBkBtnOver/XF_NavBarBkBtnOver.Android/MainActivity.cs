﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using System.Linq;
using Android.Views;

namespace XF_NavBarBkBtnOver.Droid
{
    [Activity(Label = "XF_NavBarBkBtnOver", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            // Setup toolbar to link back button override action
            AndroidX.AppCompat.Widget.Toolbar toolbar
                = this.FindViewById<AndroidX.AppCompat.Widget.Toolbar>(Resource.Id.toolbar);
            //SetSupportActionBar(toolbar);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        //public override bool OnOptionsItemSelected(IMenuItem item)
        //{
        //    // check if the current item id 
        //    // is equals to the back button id
        //    if (item.ItemId == 16908332) // xam forms nav bar back button id
        //    {
        //        // retrieve the current xamarin 
        //        // forms page instance

        //        // Note: As suggested by @kimpel in the comments of https://theconfuzedsourcecode.wordpress.com/2017/03/12/lets-override-navigation-bar-back-button-click-in-xamarin-forms/comment-page-1/#comment-1167
        //        //  using 'as <T>' instead of using normal casting of (T)
        //        var currentpage = Xamarin.Forms.Application.Current.
        //             MainPage.Navigation.NavigationStack.LastOrDefault() as BackButtonCustomActionPage;

        //        // check if the page has subscribed to the custom back button event
        //        if (currentpage?.CustomBackButtonAction != null)
        //        {
        //            // invoke the Custom back button action
        //            currentpage?.CustomBackButtonAction.Invoke();
        //            // and disable the default back button action
        //            return false;
        //        }

        //        // if its not subscribed then go ahead 
        //        // with the default back button action
        //        return base.OnOptionsItemSelected(item);
        //    }
        //    else
        //    {
        //        // since its not the back button 
        //        //click, pass the event to the base
        //        return base.OnOptionsItemSelected(item);
        //    }
        //}

        //public override void OnBackPressed()
        //{
        //    // this is really not necessary, but in Android user has both Nav bar back button 
        //    // and physical back button, so its safe to cover the both events

        //    // Note: As suggested by @kimpel in the comments of https://theconfuzedsourcecode.wordpress.com/2017/03/12/lets-override-navigation-bar-back-button-click-in-xamarin-forms/comment-page-1/#comment-1167
        //    //  using 'as <T>' instead of using normal casting of (T)
        //    var currentpage = Xamarin.Forms.Application.Current.
        //        MainPage.Navigation.NavigationStack.LastOrDefault() as BackButtonCustomActionPage;

        //    if (currentpage?.CustomBackButtonAction != null)
        //    {
        //        currentpage?.CustomBackButtonAction.Invoke();
        //    }
        //    else
        //    {
        //        base.OnBackPressed();
        //    }
        //}
    }
}