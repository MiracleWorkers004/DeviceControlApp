using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace DeviceControlApp.Tests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            // TODO: If the iOS or Android app being tested is included in the solution 
            // then open the Unit Tests window, right click Test Apps, select Add App Project
            // and select the app projects that should be tested.
            //
            // The iOS project should have the Xamarin.TestCloud.Agent NuGet package
            // installed. To start the Test Cloud Agent the following code should be
            // added to the FinishedLaunching method of the AppDelegate:
            //
            //    #if ENABLE_TEST_CLOUD
            //    Xamarin.Calabash.Start();
            //    #endif
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    // TODO: Update this path to point to your Android app and uncomment the
                    // code if the app is not included in the solution.
                    //.ApkFile ("../../../Droid/bin/Debug/xamarinforms.apk")
                    //  .ApkFile("/Users/audiology/Projects/TestingApp/DeviceControlApp/DeviceControlApp.Android/bin/Debug/DeviceControlApp.apk")
                    .StartApp();
            }

            return ConfigureApp
                //.iOS
                //.Debug()
                //.InstalledApp("com.siemens.DeviceControlApp")
                //.DeviceIdentifier("94B8EB41-8E93-46D4-802F-68C1D6307BA7")
                //.StartApp();

             .iOS
            // TODO: Update this path to point to your iOS app and uncomment the
            // code if the app is not included in the solution.
            // .AppBundle ("../../../iOS/bin/iPhoneSimulator/Debug/DeviceControlApp.iOS.app")
              .StartApp();


        }
    }
}