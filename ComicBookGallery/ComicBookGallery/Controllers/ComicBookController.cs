using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController: Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The amazing spider man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description =  "<P> Final issues </p>";
            ViewBag.Artists = new string[]
            {
                "Script: OBioyo rosalie ", 
                 "Pencils : grande fille",
                  "Inks : miss Berthe",
                  "Color:  Ambala Yann",
                   "Letters : Chris Eliopoulus"
            }
            ;
            return View();
         
        } 
    }
}