using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace GroupingWeb.Controllers
{
    public class PeopleController : Controller
    {
        public ActionResult Char(string id)
        {
            using (var data = new GroupingWeb.Models.GroupingEntities())
            {
                StringBuilder dblog = new StringBuilder();
                data.Database.Log = s => dblog.Append(s);

                ViewBag.Char = ' ';
                ViewBag.DBLog = "";

                if (String.IsNullOrEmpty(id))
                    return View();

                var ch = id.ToUpper().Substring(0, 1);

                var res = data.People
                    .Where(p => p.Name.Substring(0, 1) == ch)
                    .OrderBy(p => p.Name).ThenBy(p => p.Firstname)
                    .ToList();

                ViewBag.Char = ch;
                ViewBag.DBLog = dblog.ToString();

                return View(res);
            }
        }

        const int PAGE_SIZE = 100;

        public ActionResult Page(int? id)
        {
            using (var data = new GroupingWeb.Models.GroupingEntities())
            {
                StringBuilder dblog = new StringBuilder();
                data.Database.Log = s => dblog.Append(s);

                var page = id ?? 1;
                var count = data.People.Count();
                var nbOfPages = (count - 1) / PAGE_SIZE + 1;

                var res = data.People
                    .OrderBy(p => p.Name).ThenBy(p => p.Firstname)
                    .Skip((page - 1) * PAGE_SIZE).Take(PAGE_SIZE).ToList();

                ViewBag.Page = page;
                ViewBag.NbOfPages = nbOfPages;
                ViewBag.DBLog = dblog.ToString();

                return View(res);
            }
        }
    }
}