using SkiWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkiWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAds()
        {
            using (ShopEntitie dc = new ShopEntitie())
            {
                var ads = dc.Ads.OrderBy(a => a.Title).ToList();
                return Json(new { data = ads }, JsonRequestBehavior.AllowGet);

            }
        }
        //[HttpGet]
        //public ActionResult Save(int id)
        //{
        //    using (ShopEntities dc = new ShopEntities())
        //    {
        //        var v = dc.Ads.Where(a => a.IdAd==id).FirstOrDefault();
        //        return View(v);

        //    }
        //}
        //[HttpPost]
        //public ActionResult Save(Ads ad)
        //{
        //    bool status = false;
        //    if (ModelState.IsValid)
        //    {
        //        using (ShopEntities dc = new ShopEntities())
        //        { 
        //            if (ad.IdAd>0)
        //            {
        //                //edit
        //                var v = dc.Ads.Where(a => a.IdAd == ad.IdAd).FirstOrDefault();
        //                if (v!=null)
        //                {
        //                    v.Title = ad.Title;
        //                    v.Description = ad.Description;
        //                    v.Picture = ad.Picture;
        //                    v.Price = ad.Price;
        //                }
        //            }
        //            else
        //            {
        //                //save
        //                dc.Ads.Add(ad);
        //            }
        //            dc.SaveChanges();
        //            status = true;
        //        }
        //    }
        //    return new JsonResult { Data = new { status = status } };
        //}
    }
}