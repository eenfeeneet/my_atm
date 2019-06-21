using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class PerAccntMenu : Form
    {
        public PerAccntMenu()
        {
            InitializeComponent();
        }

        bool withdrawal = false;
        bool deposit = false;
        public double cBalance;
        public double change;


        public string acName(string name)
        {
            return txtAccntHolderName.Text = name;
        }
        public string acID(string ID)
        {
            return txtAccntNumber.Text = ID;
        }

        public string acBalance(double balance)
        {
            cBalance = balance;
            return txtBalance.Text = "$"+ balance;           
        }

        public void newBalanceAW(double change)
        {

            double obalance = cBalance;
            double nbalance = obalance - change;
           
            txtBalance.Text = "$" + nbalance;
            txtNBalance2.Text = "$" + nbalance;
            txtNBalance1.Text = "$" + nbalance;

            withdrawal = false;
            cBalance = nbalance;

            grpWithdrawal1.Visible = false;
            grpWithdrawal2.Visible = false;
            grpWithdrawalEnd.Visible = true;
        }
        public void newBalanceAD(double change)
        {
            double obalance = cBalance;
            double nbalance = obalance + change;

            txtBalance.Text = "$" + nbalance;
            txtNBalance2.Text = "$" + nbalance;
            txtNBalance1.Text = "$" + nbalance;

            deposit = false;
            cBalance = nbalance;

            grpDeposit1.Visible = false;
            grpDepositEnd.Visible = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtWOther.Text = txtWOther.Text + "1";
            txtDeposit.Text = txtDeposit.Text + "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtWOther.Text = txtWOther.Text + "2";
            txtDeposit.Text = txtDeposit.Text + "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtWOther.Text = txtWOther.Text + "3";
            txtDeposit.Text = txtDeposit.Text + "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtWOther.Text = txtWOther.Text + "4";
            txtDeposit.Text = txtDeposit.Text + "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            txtWOther.Text = txtWOther.Text + "5";
            txtDeposit.Text = txtDeposit.Text + "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txtWOther.Text = txtWOther.Text + "6";
            txtDeposit.Text = txtDeposit.Text + "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtWOther.Text = txtWOther.Text + "7";
            txtDeposit.Text = txtDeposit.Text + "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txtWOther.Text = txtWOther.Text + "8";
            txtDeposit.Text = txtDeposit.Text + "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txtWOther.Text = txtWOther.Text + "9";
            txtDeposit.Text = txtDeposit.Text + "9";
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txtWOther.Text = txtWOther.Text + "0";
            txtDeposit.Text = txtDeposit.Text + "0";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ExitForm.Exit();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWOther.Clear();
            txtDeposit.Clear();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (withdrawal == true)
            {
                change = Convert.ToDouble(txtWOther.Text);
                var result = Messages.WithdConfirmationMsg(change);
                if (result == DialogResult.Yes)
                {
                    txtWAmnt.Text = "$" + change;
                    newBalanceAW(change);

                    grpWithdrawal2.Visible = false;
                    grpWithdrawalEnd.Visible = true;
                }

            }
            else if (deposit == true)
            {
                change = Convert.ToDouble(txtDeposit.Text);
                var result = Messages.DepConfirmationMsg(change);
                if (result == DialogResult.Yes)
                {
                    txtDAmnt.Text = "$" + change;
                    newBalanceAD(change);

                    grpDeposit1.Visible = false;
                    grpDepositEnd.Visible = true;
                }
            }
        }
        
        private void PerAccntMenu_Load(object sender, EventArgs e)
        {
            grpMain.Visible = true;

            grpBalance.Visible = false;

            grpWithdrawal1.Visible = false;
            grpWithdrawal2.Visible = false;
            grpWithdrawalEnd.Visible = false;

            grpDeposit1.Visible = false;
            grpDepositEnd.Visible = false;
        }
        private void btnBalance_Click(object sender, EventArgs e)
        {
            grpMain.Visible = false;            

            grpBalance.Visible = true;

            grpWithdrawal1.Visible = false;
            grpWithdrawal2.Visible = false;
            grpWithdrawalEnd.Visible = false;

            grpDeposit1.Visible = false;
            grpDepositEnd.Visible = false;
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            grpMain.Visible = false;

            grpBalance.Visible = false;

            grpWithdrawal1.Visible = true;
            grpWithdrawal2.Visible = false;
            grpWithdrawalEnd.Visible = false;

            grpDeposit1.Visible = false;
            grpDepositEnd.Visible = false;

            withdrawal = true;
            deposit = false;
            
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            grpMain.Visible = false;

            grpBalance.Visible = false;

            grpWithdrawal1.Visible = false;
            grpWithdrawal2.Visible = false;
            grpWithdrawalEnd.Visible = false;

            grpDeposit1.Visible = true;
            grpDepositEnd.Visible = false;

            withdrawal = false;
            deposit = true;
        }
        private void btnWOther_Click(object sender, EventArgs e)
        {
            grpWithdrawal1.Visible = false;
            grpWithdrawal2.Visible = true;            
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            PerAccntMenu_Load(null, null);
        }



        private void btnW1_Click(object sender, EventArgs e)
        {
            change = 20;
            var result = Messages.FastCashConfirmationMsg(20);
            if (result == DialogResult.Yes)
            {
                txtWAmnt.Text = "$" + change;
                newBalanceAW(change);
            }
        }

        private void btnW2_Click(object sender, EventArgs e)
        {
            change = 50;
            var result = Messages.FastCashConfirmationMsg(50);
            if (result == DialogResult.Yes)
            {
                txtWAmnt.Text = "$" + change;
                newBalanceAW(change);

                grpWithdrawal1.Visible = false;
                grpWithdrawalEnd.Visible = true;
            }
        }

        private void btnW3_Click(object sender, EventArgs e)
        {
            change = 100;
            var result = Messages.FastCashConfirmationMsg(100);
            if (result == DialogResult.Yes)
            {
                txtWAmnt.Text = "$" + change;
                newBalanceAW(change);

                grpWithdrawal1.Visible = false;
                grpWithdrawalEnd.Visible = true;
            }
        }

        private void btnW4_Click(object sender, EventArgs e)
        {
            change = 200;
            var result = Messages.FastCashConfirmationMsg(200);
            if (result == DialogResult.Yes)
            {
                txtWAmnt.Text = "$" + change;
                newBalanceAW(change);

                grpWithdrawal1.Visible = false;
                grpWithdrawalEnd.Visible = true;
            }
        }

        private void btnW5_Click(object sender, EventArgs e)
        {
            change = 500;
            var result = Messages.FastCashConfirmationMsg(500);
            if (result == DialogResult.Yes)
            {
                txtWAmnt.Text = "$" + change;
                newBalanceAW(change);

                grpWithdrawal1.Visible = false;
                grpWithdrawalEnd.Visible = true;
            }
        }

        private void btnW6_Click(object sender, EventArgs e)
        {
            change = 1000;
            var result = Messages.FastCashConfirmationMsg(1000);
            if (result == DialogResult.Yes)
            {
                txtWAmnt.Text = "$" + change;
                newBalanceAW(change);

                grpWithdrawal1.Visible = false;
                grpWithdrawalEnd.Visible = true;
            }
        }

        
    }
}
