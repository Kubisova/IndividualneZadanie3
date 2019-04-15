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
    public partial class frmMain : Form
    {
        private FrmMainViewModel _frmMainViewModel;

        public frmMain(FrmMainViewModel frmMainViewModel)
        {
            _frmMainViewModel = frmMainViewModel;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _frmMainViewModel.CardNumber = int.Parse(numtxtCardNumber.Text);
            _frmMainViewModel.Pin = int.Parse(numtxtPin.Text);

            if (_frmMainViewModel.IsCardNumberInDb())
            {
                if (_frmMainViewModel.IsAccountActive())
                {
                    if (_frmMainViewModel.IsCardValid())
                    {
                        if (_frmMainViewModel.IsCardBlocked())
                        {
                            MessageBox.Show("The card is blocked");
                        }
                        else
                        {
                            if (_frmMainViewModel.IsPinValid())
                            {
                                using (frmMenu newForm = new frmMenu(new FrmMenuViewModel(_frmMainViewModel.CardNumber)))
                                {
                                    newForm.ShowDialog();
                                }
                            }
                            else
                            {
                                MessageBox.Show("The pin is not correct");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("The card is not valid anymore");
                    }
                }
                else
                {
                    MessageBox.Show("The account is not active");
                }
            }
            else
            {
                MessageBox.Show("The card number is not correct");
            }

        }
    }
}
