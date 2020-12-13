using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace ThanhDLL
{
    public class DataHelper
    {
        ///////////////////////////////////////
        // CONNECTING TO DATABASE
        ///////////////////////////////////////
        MySqlConnection connection;
        MySqlDataAdapter dataAdapter;

        /**
         * Constructors
         */
        public DataHelper()
        {
            string connectionInfo = "server=studmysql01.fhict.local;" +
                                    "database=dbi387862;" +
                                    "user id=dbi387862;" +
                                    "password=blueberrypie;" +
                                    "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
            dataAdapter = new MySqlDataAdapter();
        }

        ///////////////////////////////////////
        // DATA TABLES
        ///////////////////////////////////////

        // Data tables are used for displaying data on data grid views

        // Build data table from SQL
        public DataTable DataTableFromSQL(string sql)
        {
            try
            {
                dataAdapter.SelectCommand = new MySqlCommand(sql, connection);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                return table;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error trying to build data table");
                return null;
            }
        }

        // Update data table
        // Used when data is being modified from application
        public bool UpdateTable(DataTable changes)
        {
            try
            {
                dataAdapter.Update(changes);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error trying to update dat table");
                return false;
            }
            return true;
        }

        ///////////////////////////////////////
        // DATASETS
        ///////////////////////////////////////

        // Data sets are used for charts

        public DataSet GetDataset(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                dataAdapter.SelectCommand = new MySqlCommand(sql, connection);
                dataAdapter.Fill(ds);
                return ds;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error trying to get the dataset");
                return null;
                // return false;
            }
            finally
            {
                connection.Close();
            }
        }

        ///////////////////////////////////////
        // COUNT ROWS
        ///////////////////////////////////////

        // Count rows from an input sql
        public int CountRowSQL(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error counting rows");
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }

        // Count all rows from a specified table
        public int CountRowTable(string table)
        {
            string sql = "SELECT COUNT(*) FROM " + table;

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error counting rows");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        ///////////////////////////////////////
        // AUTHENTICATION
        ///////////////////////////////////////

        // Check for nr. of rows matching username and password
        public int CheckCredentials(string username, string pwd)
        {
            string sql = "SELECT COUNT(*) 'Nr' FROM LOGIN WHERE Username = '" + username + "' AND Password='" + pwd + "'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            int nr = 0;

            try
            {
                connection.Open();
                nr = Convert.ToInt32(command.ExecuteScalar());
                return nr;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error checking credentials");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        ///////////////////////////////////////
        // UPDATING DATA
        ///////////////////////////////////////

        // Every entity has some attributes that can be modified depending on scenarios
        // For example: with Visitor it can be the boolean CheckedIn
        // These methods update those attributes in the database to match the changes made in the app

        public int UpdateSelectedVisitor(Visitor v)
        {
            string sql = "UPDATE VISITOR " +
                        "SET Credit = " + v.Credit + "," +
                        "CheckedIn = " + v.CheckedIn + "," +
                        "IsInCamp = " + v.IsInCamp + ", " +
                        "RFIDNr = " + (v.RFIDNr == "" ? "NONE" : "'" + v.RFIDNr + "'");

            sql += " WHERE IdNr = " + v.IdNr;

            //MessageBox.Show(sql);

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
            }
            catch (MySqlException exc)
            {
                MessageBox.Show("Error trying to update visitor");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        public int UpdateSelectedReservation(Reservation r)
        {
            string sql = "UPDATE camping_reservation " +
                        "SET Paid = " + r.Paid + ", " +
                        " NrCheckedIn = " + r.NrCheckedIn +
                        " WHERE ReservNr =" + r.ReservNr;

            //MessageBox.Show(sql);

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error updating reservation");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        public int UpdateSelectedTicket(Ticket t)
        {
            string sql = "UPDATE ticket " +
                        "SET Paid = " + t.Paid
                        + ", EntryTime = CONVERT('" + t.EntryTime.ToString("yyyy-MM-dd HH:mm:ss") + "', DATETIME)"
                        + " WHERE TicketNr =" + t.TicketNr;

            //MessageBox.Show(sql);

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error updating ticket");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        public int UpdateLoanArticle(LoanArticle a)
        {
            string sql = "UPDATE loan_article" +
                        " SET Available = " + a.Available +
                        " WHERE ArticleNr = " + a.ArticleNr +
                        " AND ShopNr =" + a.ShopNr;

            //MessageBox.Show(sql);

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error updating article");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        public int UpdateSelectedArticle(Article a)
        {
            string sql = "UPDATE article" +
                        " SET Available = " + a.Available +
                        " WHERE ArticleNr =" + a.ArticleNr +
                        " AND ShopNr =" + a.ShopNr;

            //MessageBox.Show(sql);

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error updating article");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        ///////////////////////////////////////
        // VISITORS
        ///////////////////////////////////////

        // Methods dealing with data related to visitor are here


        // Read from db and transfer to variables
        public Visitor ReadDataVisitor(MySqlDataReader reader, Visitor v)
        {

            // reading
            while (reader.Read())
            {
                // temporary variables
                int nr;
                string first;
                string last;
                string phone;
                string mail;
                string rfidNr = "";
                double cred = 0;
                bool checkedIn = false;
                int reserv = 0; // not reserved by default
                bool isInCamp;

                nr = Convert.ToInt32(reader["IdNr"]);
                first = Convert.ToString(reader["FirstName"]);
                last = Convert.ToString(reader["LastName"]);
                phone = Convert.ToString(reader["Phone"]);
                mail = Convert.ToString(reader["Email"]);
                if (!(reader["RFIDNr"] is DBNull))
                {
                    rfidNr = Convert.ToString(reader["RFIDNr"]);
                }
                else
                {
                    rfidNr = "";
                }

                if (!(reader["Credit"] is DBNull))
                {
                    cred = Convert.ToDouble(reader["Credit"]);
                }
                if (!(reader["CheckedIn"] is DBNull))
                {
                    checkedIn = Convert.ToBoolean(reader["CheckedIn"]);
                }

                isInCamp = Convert.ToBoolean(reader["IsInCamp"]);

                v = (new Visitor(nr, first, last, phone, mail, rfidNr, checkedIn, cred, reserv, isInCamp));
            }
            return v;
        }

        // Find visitor based on visitor nr.
        public Visitor FindVisitorByNr(int visitorNr)
        {
            Visitor v = null;
            string sql = "SELECT * FROM VISITOR WHERE IdNr = " + visitorNr;
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                v = ReadDataVisitor(reader, v);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error trying to find visitor by nr.");
            }
            finally
            {
                connection.Close();
            }
            return v;
        }

        // Find visitor based on RFID's tag
        public Visitor FindVisitorByTag(string rfidNr)
        {
            Visitor v = null;
            string sql = "SELECT * FROM VISITOR WHERE RFIDNr = '" + rfidNr + "'";

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                v = ReadDataVisitor(reader, v);
            }
            catch (MySqlException exc)
            {
                //MessageBox.Show("Error trying to find visitor");
            }
            finally
            {
                connection.Close();
            }
            return v;
        }

        // Retrieve a list of visitor based on a given condition
        // for encapsulation purposes, FindVisitorByCondition cant be called from outside
        private List<Visitor> FindVisitorByCondition(string whereCond)
        {
            string sql = "SELECT * FROM VISITOR WHERE" + whereCond;
            List<Visitor> temp = new List<Visitor>();
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                // reading
                while (reader.Read())
                {
                    // temporary variables
                    int nr;
                    string first;
                    string last;
                    string phone;
                    string mail;
                    string rfidNr = "";
                    double cred = 0;
                    bool checkedIn = false;
                    int reserv = 0; // not reserved by default
                    bool isInCamp;

                    nr = Convert.ToInt32(reader["IdNr"]);
                    first = Convert.ToString(reader["FirstName"]);
                    last = Convert.ToString(reader["LastName"]);
                    phone = Convert.ToString(reader["Phone"]);
                    mail = Convert.ToString(reader["Email"]);
                    if (!(reader["RFIDNr"] is DBNull))
                    {
                        rfidNr = Convert.ToString(reader["RFIDNr"]);
                    }
                    else
                    {
                        rfidNr = "";
                    }

                    if (!(reader["Credit"] is DBNull))
                    {
                        cred = Convert.ToDouble(reader["Credit"]);
                    }
                    if (!(reader["CheckedIn"] is DBNull))
                    {
                        checkedIn = Convert.ToBoolean(reader["CheckedIn"]);
                    }

                    isInCamp = Convert.ToBoolean(reader["IsInCamp"]);

                    temp.Add(new Visitor(nr, first, last, phone, mail, rfidNr, checkedIn, cred, reserv, isInCamp));
                }
            }

            catch (MySqlException exc)
            {

            }
            finally
            {
                connection.Close();
            }
            return temp;
        }

        // Retrieve a list of visitor with names containing a specified phrase
        public List<Visitor> FindVisitorByName(string name)
        {
            return FindVisitorByCondition(" FirstName LIKE '%" + name + "%' OR LastName LIKE '%" + name + "%'");
        }

        // Retrieve a list of visitor who are checked in
        public List<Visitor> FindCheckedInVisitors()
        {
            return FindVisitorByCondition(" CheckedIn = 1");
        }

        // Retrieve a list of visitor who are checked out
        public List<Visitor> FindCheckedOutVisitors()
        {
            string sql = "SELECT * FROM deleted_VISITOR";
            List<Visitor> temp = new List<Visitor>();
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                // reading
                while (reader.Read())
                {
                    // temporary variables
                    int nr;
                    string first;
                    string last;
                    string phone;
                    string mail;
                    string rfidNr = "";


                    nr = Convert.ToInt32(reader["IdNr"]);
                    first = Convert.ToString(reader["FirstName"]);
                    last = Convert.ToString(reader["LastName"]);
                    phone = Convert.ToString(reader["Phone"]);
                    mail = Convert.ToString(reader["Email"]);
                    if (!(reader["RFIDNr"] is DBNull))
                    {
                        rfidNr = Convert.ToString(reader["RFIDNr"]);
                    }
                    else
                    {
                        rfidNr = "";
                    }

                    temp.Add(new Visitor(nr, first, last, phone, mail, rfidNr));
                }
            }

            catch (MySqlException exc)
            {

            }
            finally
            {
                connection.Close();
            }
            return temp;
        }


        // Add a list of unreturned items (if any) to the given visitor
        public void FindUnreturnedItems(Visitor v)
        {
            string sql = "SELECT ShopName, ArticleNr, ArticleName" +
                " FROM unreturned_items " +
                " WHERE VisitorNr = " + v.IdNr;

            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return;
                }
                else
                {
                    while (reader.Read())
                    {
                        // temporary variables
                        string shopName;
                        int articleNr;
                        string articleName;

                        shopName = Convert.ToString(reader["ShopName"]);
                        articleNr = Convert.ToInt32(reader["ArticleNr"]);
                        articleName = Convert.ToString(reader["ArticleName"]);

                        LoanArticle a = (new LoanArticle(shopName, articleNr, articleName));
                        v.ArticlesBorrowed.Add(a);
                    }
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error trying to find unreturned items");
            }
            finally
            {
                connection.Close();
            }
        }

        public string existsRFID(string rfidNr)
        {
            string sql = "SELECT RFIDNr FROM VISITOR WHERE RFIDNr <> 'NONE'";
            List<string> usedRIFD = new List<string>();

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (rfidNr == (Convert.ToString(reader["RFIDNr"])))
                    {
                        return rfidNr;
                    }
                }
            }
            catch (MySqlException)
            {
                //MessageBox.Show("Error trying to find RFID");
            }
            finally
            {
                connection.Close();
            }

            return null;
        }

        // move a record to the deleted_visitor table
        // used for checking out
        public int MoveToDeletedVisitor(Visitor v)
        {
            string sql = "INSERT INTO DELETED_VISITOR(IdNr, FirstName, LastName, Phone, Email, RFIDNr)" +
                "VALUES(@IdNr, @FirstName, @LastName, @Phone, @Email, @RFIDNr); ";
            sql += "SET FOREIGN_KEY_CHECKS=0; DELETE FROM visitor WHERE IdNr = " + v.IdNr + "; SET FOREIGN_KEY_CHECKS= 1;";
            // temporarily turning off foreign key checks

            MySqlCommand command = new MySqlCommand(sql, connection);

            // add values
            command.Parameters.AddWithValue("@IdNr", v.IdNr);
            command.Parameters.AddWithValue("@FirstName", v.FirstName);
            command.Parameters.AddWithValue("@LastName", v.LastName);
            command.Parameters.AddWithValue("@Phone", v.Phone);
            command.Parameters.AddWithValue("@Email", v.Email);
            command.Parameters.AddWithValue("@RFIDNr", v.RFIDNr);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (MySqlException exc)
            {
                //MessageBox.Show("Error trying to check out visitor");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        ///////////////////////////////////////
        // TICKETS
        ///////////////////////////////////////

        // Methods concerning ticket data are here

        // Get ticket by nr.
        public Ticket GetTicket(int nr)
        {
            string sql = "SELECT * " +
                "FROM ticket_info " +
                "WHERE TicketNr = " + nr;

            Ticket t = null;

            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                // temporary variables
                int buyerNr;
                DateTime date;
                DateTime entry = DateTime.MinValue;
                string type;
                bool paid;
                double price;

                while (reader.Read())
                {
                    // reading
                    buyerNr = Convert.ToInt32(reader["BuyerNr"]);
                    date = Convert.ToDateTime(reader["TicketDate"]);
                    type = Convert.ToString(reader["TicketType"]);

                    if (!(reader["EntryTime"] is DBNull))
                    {
                        entry = Convert.ToDateTime(reader["EntryTime"]);
                    }


                    paid = Convert.ToBoolean(reader["Paid"]);
                    price = Convert.ToDouble(reader["TicketPrice"]);
                    t = new Ticket(nr, date, buyerNr, type, paid, price, entry);
                }

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error trying to get ticket");
            }
            finally
            {
                connection.Close();
            }
            return t;
        }

        // Get a list of used tickets
        public List<Ticket> GetUsedTickets()
        {
            string sql = "SELECT * " +
                "FROM ticket_info " +
                "WHERE EntryTime IS NOT NULL "
                + "ORDER BY EntryTime DESC";

            List<Ticket> temp = new List<Ticket>();

            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                // temporary variables
                int ticketNr;
                int buyerNr;
                DateTime date;
                DateTime entry = DateTime.MinValue;
                string type;
                bool paid;
                double price;

                while (reader.Read())
                {
                    // reading
                    ticketNr = Convert.ToInt32(reader["TicketNr"]);
                    buyerNr = Convert.ToInt32(reader["BuyerNr"]);
                    date = Convert.ToDateTime(reader["TicketDate"]);
                    type = Convert.ToString(reader["TicketType"]);

                    if (!(reader["EntryTime"] is DBNull))
                    {
                        entry = Convert.ToDateTime(reader["EntryTime"]);
                    }


                    paid = Convert.ToBoolean(reader["Paid"]);
                    price = Convert.ToDouble(reader["TicketPrice"]);
                    temp.Add(new Ticket(ticketNr, date, buyerNr, type, paid, price, entry));
                }

            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }

        // Get a list of unused tickets
        public List<Ticket> GetUnusedTickets()
        {
            string sql = "SELECT * " +
                "FROM ticket_info " +
                "WHERE EntryTime IS NULL ";

            List<Ticket> temp = new List<Ticket>();

            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                // temporary variables
                int ticketNr;
                int buyerNr;
                DateTime date;
                DateTime entry = DateTime.MinValue;
                string type;
                bool paid;
                double price;

                while (reader.Read())
                {
                    // reading
                    ticketNr = Convert.ToInt32(reader["TicketNr"]);
                    buyerNr = Convert.ToInt32(reader["BuyerNr"]);
                    date = Convert.ToDateTime(reader["TicketDate"]);
                    type = Convert.ToString(reader["TicketType"]);

                    if (!(reader["EntryTime"] is DBNull))
                    {
                        entry = Convert.ToDateTime(reader["EntryTime"]);
                    }


                    paid = Convert.ToBoolean(reader["Paid"]);
                    price = Convert.ToDouble(reader["TicketPrice"]);
                    temp.Add(new Ticket(ticketNr, date, buyerNr, type, paid, price, entry));
                }

            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }


        ///////////////////////////////////////
        // STATISTICS
        ///////////////////////////////////////

        // Methods supporting the retrieval of statistics are here

        // Get sum of all the credits in the visitor table
        public double GetTotalBalance()
        {
            string sql = "SELECT SUM(Credit) 'Total' FROM VISITOR";

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                double sum = 0;

                while (reader.Read())
                {
                    sum = Convert.ToDouble(reader["Total"]);
                }
                return sum;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error getting the total balance");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }
        

        ///////////////////////////////////////
        // SHOPS
        ///////////////////////////////////////

        // methods concerning both stores and loan stands are here

        // Retrieve a shop by shop nr.
        public Shop GetShopByNr(int shopNr)
        {
            String sql = "SELECT * FROM all_shop WHERE ShopNr=" + shopNr;
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                string name = "";
                string location = "";

                //string shopname;
                while (reader.Read())
                {
                    name = Convert.ToString(reader["ShopName"]);
                    location = Convert.ToString(reader["LocationName"]);
                }

                return new Shop(Convert.ToInt32(shopNr), name, location);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error getting shop by nr");
            }
            finally
            {
                connection.Close();
            }

            return null;
        }

        ///////////////////////////////////////
        // STORES
        ///////////////////////////////////////

        // Methods concerning stores (food & drinks) are here

        // Retrieve a list of store articles based on condition
        // Cannot be called from outside for encapsulation purposes
        private List<StoreArticle> GetStoreArticlesByCondition(Shop s, string condition)
        {
            String sql = "SELECT * FROM store_article WHERE ShopNr = " + s.ShopNr + " AND " + condition;
            MySqlCommand command = new MySqlCommand(sql, connection);

            List<StoreArticle> temp;
            temp = new List<StoreArticle>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int articleNr = 0;
                string articleName = "";
                double price = 0;
                int available = 0;
                string img = "";
                string category = "";

                //string shopname;
                while (reader.Read())
                {
                    articleName = Convert.ToString(reader["ArticleName"]);
                    //shopname = Convert.ToString(reader["ShopName"]);
                    articleNr = Convert.ToInt32(reader["ArticleNr"]);
                    price = Convert.ToInt32(reader["Price"]);
                    available = Convert.ToInt32(reader["Available"]);
                    img = Convert.ToString(reader["ImgFile"]);
                    category = Convert.ToString(reader["Category"]);
                    temp.Add(new StoreArticle(s.ShopNr, s.ShopName, articleNr, articleName, price, available, img, category));
                }
            }
            catch (MySqlException)
            {

            }
            finally
            {
                connection.Close();
            }
            return temp;
        }
        
        // Retrieve all store articles of a store
        public List<StoreArticle> GetAllStoreArticles(Shop s)
        {
            return GetStoreArticlesByCondition(s, "TRUE");
        }

        // Retrieve all store articles containing a phrase
        public List<StoreArticle> GetStoreArticlesContaining(Shop s, string phrase)
        {
            return GetStoreArticlesByCondition(s, "ArticleName LIKE '%" + phrase + "%'");
        }

        // Find a store article with specified nr
        public StoreArticle FindStoreArticleByNr(int nr, Shop s)
        {
            StoreArticle a = null;
            string sql = "SELECT * FROM store_article WHERE ShopNr = " + s.ShopNr + " AND ArticleNr = " + nr;

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int articleNr = 0;
                string articleName = "";
                double price = 0;
                int available = 0;
                string img = "";
                string category = "";

                //string shopname;
                while (reader.Read())
                {
                    articleName = Convert.ToString(reader["ArticleName"]);
                    //shopname = Convert.ToString(reader["ShopName"]);
                    articleNr = Convert.ToInt32(reader["ArticleNr"]);
                    price = Convert.ToInt32(reader["Price"]);
                    available = Convert.ToInt32(reader["Available"]);
                    img = Convert.ToString(reader["ImgFile"]);
                    category = Convert.ToString(reader["Category"]);
                }
                return (new StoreArticle(s.ShopNr, s.ShopName, articleNr, articleName, price, available, img, category));

            }
            catch (MySqlException)
            {
            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        ///////////////////////////////////////
        // STORE ORDERS HANDLING
        ///////////////////////////////////////

        // Methods to handle store order are here

        // Create a new record for the order
        public int CreateNewOrder(Order o)
        {
            string sql = "INSERT INTO SHOP_ORDER(OrderDate, ShopNr, VisitorNr) " +
                       "VALUES(CONVERT('" + o.OrderDate.ToString("yyyy-MM-dd HH:mm:ss") + "', DATETIME), " + o.Shop.ShopNr + ", " + o.VisitorNr + ")";

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error adding new order");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        // Get the database-generated order number by comparing the orderdate
        public int GetRightOrderNr(Order o)
        {
            string sql = "SELECT OrderNr FROM SHOP_ORDER WHERE OrderDate = '" + o.OrderDate.ToString("yyyy-MM-dd HH:mm:ss") + "'";

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        int nr = Convert.ToInt32(reader["OrderNr"]);
                        return nr;
                    }
                }
                return -1;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error getting the right order number");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        // add order line for each item ordered into the database
        public int AddStoreOrderLine(Order o)
        {
            string sql = "";

            for (int i = 0; i < o.Articles.Count; i++)
            {
                sql += "INSERT INTO STORE_ORDER_LINE(OrderNr, LineNr, ArticleNr, Quantity) " +
                       "VALUES(" + GetRightOrderNr(o) + ", " + (i + 1) + ", " + o.Articles[i].ArticleNr + ", "
                       + o.Quantity[i] + ");";

                sql += " UPDATE STORE_ARTICLE SET Available = Available - " + o.Quantity[i] + " WHERE ArticleNr = " +
                    o.Articles[i].ArticleNr + " AND ShopNr = " + o.Shop.ShopNr + ";";
            }

            //MessageBox.Show(sql);
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error adding information to order");
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }

        // get all transactions made for a certain article
        public List<Order> GetStoreArticleOrderHistory(Shop s, StoreArticle a)
        {
            List<Order> o = new List<Order>();
            string sql = "SELECT * FROM store_orders WHERE ShopNr = " + s.ShopNr + " AND ArticleNr = " + a.ArticleNr;

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Order temp = new LoanOrder(s);
                    temp.OrderNr = Convert.ToInt32(reader["OrderNr"]);
                    temp.OrderDate = Convert.ToDateTime(reader["OrderDate"]);
                    temp.Articles.Add(new Article(s.ShopName, a.ArticleNr, Convert.ToString(reader["ArticleName"])));
                    temp.Quantity.Add(Convert.ToInt32(reader["Quantity"]));
                    temp.VisitorNr = Convert.ToInt32(reader["VisitorNr"]);
                    o.Add(temp);
                }

            }
            catch (MySqlException)
            {

            }
            finally
            {
                connection.Close();
            }
            return o;
        }

        // get all transactions made by certain list of visitors
        public List<Order> GetStoreArticleWithVisitorNrs(Shop s, List<Visitor> visitors)
        {
            List<Order> o = new List<Order>();
            string sql = "SELECT * FROM store_orders WHERE ShopNr = " + s.ShopNr + " AND VisitorNr IN(";

            if (visitors.Count == 1)
            {
                sql += visitors[0].IdNr;
            }
            else
            {
                foreach (Visitor v in visitors)
                {
                    sql += v.IdNr + ", ";
                }
            }

            sql += ");";

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Order temp = new LoanOrder(s);
                    temp.OrderNr = Convert.ToInt32(reader["OrderNr"]);
                    temp.OrderDate = Convert.ToDateTime(reader["OrderDate"]);
                    temp.Articles.Add(new Article(s.ShopName, Convert.ToInt32(reader["ArticleNr"]), Convert.ToString(reader["ArticleName"])));
                    temp.Quantity.Add(Convert.ToInt32(reader["Quantity"]));
                    temp.VisitorNr = Convert.ToInt32(reader["VisitorNr"]);
                    o.Add(temp);
                }

            }
            catch (MySqlException)
            {

            }
            finally
            {
                connection.Close();
            }
            return o;
        }

        ///////////////////////////////////////
        // LOAN
        ///////////////////////////////////////

        // Methods concerning loan stands are here

        // Retrieve a list of loan articles based on condition
        // Cannot be called from outside for encapsulation purposes
        private List<LoanArticle> GetLoanArticlesByCondition(int shopNr, string condition)
        {
            List<LoanArticle> temp = new List<LoanArticle>();

            string sql = "SELECT * FROM loan_article WHERE ShopNr = " + shopNr + " AND " + condition;

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int articleNr = 0;
                string articleName = "";
                double price = 0;
                int available = 0;
                string rfid = "";
                double deposit = 0;

                while (reader.Read())
                {
                    articleNr = Convert.ToInt32(reader["ArticleNr"]);
                    articleName = Convert.ToString(reader["ArticleName"]);
                    price = Convert.ToDouble(reader["Price"]);
                    available = Convert.ToInt32(reader["Available"]);
                    rfid = Convert.ToString(reader["RFIDNr"]);
                    deposit = Convert.ToDouble(reader["DepositValue"]);
                    temp.Add(new LoanArticle(shopNr, articleNr, articleName, price, available, rfid, deposit));
                }

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error getting all loan articles");
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }
        
        // Find a loan article by nr
        public LoanArticle FindLoanArticleByNr(int nr, int shopNr)
        {
            LoanArticle a = null;
            string sql = "SELECT * FROM loan_article WHERE ShopNr = " + shopNr + " AND ArticleNr = " + nr;

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                string articleName = "";
                double price = 0;
                int available = 0;
                string rfidNr = "";
                double deposit = 0;

                while (reader.Read())
                {
                    articleName = Convert.ToString(reader["ArticleName"]);
                    price = Convert.ToDouble(reader["Price"]);
                    rfidNr = Convert.ToString(reader["RFIDNr"]);
                    available = Convert.ToInt32(reader["Available"]);
                    deposit = Convert.ToDouble(reader["DepositValue"]);
                }
                return new LoanArticle(shopNr, nr, articleName, price, available, rfidNr, deposit);

            }
            catch (MySqlException)
            {
            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        // Find a loan article by tag
        public LoanArticle FindLoanArticleByTag(string rfidNr)
        {
            LoanArticle a = null;
            string sql = "SELECT * FROM loan_article WHERE RFIDNr = '" + rfidNr + "'";

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int shopNr = 0;
                int articleNr = 0;
                string articleName = "";
                double price = 0;
                int available = 0;
                double deposit = 0;

                while (reader.Read())
                {
                    shopNr = Convert.ToInt32(reader["ShopNr"]);
                    articleNr = Convert.ToInt32(reader["ArticleNr"]);
                    articleName = Convert.ToString(reader["ArticleName"]);
                    price = Convert.ToDouble(reader["Price"]);
                    available = Convert.ToInt32(reader["Available"]);
                    deposit = Convert.ToDouble(reader["DepositValue"]);
                }
                return new LoanArticle(shopNr, articleNr, articleName, price, available, rfidNr, deposit);

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error getting article by tag");
            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        // Retrieve all loan articles
        public List<LoanArticle> GetAllLoanArticles(int shopNr)
        {
            return GetLoanArticlesByCondition(shopNr, "TRUE"); // get all
        }

        // Retrieve articles being loaned
        public List<LoanArticle> GetLoaningArticles(int shopNr)
        {
            return GetLoanArticlesByCondition(shopNr, "Available = 0;");
        }

        // Retrieve all articles containing a string
        public List<LoanArticle> GetLoanArticlesContaining(int shopNr, string phrase)
        {
            return GetLoanArticlesByCondition(shopNr, "ArticleName LIKE '%" + phrase + "%'");
        }

        /**
        * Other methods concerning loan articles
        */

        // Get return date for an article
        public DateTime GetReturnDateForLoanArticle(Article a)
        {
            string sql = "select ReturnDate from loan_orders where ArticleNr = " + a.ArticleNr + " and ShopNr = " + a.ShopNr;

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        DateTime returnDate = Convert.ToDateTime(reader["ReturnDate"]);
                        return returnDate;
                    }
                }
                return DateTime.MinValue;
            }
            catch (MySqlException)
            {
                //MessageBox.Show("Error getting the right order number");
                return DateTime.MinValue;
            }
            finally
            {
                connection.Close();
            }
        }

        // Get visitor nr for an article
        public int GetVisitorNrForLoanArticle(Article a)
        {
            string sql = "select VisitorNr from loan_orders where ArticleNr = " + a.ArticleNr + " and ShopNr = " + a.ShopNr;

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        int nr = Convert.ToInt32(reader["VisitorNr"]);
                        return nr;
                    }
                }
                return -1;
            }
            catch (MySqlException)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }


        ///////////////////////////////////////
        // LOAN ORDERS HANDLING
        ///////////////////////////////////////

        /**
        * Handle borrow/return
        */
        
        public int AddLoanOrderLine(LoanOrder o)
        {
            string sql = "";

            for (int i = 0; i < o.Articles.Count; i++)
            {
                sql += "INSERT INTO LOAN_ORDER_LINE(OrderNr, LineNr, ArticleNr, ReturnDate) " +
                       "VALUES(" + GetRightOrderNr(o) + ", " + (i + 1) + ", " + o.Articles[i].ArticleNr + ", CONVERT('" + o.ReturnDate.ToString("yyyy-MM-dd HH:mm:ss") + "', DATETIME));";
                // quantity by default 0 as there have been 0 hours of borrowed time

                sql += " UPDATE LOAN_ARTICLE SET Available = 0 WHERE ArticleNr = " +
                    o.Articles[i].ArticleNr + " AND ShopNr = " + o.Shop.ShopNr + "; ";
            }

            //MessageBox.Show(sql);
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }
        public int ProcessLoanReturn(Order o, string visitorNr)
        {
            string sql = "";

            for (int i = 0; i < o.Articles.Count; i++)
            {
                sql += "update all_order"
                + " set ReturnDate = CONVERT('" + o.OrderDate.ToString("yyyy-MM-dd HH:mm:ss") + "', DATETIME)"
                + ", Quantity = " + o.Quantity[i]
                + " where ArticleNr = " + o.Articles[i].ArticleNr
                + " and ShopNr = " + o.Articles[i].ShopNr
                + " and VisitorNr = " + visitorNr
                + " and ReturnDate is null;";

                sql += "update article set Available = 1 where ArticleNr = " + o.Articles[i].ArticleNr + " and ShopNr = " + o.Articles[i].ShopNr;
            }

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error processing loan return");
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }

        /**
        * Find loan orders
        */
        public List<LoanOrder> GetLoanArticleOrderHistory(Shop s, LoanArticle a)
        {
            List<LoanOrder> o = new List<LoanOrder>();
            string sql = "SELECT * FROM loan_orders WHERE ShopNr = " + s.ShopNr + " AND ArticleNr = " + a.ArticleNr;

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    LoanOrder temp = new LoanOrder(s);
                    temp.OrderNr = Convert.ToInt32(reader["OrderNr"]);
                    temp.OrderDate = Convert.ToDateTime(reader["OrderDate"]);
                    temp.Articles.Add(new Article(s.ShopName, a.ArticleNr, Convert.ToString(reader["ArticleName"])));
                    temp.VisitorNr = Convert.ToInt32(reader["VisitorNr"]);
                    temp.ReturnDate = Convert.ToDateTime(reader["ReturnDate"]);
                    o.Add(temp);
                }

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error getting article by tag");
            }
            finally
            {
                connection.Close();
            }
            return o;
        }

        public List<LoanOrder> GetLoanArticleWithVisitorNrs(Shop s, List<Visitor> visitors)
        {
            List<LoanOrder> o = new List<LoanOrder>();
            string sql = "SELECT * FROM loan_orders WHERE ShopNr = " + s.ShopNr + " AND VisitorNr IN(";

            if (visitors.Count == 1)
            {
                sql += visitors[0].IdNr;
            }
            else
            {
                foreach (Visitor v in visitors)
                {
                    sql += v.IdNr + ", ";
                }
            }

            sql += ");";

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    LoanOrder temp = new LoanOrder(s);
                    temp.OrderNr = Convert.ToInt32(reader["OrderNr"]);
                    temp.OrderDate = Convert.ToDateTime(reader["OrderDate"]);
                    temp.Articles.Add(new Article(s.ShopName, Convert.ToInt32(reader["ArticleNr"]), Convert.ToString(reader["ArticleName"])));
                    temp.VisitorNr = Convert.ToInt32(reader["VisitorNr"]);
                    temp.ReturnDate = Convert.ToDateTime(reader["ReturnDate"]);
                    o.Add(temp);
                }
            }
            catch (MySqlException)
            {
            }
            finally
            {
                connection.Close();
            }
            return o;
        }


        ///////////////////////////////////////
        // CAMP RESERVATIONS
        ///////////////////////////////////////
        public Reservation FindReservationByVisitor(Visitor visitor)
        {
            string sql = "SELECT * FROM reservation_info WHERE VisitorNr = " + visitor.IdNr;
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    int reservNr = 0;
                    DateTime reservDate = DateTime.MinValue;
                    DateTime startDate = DateTime.MinValue;
                    DateTime endDate = DateTime.MinValue;
                    CampingSpot spot = null;
                    int nrOfRegistered = 0;
                    int nrCheckedIn = 0;
                    bool paid = false;

                    while (reader.Read())
                    {
                        reservNr = Convert.ToInt32(reader["ReservNr"]);
                        reservDate = Convert.ToDateTime(reader["ReservDate"]);
                        spot = new CampingSpot(Convert.ToInt32(reader["SpotNr"]), Convert.ToString(reader["SpotName"]));
                        nrOfRegistered = Convert.ToInt32(reader["NrOfRegistered"]);
                        nrCheckedIn = Convert.ToInt32(reader["NrCheckedIn"]);
                        paid = Convert.ToBoolean(reader["Paid"]);
                        startDate = Convert.ToDateTime(reader["StartDate"]);
                        endDate = Convert.ToDateTime(reader["EndDate"]);
                    }

                    return new Reservation(reservNr, reservDate, spot, visitor, nrOfRegistered, nrCheckedIn, paid, startDate, endDate);
                }
                else
                {
                    return null;
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error getting resrevation");
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public Reservation FindReservationByNr(string reservNr)
        {
            string sql = "SELECT * FROM reservation_info WHERE ReservNr = " + reservNr;
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    return null;
                }

                DateTime reservDate = DateTime.MinValue;
                DateTime startDate = DateTime.MinValue;
                DateTime endDate = DateTime.MinValue;
                Visitor reserver = null;
                CampingSpot spot = null;
                int nrOfRegistered = 0;
                int nrCheckedIn = 0;
                bool paid = false;

                while (reader.Read())
                {
                    reservDate = Convert.ToDateTime(reader["ReservDate"]);
                    spot = new CampingSpot(Convert.ToInt32(reader["SpotNr"]), Convert.ToString(reader["SpotName"]));
                    reserver = new Visitor(Convert.ToInt32(reader["VisitorNr"]), Convert.ToString(reader["FirstName"]), Convert.ToString(reader["LastName"]), Convert.ToString(reader["Phone"]), Convert.ToString(reader["Email"]));
                    nrOfRegistered = Convert.ToInt32(reader["NrOfRegistered"]);
                    nrCheckedIn = Convert.ToInt32(reader["NrCheckedIn"]);
                    paid = Convert.ToBoolean(reader["Paid"]);
                    startDate = Convert.ToDateTime(reader["StartDate"]);
                    endDate = Convert.ToDateTime(reader["EndDate"]);
                }

                return new Reservation(Convert.ToInt32(reservNr), reservDate, spot, reserver, nrOfRegistered, nrCheckedIn, paid, startDate, endDate);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error getting reservation");
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<int> FindCampersNr(Reservation r)
        {
            string sql = "SELECT VisitorNr FROM reservation_info WHERE ReservNr = " + r.ReservNr;
            MySqlCommand command = new MySqlCommand(sql, connection);

            List<int> numbers = new List<int>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    numbers.Add(Convert.ToInt32(reader["VisitorNr"]));
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error getting reservation");
                return null;
            }
            finally
            {
                connection.Close();
            }
            return numbers;
        }

        private List<Reservation> FindReservationsByCondition(String condition)
        {
            string sql = "SELECT * FROM reservation_info WHERE " + condition;
            MySqlCommand command = new MySqlCommand(sql, connection);

            List<Reservation> temp = new List<Reservation>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    return null;
                }
                int reservNr = 0;
                DateTime reservDate = DateTime.MinValue;
                DateTime startDate = DateTime.MinValue;
                DateTime endDate = DateTime.MinValue;
                Visitor reserver = null;
                CampingSpot spot = null;
                int nrOfRegistered = 0;
                int nrCheckedIn = 0;
                bool paid = false;

                while (reader.Read())
                {
                    reservNr = Convert.ToInt32(reader["ReservNr"]);
                    reservDate = Convert.ToDateTime(reader["ReservDate"]);
                    spot = new CampingSpot(Convert.ToInt32(reader["SpotNr"]), Convert.ToString(reader["SpotName"]));
                    reserver = new Visitor(Convert.ToInt32(reader["VisitorNr"]), Convert.ToString(reader["FirstName"]), Convert.ToString(reader["LastName"]), Convert.ToString(reader["Phone"]), Convert.ToString(reader["Email"]));
                    nrOfRegistered = Convert.ToInt32(reader["NrOfRegistered"]);
                    nrCheckedIn = Convert.ToInt32(reader["NrCheckedIn"]);
                    paid = Convert.ToBoolean(reader["Paid"]);
                    startDate = Convert.ToDateTime(reader["StartDate"]);
                    endDate = Convert.ToDateTime(reader["EndDate"]);
                }

                temp.Add(new Reservation(reservNr, reservDate, spot, reserver, nrOfRegistered, nrCheckedIn, paid, startDate, endDate));
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error getting reservation");
                return null;
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }

        public List<Reservation> FindFullyPresentReservations()
        {
            return FindReservationsByCondition("NrOfRegistered = NrCheckedIn");
        }

        public List<Reservation> FindNotFullyPresentReservations()
        {
            return FindReservationsByCondition("NrOfRegistered <> NrCheckedIn");
        }

        ///////////////////////////////////////
        // ATM LOGS HANDLING
        ///////////////////////////////////////
        public int CreateNewLog(Log l)
        {
            string sql = "INSERT INTO ATM_LOG(StartPeriod, EndPeriod, SenderNr, ReceiverNr, Amount) " +
                       "VALUES('" + l.StartPeriod + "', '" + l.EndPeriod + "', '"
                       + l.SenderNr + "', '" + l.ReceiverNr + "', " + l.Amount + ")";
            //MessageBox.Show(sql);
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error adding new order");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }


    }
}
