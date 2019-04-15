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
    public partial class frmTransactions : Form
    {
        private FrmTransactionsViewModel _frmTransactionsViewModel;

        /// <summary>
        /// Used when viewing all transactions.
        /// </summary>
        public frmTransactions(FrmTransactionsViewModel frmTransactionsViewModel)
        {
            _frmTransactionsViewModel = frmTransactionsViewModel;
            InitializeComponent();
            dgvTransactions.DataSource = _frmTransactionsViewModel.GetTransactions();
            dgvTransactions.Columns[0].Visible = false;
        }

        /// <summary>
        /// Used when viewing selected client's transactions.
        /// </summary>
        /// <param name="clientId"></param>
        public frmTransactions(FrmTransactionsViewModel frmTransactionsViewModel, int accountId)
        {
            _frmTransactionsViewModel = frmTransactionsViewModel;
            InitializeComponent();
            dgvTransactions.DataSource = _frmTransactionsViewModel.GetTransactionsByAccountId(accountId);
            dgvTransactions.Columns[0].Visible = false;

        }
    }
}
