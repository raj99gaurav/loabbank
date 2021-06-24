using loan.Models;
using loan.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loan.Service
{
    public class LoanService : ILoanService
    {
        private readonly ILoanRepository _Repository;
        public LoanService(ILoanRepository Repository)
        {
            _Repository = Repository;
        }
        public void AddLoan(Loan entity)
        {
            _Repository.Add(entity);
        }
    }
}
