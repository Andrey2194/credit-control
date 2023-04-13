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
    public class DebtRepository : IDebtRepository
    {
        public CreditControlContext _context;

        public DebtRepository(CreditControlContext context)
        {
            _context = context;
        }

        public Guid Create(Debt record)
        {

            if(record.Debtor != null)
            {
                record.Debtor = _context.Debtor.AsNoTracking().Where(x => x.Id == record.Debtor.Id).SingleOrDefault();

                if(record.Debtor == null)
                {
                    throw new DbUpdateException("Credit Control - Debtor not exists");
                }
            }

            var resp = _context.Debt.Add(record);
            _context.SaveChanges();

            return resp != null ? resp.Entity.Id : Guid.Empty;
        }

        public bool Delete(Guid Id)
        {
            Debt finder = _context.Debt.AsNoTracking().SingleOrDefault(x => x.Id == Id);

            if (finder != null)
            {
                _context.Debt.Remove(finder);
                _context.SaveChanges();
                return true;
            }
            else
            {
                throw new DbUpdateException("Credit Control - Debt does not exists");
            }
        }

        public List<Debt> GetAll()
        {
            return _context.Debt.Include(x => x.Debtor)
                .ThenInclude(x => x.Debts)
                .ToList();
        }

        public Debt GetById(Guid Id)
        {
            return _context.Debt.SingleOrDefault(x => x.Id == Id);
        }

        public bool Update(Debt record)
        {
            _context.Debt.Update(record);
            _context.SaveChanges();

            return true;
        }
    }
}
