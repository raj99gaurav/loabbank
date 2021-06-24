using loan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loan.Repo
{
    public interface ILoanRepository
    {
        void Add(Loan entity);
    }
}
