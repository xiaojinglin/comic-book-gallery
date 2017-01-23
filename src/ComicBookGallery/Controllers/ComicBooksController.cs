using ComicBookGallery.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController: Controller
    {
        ComicBookRepository comicBookRespository = new ComicBookRepository();
        public ActionResult Detail()
        {
            return View(comicBookRespository);
        }
    }
}