using System;
using SQLite.Net;

namespace XamDayThree
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}

