using System.Web.Mvc;
using System.Collections.Generic;
using Autoveille.Models;

namespace Autoveille.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult GetNomAppels()
        {
            List<NomAppel> nomAppels = new List<NomAppel>
            {
                new NomAppel{Id=1,Nom="Denis Tardiff",NbrArejoindre=1,NbrDesactivee=5,NbrLitiges=2,NbrProspects=6,NbrRDV=8,NbrRejoints=1,NbrRelances=6},
                new NomAppel{Id=2,Nom="Second Example",NbrArejoindre=1,NbrDesactivee=5,NbrLitiges=2,NbrProspects=6,NbrRDV=8,NbrRejoints=1,NbrRelances=6},
                new NomAppel{Id=3,Nom="Third Example",NbrArejoindre=1,NbrDesactivee=5,NbrLitiges=2,NbrProspects=6,NbrRDV=8,NbrRejoints=1,NbrRelances=6}
            };
           
            return   PartialView(nomAppels);
        }

        public ActionResult GetClients()
        {
            List<Client> clients = new List<Client>()
            {
                new Client{ClientId=1,NomClient="ABCD3",FinTerme=new System.DateTime(2010,01,15),Mobile="407 3254 1478",ModeleVehicule="Model vhi 1",Phone1="407 412 145",Phone2="458745 123"},
                new Client{ClientId=2,NomClient="NEWCLIENT",FinTerme=new System.DateTime(2010,01,15),Mobile="407 3254 1478",ModeleVehicule="Model vhi 1",Phone1="407 412 145",Phone2="458745 123"},
                new Client{ClientId=3,NomClient="Example",FinTerme=new System.DateTime(2010,01,15),Mobile="407 3254 1478",ModeleVehicule="Model vhi 1",Phone1="407 412 145",Phone2="458745 123"},
                new Client{ClientId=4,NomClient="Alpha",FinTerme=new System.DateTime(2010,01,15),Mobile="407 3254 1478",ModeleVehicule="Model vhi 1",Phone1="407 412 145",Phone2="458745 123"}
            };

            return PartialView(clients);
        }
        public ActionResult GetFicheClient()
        {
            FicheClient client = new FicheClient()
            {
                Id = 1,
                Courriel = "Sergio@Suly.ca",
                DateAchat = new System.DateTime(2015, 12, 15),
                Langue= "Français",
                Niv= "1450 000 254",
                NoClient="235 654 741",
                NomClient="Sergio Palgiaroliui",
                NoteAppelsPrecedents="alalalalalalalalalllalalalalall",
                Terme= "48 mois",
                ValeurVehicule="45 0000",
                TypeAchat="000000",
                VehiculeDesire="Honda",
                Ville="Quebec"
            };

            return PartialView(client);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}