using System.Collections.Generic;

namespace ServicingAPI.Classes
{
    public class SubmitDealResponse
    {
        public Deal Deal { get; set; }
        public List<Client> Clients { get; set; }
    }
}