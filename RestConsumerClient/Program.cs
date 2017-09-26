using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using CustomersLib;

namespace RestConsumerClient
{
	class Program
	{
		static void Main(string[] args)
		{
			Task<IList<Customer>> t1 = GetCustomersAsync();
			List<Customer> cList = (List<Customer>)t1.Result;

			foreach (Customer c in cList)
			{
				Console.WriteLine(c);
			}
		}

		public static async Task<IList<Customer>> GetCustomersAsync()
		{
			using (HttpClient client = new HttpClient())
			{
				string content = await client.GetStringAsync("http://localhost:50477/Service1.svc/customers/");
				IList<Customer> cList = JsonConvert.DeserializeObject<IList<Customer>>(content);
				return cList;
			}
		}
	}

}

