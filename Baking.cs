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
    public partial class Baking : Form
    {
        SQLDBClass con;
        Form1 form1;
        Products prod;
        int quntityAmount;
        public Baking(Form1 frm,Products pro)
        {
            InitializeComponent();
            form1 = frm;
            prod = pro;
            con = new SQLDBClass();

        }
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
        private void bread_Click(object sender, EventArgs e)
        {
            getInfo("Bread");

        }

        private void bagel_Click(object sender, EventArgs e)
        {
            getInfo("Bagle");

        }

        private void hotDogBun_Click(object sender, EventArgs e)
        {
            getInfo("Hot Dog Bun");

        }

        private void flatbread_Click(object sender, EventArgs e)
        {
            getInfo("Flatbread");

        }

        private void brownies_Click(object sender, EventArgs e)
        {
            getInfo("Browines");

        }

        private void cookies_Click(object sender, EventArgs e)
        {
            getInfo("Cookies");

        }

        private void pie_Click(object sender, EventArgs e)
        {
            getInfo("Pie");

        }

        private void pizza_Click(object sender, EventArgs e)
        {
            getInfo("Pizza");

        }

        private void cake_Click(object sender, EventArgs e)
        {
            getInfo("Cake");

        }

        private void muffin_Click(object sender, EventArgs e)
        {
            getInfo("Muffin");

        }

        private void bBread_Click(object sender, EventArgs e)
        {
            getInfo("Brown Bread");

        }

        private void naan_Click(object sender, EventArgs e)
        {
            getInfo("Naan");

        }

        private void cinnamonRolls_Click(object sender, EventArgs e)
        {
            getInfo("Cinnamon Rolls");

        }

        private void multiBread_Click(object sender, EventArgs e)
        {
            getInfo("Multi Grain Bread");

        }

        private void garlicBread_Click(object sender, EventArgs e)
        {
            getInfo("Garlic Bread");

        }
    }
}
