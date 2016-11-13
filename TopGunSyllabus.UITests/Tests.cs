using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace TopGunSyllabus.UITests
{
    [TestFixture]
    public class Tests
    {
        AndroidApp app;
        private string _deviceToTestOn = "4e6f0fb6";
        private const string _pathToAPK = "../../../TopGunSyllabus/bin/Debug/TopGunSyllabus.TopGunSyllabus-Signed.apk";
        [SetUp]
        public void BeforeEachTest()
        {
            // TODO: If the Android app being tested is included in the solution then open
            // the Unit Tests window, right click Test Apps, select Add App Project
            // and select the app projects that should be tested.
            app = ConfigureApp
                .Android
                //.DeviceSerial(_deviceToTestOn)
                .ApkFile (_pathToAPK)
                .StartApp();
        }

        [Test]
        public void PhaseListViewEnabled()
        {
            //arrange & act
            app.Screenshot("First screen.");
            var phaseListView = app.WaitForElement("PhasesListView");
            //assert
            Assert.That(phaseListView.First().Enabled);
        }
    }
}

