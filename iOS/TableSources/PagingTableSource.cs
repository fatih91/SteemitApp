using System;
using Foundation;
using MvvmCross.Binding.iOS.Views;
using UIKit;

namespace SteemitApp.iOS
{
    public class PagingTableSource : MvxTableViewSource
    {
        public EventHandler ScrolledToEnd;

        public PagingTableSource(UITableView Table) : base (Table)
        {
            Table.RegisterNibForCellReuse(PostCell.Nib, PostCell.Key);
        }

        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
        {
            var cell = (PostCell)tableView.DequeueReusableCell(PostCell.Key, indexPath);

            if (indexPath.Row >= tableView.NumberOfRowsInSection(0) - 1) 
            {
                // fire event for load next 10;
                if (ScrolledToEnd != null) 
                { 
                    ScrolledToEnd(this, new EventArgs());
                }

            }

            return cell;
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 300f;
        }
    }
}
