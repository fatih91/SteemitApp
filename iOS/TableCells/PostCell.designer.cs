// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace SteemitApp.iOS
{
    [Register ("PostCell")]
    partial class PostCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView PostImage { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelTitle != null) {
                LabelTitle.Dispose ();
                LabelTitle = null;
            }

            if (PostImage != null) {
                PostImage.Dispose ();
                PostImage = null;
            }
        }
    }
}