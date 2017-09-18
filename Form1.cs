using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.SqlClient;
//Shusen Shrestha

namespace SqlDBClass
{
    public partial class Form1 : Form
    {
        //Declaring the variable for the connection to the SQL database
        private SQLDBClass con;
        LoginScreen log;
        string start,ending,boughtTime;
        string uName, pWord;
        List<string> itemName = new List<string>();
        List<string> itemPrice = new List<string>();
        List<string> producNum = new List<string>();
        public List<int> quantity = new List<int>();
        public int counter;
        static int idCounter=1;
        
        //Form initialization 
        public Form1(LoginScreen lgn,string userName,string password)
        {
            //for list boxes it is the same code as the comboBox to display it  
            InitializeComponent();
            start = DateTime.Now.ToString("yyyy,MM,dd,HH:mm:ss");
            log = lgn;
            uName = userName;
            pWord = password;
            con = new SQLDBClass();
            con.SqlQuery("SELECT * FROM itemList");
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            con.SqlQuery("Update employeeId set start= @start where employeeUser = '" + uName + "'and employeePassword = '" + pWord + "'");
            con._cmd.Parameters.AddWithValue("@start", start);
            con.NonQueryExeute();

        }

        //this is to insert new products into the database. No need for this anymore
        //Using this as pratice to learn the commands for SQL. CAN DELETE
        private void Insery_Click(object sender, EventArgs e)
        {
            //con = new SQLDBClass();

            con.SqlQuery("INSERT INTO itemList (Name,Price) Values(@Name,@Price)");
          
            con._cmd.Parameters.Add("@Name", textBox2.Text.Trim());
            con._cmd.Parameters.Add("@Price", textBox3.Text.Trim());
            //con._cmd.Parameters.Add("@productNum", textBox4.Text.Trim());

            con.NonQueryExeute();
            con.SqlQuery("SELECT * FROM itemList");
        }
        
        //This shows the second form which are all buttons so all you need to do is 
        //click and it will add the information to this form and display it on the Listboxes
        private void Show_Click(object sender, EventArgs e)
        {
            newCustomer();
            Products moreProd = new Products(this);
            moreProd.ShowDialog();
                
        }

        //This is adding the information entered into the textbox to the listboxes from the database
        //Can be removed due to the KeyDown method
        private void add_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Please enter the correct information in the box");
            }
            else {
                
                con = new SQLDBClass();
                //con.SqlQuery("SELECT * FROM itemList where Name='" + textBox2.Text + "'or productNum='" + textBox3.Text + "'");
                con.SqlQuery("SELECT Name,Price,productNum FROM itemList where Name='" + textBox2.Text + "'or productNum='" + textBox3.Text + "'");
                foreach (DataRow dr in con.QueryExeute().Rows)
                {
                    listBox1.Items.Add(dr[0].ToString());
                    listBox2.Items.Add(dr[1].ToString());
                    listBox3.Items.Add(dr[2].ToString());
                }
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        //Keeps all the information from the last customer until a new item is added after hitting check out
        private void newCustomer()
        {
            if (txtCashAmt.Text != "" && txtChange.Text != "")
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                txtCashAmt.Clear();
                txtChange.Clear();
                subTotal.Text = "";
                Tax.Text = "";
                finalTotal.Text = "";
            }
            else
            {
                return;
            }

        }


        //*****************************************************************************************************************************
        //This is to search the database. Need to use something else to display because it only displays the first item found with the 
        //given information from the textbox. Fix later STILL NEED TO FIX
        private void Search_Click(object sender, EventArgs e)
        {
            con = new SQLDBClass();
            con.SqlQuery("SELECT * FROM itemList where Name LIKE'%" + textBox2.Text + "%'or productNum LIKE'%" + textBox3.Text + "%'");

            if (textBox2.Text !=""||textBox3.Text!= "")
            {
                foreach (DataRow dr in con.QueryExeute().Rows)
                {
                    if (textBox2.Text == dr[1].ToString() || textBox3.Text == dr[3].ToString())
                    {
                        MessageBox.Show("Item Found\nProductID: " + dr[0] + " Name: " + dr[1] + " Price: " + dr[2] + " ProductNumber: " + dr[3] + " ");
            
                        textBox2.Text = "";
                        textBox3.Text = "";
                        break;

                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter information in the box");
            }
        }
        //******************************************************************************************************************************


        //this is so that if enter is pressd it does the same function as add
        //added this to make it easier to enter information
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                newCustomer();
                add.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        //Same as above
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                newCustomer();
                add.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        //Same as above
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                add.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        //This is to make sure all the product numbers do not exceed 5 character lengths
        //All product number are 5 numbers long
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //max length of the number can be 5
            textBox3.MaxLength = 5;

            //makes it so that only number can be inputted into the text box
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //Gets the total of all the items bought and adds said items into boughtItems Database
        private void total_Click(object sender, EventArgs e)
        {
            double total = 0.00;
            //MessageBox.Show(""+counter);
            //Adding items into the list from each listbox
            foreach (string str in listBox1.Items)
            {
                itemName.Add(str);   
            }
            foreach (string str in listBox2.Items)
            {
                itemPrice.Add(str);
                total = total + Double.Parse(str);
                
            }
            foreach (string str in listBox3.Items)
            {
                producNum.Add(str);
            }
            //setting the list to get the enumerator
            var item=itemName.GetEnumerator();
            var price=itemPrice.GetEnumerator();
            var product=producNum.GetEnumerator();
            var quantityCounter = quantity.GetEnumerator();
            //Loops throught all three list and addeds it into the database
            //Used Enumerators because it allows me to loop through mulitple list and i am able to read the data in the collection
            while (item.MoveNext() && price.MoveNext() && product.MoveNext()&&quantityCounter.MoveNext())
            {
                addBoughtItems(item.Current, price.Current, product.Current,quantityCounter.Current);
            }
            
            //Calculates the total of all the products
            subTotal.Text = "$" + total;
            Tax.Text = "13%";
            total = total * 1.13;
            finalTotal.Text = "$" + (total.ToString("#.##"));
            paymentMethod.Visible = true;

        }

        //Function for adding items to the boughtItems table
        //Part of the Total
        private void addBoughtItems(string val1,string val2,string val3,int qun)
        {
            boughtTime = DateTime.Now.ToString("yyy,MM,dd,HH:mm:ss");
            con.SqlQuery("INSERT INTO boughtItems (IdCounter,Cashier,ItemName,ItemPrice,ProductNumber,boughtTime,Quantity) Values(@idCounter,@User,@iName,@iPrice,@pNum,@bTime,@qun)");
            con._cmd.Parameters.AddWithValue("@idCounter", idCounter);
            con._cmd.Parameters.AddWithValue("@User", uName);
            con._cmd.Parameters.AddWithValue("@iName",val1);
            con._cmd.Parameters.AddWithValue("@iPrice", val2);
            con._cmd.Parameters.AddWithValue("@pNum", val3);
            con._cmd.Parameters.AddWithValue("@bTime", boughtTime);
            con._cmd.Parameters.AddWithValue("@qun", qun);
            con.NonQueryExeute();
        }

        //Can delete items from listboxes if items need to be removed from the listboxes
        //Only problem is that you have to click all items in all listboxes to remove the single item from the list
        //Must find a way to connect the three different listboxes so that it can be done more efficiently
        //Google maybe or ask FIX!!!!
        private void button2_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex >= 0)
            { 
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                listBox3.Items.RemoveAt(listBox3.SelectedIndex);

            }

        }

        //calls the payment
        private void paymentMethod_Click(object sender, EventArgs e)
        {
            paymentMethod pay = new paymentMethod(this);
            pay.Show();
        }
        
        //clears everything in the form
        public void clearAll()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            subTotal.Text = "";
            Tax.Text = "";
            finalTotal.Text = "";
            paymentMethod.Hide();
            textBox2.Focus();
            itemName.Clear();
            itemPrice.Clear();
            producNum.Clear();
            idCounter++;
        }

        //logs out the user
        private void logOut_Click(object sender, EventArgs e)
        {
            ending=DateTime.Now.ToString("yyyy,MM,dd,HH:mm:ss").Trim();
            con.SqlQuery("Update employeeId set start= @start,finish= @end where employeeUser = '" + uName + "'and employeePassword = '" + pWord + "'");

            con._cmd.Parameters.AddWithValue("@start", start);
            con._cmd.Parameters.AddWithValue("@end", ending.Trim());

            con.NonQueryExeute();


            this.Close();
            log.Show();
            log.uName.Clear();
            log.pWord.Clear();
        }


        //***********************************************************************************************************************
        //All function from here on out are misclicks and are too much of a hassle to removed
        //Since it will mess up the program and I don't want to go to the designer can change it manually.
        private void Tax_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ending = DateTime.Now.ToString("yyyy,MM,dd,HH:mm:ss").Trim();
            con.SqlQuery("Update employeeId set start= @start,finish= @end where employeeUser = '" + uName + "'and employeePassword = '" + pWord + "'");
            con._cmd.Parameters.AddWithValue("@start", start);
            con._cmd.Parameters.AddWithValue("@end", ending.Trim());
            con.NonQueryExeute();
            log.Show();
            log.uName.Clear();
            log.pWord.Clear();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //End of Comments
        //***********************************************************************************************************************

    }
}
