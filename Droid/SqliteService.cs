using System;
using XamDayThree;
using Xamarin.Forms;
using System.IO;
using XamDayThree.Droid;

[assembly: Dependency (typeof (SqliteService))]
namespace XamDayThree.Droid
{
	
	public class SqliteService : ISQLite {

		public SqliteService () {}

		#region ISQLite implementation
		public SQLite.Net.SQLiteConnection GetConnection ()
		{
			var sqliteFilename = "MyAppSQLite.db3";
			string documentsPath = System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal); // Documents folder
			var path = Path.Combine(documentsPath, sqliteFilename);

			// This is where we copy in the prepopulated database
			Console.WriteLine (path);
			if (!File.Exists(path))
			{
				File.Create (path);
			}
			var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
			var conn = new SQLite.Net.SQLiteConnection(plat, path);

			// Return the database connection 
			return conn;
		}
		#endregion

	}
}

