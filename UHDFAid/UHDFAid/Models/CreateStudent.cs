using System;

// model declare all the setters and getters of methods..
namespace UHDFAid
{
	public class CreateStudent
	{
		#region student properties on what student can add...
		// this will be login features to log into the scholarship database.
		public string studentFirstName { get; set; }
		public string studentLastName { get; set; }
		// 900 would be private but for project sake public 
		public string studentNineHunNum { get; set; }
		public string studentPassword{ get; set;}

		public float studentGPA { get; set; }
		public string studentMajor { get; set; }
		public int studentHours { get; set; }
		#endregion
	}
}

