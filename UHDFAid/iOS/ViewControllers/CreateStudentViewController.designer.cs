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

namespace UHDFAid.iOS
{
    [Register ("CreateStudentViewController")]
    partial class CreateStudentViewController
    {
        [Outlet]
        UIKit.UIButton createStudentAccount { get; set; }


        [Outlet]
        UIKit.UITextField studentFirstName { get; set; }


        [Outlet]
        UIKit.UITextField studentGPA { get; set; }


        [Outlet]
        UIKit.UITextField studentHours { get; set; }


        [Outlet]
        UIKit.UITextField studentLastName { get; set; }


        [Outlet]
        UIKit.UITextField studentMajor { get; set; }


        [Outlet]
        UIKit.UITextField studentNinNumber { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (createStudentAccount != null) {
                createStudentAccount.Dispose ();
                createStudentAccount = null;
            }

            if (studentFirstName != null) {
                studentFirstName.Dispose ();
                studentFirstName = null;
            }

            if (studentGPA != null) {
                studentGPA.Dispose ();
                studentGPA = null;
            }

            if (studentHours != null) {
                studentHours.Dispose ();
                studentHours = null;
            }

            if (studentLastName != null) {
                studentLastName.Dispose ();
                studentLastName = null;
            }

            if (studentMajor != null) {
                studentMajor.Dispose ();
                studentMajor = null;
            }

            if (studentNinNumber != null) {
                studentNinNumber.Dispose ();
                studentNinNumber = null;
            }
        }
    }
}