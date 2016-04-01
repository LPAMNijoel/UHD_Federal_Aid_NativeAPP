using System;

namespace UHDFAid
{
	public class StudentViewModel
	{
		public StudentViewModel ()
		{
		}

		/// CreateStudent Student which access the model student.
		public CreateStudent student {get;set;}

		public void createStudent()
		{
			// init the student 
			student = new CreateStudent();

			// init the things we need to know about the student to log in. 
			student.studentFirstName = "Nijoel";
			student.studentNineHunNum = "900234035";
			student.studentLastName = "Jackson";
			student.studentGPA = 3.2f;
			student.studentHours = 10;
			student.studentMajor = "Computer Science";
			student.studentPassword = "password";

		}
	}
}

