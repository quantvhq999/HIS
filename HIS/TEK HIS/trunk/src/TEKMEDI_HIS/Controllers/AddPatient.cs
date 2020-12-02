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
    public class AddPatient : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(PatientResource patient)
        {
            string id = patient.Id;
            string MessageID = Guid.NewGuid().ToString();

            var pan = new Patient();
            pan.Name.Add(new HumanName().WithGiven(patient.givenName).AndFamily(patient.familyName));
            pan.Identifier.Add(new Identifier("http://acme.org/MRNs", id));
            pan.Id = MessageID;
            patient.Active =true;
           
            pan.Active = patient.Active;
            if (patient.Gender == "Male")
            {
                pan.Gender = AdministrativeGender.Male;
            }else if (patient.Gender == "Female")
            {
                pan.Gender = AdministrativeGender.Female;
            }
            else if (patient.Gender == "Other")
            {
                pan.Gender = AdministrativeGender.Other;
            }else if(patient.Gender =="Unknown")
            {
                pan.Gender = AdministrativeGender.Unknown;
            }
            pan.BirthDate = patient.birthDay;
            pan.Address.Add(new Address()
            {
                Text = patient.Line,
                District = patient.District,
                City = patient.City
            });
            pan.Telecom.Add(new ContactPoint()
            {
                System = ContactPoint.ContactPointSystem.Phone,
                Value = patient.phoneNumber
            }) ;
            pan.MaritalStatus = new CodeableConcept("http://acme.org/MRNs",patient.maritalStatus);
            pan.Language = patient.Language;
            pan.Contact.Add(new Patient.ContactComponent()
            {
                Name = new HumanName().WithGiven(patient.middleNameContact).WithGiven(patient.givenNameContact).AndFamily(patient.familyNameContact),
                Address = new Address()
                {
                    Text = patient.LineContact,
                    District = patient.CityContact,
                    City = patient.DistrictContact
                },
                Gender = AdministrativeGender.Female,
                

            }) ;
            var client = new FhirClient("http://sqlonfhir-stu3.azurewebsites.net/fhir/");
            var outcome = client.Create<Patient>(pan);
            //var outcome = client.Update<Patient>(pat);
            // Print the ID of the newly created resource
            
            Console.WriteLine(outcome.Id);
            Console.ReadLine();
            return View();
        }
    }
}
