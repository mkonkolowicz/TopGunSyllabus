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

namespace TopGunSyllabus.iPhone
{
    [Register ("PhaseDetailViewController")]
    partial class PhaseDetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView LearningObjectivesText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel PhaseDetailLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView PhaseDetailPicture { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel PhaseSummaryLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView PhaseSummaryText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TopGunSyllabusLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LearningObjectivesText != null) {
                LearningObjectivesText.Dispose ();
                LearningObjectivesText = null;
            }

            if (PhaseDetailLabel != null) {
                PhaseDetailLabel.Dispose ();
                PhaseDetailLabel = null;
            }

            if (PhaseDetailPicture != null) {
                PhaseDetailPicture.Dispose ();
                PhaseDetailPicture = null;
            }

            if (PhaseSummaryLabel != null) {
                PhaseSummaryLabel.Dispose ();
                PhaseSummaryLabel = null;
            }

            if (PhaseSummaryText != null) {
                PhaseSummaryText.Dispose ();
                PhaseSummaryText = null;
            }

            if (TopGunSyllabusLabel != null) {
                TopGunSyllabusLabel.Dispose ();
                TopGunSyllabusLabel = null;
            }
        }
    }
}