using System;
using Foundation;
using MvvmCross.Binding.iOS.Views;
using UIKit;

namespace SteemitApp.iOS
{
    public class GenericTableSource<TCell> : PagingTableSource where TCell : MvxTableViewCell
    {
    	private NSString cellKey;
        private readonly float rowHeight = 90;

        public GenericTableSource(UITableView Table, UINib CellNib, NSString CellKey, float RowHeight) : base (Table)
        {
    		cellKey = CellKey;
            rowHeight = RowHeight;
    		Table.RegisterNibForCellReuse(CellNib, CellKey);
    	}

    	protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
    	{
    		var cell = (TCell)tableView.DequeueReusableCell(cellKey, indexPath);

            base.GetOrCreateCellFor(tableView, indexPath, item);

    		return cell;
    	}

	    public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return rowHeight;
        }
    }
}
