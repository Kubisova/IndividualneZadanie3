using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmMain : Form
    {
        private FrmMainViewModel _frmMainViewModel;

        public frmMain(FrmMainViewModel frmMainViewModel)
        {
            _frmMainViewModel = frmMainViewModel;
            InitializeComponent();
        }

        private void cmdFindClient_Click(object sender, EventArgs e)
        {
            var findedAccounts = _frmMainViewModel.FindClients(txtFilter.Text);

            if (findedAccounts.Count == 1)
            {
                using (frmClientManagement newForm = new frmClientManagement(new FrmClientManagementViewModel(), findedAccounts[0].Id))
                {
                    newForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("There is no such client/account, or there was found more than one account");
            }


            
        }

        private void cmdNewAccount_Click(object sender, EventArgs e)
        {
            using (frmAccount newForm = new frmAccount(new FrmAccountViewModel()))
            {
                newForm.Text = "Add account";
                newForm.ShowDialog();
            }
        }

        private void cmdAllAccounts_Click(object sender, EventArgs e)
        {
            using (frmAccounts newForm = new frmAccounts(new FrmAccountsViewModel()))
            {
                
                newForm.ShowDialog();
            }
        }

        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions(new FrmTransactionsViewModel()))
            {
                newForm.ShowDialog();
            }
        }
    }
}
