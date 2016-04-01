using System;
using Newtonsoft.Json;
using SQLite;
using System.IO;

// create the student viewmodel and the admin viewmodel.

namespace UHDFAid
{
	public class Database
	{
		public string _pathToDatabase;

		public void InitalizeDatabase()
		{
			// this constructor will init the file where we hold the database contents.
			// Figure out where the SQLite database will be.
			var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			_pathToDatabase = Path.Combine(documents, "Library");

			var database = new SQLite.SQLiteConnection(_pathToDatabase);
		}

		//[PrimaryKey, AutoIncrement]

	

	}
}

