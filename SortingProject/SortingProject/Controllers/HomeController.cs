using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using SortingProject.Models;
namespace SortingProject.Controllers
{
    public class HomeController : Controller
    {
        List<Numbers> list = new List<Numbers>();
        RandomizeList randomList = new RandomizeList();
        BubbleSort bubble = new BubbleSort();
        Turn turn = new Turn();
        SelectionSort selection = new SelectionSort();
        QuickSort QS = new QuickSort();
        public HomeController()
        {
            randomList.Count = 10;
            list = randomList.Randomize();
        }
        public ActionResult Index()
        {
            turn.Turns = 0;
            Session["count"] = 0;
            Session["list"] = list;
            return View("Index", Session["list"]);
        }

        [HttpPost]
        public ActionResult Randomize(RandomizeList random)
        {
            Session["totalTurns"] = null;
            Session["list"] = random.Randomize();
            return View("Index", Session["list"] as List<Numbers>);
        }

        public ActionResult Bubble()
        {
            if ((int)Session["count"] == 0)
            {
                Session["count"] = 1;
            }
            else
            {
                Session["count"] = (int)Session["count"] + 1;
            }
            if(!bubble.CheckList(Session["list"] as List<Numbers>))
            {
                Session["list"] = bubble.OnePass(Session["list"] as List<Numbers>);
                return View("Bubble", Session["list"] as List<Numbers>);
            }
            int temp = (int)Session["count"];
            Session["totalTurns"] = temp;
            Session["count"] = 0;
            return View("Index", Session["list"] as List<Numbers>);
        }
        
        public ActionResult Selection()
        {
            if(!selection.CheckList(Session["list"] as List<Numbers>))
            {
                Session["list"] = selection.OnePass(Session["list"] as List<Numbers>, (int)Session["count"]);
                Session["count"] = (int)Session["count"] + 1;
                return View("Selection", Session["list"] as List<Numbers>);
            }
            int temp = (int)Session["count"];
            Session["totalTurns"] = temp;
            Session["count"] = 0;
            return View("Index", Session["list"] as List<Numbers>);

        }

        public ActionResult QuickSort()
        {

            Session["list"] = QS.Sort(Session["list"] as List<Numbers>, 0, (Session["list"] as List<Numbers>).Count - 1);
            Session["QSList"] = QS.ListOfPassThroughs;
            int temp = (int)Session["count"];
            Session["totalTurns"] = temp;
            Session["count"] = 0;
            return View("QSView", (Session["QSlist"] as List<List<Numbers>>)[0]);
        }

        public ActionResult QSView()
        {
            if((int)Session["count"] < (Session["QSList"] as List<List<Numbers>>).Count -1)
            {
                Session["count"] = (int)Session["count"] + 1;
                return View("QSView", (Session["QSList"] as List<List<Numbers>>)[(int)Session["count"]]);
            }
            int temp = (int)Session["count"];
            Session["totalTurns"] = temp;
            Session["count"] = 0;
            return View("Index", Session["list"] as List<Numbers>);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}