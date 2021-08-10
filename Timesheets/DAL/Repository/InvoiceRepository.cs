using Timesheets.DAL.Interfaces;
using Timesheets.Models;

namespace Timesheets.DAL.Repository
{
    public class InvoiceRepository : Repository<Invoice>
    {
        private readonly IDataContainer<Invoice> _container;

        public InvoiceRepository(IDataContainer<Invoice> container) 
            : base(container)
        {
            _container = container;
        }

        public Invoice GetInvoiceByContractId(int contractId)
        {
            return _container.Entities.Find(x => x.ContractId == contractId);
        }
    }
}
