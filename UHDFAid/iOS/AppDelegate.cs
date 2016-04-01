using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace UHDFAid.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			//
			UHDFAidLoginViewController UHDLoginVC = new UHDFAidLoginViewController ();
		
			UIWindow window = new UIWindow (UIScreen.MainScreen.Bounds);

			window.RootViewController = UHDLoginVC;

			window.MakeKeyAndVisible();

			// create student view controller created
			CreateStudentViewController createStudentVC = new CreateStudentViewController();



			return true;
		}
	}
}

