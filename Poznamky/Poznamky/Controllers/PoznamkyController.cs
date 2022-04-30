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
        public IActionResult pridat(string nadpis, string text, string dulezitost)
        {

            Models.poznamka nova_poznamka = new Models.poznamka()
            {
                Nadpis = nadpis,
                Text = text,
                CasPridani = DateTime.Now,
                dulezita_poznamka = !string.IsNullOrEmpty(dulezitost),
                jmeno = HttpContext.Session.GetString("jmeno")
                
            };
            Databaze.Add(nova_poznamka);
            Databaze.SaveChanges();

            return RedirectToAction("poznamky");
        }


        [HttpGet]
        public IActionResult smazat() //poznamku
        {
            poznamka SameUser = Databaze.Novinky
           .Where(n => n.jmeno == HttpContext.Session.GetString("jmeno"))
           .FirstOrDefault();

            poznamka mazany_uzovatel = Databaze.Novinky
           .Where(n => n.jmeno == HttpContext.Session.GetString("jmeno"))
           .FirstOrDefault();



            if (SameUser == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Databaze.Novinky.Remove(SameUser);
            Databaze.SaveChanges();
            return RedirectToAction("Index", "Home");
        }



        [HttpGet]
        public IActionResult smazat_ucet()
        {
            return View();
        }

        [HttpPost]
        public IActionResult smazat_ucet(string heslo) //smazání učtu

        {
            Models.pripojeni smazany_uzovatel = Databaze.Pristup.Where(U => U.jmeno == HttpContext.Session.GetString("jmeno")).FirstOrDefault();


            if (heslo == null || !BCrypt.Net.BCrypt.Verify(heslo, smazany_uzovatel.heslo))
            {
                return RedirectToAction("smazat_ucet");
            }


            
            foreach (poznamka smazanae_poznamky in Databaze.Novinky.Where (P => P.jmeno == HttpContext.Session.GetString("jmeno")))
            {
                Databaze.Remove(smazanae_poznamky);
            }

            Databaze.Remove(smazany_uzovatel);
            Databaze.SaveChanges();
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");



           
        }
    }
}
