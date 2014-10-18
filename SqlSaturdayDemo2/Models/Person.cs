using System;

namespace SqlSaturdayDemo2
{
	public class Person
	{
		public Person (string f, string l)
		{
			FirstName = f;
			LastName = l;
		}

		public string FirstName {
			get;
			set;
		}

		public string LastName {
			get;
			set;
		}
	}
}

