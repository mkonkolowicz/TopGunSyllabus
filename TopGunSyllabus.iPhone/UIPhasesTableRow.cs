using Foundation;
using System;
using UIKit;

namespace TopGunSyllabus.iPhone
{
    public partial class UIPhasesTableRow : UITableViewCell
    {
        public UIPhasesTableRow (IntPtr handle) : base (handle)
        {
			this.AccessibilityIdentifier = "UIPhasesTableRow";
        }
    }
}