using loan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loan.Repo
{
    public class LoanRepository : ILoanRepository
    {
        readonly LoanContext _loanContext;
        public LoanRepository(LoanContext context)
        {
            _loanContext = context;
        }
        public void Add(Loan entity)
        {
            _loanContext.Loans.Add(entity);
            _loanContext.SaveChanges();
        }
    }
}
