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
        UIKit.UILabel LabelAuthor { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelComments { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelCreatedAgo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelPendingPayout { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelVotes { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView PostImage { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelAuthor != null) {
                LabelAuthor.Dispose ();
                LabelAuthor = null;
            }

            if (LabelComments != null) {
                LabelComments.Dispose ();
                LabelComments = null;
            }

            if (LabelCreatedAgo != null) {
                LabelCreatedAgo.Dispose ();
                LabelCreatedAgo = null;
            }

            if (LabelPendingPayout != null) {
                LabelPendingPayout.Dispose ();
                LabelPendingPayout = null;
            }

            if (LabelTitle != null) {
                LabelTitle.Dispose ();
                LabelTitle = null;
            }

            if (LabelVotes != null) {
                LabelVotes.Dispose ();
                LabelVotes = null;
            }

            if (PostImage != null) {
                PostImage.Dispose ();
                PostImage = null;
            }
        }
    }
}