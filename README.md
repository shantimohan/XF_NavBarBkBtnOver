# XF_NavBarBkBtnOver
NavigationBar Back Button Override demo with Xamarin.Forms.TabbedPage

It is very common for a user to go back from a page without saving the edited details. So an app has to detect the situation and give options to the user either to save and go back, go back without saving the details or to stay in the page.

So we have to catch the event that is triggered when the back button in the NavigationBar is tapped. This task is not easy as there is no override event for this. When searching for how to do this I landed on the following article:
[Override Nav Bar Back Button Click](https://theconfuzedsourcecode.wordpress.com/2017/03/12/lets-override-navigation-bar-back-button-click-in-xamarin-forms/comment-page-1/#comment-1167)

A sample project that implements this method is uploaded to GitHub: [XF_NavBarBackBtnOverride]{https://github.com/shantimohan/XF_NavBarBackBtnOverride).

But unfortunately this was not working for **Xamarin.Forms.TabbedPage** in Android. The *override event OnOptionsItemSelected* in **MainActivity** was not being fired. There was no problem with iOS implementation.

Then the suggestion came from forums to use **NavigationPage.TitleView**. This **XF_NavBarBkBtnOver** project implements this suggestion for a TabbedPage. In this solution you can find the original code and the code that was modified to work with the TabbedPage are tagged with **"TODO: Changes as per JarvanZhang-MSFT in"**. The commented code was the original one that didn't work with a TabbedPage.

The procedure to test the code is:
1. Tap on the **ADD** toolbar button at the top right. This opens the *Details* page.
1. In the Details page, Tap the **BACK ARROW** at the top left. This displays a question *"Hey wait ow! Are you sure you want to go back?"* with two choices **NOPE** & **YES GO BACK**.
1. Tap **NOPE** to stay in the Details Page.
1. Tap **YES GO BACK** to go back to the main TabbedPage.
1. In Android, if you tap on the *hard* back button, you will be presented with the same choices.
