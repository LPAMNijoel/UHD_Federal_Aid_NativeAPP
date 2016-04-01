using System;
using System.Collections.Generic;

namespace UHDFAid
{
	public class AdminViewModel
	{

		public CreateAdmin admin { get; set; }

		public void createAdminDefaultData()
		{
			// init the admin
			admin = new CreateAdmin();
			// default admin name.
			admin.adminName = "Nijoel";
			//admin.adminPassword =
		}




	}
}

