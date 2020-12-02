using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TEKMEDI_HIS.Models
{

    public class PatientResource
    {
        [Required]
        public string Id{get; set;}
        public bool Active { get; set; }
        public bool Deceased { get; set; }
        public string familyName { get; set; }
        public string givenName { get; set; }
        public string Gender { get; set; }
        public string birthDay { get; set; }
        public string phoneNumber { get; set; }
        
            public string Line { get; set; }
            public string District { get; set; }
            public string City { get; set; }
        
        public string maritalStatus { get; set; }
        public string Email { get; set; }
        public string Language { get; set; }
        public void Test()
        {
            Console.WriteLine("Hello");
        }
        
            public string Relationship { get; set; }
            public string familyNameContact { get; set; }
            public string middleNameContact { get; set; }
            public string givenNameContact { get; set; }
            public string GenderContact { get; set; }
            public string LineContact { get; set; }
            public string DistrictContact { get; set; }
            public string CityContact { get; set; }
            public string PhoneContact { get; set; }
        
    }
}
