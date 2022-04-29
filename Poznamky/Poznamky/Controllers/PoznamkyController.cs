using Microsoft.AspNetCore.Mvc;
using Poznamky.Data;
using Poznamky.Models;


namespace Poznamky.Controllers
{
    public class PoznamkyController : Controller
    {
  
        kontext_data Databaze
        { get; }

        public PoznamkyController(kontext_data databaze)
        {
            Databaze = databaze;
        }

        [HttpGet]
        public IActionResult Poznamky()
        {



            List<poznamka> list_poznamek= Databaze.Novinky.ToList();
            return View(list_poznamek);
        }



        [HttpGet]
        public IActionResult edit()
        {
            return View();
        }

        [HttpGet]
        public IActionResult pridat()
        {
            return View();
        }

        [HttpPost]
        public IActionResult pridat(string nadpis, string text)
        {

            Models.poznamka nova_poznamka = new Models.poznamka()
            {
                Nadpis = nadpis,
                Text = text,
                CasPridani = DateTime.Now,
                dulezita_poznamka = false,
                jmeno = HttpContext.Session.GetString("jmeno")
                
            };
            Databaze.Add(nova_poznamka);
            Databaze.SaveChanges();
            return RedirectToAction("poznamky");


            
        }

    }
}
