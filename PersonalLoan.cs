using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppUnionBuildingLoans
{
    public class PersonalLoans : Loan
    {
        public PersonalLoans(int loannum, string name, string surname, int iRate, int period, double loan, double balance) : base(loannum, name, surname, iRate, period, loan, balance)
        {
        }
        public PersonalLoans() { }
        public List<PersonalLoans> PersonalLoan(List<Loan> LoanList)
        {
            List<PersonalLoans> PersonalLoansList = new List<PersonalLoans>();

            foreach (var item in LoanList)
            {
                if (item is PersonalLoans)
                {
                    PersonalLoansList.Add(item as PersonalLoans);
                }
            }
            return PersonalLoansList;
        }
        public override List<Loan> moneyOwed(List<Loan> LoanList)
        {
            foreach (var item in LoanList)
            {
                if (item is PersonalLoans)
                {
                    double rate = item._IRate / 100;
                    item.Balance = item._Loan + (item._Loan * rate);
                }
            }

            return LoanList;

        }
    }
}
