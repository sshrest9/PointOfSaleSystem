using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
//Shusen Shrestha

namespace SqlDBClass
{
    public partial class LoginScreen : Form
    {
        //SqlDataReader dr;
        SQLDBClass con;
        int count = 0, admin = 0;
        string final;
        public LoginScreen()
        {
            InitializeComponent();

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Does the login in check. Can't get the error message to pop-up becuase there is no reader so i can't do it yet
        //need to fix this later.
        private void loginIn_Click(object sender, EventArgs e)
        {
            con = new SQLDBClass();
            con.SqlQuery("SELECT * FROM employeeId where employeeUser='" + uName.Text + "' and employeePassword='" + pWord.Text + "'");
            if (uName.Text != "" && pWord.Text != "")
            {
                foreach (DataRow drs in con.QueryExeute().Rows)
                {
                    if (uName.Text == drs[4].ToString() && pWord.Text == drs[5].ToString())
                    {
                        final = drs[6].ToString().Trim();
                        if (final == "Admin")
                        {
                            admin++;
                        }
                        else if (final == "Cash")
                        {
                            count++;
                        }
                    }
                }

                if (admin == 1)
                {
                    AdminForm adm = new AdminForm(this, uName.Text, pWord.Text);
                    adm.Show();
                    this.Hide();
                }
                else if (count == 1)
                {
                    Form1 frm = new Form1(this, uName.Text, pWord.Text);
                    frm.Show();
                    this.Hide();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate User");
                }
                else if (admin == 0 && count == 0)
                {
                    MessageBox.Show("Incorrect Username or Passowrd");
                    uName.Text = "";
                    pWord.Text = "";
                }
            }
            else { MessageBox.Show("Please enter username and password"); }
            
        }
    }
}
