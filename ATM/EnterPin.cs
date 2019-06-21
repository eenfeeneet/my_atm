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
    public partial class EnterPin : Form
    {

        public EnterPin()
        {
            InitializeComponent();
        }

        public void PinClear()
        {
            if (txtPinNum.TextLength < 4)
            {
                Messages.ErrorMsg();
                txtPinNum.Clear();
            }
            else
            {
                int pin;
                pin = int.Parse(txtPinNum.Text);

                PerAccntMenu perAM = new PerAccntMenu();

                switch (pin)
                {
                    case 1234:
                        perAM.Show();
                        perAM.acName("Clark Kent");
                        perAM.acID("1-902871-187");
                        perAM.acBalance(1500.50);
                        this.Hide();
                        break;
                    case 5555:
                        perAM.Show();
                        perAM.acName("Bruce Wayne");
                        perAM.acID("5-278390-010");
                        perAM.acBalance(20.30);
                        this.Hide();
                        break;
                    case 1987:
                        perAM.Show();
                        perAM.acName("Diana Prince");
                        perAM.acID("8-198222-011");
                        perAM.acBalance(5050.00);
                        this.Hide();
                        break;
                    case 2018:
                        perAM.Show();
                        perAM.acName("Hal Jordan");
                        perAM.acID("9-122873-227");
                        perAM.acBalance(30.15);
                        this.Hide();
                        break;
                    default:
                        Messages.ErrorMsg();
                        txtPinNum.Clear();
                        break;
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPinNum.Text = txtPinNum.Text + "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtPinNum.Text = txtPinNum.Text + "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtPinNum.Text = txtPinNum.Text + "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtPinNum.Text = txtPinNum.Text + "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            txtPinNum.Text = txtPinNum.Text + "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txtPinNum.Text = txtPinNum.Text + "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtPinNum.Text = txtPinNum.Text + "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txtPinNum.Text = txtPinNum.Text + "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txtPinNum.Text = txtPinNum.Text + "9";
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txtPinNum.Text = txtPinNum.Text + "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPinNum.Clear();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            PinClear();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ExitForm.Exit();
        }

        private void EnterPin_Load(object sender, EventArgs e)
        {

        }
    }
}
