using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LibraryController : Controller
    {
        // GET: Library
        EMISDBEntities _db = new EMISDBEntities();
        class BatchDetails
        {
            public int BatchNo { get; set; }
        }
        public ActionResult Index()
        {
            var lst = _db.tblMasterAcademicDetails.Select(m => m.BatchNo).Distinct();
            List<BatchDetails> str = new List<BatchDetails>();

            foreach (int item in lst)
            {
                BatchDetails bt = new BatchDetails();
                bt.BatchNo = item;
                str.Add(bt);
            }
            ViewBag.BatchList = str;
            return View();
         
        }
        public JsonResult getRollno(int id)
        {
            var lstrollno = _db.tblMasterAcademicDetails.Where(b => b.BatchNo == id);
            return Json(lstrollno);
           


        }

    }
}