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
    public partial class produceItems : Form
    {
        Form1 form1;
        Products prod;
        SQLDBClass con;
        int quntityAmount;
        public produceItems(Form1 form_1, Products pro)
        {
            InitializeComponent();
            form1 = form_1;
            prod = pro;
            con = new SQLDBClass();
        }

        //Displays the products information depending on the button that is pressed.
        //It will display in Form1 and close after the button has been clicked;
        private void getInfo(string name)
        {
            con.SqlQuery("SELECT * FROM itemList where Name='" + name + "'");
            foreach (DataRow dr in con.QueryExeute().Rows)
            {
                form1.listBox1.Items.Add(dr[1].ToString());
                form1.listBox2.Items.Add(dr[2].ToString());
                form1.listBox3.Items.Add(dr[3].ToString());
                form1.counter++;
                quntityAmount = (int)dr[4];
            }
            quntityAmount--;
            form1.quantity.Add(quntityAmount);

            con.SqlQuery("UPDATE itemList SET Quantity=@Qun WHERE Name='" + name + "'");
            con._cmd.Parameters.AddWithValue("@Qun", quntityAmount);
            con.NonQueryExeute();
            this.Close();
            prod.Close();
        }

        private void redApple_Click(object sender, EventArgs e)
        {
            getInfo("Red Apple");
        }

        private void gApple_Click(object sender, EventArgs e)
        {
            getInfo("Green Apple");
        }

        private void oranges_Click(object sender, EventArgs e)
        {
            getInfo("Oranges");
        }

        private void peach_Click(object sender, EventArgs e)
        {
            getInfo("Peach");
        }

        private void nectarines_Click(object sender, EventArgs e)
        {
            getInfo("Nectarine");
        }

        private void strawberry_Click(object sender, EventArgs e)
        {
            getInfo("Strawberry");
        }

        private void grapesGreen_Click(object sender, EventArgs e)
        {
            getInfo("Green Grapes");
        }

        private void redGrapes_Click(object sender, EventArgs e)
        {
            getInfo("Red Grapes");
        }

        private void avocado_Click(object sender, EventArgs e)
        {
            getInfo("Avocada");
        }

        private void celery_Click(object sender, EventArgs e)
        {
            getInfo("Celery");
        }

        private void spinach_Click(object sender, EventArgs e)
        {
            getInfo("Spinach");
        }

        private void cucumber_Click(object sender, EventArgs e)
        {
            getInfo("Cucumber");
        }

        private void kale_Click(object sender, EventArgs e)
        {
            getInfo("Kale");
        }

        private void asparagus_Click(object sender, EventArgs e)
        {
            getInfo("Asparagus");
        }

        private void slicedMush_Click(object sender, EventArgs e)
        {
            getInfo("Sliced Mushroom");
        }

        private void wholeMush_Click(object sender, EventArgs e)
        {
            getInfo("Whole Mushroom");
        }

        private void potato_Click(object sender, EventArgs e)
        {
            getInfo("Potato");
        }

        private void sweetCorn_Click(object sender, EventArgs e)
        {
            getInfo("Sweet Corn");
        }
    }
}
