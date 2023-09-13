using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppUnionBuildingLoans
{
    public class BusinessLoans : Loan
    {
        public BusinessLoans(int loannum, string name, string surname, int iRate, int period, double loan, double balance) : base(loannum, name, surname, iRate, period, loan, balance)
        {
        }
        public BusinessLoans() { }
        public List<BusinessLoans> BusinessLoan(List<Loan> LoanList)
        {
            List<BusinessLoans> businessLoansList = new List<BusinessLoans>();

            foreach (var item in LoanList)
            {
                if (item is BusinessLoans)
                {
                    businessLoansList.Add(item as BusinessLoans);
                }
            }
            return businessLoansList;
        }
        public override List<Loan> moneyOwed(List<Loan> LoanList)
        {
            foreach (var item in LoanList)
            {
                if (item is BusinessLoans)
                {
                    double rate = item._IRate / 100;
                    item.Balance = item._Loan + (item._Loan * rate);
                }
            }

            return LoanList;

        }
    }
}
