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
    public partial class frmTransaction : Form
    {
        private FrmTransactionViewModel _frmTransactionViewModel;
        private int _accountId;

        public frmTransaction(FrmTransactionViewModel frmTransactionViewModel, int accountId)
        {
            _accountId = accountId;
            _frmTransactionViewModel = frmTransactionViewModel;
            InitializeComponent();
            Init();
        }

        public frmTransaction(FrmTransactionViewModel frmTransactionViewModel, string transactionType, int accountId)
        {
            _accountId = accountId;
            _frmTransactionViewModel = frmTransactionViewModel;

            if (transactionType == "deposit")
            {
                _frmTransactionViewModel.IsDeposit = true;
            }
            else
            {
                _frmTransactionViewModel.IsWithdrawal = true;
            }
                        
            InitializeComponent();
            InitForDepositAndWithdrawal();
        }

        private void Init()
        {
            txtSenderAccout.Text = _frmTransactionViewModel.GetSenderAccountByAccounId(_accountId);
        }

        private void InitForDepositAndWithdrawal()
        {
            if (_frmTransactionViewModel.IsDeposit)
            {
                Text = "Deposit";
            }
            else
            {
                Text = "Withdrawal";
            }
            lblAccountOfRecipient.Visible = false;
            txtRecipientAccount.Visible = false;
            lblSender.Visible = false;
            txtSenderAccout.Visible = false;
            lblSS.Visible = false;
            txtSS.Visible = false;
            lblKS.Visible = false;
            numtxtKS.Visible = false;
            lblVS.Visible = false;
            numtxtVS.Visible = false;
            lblMessageForRecipient.Visible = false;
            txtMessageForRecipient.Visible = false;
            Height = 161;
            Width = 376;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_frmTransactionViewModel.IsDeposit ||_frmTransactionViewModel.IsWithdrawal)
            {
                if (_frmTransactionViewModel.IsNotEnoughMoney(decimal.Parse(numtxtAmmount.Text), _accountId) && _frmTransactionViewModel.IsWithdrawal)
                {
                    MessageBox.Show("It's not possible to make withdrawal, there is not enough money.");
                }
                else
                {
                    _frmTransactionViewModel.Ammount = decimal.Parse(numtxtAmmount.Text);
                    _frmTransactionViewModel.AddTransaction(_accountId);
                }
                
            }
            else
            {
                if (_frmTransactionViewModel.IsNotEnoughMoney(decimal.Parse(numtxtAmmount.Text), _accountId))
                {
                    MessageBox.Show("It's not possible to make transaction, there is not enough money.");
                }
                else
                {
                    _frmTransactionViewModel.AccountOfRecipient = txtRecipientAccount.Text;
                    _frmTransactionViewModel.Ammount = decimal.Parse(numtxtAmmount.Text);
                    _frmTransactionViewModel.Vs = int.Parse(numtxtVS.Text);
                    _frmTransactionViewModel.Ss = txtSS.Text;
                    _frmTransactionViewModel.Ks = int.Parse(numtxtKS.Text);
                    _frmTransactionViewModel.MessageForRecipient = txtMessageForRecipient.Text;
                    _frmTransactionViewModel.AddTransaction(_accountId);
                }
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
