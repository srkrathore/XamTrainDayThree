using System;
using Xamarin.Forms;
using SQLite.Net;
using SQLite.Net.Attributes;
using System.Collections.Generic;

namespace XamDayThree
{
	public class SecDataAccess
	{
		static object objLock = new object (); 
		SQLiteConnection dbConnection; 
		public SecDataAccess ()
		{
			dbConnection = DependencyService.Get<ISQLite> ().GetSecConnection ();
			// create the tables
			dbConnection.CreateTable<GameImage>();

		}

		public IEnumerable<GameImage> GetAllImages()
		{
			lock (objLock) {
				return dbConnection.Query<GameImage>("Select * From [GameImage]");
			}
		}
	

	}

	public class GameImage
	{
		public int ImageId
		{ get; set; }
		public int LevelId
		{ get; set; }
		public string ImgName
		{ get; set; }
		public string ImgMessage
		{ get; set; }
	}

}

