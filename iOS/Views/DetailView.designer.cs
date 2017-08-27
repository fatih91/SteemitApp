// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace SteemitApp.iOS
{
    [Register ("DetailView")]
    partial class DetailView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView ScrollView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIWebView WebView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ScrollView != null) {
                ScrollView.Dispose ();
                ScrollView = null;
            }

            if (WebView != null) {
                WebView.Dispose ();
                WebView = null;
            }
        }
    }
}