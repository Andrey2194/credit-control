using credit_control_api.core.Entities;
using credit_control_api.core.Interfaces.Domain;
using credit_control_api.infraestructure.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace credit_control_api.infraestructure.DataAccess.Repositories
{
    public class DebtorRepository : IDebtorRepository
    {
        public CreditControlContext _context;

        public DebtorRepository(CreditControlContext context)
        {
            _context = context;
        }

        public Guid Create(Debtor record)
        {
            var resp = _context.Debtor.Add(record);
            _context.SaveChanges();

            return resp != null ? resp.Entity.Id : Guid.Empty;
        }

        public bool Delete(Guid Id)
        {
            Debtor finder = _context.Debtor.AsNoTracking().SingleOrDefault(x => x.Id == Id);

            if (finder != null)
            {
                _context.Debtor.Remove(finder);
                _context.SaveChanges();
                return true;
            }
            else
            {
                throw new DbUpdateException("Credit Control - Debtor does not exists");
            }
        }

        public List<Debtor> GetAll()
        {
            return _context.Debtor.ToList();
        }

        public Debtor GetById(Guid Id)
        {
            return _context.Debtor.AsNoTracking().Where(x => x.Id == Id).SingleOrDefault();
        }

        public bool Update(Debtor record)
        {
            _context.Update(record);
            _context.SaveChanges();

            return true;
        }
    }
}
