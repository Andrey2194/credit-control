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
    public class PaymentRepository : IPaymentRepository
    {
        CreditControlContext _context;

        public PaymentRepository(CreditControlContext context) {
            _context = context;
        }  

        public Guid Create(Payment record)
        {
            var resp = _context.Payment.Add(record);
            _context.SaveChanges();

            return resp != null ? resp.Entity.Id : Guid.Empty;
        }

        public bool Delete(Guid Id)
        {
            Payment finder = _context.Payment.AsNoTracking().SingleOrDefault(x => x.Id == Id);

            if (finder != null)
            {
                _context.Payment.Remove(finder);
                _context.SaveChanges();
                return true;
            }
            else
            {
                throw new DbUpdateException("Credit Control - Payment does not exists");
            }
        }

        public List<Payment> GetAll()
        {
            return _context.Payment.AsNoTracking().ToList();
        }

        public Payment GetById(Guid Id)
        {
            return _context.Payment.AsNoTracking().SingleOrDefault(x => x.Id == Id);
        }

        public bool Update(Payment record)
        {
            Payment finder = _context.Payment.AsNoTracking().SingleOrDefault(x => x.Id == record.Id);

            if(finder != null){
                _context.Update(record);
                _context.SaveChanges();
                return true;
            }
            else
            {
                throw new DbUpdateException("Credit Control - Payment does not exists");
            }
        }
    }
}
