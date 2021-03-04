using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReproduceDateTimeBindingBug.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace ReproduceDateTimeBindingBug.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index([FromQuery] Filter filter)
        {
            //AssertDataConsitency(filter);
            
            return View(nameof(Index), filter);
        }

        [HttpPost]
        [ActionName(nameof(Index))]
        public IActionResult IndexPost([FromForm] Filter filter)
        {
            //AssertDataConsitency(filter);

            return View(nameof(Index), filter);
        }

        private void AssertDataConsitency(Filter f)
        {
            Contract.Assert(f.From != null);
            Contract.Assert(f.From.Value.Day == 22);
        }
    }

    public class Filter
    {
        public Filter()
        {
            From = new DateTime(2022, 2, 22);
        }

        public DateTime? From { get; set; }
    }
}
