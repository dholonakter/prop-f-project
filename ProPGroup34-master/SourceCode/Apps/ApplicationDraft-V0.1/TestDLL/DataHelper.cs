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
       #region properties
        MySqlConnection connection;
        MySqlDataAdapter dataAdapter;
        private ILogger logger;
        #endregion

       #region Constructor
        /// <summary>
        /// Connecting to the Database
        /// </summary>
        /// <param name="logger"></param>
        public DataHelper(ILogger logger)
        {
            this.logger = logger;
            string connectionInfo = "server=studmysql01.fhict.local;" +
                                    "database=dbi387862;" +
                                    "user id=dbi387862;" +
                                    "password=blueberrypie;" +
                                    "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
            dataAdapter = new MySqlDataAdapter();
            try
            {
                connection.Open();
                LogMessage("DBConnection: Database is connected");
            }
            catch (MySqlException)
            {
                LogMessage("DBConnection: Database is not connected");

            }
            finally
            {
                connection.Close();

            }
        }
        #endregion

       #region Private Method LogMessage
        private void LogMessage(string message)
        {
            if (logger != null)
            {
                logger.LogMessage(message);
            }
        }
       #endregion

       #region Public Method Datatable

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
            catch(InvalidOperationException)
            {
                LogMessage("DataTableFromSQL:Error trying to build data table");

            }
           
            return null;
        }

        /// <summary>
        /// Updates datatable
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
         public bool UpdateTable(DataTable changes)
        {
            bool updateSuccess = false;
            try
            {
                if (changes != null)
                {
                    dataAdapter.Update(changes);
                    updateSuccess = true;
                }
            }
            catch (InvalidOperationException)
            { 
              LogMessage("UpdateTable : the source table is invalid");  
            }
            catch (DBConcurrencyException)
            {
                LogMessage("UpdateTable : An attempt to execute an INSERT, UPDATE, or DELETE statement resulted in zero rows affected");
            }
            catch (SystemException)
            {
                LogMessage("UpdateTable : No data exist to use as a source");

            }
            return updateSuccess;
        }


        public DataSet GetDataset(string sql)
        {
            DataSet ds = new DataSet();
           
            try
            {
                
                dataAdapter.SelectCommand = new MySqlCommand(sql, connection);
                dataAdapter.Fill(ds);
                return ds;
               
            }
            catch (InvalidOperationException)
            {
                LogMessage("GetDataset : the source dataset is invalid");
                return null;

            }
            catch (SystemException)
            {
                LogMessage("UpdateTable : No dataset exist to use as a source");
                return null;


            }

            //finally
            //{
            //    connection.Close();
            //}
        }
        #endregion

       #region public Method  login with credentials

        public int CheckCredentials(string username, string pwd)
        {
            string sql = "SELECT COUNT(*) 'Nr' FROM LOGIN WHERE Username = '" + username + "' AND Password='" + pwd + "'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            int nr=0;

            try
            {
                connection.Open();
                nr = Convert.ToInt32(command.ExecuteScalar());
                return nr;
            }
            catch (MySqlException)
            {
                LogMessage("CheckCredentials: Error checking credentials");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

       #region Public Method Visitor Handling

        /// <summary>
        ///  Updates credit, checked in status and rfid of the selected visitor in the database 
        /// </summary>
        /// <param name="v">The selected visitor</param>
        /// <returns>-1 if fails, otherwise returns nr. of record affected (should be 1)</returns>
        public int UpdateSelectedVisitor(Visitor v)
        {
            string sql = "UPDATE VISITOR " +
                        "SET Credit = " + v.Credit + "," +
                        "CheckedIn = " + v.CheckedIn + "," +
                        "IsInCamp = " + v.IsInCamp + ", " +
                        "RFIDNr = " + (v.RFIDNr == "" ? "NULL" : "'" + v.RFIDNr + "'");

            sql += " WHERE VisitorNr = " + v.IdNr;

            //MessageBox.Show(sql);

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
            }
            catch (MySqlException )
            {
                LogMessage("UpdateSelectedVisitor : Error trying to update visitor");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Reading data onto a visitor
        /// </summary>
        /// <param name="reader">MySQL's reader</param>
        /// <param name="v">The selected visitor</param>
        /// <returns>The selected visitor initialized</returns>
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
                bool isInCamp;
                int reservenr=0;

                nr = Convert.ToInt32(reader["VisitorNr"]);
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
                //fix the problem,there is no reserveNr in database.
                
                v = (new Visitor(nr, first, last, phone, mail, rfidNr, checkedIn, cred,reservenr, isInCamp));
            }
            return v;
        }

        /// <summary>
        ///  Finds the visitor with a given visitorNr
        /// </summary>
        /// <param name="visitorNr"></param>
        /// <returns>Returns null if fails and the object visitor initiated if found</returns>
        public Visitor FindVisitorByNr(int visitorNr)
        {
            Visitor v = null;
            string sql = "SELECT * FROM VISITOR WHERE VisitorNr = " + visitorNr;
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                v = ReadDataVisitor(reader, v);
            }
            catch (MySqlException)
            {
                LogMessage("FindVisitorByNr : Error trying to find visitor by nr.");
            }
            finally
            {
                connection.Close();
            }
            return v;
        }

        /// <summary>
        /// Finds all unreturned items and adds it to the selected visitor's object list
        /// </summary>
        /// <param name="v">Selected visitor</param>
        public void FindUnreturnedItems(Visitor v)
        {
            string sql = "SELECT ShopName, ArticleNr, ArticleName" +
                " FROM all_order" +
                " WHERE IsLoanable = 1 and VisitorNr = " + v.IdNr + " AND ReturnDate IS NULL";

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
                LogMessage("FindUnreturnedItems : Error trying to find unreturned items");
            }
            finally
            {
                connection.Close();
            }
        }
         /// <summary>
        /// Checks if a certain RFID tag exists in the database
        /// </summary>
        /// <param name="rfidNr"></param>
        /// <returns></returns>
        public string existsRFID(string rfidNr)
        {
            string sql = "SELECT RFIDNr FROM VISITOR WHERE RFIDNr IS NOT NULL";
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
                LogMessage("existsRFID: Error trying to find RFID");
            }
            finally
            {
                connection.Close();
            }

            return null;
        }

        /// <summary>
        /// Returns the ticket with a specified visitorNr
        /// </summary>
        /// <param name="visitorNr"></param>
        /// <returns></returns>
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
                string type;
                bool paid;
                double price;

                while (reader.Read())
                {
                    // reading
                    buyerNr = Convert.ToInt32(reader["BuyerNr"]);
                    date = Convert.ToDateTime(reader["TicketDate"]);
                    type = Convert.ToString(reader["TicketType"]);
                    paid = Convert.ToBoolean(reader["Paid"]);
                    price = Convert.ToDouble(reader["TicketPrice"]);
                    t = new Ticket(nr, date, buyerNr, type, paid, price);
                }

            }
            catch (MySqlException)
            {
                LogMessage("GetTicket : Error trying to get ticket");
            }
 
            finally
            {
                connection.Close();
            }
            return t;
        }

        /// <summary>
        /// Finds visitor by RFID tag
        /// </summary>
        /// <param name="rfidNr"></param>
        /// <returns></returns>
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
            catch (MySqlException)
            {
                LogMessage("FindVisitorByTag: Error trying to find visitor");
            }
            finally
            {
                connection.Close();
            }
            return v;
        }

        public int MoveToDeletedVisitor(Visitor v)
        {
            string sql = "INSERT INTO DELETED_VISITOR(IdNr, FirstName, LastName, Phone, Email, RFIDNr, ReservNr)" +
                "VALUES(@IdNr, @FirstName, @LastName, @Phone, @Email, @RFIDNr, @ReservNr); ";
            sql += "SET FOREIGN_KEY_CHECKS=0; DELETE FROM PARTICIPANT WHERE IdNr = " + v.IdNr + "; SET FOREIGN_KEY_CHECKS= 1;";
            // temporarily turning off foreign key checks

            MySqlCommand command = new MySqlCommand(sql, connection);

            // add values
            command.Parameters.AddWithValue("@IdNr", v.IdNr);
            command.Parameters.AddWithValue("@FirstName", v.FirstName);
            command.Parameters.AddWithValue("@LastName", v.LastName);
            command.Parameters.AddWithValue("@Phone", v.Phone);
            command.Parameters.AddWithValue("@Email", v.Email);
            command.Parameters.AddWithValue("@RFIDNr", v.RFIDNr);
            command.Parameters.AddWithValue("@ReservNr", v.ReservNr);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (MySqlException)
            {
                LogMessage("MoveToDeletedVisitor :Error trying to check out visitor");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Count the row in a table 
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
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
                LogMessage("CountRowTable: Error counting rows");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }
       #endregion

        ///////////////////////////////////////
        // STATISTICS
        ///////////////////////////////////////
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
                LogMessage("GetTotalBalance : Error getting the total balance");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        public double GetTotalSpent()
        {
            string sql = "SELECT SUM(Subtotal) 'Total' FROM ALL_ORDER";

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
                LogMessage("GetTotalSpent: Error getting total credit spent");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        //shop
        public List<Article> GetFoodArticles(int shopnr)
        {
            String sql = "SELECT * FROM all_article WHERE Category = 'Food' and ShopNr=" + Convert.ToString(shopnr);
            MySqlCommand command = new MySqlCommand(sql, connection);

            List<Article> temp;
            temp = new List<Article>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                String name;
                int nr;
                double price;
                string img = "";
                int stock;
                //string shopname;
                while (reader.Read())
                {
                    name = Convert.ToString(reader["ArticleName"]);
                    //shopname = Convert.ToString(reader["ShopName"]);
                    nr = Convert.ToInt32(reader["ArticleNr"]);
                    shopnr = Convert.ToInt32(reader["ShopNr"]);
                    price = Convert.ToInt32(reader["price"]);
                    if (!(reader["Img"] is DBNull))
                    {
                        img = Convert.ToString(reader["Img"]);
                    }
                    stock = Convert.ToInt32(reader["Available"]);
                    temp.Add(new Article(shopnr, nr, name, price, stock));
                }
            }
            catch (MySqlException)
            {
                LogMessage("GetFoodArticles : Error getting food articles");
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }

        public List<Article> GetDrinkArticles(int shopnr)
        {
            String sql = "SELECT * FROM all_article WHERE Category = 'Drink' AND ShopNr=" + Convert.ToString(shopnr);
            MySqlCommand command = new MySqlCommand(sql, connection);

            List<Article> temp;
            temp = new List<Article>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                String name;
                int nr;
                double price;
                string img = "";
                int stock;
                //string shopname;
                while (reader.Read())
                {
                    name = Convert.ToString(reader["ArticleName"]);
                    //shopname = Convert.ToString(reader["ShopName"]);
                    nr = Convert.ToInt32(reader["ArticleNr"]);
                    shopnr = Convert.ToInt32(reader["ShopNr"]);
                    price = Convert.ToInt32(reader["price"]);
                    if (!(reader["Img"] is DBNull))
                    {
                        img = Convert.ToString(reader["Img"]);
                    }
                    stock = Convert.ToInt32(reader["Available"]);
                    temp.Add(new Article(shopnr, nr, name, price, stock));
                }
            }
            catch (MySqlException)
            {
                LogMessage("GetDrinkArticles : Error getting drink articles");
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }


        public int CreateNewLoanOrder(Order o)
        {
            string sql = "INSERT INTO SHOP_ORDER(OrderDate, ShopNr, VisitorNr, IsLoanable) " +
                       "VALUES(CONVERT('" + o.OrderDate.ToString("yyyy-MM-dd HH:mm:ss") + "', DATETIME), " + o.Shop.ShopNr + ", " + o.VisitorNr + ", 1)";
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
                LogMessage("CreateNewLoanOrder : Error adding new order");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        public int CreateNewStoreOrder(Order o)
        {
            string sql = "INSERT INTO SHOP_ORDER(OrderDate, ShopNr, VisitorNr, IsLoanable) " +
                       "VALUES(CONVERT('" + o.OrderDate.ToString("yyyy-MM-dd HH:mm:ss") + "', DATETIME)" + ", " + o.Shop.ShopNr + ", " + o.VisitorNr + ", 0)";
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
                LogMessage("CreateNewStoreOrder : Error adding new order");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }


        /// <summary>
        /// Get the right order number
        /// </summary>
        /// <returns>The right order nr for a given order</returns>
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
                LogMessage("GetRightOrderNr: Error getting the right order number");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Add order lines for a given order 
        /// </summary>
        /// <param name="o">The given order</param>
        /// <returns>Number of rows affected</returns>
        public int AddStoreOrderLine(Order o)
        {
            string sql = "";

            for (int i = 0; i < o.Articles.Count; i++)
            {
                sql += "INSERT INTO SHOP_ORDER_LINE(OrderNr, LineNr, ArticleNr, Quantity) " +
                       "VALUES(" + GetRightOrderNr(o) + ", " + (i + 1) + ", " + o.Articles[i].ArticleNr + ", "
                       + o.Quantity[i] + ");";

                sql += " UPDATE ARTICLE SET Available = Available - " + o.Quantity[i] + " WHERE ArticleNr = " +
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
                LogMessage("AddStoreOrderLine : Error adding information to order");
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }

        public int AddLoanOrderLine(Order o)
        {
            string sql = "";

            for (int i = 0; i < o.Articles.Count; i++)
            {
                sql += "INSERT INTO SHOP_ORDER_LINE(OrderNr, LineNr, ArticleNr) " +
                       "VALUES(" + GetRightOrderNr(o) + ", " + (i + 1) + ", " + o.Articles[i].ArticleNr + ");";
                // quantity by default 0 as there have been 0 hours of borrowed time

                sql += " UPDATE ARTICLE SET Available = Available = 0 WHERE ArticleNr = " +
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
                LogMessage("AddLoanOrderLine: Error adding information to order");
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }

        public DateTime GetOrderDateOfArticle(LoanArticle a, string visitorNr)
        {
            string sql = "select OrderDate from all_order"
                + " where ArticleNr = " + a.ArticleNr
                + " and ShopNr = " + a.ShopNr
                + " and VisitorNr = " + visitorNr
                + " and ReturnDate is null;";

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        return (Convert.ToDateTime(reader["OrderDate"]));
                    }
                }
            }
            catch (MySqlException)
            {
                LogMessage("GetOrderDateOfArticle:Error getting the right order number");
            }
            finally
            {
                connection.Close();
            }
            return DateTime.MinValue;
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
                LogMessage("ProcessLoanReturn: Error processing loan return");
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }

        public Shop GetShopByNr(string shopNr)
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
                LogMessage("ProcessLoanReturn : Error getting shop by nr");
            }
            finally
            {
                connection.Close();
            }

            return null;
        }

        //loan stuff
        public LoanArticle FindLoanArticleByTag(string rfidNr)
        {
            LoanArticle a = null;
            string sql = "SELECT * FROM all_article WHERE IsLoanable = 1 and RFIDNr = '" + rfidNr + "'";
            
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
                LogMessage("FindLoanArticleByTag: Error getting article by tag");
            }
            finally
            {
                connection.Close();
            }
            return a;
        }

        public List<LoanArticle> GetAllLoanArticles()
        {
            List<LoanArticle> temp = new List<LoanArticle>();

            string sql = "SELECT * FROM all_article WHERE IsLoanable = 1";

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
                string rfid = "";
                double deposit = 0;

                while (reader.Read())
                {
                    shopNr = Convert.ToInt32(reader["ShopNr"]);
                    articleNr = Convert.ToInt32(reader["ArticleNr"]);
                    articleName = Convert.ToString(reader["ArticleName"]);
                    price = Convert.ToDouble(reader["Price"]);
                    available = Convert.ToInt32(reader["Available"]);
                    rfid = Convert.ToString(reader["RFIDNr"]);
                    deposit = Convert.ToDouble(reader["DepositValue"]);
                }
                temp.Add(new LoanArticle(shopNr, articleNr, articleName, price, available, rfid, deposit));

            }
            catch (MySqlException)
            {
                LogMessage("GetAllLoanArticles : Error getting all loan articles");
            }
            finally
            {
                connection.Close();
            }
            return temp;
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
                LogMessage("UpdateSelectedReservation: Error updating reservation");
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
                        "SET Paid = " + t.Paid +
                        " WHERE TicketNr =" + t.TicketNr;

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
                LogMessage("UpdateSelectedTicket : Error updating ticket");
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
                LogMessage("UpdateSelectedArticle: Error updating article");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        public Reservation FindReservationByVisitor(Visitor visitor)
        {
            string sql = "SELECT * FROM reservation_info WHERE Reserver = " + visitor.IdNr;
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
                LogMessage("FindReservationByVisitor : Error getting resrevation");
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
                    reserver = new Visitor(Convert.ToInt32(reader["Reserver"]), Convert.ToString(reader["FirstName"]), Convert.ToString(reader["LastName"]), Convert.ToString(reader["Phone"]), Convert.ToString(reader["Email"]));
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
                LogMessage("FindReservationByNr: Error getting reservation");
                return null;
            }
            finally
            {
                connection.Close();
            }
        }


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
                LogMessage("CreateNewLog : Error adding new order");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
