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
    [Register ("TagView")]
    partial class TagView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView TableTags { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TableTags != null) {
                TableTags.Dispose ();
                TableTags = null;
            }
        }
    }
}