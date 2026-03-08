using System;
namespace Days_13.users
{
	public class Person
	{
		public string nameSurname = "";

        // virtual sayesinde -> override edilmeye uygun bir method oluşturmuş olduk.
        public virtual bool Login(string username, string password) 
		{
			return false;
		}

		public void DBConnect( string tableName )
		{
			Console.WriteLine($"{tableName} table select");
		}


	}
}

