using credit_control_api.core.Entities;

namespace credit_control_api.core.Interfaces.Domain
{
    public interface IDebtorRepository
    {
        Guid Create(Debtor record);
        Debtor GetById(Guid Id);
        List<Debtor> GetAll();
        bool Update(Debtor record);
        bool Delete(Guid Id);
    }
}
