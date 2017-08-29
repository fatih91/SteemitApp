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

namespace SteemitApp.iOS.Views
{
    [Register ("MainView")]
    partial class MainView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISegmentedControl SegmentedControl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView TableDiscussions { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (SegmentedControl != null) {
                SegmentedControl.Dispose ();
                SegmentedControl = null;
            }

            if (TableDiscussions != null) {
                TableDiscussions.Dispose ();
                TableDiscussions = null;
            }
        }
    }
}