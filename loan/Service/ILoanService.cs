using loan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loan.Service
{
    public interface ILoanService
    {
        void AddLoan(Loan entity);
    }
}
