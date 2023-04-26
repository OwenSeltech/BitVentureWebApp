using BitVentureWebApp.Models;

namespace BitVentureWebApp.Interfaces
{
    public interface IPaymentRepository
    {
        Task<bool> AddPaymentAsync(Payments payments);
        Task<IEnumerable<Master>> GetMasterDetails();
        Task<IEnumerable<Report>> GetReport();
        Task<IEnumerable<Detail>> GetDetails(string accNumber);
    }
}
