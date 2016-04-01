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
    [Register ("AdminLoginViewController")]
    partial class AdminLoginViewController
    {
        [Outlet]
        UIKit.UITextField adminName { get; set; }


        [Outlet]
        UIKit.UITextField adminPassword { get; set; }


        [Outlet]
        UIKit.UIButton createAdminAccount { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (adminName != null) {
                adminName.Dispose ();
                adminName = null;
            }

            if (adminPassword != null) {
                adminPassword.Dispose ();
                adminPassword = null;
            }

            if (createAdminAccount != null) {
                createAdminAccount.Dispose ();
                createAdminAccount = null;
            }
        }
    }
}