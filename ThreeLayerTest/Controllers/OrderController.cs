using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using ThreeLayerTest.BLL;

namespace ThreeLayerTest.Controllers
{
	public class OrderController : Controller
	{
		private IOrderService _service;

		public OrderController(IOrderService service) {
			//_service = service;
		}
		//or
		public IOrderService GetService {
			get 
			{
				if (_service == null) 
				{
					//_service = ServiceFactory.createOrderService();
					_service = new PAOrderService ();
				}
				return _service;
			}
		}

		public ActionResult Index ()
		{
			var mvcName = typeof(Controller).Assembly.GetName ();
			var isMono = Type.GetType ("Mono.Runtime") != null;

			ViewData ["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;// + GetService().GetOrderByWorkRequestId(1);
			ViewData ["Runtime"] = isMono ? "Mono" : ".NET";

			return View ();
		}
	}
}

