using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelOrder.Controllers
{
    public class RoomController : Controller
    {
        // GET: Room
        public ActionResult List()
        {
            HotelOrderEntities db = new HotelOrderEntities();
            var datas = from c in db.Room
                        select c;
            return View(datas);
        }
    }
}