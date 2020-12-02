using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TEKMEDI_HIS.Models;

namespace TEKMEDI_HIS.Controllers
{
    public class HomeController : Controller
    {

       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AddPatient()
        {
            
            return View();
        }
        public IActionResult SearchPatient()
        {
            return View();
        }
        public IActionResult Patient()
        {

            return View();
        }
        public IActionResult UpdatePatient()
        {
            return View();
        }
        public IActionResult ReceivePatient()
        {
            return View();
        }
        public IActionResult PatientHistory()
        {
            return View();
        }
        public IActionResult OutPatientExam()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Subscribe(PatientResource patient)
        {
            if (ModelState.IsValid)
            {
                //TODO: SubscribeUser(model.Email);
            }

            return View("Index", patient);
        }
        public ActionResult Search(PatientResource patient)
        {
            if (ModelState.IsValid)
            {
                //TODO: SubscribeUser(model.Email);
            }

            return View("Index", patient);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
