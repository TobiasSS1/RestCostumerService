using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CustomersLib;

namespace RestCostumerService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CustomerService" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select CustomerService.svc or CustomerService.svc.cs at the Solution Explorer and start debugging.
	public class CustomerService : ICustomerService
	{
		private static List<Customer> _cList = new List<Customer>()
		{
			new Customer(1, "Lars", "Larsen", 1820),
			new Customer(2, "Anders", "And", 1770)
		};

		public CustomerService()
		{
			Customer Customer1 = new Customer(3, "Hans", "Christian", 1967);
			Customer Customer2 = new Customer(4, "Børge", "Henningsen", 1456);

			_cList.Add(Customer1);
			_cList.Add(Customer2);

		}



		public IList<Customer> GetCustomers()
		{
			//Customer Customer1 = new Customer(1, "Lars", "Larsen", 1820);
			//Customer Customer2 = new Customer(2, "Anders", "And", 1770);

			//cList.Add(Customer1);
			//cList.Add(Customer2);
			return _cList;
		}
	}
}
