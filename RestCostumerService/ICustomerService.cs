using CustomersLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestCostumerService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICustomerService" in both code and config file together.
	[ServiceContract]
	public interface ICustomerService
	{
		[OperationContract]
		[WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
			UriTemplate = "customers/")]
		IList<Customer> GetCustomers();

	}


	//// Use a data contract as illustrated in the sample below to add composite types to service operations.
	//[DataContract]
	//public class Customer
	//{
	//	[DataMember]
	//	public int Id { get; set; }

	//	[DataMember]
	//	public string Firstname { get; set; }


	//	[DataMember]
	//	public string Secondname { get; set; }

	//	[DataMember]
	//	public int Year { get; set; }

	//	public Customer(int id, string firstname, string secondname, int year)
	//	{
	//		Id = id;
	//		Firstname = firstname;
	//		Secondname = secondname;
	//		Year = year;
	//	}

	//	public Customer()
	//	{

	//	}


	//	//bool boolValue = true;
	//	//string stringValue = "Hello ";

	//	//[DataMember]
	//	//public bool BoolValue
	//	//{
	//	//	get { return boolValue; }
	//	//	set { boolValue = value; }
	//	//}

	//	//[DataMember]
	//	//public string StringValue
	//	//{
	//	//	get { return stringValue; }
	//	//	set { stringValue = value; }
	//	//}
	//}
}
