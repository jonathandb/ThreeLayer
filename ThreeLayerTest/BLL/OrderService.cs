using System;
using System.Collections.Generic;
using ThreeLayerTest.DAL;

namespace ThreeLayerTest.BLL
{
	public interface IOrderService
	{
		List<OrderDTO> GetAllOrders();
		OrderDTO GetOrderByWorkRequestId(int id);
	}

	public class SOAOrderService : IOrderService
	{
		public List<OrderDTO> GetAllOrders()
		{
			List<OrderDTO> orders = new List<OrderDTO>();
			orders.Add(Convert(new SOA_Order()));
			orders.Add(Convert(new SOA_Order()));
			return orders;
		}

		public OrderDTO GetOrderByWorkRequestId(int id) {
			return new OrderDTO();
		}

		public OrderDTO Update(OrderDTO orderDTO)
		{
			//get ef order by id, put in dto properties
			//update it and convert the updated ef order back to dto
			SOA_Order soa_Order = null;
			return Convert(soa_Order);
		}



		private SOA_Order Convert(OrderDTO soa_Order) 
		{
			SOA_Order order = new SOA_Order();
			order.OrderName = soa_Order.Name;
			//...

			return order;
		}

		private OrderDTO Convert(SOA_Order soa_Order) 
		{
			OrderDTO order = new OrderDTO ();
			order.Name = soa_Order.OrderName;
			//...

			return order;
		}
	}

	public class PAOrderService : IOrderService
	{

		public List<OrderDTO> GetAllOrders()
		{
			List<OrderDTO> orders = new List<Order>();
			orders.Add(new PA_Order());
			orders.Add(new PA_Order());
			return orders;
		}

		public OrderDTO GetOrderByWorkRequestId(int id) {
			return new PA_Order();
		}
	}
}



//get only DTO data from SQL:

//http://www.productiverage.com/entity-framework-projections-to-immutable-types-ienumerable-vs-iqueryable
//https://bitbucket.org/DanRoberts/compilabletypeconverter

//!!! https://lostechies.com/jimmybogard/2011/02/09/autoprojecting-linq-queries/
//http://www.devtrends.co.uk/blog/stop-using-automapper-in-your-data-access-code





//var personsDTO = persons.Select(x => ToPersonDTOMap(x)).ToList();

//	public static PersonDTO ToPersonDTOMap(Person person)
//	{
//		return new PersonDTO()
//		{
//			ID = person.ID,
//			Name = person.Name,
//			Address = ToAddressDTOMap(person.Address)
//		};
//	}

//http://stackoverflow.com/questions/29613779/cleanest-way-to-map-entity-to-dto-with-linq-select

//https://github.com/AutoMapper/AutoMapper/wiki/Queryable-Extensions