using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppUnionBuildingLoans
{
    public partial class Form1 : Form
    {
        List<Loan> LoanList = new List<Loan>();
        BindingSource bs = new BindingSource();
        public static Form1 Instance;

        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCont.Visible = false;
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            FormDisplay form = new FormDisplay();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        public int lnum = 0; 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lnum++;
                //Created instances of sub classes to apply discounts
                Loan l = new Loan();
                PersonalLoans pl = new PersonalLoans();

                string name = txtName.Text;
                string surname = txtSurname.Text;
                int iRate = (int)nudIRate.Value;
                int period = (int)nudPeriod.Value;
                double loan = double.Parse(txtARequired.Text);

                PersonalLoans person = new PersonalLoans(lnum, name, surname, iRate, period, loan, loan);
                LoanList.Add(person);

                LoanList = pl.moneyOwed(LoanList);

                foreach (var loanItem in LoanList)
                {
                    MessageBox.Show($"Loan Number: {loanItem.Loannum}, Name: {loanItem._Name}, Balance: {loanItem._Loan}");
                }
                LoanList.Sort(l);

                // Creating an instance of FormDisplay if it doesn't exist
                if (FormDisplay.accessF == null)
                {
                    FormDisplay.accessF = new FormDisplay();
                }

                //DataGridView dg = FormDisplay.accessF.dgvl.DataSource;

                bs.DataSource = LoanList;
                FormDisplay.accessF.dgvl.DataSource = bs;


                if (lnum == 5)
                {
                    btnCapnStore.Visible = false;
                    btnCont.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
