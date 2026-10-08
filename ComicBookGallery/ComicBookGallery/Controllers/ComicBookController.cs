using ComicBookGallery.Models;
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
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The amazing spider man",
                IssueNumber = 700,
                DescriptionHtml = "<P> Final issues </p>",
                Artists = new Artist[]

            {
                new Artist() { Name= "OBioyo rosalie", Role="Scripts"},
                new Artist() { Name= "grande fille", Role="Pencils"},
                new Artist() { Name= "miss Berthe", Role="Inks"},
                new Artist() { Name= "Ambala Yann", Role="Color"},
                new Artist() { Name= "Chris Eliopoulus", Role="Letters"},
            }
           };

             
            return View(comicBook);
         
        } 
    }
}