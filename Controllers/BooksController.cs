using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibApp_WSEI.Models;

namespace LibApp_WSEI.Controllers
{
    public class BooksController : Controller
    {
        //GET /Books/Random
        public IActionResult Random()
        {
            var firstBook = new Book() { Name = "English dictionary" };

            return View(firstBook);
        }
    }
}
