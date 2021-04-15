using System;
using System.Text.Json.Serialization;

namespace ServicingAPI.Classes
{
    public class MortgageInsuranceDetails
    {
        public Enums.MortgageInsurers MortgageInsurer {get;set;}
        public Decimal PremiumAmount {get;set;}
        public Decimal TaxAmount {get;set;}
        public string CertificateNumber {get;set;}        
    }
}
