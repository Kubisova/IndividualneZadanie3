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
    public partial class frmAccounts : Form
    {
        private frmAccountsViewModel _frmAccountsViewModel;

        public frmAccounts(frmAccountsViewModel frmAccountsViewModel)
        {
            _frmAccountsViewModel = frmAccountsViewModel;
            InitializeComponent();
        }

        private void cmdManageAccount_Click(object sender, EventArgs e)
        {
            using (frmClientManagement newForm = new frmClientManagement())
            {
                newForm.ShowDialog();
            }
        }

        private void frmAccounts_Load(object sender, EventArgs e)
        {
            dGVAccounts.DataSource = _frmAccountsViewModel.GetAccounts();
            
        }
    }
}
