using System;

namespace UHDFAid
{
	public class CreateAdmin
	{
		#region admin properties on what admin can do...
		public string adminName {get; set;}
		public string adminPassword{ get; set;}

		public bool canViewStudents;
		public bool canViewStudentScholarships;

		// should be a list view when admin can view the students scholarships thats availible
	
		// only admins can create the scholarships name and amount awarded based on hours met by the students.
		// admins can edit the students in the database.. 
		public string scholarshipName { get; set;}
		public int scholashipAmount {get; set;}
		#endregion


	}
}

