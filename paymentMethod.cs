using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlDBClass
{
    public partial class paymentMethod : Form
    {
        Form1 form;
        public paymentMethod(Form1 frm)
        {
            InitializeComponent();
            form = frm;
        }

        private void cash_Click(object sender, EventArgs e)
        {
            cashMethod.Visible = true;
            cashAmount.Focus();
        }

        private void cashAmount_KeyDown(object sender, KeyEventArgs e)
        {
            double cshamt,total=0.00,change=0.00;
            string exactChange;
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(cashAmount.Text))
                { 
                    cshamt = Convert.ToDouble(cashAmount.Text);
                    foreach (string str in form.listBox2.Items)
                    {
                        total = total + Double.Parse(str);
                    }
                    total = total * 1.13;
                    if (cshamt > 0)
                    {
                        if (cshamt >=total)
                        {
                            change = (cshamt - total);
                            exactChange = change.ToString("#.##");
                            if (exactChange=="0.00")
                            {
                                MessageBox.Show("No Change");

                            }
                            else
                            {
                                form.txtCashAmt.Text = cashAmount.Text;
                                form.txtChange.Text = change.ToString("#.##");
                                //MessageBox.Show("The change is $" + change.ToString("#.##") + "");

                            }
                            this.Close();
                        }
                        else { MessageBox.Show("Amount entered is less than total"); }
                    }
                    else
                    {
                        MessageBox.Show("Please enter an amount greater than 0");
                        cashAmount.Clear();
                    }
                }
            }
        }

        private void cashAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cashAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
