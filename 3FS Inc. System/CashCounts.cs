using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using _3FS_System.Helpers;
using _3FS_System.Models;
using _3FS_System.Repositories;
using _3FS_System.Global_Variables;

namespace _3FS_System
{
    public partial class CashCounts : Form
    {
        float beginningcash, incash, payments, totalsales, subtot1, expenses, deposits, subtot2, computed, actual, difference;
        public CashCounts()
        {
            InitializeComponent();
            float beginningcash, totalsales, payments, expenses;
            CashCountRepository cashCountRepository = new CashCountRepository();
            SalesRepository salesRepository = new SalesRepository(); 
            CollectiblesRepository collectiblesRepository = new CollectiblesRepository();
            ExpensesRepository expensesRepository = new ExpensesRepository();
            beginningcash = cashCountRepository.GetActualRemainingCash_PerDate(DateTime.Today.AddDays(-1));
            totalsales = salesRepository.GetTotalSalesOfTheDay(DateTime.Today);
            payments = collectiblesRepository.GetCollectedAmountByDate(DateTime.Today);
            expenses = expensesRepository.GetExpensesAmount_PerDate(DateTime.Today);
            if (beginningcash > 0 )
            {
                BeginningCashText.Text = beginningcash.ToString();
            }
            else
            {
                MessageBox.Show("Manually enter beginning cash!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BeginningCashText.Enabled = true;
            }
            TotalSalesText.Text = totalsales.ToString();
            PaymentsText.Text = payments.ToString();
            ExpensesText.Text = expenses.ToString(); 
        }

        private void cashCountbutton_Click(object sender, EventArgs e)
        {
            if((String.IsNullOrEmpty(BeginningCashText.Text)) || (String.IsNullOrEmpty(IncashText.Text)) || (String.IsNullOrEmpty(PaymentsText.Text)) || (String.IsNullOrEmpty(TotalSalesText.Text)) || (String.IsNullOrEmpty(ExpensesText.Text)) || (String.IsNullOrEmpty(DepositsText.Text)) || (String.IsNullOrEmpty(ActualText.Text)))
            {
                MessageBox.Show("Enter complete details!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ExpensesRepository expensesRepository = new ExpensesRepository();
                
                try
                {
                    beginningcash = float.Parse(BeginningCashText.Text);
                    incash = float.Parse(IncashText.Text);
                    payments = float.Parse(PaymentsText.Text);
                    totalsales = float.Parse(TotalSalesText.Text);
                    subtot1 = beginningcash + incash + payments + totalsales;
                    SubtotText1.Text = subtot1.ToString();
                    expenses = expensesRepository.GetExpensesAmount_PerDate(DateTime.Today);
                    deposits = float.Parse(DepositsText.Text);
                    subtot2 = expenses + deposits;
                    SubtotText2.Text = subtot2.ToString();
                    computed = subtot1 - subtot2;
                    ComputedText.Text = computed.ToString();
                    actual = float.Parse(ActualText.Text);
                    difference = actual - computed;
                    DifferenceText.Text = difference.ToString();

                    save.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Invalid Input!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            CashCountRepository cashCountRepository = new CashCountRepository();
            CashCount cashCount = new CashCount
            {
                ActualRemainingCash = actual,
                ComputedRemainingCash = computed,
                TransactionDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                CreatedDate = DateTime.Now,
                StoreID = 1
            };
            cashCountRepository.Insert(cashCount);
            MessageBox.Show("Done Saving!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
