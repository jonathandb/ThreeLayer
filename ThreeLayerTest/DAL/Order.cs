using System;
using System.Collections.Generic;

namespace ThreeLayerTest.DAL
{
	public class OrderDTO
	{
		public int ID {get; set;}
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime CreationDate { get; set; }

	}

	public class WorkRequestDTO
	{
		public List<WorkResponseDTO> WorkResponses { get; set; }
	}

	public class WorkResponseDTO
	{

	}

//	public abstract class Order
//	{
//
//		int ID {get; set;}
//		string Name { get; set; }
//		string Description { get; set; }
//		DateTime CreationDate { get; set; }
//
//		int UniqueSOAProperty { get; set; }
//		int UniquePAProperty { get; set; }
//	}
//
//
//	public partial class SOA_Order : Order {
//
//		public int UniquePAProperty { get; set; }
//	}
//
//	public partial class PA_Order : Order {
//		public int UniqueSOAProperty { get; set; }
//	}

	//generated entity
	public partial class SOA_Order  
	{
		public int ID {get; set;}
		public string OrderName { get; set; }
		public string Description { get; set; }
		public DateTime CreationDate { get; set; }
		public string S95Id { get; set; }

//		public int UniqueSOAProperty { get; set; }
		//...
	}

	//generated entity
	public partial class PA_Order
	{
		public int ID {get; set;}
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime CreationDate { get; set; }
		public string S95Id { get; set; }

//		public int UniquePAProperty { get; set; }
	}
}

