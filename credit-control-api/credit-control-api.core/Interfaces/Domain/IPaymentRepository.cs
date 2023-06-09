﻿using credit_control_api.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace credit_control_api.core.Interfaces.Domain
{
    public interface IPaymentRepository
    {
        Guid Create(Payment record);
        Payment GetById(Guid Id);
        List<Payment> GetAll();
        bool Update(Payment record);
        bool Delete(Guid Id);
    }
}
