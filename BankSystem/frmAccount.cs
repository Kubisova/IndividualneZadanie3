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
    public partial class frmAccount : Form
    {
        private FrmAccountViewModel _frmAccountViewModel;

        /// <summary>
        /// Used when adding new account.
        /// </summary>
        public frmAccount(FrmAccountViewModel frmAccountViewModel)
        {
            _frmAccountViewModel = frmAccountViewModel;
            InitializeComponent();
        }

        /// <summary>
        /// Used when viewing/updating existing account.
        /// </summary>
        /// <param name="clientId"></param>
        public frmAccount(FrmAccountViewModel frmAccountViewModel, int accountId)
        {
            _frmAccountViewModel = frmAccountViewModel;
            _frmAccountViewModel.GetAccountById(accountId);
            _frmAccountViewModel.IsEdit = true;
            InitializeComponent();
            InitForEdit();
        }

        private void InitForEdit()
        {
            txtAccountName.Text = _frmAccountViewModel.Account.AccountName;
            txtIban.Text = _frmAccountViewModel.Account.Iban;
            numtxtOverdraftLimit.Text = _frmAccountViewModel.Account.OverdraftLimit.ToString();
            numtxtCardsCount.Text = _frmAccountViewModel.Account.CardsCount.ToString();
            numtxtCardsCount.Enabled = false;
            txtName.Text = _frmAccountViewModel.Account.Client.Name;
            txtSurname.Text = _frmAccountViewModel.Account.Client.Surname;
            txtOpNumber.Text = _frmAccountViewModel.Account.Client.OpNumber;
            txtStreet.Text = _frmAccountViewModel.Account.Client.Street;
            txtStreetNumber.Text = _frmAccountViewModel.Account.Client.StreetNumber;
            txtCity.Text = _frmAccountViewModel.Account.Client.City;
            txtContact.Text = _frmAccountViewModel.Account.Client.Contact;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _frmAccountViewModel.AccountName = txtAccountName.Text;
            _frmAccountViewModel.Iban = txtIban.Text;
            _frmAccountViewModel.OverdraftLimit = decimal.Parse(numtxtOverdraftLimit.Text);
            _frmAccountViewModel.CardsCount = int.Parse(numtxtCardsCount.Text);

            _frmAccountViewModel.Name = txtName.Text;
            _frmAccountViewModel.Surname = txtSurname.Text;
            _frmAccountViewModel.OpNumber = txtOpNumber.Text;
            _frmAccountViewModel.Street = txtStreet.Text;
            _frmAccountViewModel.StreetNumber = txtStreetNumber.Text;
            _frmAccountViewModel.City = txtCity.Text;
            _frmAccountViewModel.Contact = txtContact.Text;

            if (_frmAccountViewModel.IsEdit)
            {
                _frmAccountViewModel.EditAccount();
            }
            else
            {
                _frmAccountViewModel.AddAccount();
            }

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
