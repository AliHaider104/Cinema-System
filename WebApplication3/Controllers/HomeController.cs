using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;


namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            return View(Class1.getUsers());
        }

        public ActionResult Contact()
        {

            return View(Class1.getUsers());
        }

        public ActionResult save(String EMAIL, String PASSWORD)
        {
            if (Class1.CHECK_USER(EMAIL, PASSWORD) == true)
                return View("HOME_PAGE_WITH_FUNCTIONS");
            else
                return View("LOGIN_FAIL");
        }

        public ActionResult create_user(String Uname, String Uemail, String Umobile, String Upassword)
        {
            if (Class1.INSERT_USER(Uname, Uemail, Umobile, Upassword)==true)
                return View("Inserted");
            else
                return View("notInserted");
        }

        public ActionResult HOME_PAGE_WITH_FUNCTIONS()
        {
            return View();
        }

        public ActionResult LOGIN_FAIL()
        {
            return View();
        }

        public ActionResult REQUIRED_LOGIN()
        {
            return View();
        }

        public ActionResult Inserted()
        {
            return View();
        }

        public ActionResult notInserted()
        {
            return View();
        }

        public ActionResult NOWSHOWING()
        {
            return View(Class1.getMovies());
        }

        public ActionResult Book1()
        {
            if (Class1.BOOK_TICKET(1, "12-3-2019"))
                return View("Booked");
            else
                return View("notBooked");
        }

        public ActionResult Book2()
        {
            if (Class1.BOOK_TICKET(2, "12-3-2019"))
                return View("Booked");
            else
                return View("notBooked");

        }

        public ActionResult Book3()
        {
            if (Class1.BOOK_TICKET(3, "12-1-2019"))
                return View("Booked");
            else
                return View("notBooked");

        }

        public ActionResult Book4()
        {
            if (Class1.BOOK_TICKET(4, "12-2-2019"))
                return View("Booked");
            else
                return View("notBooked");

        }

        public ActionResult Book5()
        {
            if (Class1.BOOK_TICKET(5, "12-3-2019"))
                return View("Booked");
            else
                return View("notBooked");

        }

        public ActionResult NOT_AVAILABLE()
        {
            return View();
        }

        public ActionResult Booked()
        {
            return View();
        }

        public ActionResult notBooked()
        {
            return View();
        }

        public ActionResult EVENT_BOOKING()
        {
            return View();
        }

        public ActionResult BOOK_EVENT()
        {
            if (Class1.BOOK_EVENT(1))
                return View("Booked");
            else
                return View("notBooked");
        }

        public ActionResult BOOK_EVENT1()
        {
            if (Class1.BOOK_EVENT(2))
                return View("Booked");
            else
                return View("notBooked");
        }

        public ActionResult BOOK_EVENT2()
        {
            if (Class1.BOOK_EVENT(3))
                return View("Booked");
            else
                return View("notBooked");
        }

    }
}