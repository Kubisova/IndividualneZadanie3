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
    public partial class frmClientManagement : Form
    {
        private FrmClientManagementViewModel _frmClientManagementViewModel;
        private int _accountId;

        /// <summary>
        /// Used when viewing/updating existing client.
        /// </summary>
        /// <param name="clientId"></param>
        public frmClientManagement(FrmClientManagementViewModel frmClientManagementViewModel, int accountId)
        {
            _frmClientManagementViewModel = frmClientManagementViewModel;
            _accountId = accountId;
            InitializeComponent();

            dGVShortAccountInfo.DataSource = _frmClientManagementViewModel.GetAccountByID(accountId);
            dGVShortAccountInfo.Columns[0].Visible = false;
            dGVShortAccountInfo.Columns[1].Visible = false;
            dGVShortAccountInfo.Columns[7].Visible = false;
            dGVShortAccountInfo.Columns[8].Visible = false;
            dGVShortAccountInfo.Columns[11].Visible = false;
            dGVShortAccountInfo.Columns[12].Visible = false;

            dGVCards.DataSource = _frmClientManagementViewModel.GetCards(accountId);
            dGVCards.Columns[0].Visible = false;

           
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            using (frmAccount newForm = new frmAccount(new FrmAccountViewModel(), _accountId))
            {
                if (_frmClientManagementViewModel.IsAccountOpen(_accountId))
                {
                    newForm.Text = "Edit account";
                    newForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("It's not possible to update, account is canceled!");
                }
                
            }
        }

        private void cmdDeposit_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction(new FrmTransactionViewModel(), $"deposit", _accountId))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdWithdrawal_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction(new FrmTransactionViewModel(), $"withdrawal", _accountId))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions(new FrmTransactionsViewModel(), _accountId))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdNewTransaction_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction(new FrmTransactionViewModel(), _accountId))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdCloseAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close the account?", "Close Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _frmClientManagementViewModel.CloseAccount(_accountId);
                //DialogResult = DialogResult.OK;

            }
        }

        private void btnAddNewCard_Click(object sender, EventArgs e)
        {
            if (_frmClientManagementViewModel.IsAccountOpen(_accountId))
            {
                _frmClientManagementViewModel.AddNewCard(_accountId);
            }
            else
            {
                MessageBox.Show("It's not possible to add new card, account is canceled!");
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dGVCards.DataSource = _frmClientManagementViewModel.GetCards(_accountId);
            dGVCards.Columns[0].Visible = false;

            dGVShortAccountInfo.DataSource = _frmClientManagementViewModel.GetAccountByID(_accountId);
            dGVShortAccountInfo.Columns[0].Visible = false;
            dGVShortAccountInfo.Columns[1].Visible = false;
            dGVShortAccountInfo.Columns[7].Visible = false;
            dGVShortAccountInfo.Columns[8].Visible = false;
            dGVShortAccountInfo.Columns[11].Visible = false;
            dGVShortAccountInfo.Columns[12].Visible = false;
        }
    }
}
