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
    public partial class adminEmployee : Form
    {
        SQLDBClass con;
        int count=0;
        string sFName, sLName, sEmpId, sRole, sEmpUser, sEmpPass;
        int selectIndex;
        public bool addShowData=false, removeShowData=false, updateShowData=false;
        public adminEmployee()
        {
            InitializeComponent();
            con = new SQLDBClass();
            con.SqlQuery("SELECT empid,FirstName,LastName,employeeUser,employeePassword,role from employeeID");
            empDataVIew.DataSource = con.QueryExeute();
        }
       
        //removes employee from the database
        private void rmvEmp_Click(object sender, EventArgs e)
        {
            clearBool();
            removeShowData = true;
            addEmployee.Show();
            updateEmp.Show();
            rmvEmp.Hide();
            removeBtn.Show();
            removeEmpGroup.Show();
            addEmpGroup.Hide();
            UpdateInfoGroup.Hide();

        }
        private void removeBtn_Click(object sender, EventArgs e)
        {
            //con = new SQLDBClass();     
            clearBool(); 
            removeShowData = true;

            selectIndex = empDataVIew.CurrentCell.RowIndex;
            //empDataVIew.Rows.RemoveAt(selectIndex);
            con.SqlQuery("DELETE FROM employeeID WHERE empid=" + rEmpID.Text);
            con.NonQueryExeute();
            MessageBox.Show("Deleted");
        }
       
        
        //Addes new employee into the database
        private void addEmployee_Click(object sender, EventArgs e)
        {
            clearBool();
            addShowData = true;
            addEmpGroup.Show();
            removeEmpGroup.Hide();
            UpdateInfoGroup.Hide();
            addingBtn.Show();
            addEmployee.Hide();
            rmvEmp.Show();
            updateEmp.Show();
        }
        private void addingBtn_Click(object sender, EventArgs e)
        {
            addShowData = true;
            if (firstName.Text == "" || lastName.Text == "" || employeeId.Text == "" || empRole.Text == "" || Username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Please fill out all of the fields shown");
            }
            else
            {
                con.SqlQuery("INSERT INTO employeeID (FirstName,LastName,employeeUser,employeePassword,role,empid) values(@fName,@lName,@User,@Pass,@Role,@ID)");
                con._cmd.Parameters.AddWithValue("@fName", firstName.Text);
                con._cmd.Parameters.AddWithValue("@lName", lastName.Text);
                con._cmd.Parameters.AddWithValue("@User", Username.Text);
                con._cmd.Parameters.AddWithValue("@Pass", Password.Text);
                con._cmd.Parameters.AddWithValue("@Role", empRole.Text);
                con._cmd.Parameters.AddWithValue("@ID", employeeId.Text);

                con.NonQueryExeute();
            }
            MessageBox.Show("Employee Added");
        }

        //update datebase
        //Updates employee information
        private void updateEmp_Click(object sender, EventArgs e)
        {
            clearBool();
            updateShowData = true;
            UpdateInfoGroup.Show();
            updateBtn.Show();
            updateBtn.BringToFront();
            updateEmp.Hide();
            updateEmp.Hide();
            removeEmpGroup.Hide();
            addEmpGroup.Hide();
            rmvEmp.Show();
            updateEmp.Show();
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            clearBool(); 
            updateShowData = true;
            //con = new SQLDBClass();
            con.SqlQuery("Select empid,FirstName,LastName,employeeUser,employeePassword,role from employeeID where empid='" + searchId.Text + "'");
            //checks if the employee is in the database
            foreach (DataRow drs in con.QueryExeute().Rows)
            {
                if (searchId.Text == drs[0].ToString())
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
            }
            if (count == 0)
            {
                MessageBox.Show("Please enter a valid EmployeeID");
            }
            else
            {
                //starts the update process
                foreach (DataRow dr in con.QueryExeute().Rows)
                {
                    //After the employee is found it checks the textboxes so it knows which one to update
                    if (uFName.Text != "" || uLName.Text != "" || uRole.Text != "" || uEmpID.Text != "" || uUsername.Text != "" || uPassword.Text != "")
                    {
                        //updates the employees information based on the textboxes that are filled in.
                        con.SqlQuery("Update employeeId set FirstName= @fName, LastName= @lastName,role=@role,employeeUser=@user,employeePassword=@password,empid=@ID where empid ='" + searchId.Text + "'");
                        //if the textbox is empty it stores the value back to the database
                        if (uFName.Text == "")
                        {
                            sFName = dr[1].ToString();
                            con._cmd.Parameters.AddWithValue("@fName", sFName);

                        }
                        //if there is something there it will update that cell with the new information
                        else
                        {
                            con._cmd.Parameters.AddWithValue("@fName", uFName.Text);
                        }

                        if (uLName.Text == "")
                        {
                            sLName = dr[2].ToString();
                            con._cmd.Parameters.AddWithValue("@lastName", sLName);
                        }
                        else
                        {
                            con._cmd.Parameters.AddWithValue("@lastName", uLName.Text);

                        }

                        if (uRole.Text == "")
                        {
                            sRole = dr[5].ToString();
                            con._cmd.Parameters.AddWithValue("@role", sRole);
                        }
                        else
                        {
                            con._cmd.Parameters.AddWithValue("@role", uRole.Text);

                        }

                        if (uUsername.Text == "")
                        {
                            sEmpUser = dr[3].ToString();
                            con._cmd.Parameters.AddWithValue("@user", sEmpUser);
                        }
                        else
                        {
                            con._cmd.Parameters.AddWithValue("@user", uUsername.Text);
                        }

                        if (uPassword.Text == "")
                        {
                            sEmpPass = dr[4].ToString();
                            con._cmd.Parameters.AddWithValue("@password", sEmpPass);
                        }
                        else
                        {

                            con._cmd.Parameters.AddWithValue("@password", uPassword.Text);

                        }

                        if (uEmpID.Text == "")
                        {
                            sEmpId = dr[0].ToString();
                            con._cmd.Parameters.AddWithValue("@ID", sEmpId);
                        }
                        else
                        {
                            con._cmd.Parameters.AddWithValue("@ID", uEmpID.Text);
                        }

                    }
                    else { MessageBox.Show("Please enter information in the textboxes"); }
                    con.NonQueryExeute();
                }
                MessageBox.Show("Updated");
            }
        }

        private void adminEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productListDataSet.employeeID' table. You can move, or remove it, as needed.
            //this.employeeIDTableAdapter.Fill(this.productListDataSet.employeeID);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //Clears all the booleans for the datatable view

        private void clearBool()
        {
            addShowData = false;
            removeShowData = false;
            updateShowData = false;
        }
        


        //If any cell in the datagrid is click the information needed to change,add,or remove will display in the textbox
        private void empDataVIew_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectIndex = e.RowIndex;
            DataGridViewRow row = empDataVIew.Rows[selectIndex];
            if (addShowData)
            {
                employeeId.Text = row.Cells[0].Value.ToString();
                firstName.Text = row.Cells[1].Value.ToString();
                lastName.Text = row.Cells[2].Value.ToString();
                Username.Text = row.Cells[3].Value.ToString();
                Password.Text = row.Cells[4].Value.ToString();
                empRole.Text = row.Cells[5].Value.ToString();

            }
            else if (removeShowData)
            {
                rFName.Text = row.Cells[1].Value.ToString();
                rLName.Text = row.Cells[2].Value.ToString();
                rEmpID.Text = row.Cells[0].Value.ToString();
            }
            else if (updateShowData)
            {
                searchId.Text = row.Cells[0].Value.ToString();
                uEmpID.Text = row.Cells[0].Value.ToString();
                uFName.Text = row.Cells[1].Value.ToString(); 
                uLName.Text = row.Cells[2].Value.ToString();
                uRole.Text = row.Cells[5].Value.ToString();
                uUsername.Text = row.Cells[3].Value.ToString();
                uPassword.Text = row.Cells[4].Value.ToString();
            }

        }

     
    
        //*********************************************************************************************************************
        private void fName_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addEmp_Enter(object sender, EventArgs e)
        {

        }

        private void removeEmp_Enter(object sender, EventArgs e)
        {

        }
    }
}
