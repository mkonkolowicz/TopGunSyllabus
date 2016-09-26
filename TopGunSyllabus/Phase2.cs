using Android.App;
using Android.OS;
using Android.Widget;
using TopGunSyllabus.Android.Utility;
using TopGunSyllabus.Core.Model;
using TopGunSyllabus.Core.Service;

namespace TopGunSyllabus.Android
{
    [Activity(Label = "Page Modelling", MainLauncher = false)]
    public class Phase2 : Activity
    {
        private ImageView phaseDetailImageView;
        private TextView phaseNameTextView;
        private TextView phaseSummaryTextView;
        private TextView phaseLearningObjectivesTextView;

        private Phase selectedPhase;
        private PhaseDataService dataService;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PhaseDetailView);
            PhaseDataService dataService = new PhaseDataService();
            selectedPhase = dataService.ReturnPhaseById(2);
            FindViews();
            BindData();
        }

        private void FindViews()
        {
            phaseSummaryTextView = FindViewById<TextView>(Resource.Id.phaseSummaryTextView);
            phaseLearningObjectivesTextView = FindViewById<TextView>(Resource.Id.phaseLearningObjectivesTextView);
        }

        private void BindData()
        {
            phaseSummaryTextView.Text = selectedPhase.Summary;
            phaseLearningObjectivesTextView.Text = selectedPhase.LearningObjectives;
        }

    }
}