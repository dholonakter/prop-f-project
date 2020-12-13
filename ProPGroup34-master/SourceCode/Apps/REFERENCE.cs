  public class DataHelper
    {
        ///////////////////////////////////////
        // CONNECTING TO DATABASE
        ///////////////////////////////////////
        MySqlConnection connection;
        ILogger logger;

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
        }

        ///////////////////////////////////////
        // LOG ERROR
        ///////////////////////////////////////
        private void LoggingError(ErrorTypes.ErrorType errorType, String message)
        {
            if (this.logger != null)
            {
                logger.LogMessage(errorType, message);
            }
        }

        ///////////////////////////////////////
        // VISITOR HANDLING 
        ///////////////////////////////////////

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
                        "RFIDNr = " + (v.RFIDNr == "" ? "NULL" : "'" + v.RFIDNr + "'");

            if (v.SpotNr != 0) // if they reserve a spot
            {
                sql += ", SpotNr = " + v.SpotNr;
            }

            sql += " WHERE VisitorNr = " + v.IdNr;

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
                LoggingError(ErrorTypes.ErrorType.DATABASE, exc.Message);
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
                bool checkedIn;
                int spot = 0; // not reserved by default

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
                checkedIn = Convert.ToBoolean(reader["CheckedIn"]);
                if (!(reader["SpotNr"] is DBNull))
                {
                    spot = Convert.ToInt32(reader["SpotNr"]);
                }

                v = (new Visitor(nr, first, last, phone, mail, rfidNr, cred, checkedIn, spot));
            }
            return v;
        }

        /// <summary>
        ///  Finds the visitor with a given visitorNr
        /// </summary>
        /// <param name="visitorNr"></param>
        /// <returns>Returns null if fails and the object visitor initiated if found</returns>
        public Visitor FindVisitorByNr(string visitorNr)
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
            catch (MySqlException exc)
            {
                LoggingError(ErrorTypes.ErrorType.DATABASE, exc.Message);
            }
            catch (Exception exc)
            {
                LoggingError(ErrorTypes.ErrorType.DATABASE, exc.Message);
            }
            finally
            {
                connection.Close();
            }
            return v;
        }

        /// <summary>
        /// Links a visitor to a RFID card and updates it in the database
        /// </summary>
        /// <param name="v">Selected visitor</param>
        /// <param name="rfidNr">RFID Nr. to link</param>
        /// <returns>True if successful, false otherwise.</returns>
        public bool LinkRFID(Visitor v, string rfidNr)
        {
            if (existsRFID(rfidNr) != null)
            {
                return false;
            }
            else
            {
                v.RFIDNr = rfidNr;
                v.CheckedIn = true;

                int updated = UpdateSelectedVisitor(v);

                if (updated == 1) // only 1 visior's information should be updated
                {
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// Returns all visitors in the database as a list of visitor object
        /// </summary>
        /// <returns>A list of visitor object</returns>
        public List<Visitor> GetAllVisitors()
        {
            string sql = "SELECT * FROM VISITOR";
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
                    bool checkedIn;
                    int spot = 0; // not reserved by default

                    nr = Convert.ToInt32(reader["VisitorNr"]);
                    first = Convert.ToString(reader["FirstName"]);
                    last = Convert.ToString(reader["LastName"]);
                    phone = Convert.ToString(reader["Phone"]);
                    mail = Convert.ToString(reader["Email"]);
                    if (!(reader["RFIDNr"] is DBNull))
                    {
                        rfidNr = Convert.ToString(reader["RFIDNr"]);
                    }
                    if (!(reader["Credit"] is DBNull))
                    {
                        cred = Convert.ToDouble(reader["Credit"]);
                    }
                    checkedIn = Convert.ToBoolean(reader["CheckedIn"]);
                    if (!(reader["SpotNr"] is DBNull))
                    {
                        spot = Convert.ToInt32(reader["SpotNr"]);
                    }

                    temp.Add(new Visitor(nr, first, last, phone, mail, rfidNr, cred, checkedIn, spot));
                }
            }
            catch (MySqlException exc)
            {
                LoggingError(ErrorTypes.ErrorType.DATABASE, exc.Message);
            }
            finally
            {
                connection.Close();
            }
            return temp;
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
            catch (MySqlException exc)
            {
                LoggingError(ErrorTypes.ErrorType.DATABASE, exc.Message);
            }
            finally
            {
                connection.Close();
            }

            return null;
        }


        /// <summary>
        /// Finds all unreturned items and adds it to the selected visitor's object list
        /// </summary>
        /// <param name="v">Selected visitor</param>
        public void FindUnreturnedItems(Visitor v)
        {
            string sql = "SELECT ShopName, ArticleNr, ArticleName " +
                "FROM ORDER_LOAN " +
                "WHERE VisitorNr = " + v.IdNr + " AND IsReturned = 0";
            
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
            catch (MySqlException exc)
            {
                LoggingError(ErrorTypes.ErrorType.DATABASE, exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Returns the ticket with a specified visitorNr
        /// </summary>
        /// <param name="visitorNr"></param>
        /// <returns></returns>
        public Ticket GetTicketStatusForVisitor(int visitorNr)
        {
            string sql = "SELECT * " +
                "FROM TICKET " +
                "WHERE BuyerNr = " + visitorNr;

            Ticket t = null;

            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                // temporary variables
                int nr;
                string date;
                string time;
                string type;
                bool paid;

                while (reader.Read())
                {
                    // reading
                    nr = Convert.ToInt32(reader["TicketNr"]);
                    date = Convert.ToString(reader["TicketDate"]);
                    time = Convert.ToString(reader["TicketTime"]);
                    type = Convert.ToString(reader["TicketType"]);
                    paid = Convert.ToBoolean(reader["Paid"]);
                    t = new Ticket(nr, date, time, visitorNr, type, paid);
                }

            }
            catch (MySqlException exc)
            {
                LoggingError(ErrorTypes.ErrorType.DATABASE, exc.Message);
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
            string sql = "SELECT * FROM VISITOR WHERE RFIDNr = " + rfidNr;

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                v = ReadDataVisitor(reader, v);
            }
            catch (MySqlException exc)
            {
                LoggingError(ErrorTypes.ErrorType.DATABASE, exc.Message);
            }
            finally
            {
                connection.Close();
            }
            return v;
        }

        ///////////////////////////////////////
        // STORES AND ARTICLES HANDLING
        ///////////////////////////////////////


        /// <summary>
        /// Gets all stores in database with their locations
        /// </summary>
        /// <returns>List of stores</returns>
        public List<Shop> GetAllStores()
        {
            string sql = "SELECT * FROM LIST_OF_STORES";
            List<Shop> temp = new List<Shop>();
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                // temporary variables
                int nr;
                string name;
                string loc;

                // reading
                while (reader.Read())
                {
                    nr = Convert.ToInt32(reader["ShopNr"]);
                    name = Convert.ToString(reader["ShopName"]);
                    loc = Convert.ToString(reader["LocationName"]);

                    temp.Add(new Shop(nr, name, loc));
                }
                return temp;
            }
            catch (MySqlException exc)
            {
                LoggingError(ErrorTypes.ErrorType.DATABASE, exc.Message);
            }
            catch (Exception exc)
            {
                LoggingError(ErrorTypes.ErrorType.DATABASE, exc.Message);
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }

        /// <summary>
        /// Gets all stores in database with their locations
        /// </summary>
        /// <returns>List of articles</returns>
        public List<Article> GetArticlesOfShop(Shop s)
        {
            string sql = "SELECT * FROM ARTICLE WHERE ShopNr = " + s.ShopNr;
            List<Article> temp = new List<Article>();
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                // temporary variables
                int nr;
                string name;
                double price;
                int stock;
                string img = "";

                // reading
                while (reader.Read())
                {
                    nr = Convert.ToInt32(reader["ArticleNr"]);
                    name = Convert.ToString(reader["ArticleName"]);
                    price = Convert.ToDouble(reader["Price"]);
                    stock = Convert.ToInt32(reader["Available"]);
                    if (!(reader["Img"] is DBNull))
                    {
                        img = Convert.ToString(reader["Img"]);
                    }
                    temp.Add(new Article(s.ShopNr, nr, name, price, stock, img));
                }
                return temp;
            }
            catch (MySqlException exc)
            {
                LoggingError(ErrorTypes.ErrorType.DATABASE, exc.Message);
            }
            catch (Exception exc)
            {
                LoggingError(ErrorTypes.ErrorType.DATABASE, exc.Message);
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }

        /// <summary>
        /// Create a new order in the database
        /// </summary>
        /// <param name="o">The confirmed order's information</param>
        /// <returns>Number of rows affected</returns>
        public int CreateNewOrder(Order o)
        {
            string sql = "INSERT INTO SHOP_ORDER(OrderDate, OrderTime, ShopNr, VisitorNr) " +
                       "VALUES(CONVERT('" + o.OrderDate + "', DATE), CONVERT('" + o.OrderTime + "', TIME), " + o.Shop.ShopNr + ", " + o.VisitorNr + ")";
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
                LoggingError(ErrorTypes.ErrorType.DATABASE, exc.Message);
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Get the latest order number
        /// </summary>
        /// <returns>The biggest order number in database</returns>
        public int GetLatestOrderNr()
        {
            string sql = "SELECT MAX(OrderNr) FROM SHOP_ORDER";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (MySqlException exc)
            {
                LoggingError(ErrorTypes.ErrorType.DATABASE, exc.Message);
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
        public int AddOrderLine(Order o)
        {
            string sql = "";

            for (int i = 0; i < o.Articles.Count; i++)
            {
                sql += "INSERT INTO SHOP_ORDER_LINE(OrderNr, LineNr, ArticleNr, Quantity) " +
                       "VALUES(" + GetLatestOrderNr() + ", " + (i + 1) + ", " + o.Articles[i].ArticleNr + ", "
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
            catch (MySqlException exc)
            {
                LoggingError(ErrorTypes.ErrorType.DATABASE, exc.Message);
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }
    }