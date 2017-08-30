using System;
using Foundation;
using MvvmCross.Binding.iOS.Views;
using UIKit;

namespace SteemitApp.iOS
{
    public abstract class PagingTableSource : MvxTableViewSource
    {
        public EventHandler ScrolledToEnd;

        public PagingTableSource(UITableView Table) : base (Table)
        {
        }

        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
        {
            if (indexPath.Row >= tableView.NumberOfRowsInSection(0) - 1) 
            {
                // fire event for load next 10;
                if (ScrolledToEnd != null) 
                { 
                    ScrolledToEnd(this, new EventArgs());
                }
            }

            return null;
        }
    }
}
