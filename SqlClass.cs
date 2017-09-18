using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Data.OleDb;
//Shusen Shrestha

namespace SqlDBClass
{
    public class SQLDBClass
    {
        //Declaring the variables need to make the connections from C# to SQL 
        //Made a class to so it's more efficent to use in the future. Don't need to keep
        //writing it over and over again
        private SqlConnection _con;
        public SqlCommand _cmd;
        private SqlDataAdapter _da;
        private DataTable _dt;
        private SqlDataReader dr;

        //Creating the connection from C# to SQL
        public SQLDBClass()
        {
            //Used SQL SERVER EXPLORER 
            //Messed up the datatable DO NOT USE IN FUTURE
            //_con = new SqlConnection(@"Data Source=SHUSEN-LAPTOP;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            
            //Useing SQL SERVER OBJECT EXPLORER
            //Just works better idk why
            _con = new SqlConnection(@"Data Source=SHUSEN-LAPTOP;Initial Catalog=productList;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _con.Open();
        }
        
        //Used to pass in SQL commands 
        public void SqlQuery(string queryTest)
        {
            _cmd = new SqlCommand(queryTest, _con);

        }

        //Filling the DataTable with information from the database
        public DataTable QueryExeute()
        {
            _da = new SqlDataAdapter(_cmd);
            _dt = new DataTable();
            _da.Fill(_dt);
            return _dt;
        }

        //for insert,update,delete
        public void NonQueryExeute()
        {
            _cmd.ExecuteNonQuery();
        }
        //End of Comments
    }
}
