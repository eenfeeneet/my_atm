using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Messages
    {
        public static void ErrorMsg()
        {
            var result = MessageBox.Show("Invalid Input!\nWould you like to continue?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                ExitForm.Exit();
            }
        }
        public static DialogResult WithdConfirmationMsg(double change)
        {
            return MessageBox.Show("You chose to withdraw $ "+change+".\nConfirm Selection?", "Confirm Withdrawal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
        }
        public static DialogResult DepConfirmationMsg(double change)
        {
            return MessageBox.Show("You chose to deposit $ "+change+".\nConfirm Selection?", "Confirm Deposit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }
        public static DialogResult FastCashConfirmationMsg(double change)
        {
            return MessageBox.Show("You chose to withdraw $ "+change+".\nConfirm Selection?", "Confirm Withdrawal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
        }

    }   }