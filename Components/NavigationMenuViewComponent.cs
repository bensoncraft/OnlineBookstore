using Microsoft.AspNetCore.Mvc;
using OnlineBookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBooksRepository repository;

        public NavigationMenuViewComponent (IBooksRepository r)
        {
            repository = r;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.ClassificationCategory)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
