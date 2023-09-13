using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsAppUnionBuildingLoans
{
    public class Loan:IComparer<Loan>
    {
        int loannum;
        string _name;
        string _surname;
        int _iRate;
        int _period;
        double _loan;
        double balance;
        public Loan(int loannum,string name, string surname, int iRate, int period, double loan, double balance)
        {
            this.Loannum = loannum;
            this._Name = name;
            this._Surname = surname;
            this._IRate = iRate;
            this._Period = period;
            this._Loan = loan;
            this.Balance = balance;
        }
        public Loan() { }

        public int Loannum { get => loannum; set => loannum = value; }
        public string _Name { get => _name; set => _name = value; }
        public string _Surname { get => _surname; set => _surname = value; }
        public int _IRate { get => _iRate; set => _iRate = value; }
        public int _Period { get => _period; set => _period = value; }
        public double _Loan { get => _loan; set => _loan = value; }
        public double Balance { get => balance; set => balance = value; }

        public virtual List<Loan> moneyOwed(List<Loan> LoanList)
        {
            return LoanList;
        }

        public int Compare(Loan x, Loan y)
        {
            if (x.loannum == y.loannum)
            {
                return 0;//Indicates loan numbers are the same
            }
            return x.loannum.CompareTo(y.loannum);
        }
    }
}
