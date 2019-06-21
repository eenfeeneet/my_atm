using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class ExitForm
    {       

        public static void Exit()
        {
            var result = MessageBox.Show("Do you want to exit application?", "Terminating Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
                
            }
        }
    }
}
