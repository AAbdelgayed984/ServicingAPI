using System;
using System.Text.Json.Serialization;

namespace ServicingAPI.Classes
{
    public class MortgageLifeInsurance
    {
        public string Policy {get;set;}
        public string Company {get;set;}
        public DateTime Expiry {get;set;}
        public Decimal CoverageValue {get;set;}    
    }

}