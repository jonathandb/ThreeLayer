using System;

namespace ThreeLayerTest
{
	public abstract class Order
	{

	    int ID {get; set;}
	    string Name { get; set; }
	    string Description { get; set; }
	    DateTime DueDate { get; set; }

		int UniqueSOAProperty { get; set; }
		int UniquePAProperty { get; set; }

//		public static Order FromSOAOrder(SOA_Order soa_Order) {
//			return (Order)soa_Order;
//		}
//
//		public static Order FromPAOrder(PA_Order pa_Order) {
//			return (Order) pa_Order;
//		}
	}


	public partial class SOA_Order : Order {

		public int UniquePAProperty { get; set; }
	}

	public partial class PA_Order : Order {
		public int UniqueSOAProperty { get; set; }
	}

	//generated entity
	public partial class SOA_Order  
	{
		public int ID {get; set;}
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime DueDate { get; set; }
		public string S95Id { get; set; }

		public int UniqueSOAProperty { get; set; }
		//...
	}

	//generated entity
	public partial class PA_Order
	{
		public int ID {get; set;}
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime DueDate { get; set; }
		public string S95Id { get; set; }

		public int UniquePAProperty { get; set; }
	}
}

