using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using TestLibrary;

namespace TestUi.Ios
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations
        UIWindow window;

        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            // create a new window instance based on the screen size
            window = new UIWindow(UIScreen.MainScreen.Bounds);
            UIViewController navigationController = new UIViewController();

            window.BackgroundColor = UIColor.White;

            var label = new UILabel(new RectangleF(20, 20, 250, 50));
            var messenger = new PortableReferenceLibrary.ReferenceTest();

            label.Text = messenger.GetMessage();
            window.Add(label);

            // If you have defined a view, add it here:
            window.RootViewController  = navigationController;

            // make the window visible
            window.MakeKeyAndVisible();

            return true;
        }
    }
}