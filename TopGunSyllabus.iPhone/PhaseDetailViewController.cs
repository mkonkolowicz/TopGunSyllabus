using System;
using TopGunSyllabus.Core.Model;
using UIKit;

namespace TopGunSyllabus.iPhone
{
    public partial class PhaseDetailViewController : UIViewController
    {
        public PhaseDetailViewController(IntPtr handle) : base(handle)
        {
        }

        public Phase SelectedPhase
        { get; set; }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            DataBindUI();
        }

        private void DataBindUI()
        {
            PhaseSummaryText.Text= SelectedPhase.Summary;
            LearningObjectivesText.Text = SelectedPhase.LearningObjectives;
            PhaseDetailPicture = new UIImageView { Image = UIImage.FromFile("Images\topgun_teamfortress.png") };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}