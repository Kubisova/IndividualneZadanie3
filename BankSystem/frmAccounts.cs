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
        private FrmAccountsViewModel _frmAccountsViewModel;

        public frmAccounts(FrmAccountsViewModel frmAccountsViewModel)
        {
            _frmAccountsViewModel = frmAccountsViewModel;
            InitializeComponent();
            
        }

        private void cmdManageAccount_Click(object sender, EventArgs e)
        {
            if(dGVAccounts.CurrentRow!= null)
            {
                int index = dGVAccounts.CurrentRow.Index;
                int accountId = _frmAccountsViewModel.GetAccountId(index);
                using (frmClientManagement newForm = new frmClientManagement(new FrmClientManagementViewModel(), accountId))
                {
                    newForm.ShowDialog();
                }
            }
        }

        private void frmAccounts_Load(object sender, EventArgs e)
        {
            dGVAccounts.DataSource = _frmAccountsViewModel.GetAccounts();
            dGVAccounts.Columns[0].Visible = false;

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dGVAccounts.DataSource = _frmAccountsViewModel.GetFilteredAccounts(txtFilter.Text);
        }
    }
}
