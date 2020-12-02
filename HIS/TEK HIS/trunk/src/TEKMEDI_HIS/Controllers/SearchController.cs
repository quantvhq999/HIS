using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Microsoft.AspNetCore.Mvc;
using TEKMEDI_HIS.Models;

namespace TEKMEDI_HIS.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        
        public IActionResult Search(PatientResource patient)
        {
            var pan = new Patient();
            //The fhir server end point address      
            string ServiceRootUrl = "http://sqlonfhir-stu3.azurewebsites.net/fhir";
            //Create a client to send to the server at a given endpoint.
            var FhirClient = new FhirClient(ServiceRootUrl);
            // increase timeouts since the server might be powered down
            FhirClient.Timeout = (60 * 1000);
            try
            {
               
                ////Attempt to send the resource to the server endpoint
                //Bundle ReturnedSearchBundle = FhirClient.Search<Patient>(new string[] { "family=Nguyen" });
               
                //foreach (var Entry in ReturnedSearchBundle.Entry)
                //{

                //    Console.WriteLine("ID: " + Entry.Resource.Id);
                //    Console.WriteLine("Quốc gia: " + Entry.Resource.Language);
                //}
                //Console.WriteLine();
            }
            catch (FhirOperationException FhirOpExec)
            {
                ////Process any Fhir Errors returned as OperationOutcome resource
                //Console.WriteLine();
                //Console.WriteLine("An error message: " + FhirOpExec.Message);
                //Console.WriteLine();

            }
            catch (Exception GeneralException)
            {
                //Console.WriteLine();
                //Console.WriteLine("An error message: " + GeneralException.Message);
                //Console.WriteLine();
            }
            //Console.WriteLine("Press any key to end.");
            //Console.ReadKey();
            return View();

        }
    }
}
