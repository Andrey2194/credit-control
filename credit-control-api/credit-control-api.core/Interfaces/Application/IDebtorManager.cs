using credit_control_api.core.Entities;

namespace credit_control_api.core.Interfaces.Application
{
    public interface IDebtorManager
    {
        //CRUD
        Guid Create(Debtor record);
        Debt GetById(Guid Id);
        List<Debt> GetAll();
        bool Update(Debtor record);
        bool Delete(Guid Id);
    }
}
