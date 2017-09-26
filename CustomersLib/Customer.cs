using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersLib
{
	public class Customer
	{
		public int Id { get; set; }

		public string Firstname { get; set; }

		public string Secondname { get; set; }

		public int Year { get; set; }

		public Customer(int id, string firstname, string secondname, int year)
		{
			Id = id;
			Firstname = firstname;
			Secondname = secondname;
			Year = year;
		}

		public Customer()
		{

		}

		public override string ToString()
		{
			return $"{Id}, {Firstname}, {Secondname}, {Year}";
		}
	}
}
