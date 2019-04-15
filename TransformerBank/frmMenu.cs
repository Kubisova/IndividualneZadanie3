using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformerBank
{
    public partial class frmMenu : Form
    {
        private FrmMenuViewModel _frmMenuViewModel;

        public frmMenu(FrmMenuViewModel frmMenuViewModel)
        {
            _frmMenuViewModel = frmMenuViewModel;
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            numtxtAmount.Enabled = false;
            btnOkWithdrawal.Enabled = false;
            btnCancelWithdrawal.Enabled = false;
            txtAccountBalance.Enabled = false;
            btnBalanceOK.Enabled = false;
            btnCancelBalance.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            numtxtAmount.Enabled = true;
            btnOkWithdrawal.Enabled = true;
            btnCancelWithdrawal.Enabled = true;
            btnAccountBalance.Enabled = false;
        }

        private void btnAccountBalance_Click(object sender, EventArgs e)
        {
            txtAccountBalance.Text = _frmMenuViewModel.GetAccounBalance();
            btnBalanceOK.Enabled = true;
            btnCancelBalance.Enabled = true;
            btnWithdrawal.Enabled = false;
        }

        private void btnOkWithdrawal_Click(object sender, EventArgs e)
        {
            _frmMenuViewModel.Amount = decimal.Parse(numtxtAmount.Text);
            _frmMenuViewModel.AddWithdrawal();
            MessageBox.Show("Thank you for using our services, have a nice day");
            Close();

        }

        private void btnBalanceOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our services, have a nice day");
            Close();
        }

        private void btnCancelWithdrawal_Click(object sender, EventArgs e)
        {
            numtxtAmount.Enabled = false;
            numtxtAmount.Text = "";
            btnOkWithdrawal.Enabled = false;
            btnCancelWithdrawal.Enabled = false;
            txtAccountBalance.Enabled = false;
            btnBalanceOK.Enabled = false;
            btnCancelBalance.Enabled = false;
            btnAccountBalance.Enabled = true;
        }

        private void btnCancelBalance_Click(object sender, EventArgs e)
        {
            numtxtAmount.Enabled = false;
            btnOkWithdrawal.Enabled = false;
            btnCancelWithdrawal.Enabled = false;
            txtAccountBalance.Enabled = false;
            txtAccountBalance.Text = "";
            btnBalanceOK.Enabled = false;
            btnCancelBalance.Enabled = false;
            btnWithdrawal.Enabled = true;
        }
    }
}
