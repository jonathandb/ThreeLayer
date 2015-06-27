using System;
using System.Collections.Generic;

namespace ThreeLayerTest.BLL
{
	public interface IOrderService
	{
		List<Order> GetAllOrders();
		Order GetOrderByWorkRequestId(int id);
	}


	public class SOAOrderService : IOrderService
	{
		public List<Order> GetAllOrders()
		{
			List<Order> orders = new List<Order>();
			orders.Add(new SOA_Order());
			orders.Add(new SOA_Order());
			return orders;
		}

		public Order GetOrderByWorkRequestId(int id) {
			return new SOA_Order();
		}
	}

	public class PAOrderService : IOrderService
	{

		public List<Order> GetAllOrders()
		{
			List<Order> orders = new List<Order>();
			orders.Add(new PA_Order());
			orders.Add(new PA_Order());
			return orders;
		}

		public Order GetOrderByWorkRequestId(int id) {
			return new PA_Order();
		}
	}
}

