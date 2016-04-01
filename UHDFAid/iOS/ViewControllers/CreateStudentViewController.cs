using System;

using UIKit;

namespace UHDFAid.iOS
{
	public partial class CreateStudentViewController : UIViewController
	{
		public CreateStudentViewController () : base ("CreateStudentViewController", null)
		{

			//when create student button is pressed it should invoke this method. 
			createStudentAccount.TouchUpInside += CreateStudentAccount_TouchUpInside; 

		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}  

		// create the student method..
		void CreateStudentAccount_TouchUpInside(object obj, EventArgs e)
		{
			
			// we create the student from the student view model 
			StudentViewModel studentobj = new StudentViewModel();


			// assigning my view from the viewmodel 
			studentobj.student.studentFirstName = studentFirstName.Text;
			studentobj.student.studentLastName = studentLastName.Text;
			studentobj.student.studentNineHunNum = studentNinNumber.Text;

			// find a way for the 900 to be in the 900 range so 900-xx-xxxx like a phone number


			// if GPA is below 0 and higher than 4.0 display an error 
			if (studentobj.student.studentGPA <= 4.0 || studentobj.student.studentGPA <= 0.0||studentobj.student.studentGPA.ToString() == "" ) 
			{

				// display an alert here 
				Console.WriteLine("Error....");

					
			}



		}
	}
}


