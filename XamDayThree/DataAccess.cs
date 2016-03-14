using System;
using Xamarin.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SQLite.Net;

namespace XamDayThree
{
	public class DataAccess
	{
		static object locker = new object ();
		SQLiteConnection dbConn;
		public DataAccess ()
		{
			dbConn = DependencyService.Get<ISQLite> ().GetConnection ();
			// create the tables
			dbConn.CreateTable<AppUser>();
		}

		public int SaveUser(AppUser aIUser) {
		lock (locker) {
			return dbConn.Insert(aIUser);
			}
		 }

		public IEnumerable<AppUser> GetAllUser()
		{
			lock (locker) {
				return dbConn.Query<AppUser>("Select * From [AppUser]");
			}
		}
		public AppUser GetSingleUser(int iUserId)
		{
			lock (locker) {
				return dbConn.Table<AppUser>().FirstOrDefault(x => x.UserId == iUserId);
			}
		}
	}
}

