using Microsoft.AspNetCore.Mvc;
using Poznamky.Data;
using Poznamky.Models;

namespace Poznamky.Controllers
{
    public class PristupController : Controller
    {

        kontext_data Databaze { get; }

        public PristupController(kontext_data databaze)
        {
            Databaze = databaze;
        }


        [HttpGet]
        public IActionResult prihlaseni()
        {
            return View();


        }


        [HttpGet]
        public IActionResult registrace()
        {
            return View();

        }

        [HttpPost]
        public IActionResult registrace(string jmeno, string email, string heslo)
        {
            if (jmeno == null)
            {
                ViewData["chyba"] = "Chybí jméno";
                return View();
            }


            if (email == null)
            {
                ViewData["chyba"] = "Chybí email";
                return View();
            }


            if (heslo == null)
            {
                ViewData["chyba"] = "Chybí heslo";
                return View();
            }


            pripojeni novy_uzivatel = new pripojeni();
            novy_uzivatel.jmeno = jmeno;
            novy_uzivatel.heslo = BCrypt.Net.BCrypt.HashPassword(heslo);
            novy_uzivatel.email = email;
            return View();


        }

        [HttpPost]
        public IActionResult prihlaseni(string jmeno, string heslo)
        {
            if (jmeno == null)
            {
                ViewData["chyba"] = "Chybí jméno";
                return View();
            }


            if (heslo == null)
            {
                ViewData["chyba"] = "Chybí heslo";
                return View();
            }


            return View();
        }

       
    }
}
