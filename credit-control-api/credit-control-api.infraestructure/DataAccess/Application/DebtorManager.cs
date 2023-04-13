using credit_control_api.core.Entities;
using credit_control_api.core.Interfaces.Application;
using credit_control_api.core.Interfaces.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace credit_control_api.infraestructure.DataAccess.Application
{
    public class DebtorManager : IDebtorManager
    {
        private IDebtorRepository _debtorRepository;

        public DebtorManager(IDebtorRepository debtorRepository)
        {
            _debtorRepository = debtorRepository;
        }

        public Guid Create(Debtor record)
        {
            return _debtorRepository.Create(new Debtor
            {
                Name = record.Name,
                Active = record.Active,
            });
        }

        public bool Delete(Guid Id)
        {
            return _debtorRepository.Delete(Id);
        }

        public List<Debtor> GetAll()
        {
            return _debtorRepository.GetAll();
        }

        public Debtor GetById(Guid Id)
        {
            return _debtorRepository.GetById(Id);
        }

        public bool Update(Debtor record)
        {
            return _debtorRepository.Update(record);
        }
    }
}
