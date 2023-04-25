using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelOrder.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        public ActionResult List()
        {
            HotelOrderEntities db = new HotelOrderEntities();
            var datas = from c in db.Comments
                        select c;
            return View(datas);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Comments p)
        {
            HotelOrderEntities db = new HotelOrderEntities();
            p.CommentDate = DateTime.Now;
            db.Comments.Add(p);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult Delete(int? id)
        {
            HotelOrderEntities db = new HotelOrderEntities();
            Comments prod = db.Comments.FirstOrDefault(t => t.CommentId == id);

            if (prod != null)
            {
                db.Comments.Remove(prod);
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return RedirectToAction("List");

            HotelOrderEntities db = new HotelOrderEntities();
            Comments prod = db.Comments.FirstOrDefault(t => t.CommentId == id);

            if (prod == null)
                return RedirectToAction("List");
            return View(prod);
        }

        [HttpPost]
        public ActionResult Edit(Comments p)
        {
            HotelOrderEntities db = new HotelOrderEntities();
            Comments prod = db.Comments.FirstOrDefault(t => t.CommentId == p.CommentId);
            if (prod != null)
            {
                prod.CommentDate = p.CommentDate;
                prod.MemberID = p.MemberID;
                prod.RoomClassID = p.RoomClassID;
                prod.CommentPoint = p.CommentPoint;
                prod.CommentDetail = p.CommentDetail;
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}