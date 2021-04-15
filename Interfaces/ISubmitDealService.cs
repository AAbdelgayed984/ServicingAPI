using ServicingAPI.Classes;

namespace ServicingAPI.Interfaces
{
    public interface ISubmitDealService
    {
        SubmitDealResponse SubmitDeal(SubmitDealRequest model);
    }
}