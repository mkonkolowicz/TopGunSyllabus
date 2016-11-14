using Foundation;
using System;
using UIKit;

namespace TopGunSyllabus.iPhone
{
    public partial class PhasesTableView : UITableView
    {
        public PhasesTableView (IntPtr handle) : base (handle)
        {
			this.AccessibilityIdentifier = "UIPhasesTable";
        }
    }
}