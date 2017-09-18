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
    public partial class adminProducts : Form
    {
        SQLDBClass con;
        int selectIndex,count;
        string uSName, uSPrice, uSProName, uSQuantity;
        public bool addShowData = false, removeShowData = false, updateShowData = false;

        private void updateProductGroup_Enter(object sender, EventArgs e)
        {

        }



        private void removeProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public adminProducts()
        {
            InitializeComponent();
            con = new SQLDBClass();
            con.SqlQuery("SELECT Name,Price,productNum,Quantity FROM itemList");
            productList.DataSource = con.QueryExeute();
        }

        //adds new products to database
        private void addingBtm_Click(object sender, EventArgs e)
        {
            if (addProductName.Text == "" || addProductPrice.Text == "" || addProNumber.Text == "" || addQuantity.Text == "")
            {
                MessageBox.Show("Please fill out all of the fields shown");
            }
            else
            {
                con.SqlQuery("INSERT INTO itemList (Name,Price,productNum,Quantity) values(@Name,@Price,@productNum,@Quantity)");
                con._cmd.Parameters.AddWithValue("@Name", addProductName.Text);
                con._cmd.Parameters.AddWithValue("@Price", addProductPrice.Text);
                con._cmd.Parameters.AddWithValue("@productNum", addProNumber.Text);
                con._cmd.Parameters.AddWithValue("@Quantity", addQuantity.Text);
                con.NonQueryExeute();
                MessageBox.Show("Product added");

            }
            displayData();
        }
        private void addProduct_Click(object sender, EventArgs e)
        {
            addProductsGroup.Show();
            updateProductGroup.Hide();
            removeProductsGroup.Hide();
            clearBool();
            addShowData = true;
            addProduct.Hide();
            addingBtm.Show();
            removeBtn.Show();
            updateProduct.Show();
        }



        private void removeBtn_Click(object sender, EventArgs e)
        {
            clearBool();
            removeProductsGroup.Show();
            addProductsGroup.Hide();
            updateProductGroup.Hide();
            removeShowData = true;
            removingBtn.Show();
            removeBtn.Hide();
            addProduct.Show();
            updateProduct.Show();
        }
        private void removingBtn_Click(object sender, EventArgs e)
        {

            con.SqlQuery("DELETE FROM itemList where productNum='" + removeProNumber.Text + "'");
            //con._cmd.Parameters.Remove(removeProNumber.Text);
            con.NonQueryExeute();
            displayData();
            MessageBox.Show("Product deleted");
            
        }


        //Updates products information in the database
        private void updateProduct_Click(object sender, EventArgs e)
        {

            updateProductGroup.Show();
            addProductsGroup.Hide();
            removeProductsGroup.Hide();
            updateShowData = true;
            updateProduct.Hide();
            updatingBtn.Show();
            addProduct.Show();
            removeBtn.Show();
        }
        private void updating()
        {
            selectIndex = productList.CurrentCell.RowIndex;
            con.SqlQuery("Select * from itemList where productNum='" + searchId.Text + "'");
            //checks if the employee is in the database
            foreach (DataRow drs in con.QueryExeute().Rows)
            {
                if (searchId.Text == drs[3].ToString())
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
                MessageBox.Show("Please enter a valid Product Number");
            }
            else
            {
                //starts the update process
                foreach (DataRow dr in con.QueryExeute().Rows)
                {

                    //After the employee is found it checks the textboxes so it knows which one to update
                    if (uProductName.Text != "" || uProductPrice.Text != "" || uProductNum.Text != "" || uQuantity.Text != "")
                    {
                        //updates the employees information based on the textboxes that are filled in.
                        con.SqlQuery("Update itemList set Name= @fName, Price= @lastName,productNum=@role,Quantity=@user where productNum ='" + searchId.Text + "'");
                        //if the textbox is empty it stores the value back to the database
                        if (uProductName.Text == "")
                        {
                            uSName = dr[1].ToString();
                            con._cmd.Parameters.AddWithValue("@fName", uSName);

                        }
                        //if there is something there it will update that cell with the new information
                        else
                        {
                            con._cmd.Parameters.AddWithValue("@fName", uProductName.Text);
                        }

                        if (uProductPrice.Text == "")
                        {
                            uSPrice = dr[2].ToString();
                            con._cmd.Parameters.AddWithValue("@lastName", uSPrice);
                        }
                        else
                        {
                            con._cmd.Parameters.AddWithValue("@lastName", uProductPrice.Text);

                        }

                        if (uProductNum.Text == "")
                        {
                            uSProName = dr[3].ToString();
                            con._cmd.Parameters.AddWithValue("@role", uSProName);
                        }
                        else
                        {
                            con._cmd.Parameters.AddWithValue("@role", uProductNum.Text);

                        }

                        if (uQuantity.Text == "")
                        {
                            uSQuantity = dr[4].ToString();
                            con._cmd.Parameters.AddWithValue("@user", uSQuantity);
                        }
                        else
                        {
                            con._cmd.Parameters.AddWithValue("@user", uQuantity.Text);
                        }
                    }
                    else { MessageBox.Show("Please enter infromation"); }
                    con.NonQueryExeute();
                }
                displayData();
                MessageBox.Show("Updated");
            }
        }
        private void updatingBtn_Click(object sender, EventArgs e)
        {
            clearBool();
            updating();
        }



        //displays updated information;
        private void displayData()
        {
            con.SqlQuery("SELECT * FROM itemList");
            productList.DataSource = con.QueryExeute();
        }
        
        private void clearBool()
        {
            addShowData = false;
            removeShowData = false;
            updateShowData = false;
        }
        private void productList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            con.SqlQuery("SELECT * From itemList");
            selectIndex = e.RowIndex;
            DataGridViewRow row = productList.Rows[selectIndex];
            if (updateShowData)
            {
                searchId.Text = row.Cells[2].Value.ToString();
                uProductName.Text = row.Cells[0].Value.ToString();
                uProductPrice.Text= row.Cells[1].Value.ToString();
                uProductNum.Text= row.Cells[2].Value.ToString();
                uQuantity.Text= row.Cells[3].Value.ToString();
            }
            else if (addShowData)
            {
                addProductName.Text = row.Cells[0].Value.ToString();
                addProductPrice.Text = row.Cells[1].Value.ToString();
                addProNumber.Text = row.Cells[2].Value.ToString();
                addQuantity.Text = row.Cells[3].Value.ToString();
            }
            else if (removeShowData)
            {
                removeProductName.Text = row.Cells[0].Value.ToString();
                removeProNumber.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
