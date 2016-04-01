using System;
using UIKit;

namespace UHDFAid.iOS
{
	public partial class UHDFAidLoginViewController : UIViewController
	{
		public UHDFAidLoginViewController () : base ("UHDFAidLoginViewController", null)
		{
		}


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			// initalize all buttons and create the methods so the buttons can execute them.



			// when user pushes create account it will go to the create student view controller.
			createStudent.TouchUpInside += (sender, e) => {this.PresentViewController(new CreateStudentViewController(),true,null);};


		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		// this method handles creating the student to be added to the database
		void createStudentEvent(object sender, EventArgs el)
		{


		}
	}
}


