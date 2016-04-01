// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace UHDFAid.iOS
{
	[Register ("UHDFAidLoginViewController")]
	partial class UHDFAidLoginViewController
	{
		[Outlet]
		UIKit.UIButton adminLogin { get; set; }

		[Outlet]
		UIKit.UIButton createAdmin { get; set; }

		[Outlet]
		UIKit.UIButton createDatabase { get; set; }

		[Outlet]
		UIKit.UIButton createStudent { get; set; }

		[Outlet]
		UIKit.UITextField nineHunNumberTxtBox { get; set; }

		[Outlet]
		UIKit.UITextField password_txt { get; set; }

		[Outlet]
		UIKit.UIButton studentLogin { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (nineHunNumberTxtBox != null) {
				nineHunNumberTxtBox.Dispose ();
				nineHunNumberTxtBox = null;
			}

			if (password_txt != null) {
				password_txt.Dispose ();
				password_txt = null;
			}

			if (studentLogin != null) {
				studentLogin.Dispose ();
				studentLogin = null;
			}

			if (createStudent != null) {
				createStudent.Dispose ();
				createStudent = null;
			}

			if (adminLogin != null) {
				adminLogin.Dispose ();
				adminLogin = null;
			}

			if (createAdmin != null) {
				createAdmin.Dispose ();
				createAdmin = null;
			}

			if (createDatabase != null) {
				createDatabase.Dispose ();
				createDatabase = null;
			}
		}
	}
}
