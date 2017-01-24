using ComicBookGallery.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController: Controller
    {
        private ComicBookRepository _comicBookRespository;
        public ComicBooksController()
        {
            _comicBookRespository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            return View(_comicBookRespository.GetComicBooks());
        }

        public ActionResult SeriesIndex()
        {
            return View(_comicBookRespository.GetComicBooks());
        }

        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }

            string twitterAccount = ConfigurationManager.AppSettings["TwitterAccount"];
            ViewBag.TwitterAccount = twitterAccount;
            return View(_comicBookRespository.GetComicBook((int)id));
        }
    }
}