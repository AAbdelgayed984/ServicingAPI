using System;

namespace ServicingAPI.Classes
{
    public class PropertyTax
    {
        public Decimal Amount {get;set;}
        public string Municipality {get;set;}
        public Decimal CurrentTaxBalance{get;set;}
    }
}