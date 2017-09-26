using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestCostumerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestCostumerService.Tests
{
	[TestClass()]
	public class CustomerServiceTests
	{
		[TestMethod()]
		public void GetCustomersTest()
		{
			var kunde = new CustomerService();
	
			Assert.AreEqual(2, kunde.GetCustomers().Count);
		}
	}
}