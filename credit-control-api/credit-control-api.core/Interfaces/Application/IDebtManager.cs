using credit_control_api.core.Entities;

namespace credit_control_api.core.Interfaces.Application
{
    public interface IDebtManager
    {
        //CRUD
        Guid Create(Debt record);
        Debt GetById(Guid Id);
        List<Debt> GetAll();
        bool Update(Debt record);
        bool Delete(Guid Id);
    }
}
