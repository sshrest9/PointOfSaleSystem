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
    public partial class AdminForm : Form
    {
        LoginScreen log;
        string uName, pWord;
        SQLDBClass con;
        string start,ending;
        adminEmployee emp;
        adminProducts pro;

        public AdminForm()
        {
            InitializeComponent();
            start = DateTime.Now.ToString();
            con = new SQLDBClass();
        }

        public AdminForm(LoginScreen lgn,string userName,string passWord)
        {
            InitializeComponent();
            log = lgn;
            uName = userName;
            pWord = passWord;
            start = DateTime.Now.ToString("yyyy,MM,dd,HH:mm:ss");
            con = new SQLDBClass();
            con.SqlQuery("Update employeeId set start= @start where employeeUser = '" + uName + "'and employeePassword = '" + pWord + "'");
            con._cmd.Parameters.AddWithValue("@start", start);
            con.NonQueryExeute();

        }

        private void viewProducts_Click(object sender, EventArgs e)
        {
            adminProducts pro = new adminProducts();
            pro.Show();
        }

        private void viewEmployee_Click(object sender, EventArgs e)
        {
            emp = new adminEmployee();
            emp.Show();
            emp.empDataVIew.Show();
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            emp = new adminEmployee();
            emp.Show();
            //btn
            emp.addEmpGroup.Show();
            //group
            emp.addEmployee.Show();
            emp.addShowData = true;
        }

        private void rmvEmployee_Click(object sender, EventArgs e)
        {
            emp = new adminEmployee();
            emp.Show();
            //btn
            emp.rmvEmp.Show();
            //group
            emp.removeEmpGroup.Show();
            emp.removeShowData = true;
        }

        private void updateEmployee_Click(object sender, EventArgs e)
        {
            emp = new adminEmployee();
            emp.Show();
            emp.updateShowData = true;
            //btn
            emp.updateEmp.Show();
            //group
            emp.UpdateInfoGroup.Show();
        }

        private void updateProducts_Click(object sender, EventArgs e)
        {
            pro = new adminProducts();
            pro.Show();
            pro.updateShowData = true;
            pro.updateProductGroup.Show();
        }

        private void rmvProduct_Click(object sender, EventArgs e)
        {
            pro = new adminProducts();
            pro.Show();
            pro.removeShowData = true;
            pro.removeProductsGroup.Show();
        }

        private void addProducts_Click(object sender, EventArgs e)
        {
            pro = new adminProducts();
            pro.Show();
            pro.addShowData = true;

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ending = DateTime.Now.ToString("yyyy,MM,dd,HH:mm:ss").Trim();
            con.SqlQuery("Update employeeId set start= @start,finish= @end where employeeUser = '" + uName + "'and employeePassword = '" + pWord + "'");
            con._cmd.Parameters.AddWithValue("@start", start);
            con._cmd.Parameters.AddWithValue("@end", ending.Trim());
            con.NonQueryExeute();
            log.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
