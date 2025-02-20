using BackEnd2._3.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd2._3.Controllers
{
    public class VenditaController : Controller
    {
        private static List<Sala> Sale = new List<Sala>
        {
        new Sala { NomeSala = "SALA NORD" },
        new Sala { NomeSala = "SALA EST" },
        new Sala { NomeSala = "SALA SUD" }

        };
        public IActionResult Vendite()
        {
            return View(Sale);
        }

        public IActionResult Statistica ()
        {
            return View(Sale);
        }


        [HttpPost]
        public IActionResult VendiBiglietto(string nome, string cognome, string sala, string tipo)
        {

            var persona = new BigliettoVenduto { Nome = nome, Cognome = cognome, Tipo = tipo };

            var salaSelezionata = Sale.FirstOrDefault(s => s.NomeSala == sala);
            if (salaSelezionata != null && salaSelezionata.BigliettiInteriVenduti < salaSelezionata.CapienzaMassima)
            {
                salaSelezionata.BigliettiInteriVenduti++;
                if (tipo == "Ridotto")
                {
                    salaSelezionata.BigliettiRidottiVenduti++;
                }

                salaSelezionata.BigliettiVenduti.Add(persona);
            }

            return RedirectToAction("Vendite");
        }
    }
}

