using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BuyTicketApp
{
    public class DatabaseHelper
    {
        #region Private Fields
        private MySqlConnection connection;
        private ILogger logger;
        #endregion

        #region Constructor
        //Connecting to the database
        public DatabaseHelper(ILogger logger)
        {
            this.logger = logger;
            try
            {
                String connectionInfo = "server=studmysql01.fhict.local;" +//the hera-server
                               "database=dbi364365;" +
                               "user id=dbi364365;" +
                               "password=Dholon;";
                connection = new MySqlConnection(connectionInfo);
                connection.Open();
                if (connection.Ping())
                {
                    LogMessage(ErrorType.Database, "Connected");
                    connection.Close();
                }
                else
                {
                    LogMessage(ErrorType.Database, "Cannot connect");
                }
            }
            catch
            {
              
                LogMessage(ErrorType.Database, "Something went wrong cannot connect");
                
            }
        }
        #endregion

        #region Private Methods
        private void LogMessage(ErrorType errorType, String message)
        {
            if (this.logger != null)
            {
                logger.LogMessage(errorType, message);
            }
        }

        public Visitor FindVisitor(string rfidCode)
        {
            Visitor foundVisitor = null;
            string sql = "SELECT * FROM visitor WHERE RFID ='" + rfidCode + "'";

            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();

                int id;
                string fullName;
                int phone;
                string mail;
                bool isCardLinked, isCheckedIn;
                double balance;
                // reading
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                    fullName = Convert.ToString(reader["FullName"]);
                    mail = Convert.ToString(reader["EmailAddress"]);
                    phone = Convert.ToInt32(reader["PhoneNumber"]);
                    isCardLinked = Convert.ToBoolean(reader["IsCardLinked"]);
                    isCheckedIn = Convert.ToBoolean(reader["IsCheckedIn"]);
                    balance = Convert.ToInt32(reader["Balance"]);
                    foundVisitor = new Visitor(fullName, mail, phone, balance, rfidCode);
                    foundVisitor.IsCheckedIn = isCheckedIn;
                    foundVisitor.IsCardLinked = isCardLinked;
                    foundVisitor.Id = id;
                }
            }
            catch (MySqlException)
            {
                LogMessage(ErrorType.MySqlException, "Something went wrong while querying");
            }
            finally
            {
                connection.Close();
            }
            return foundVisitor;
        }
        private bool UpdateVisitorTableIsCheckedInColumn(string rfidCode, bool checkedIn)
        {
            bool onSuccess = false;

            string sql = "UPDATE visitor " +
            "SET IsCheckedIn = " + checkedIn +
             " WHERE RFID='" + rfidCode+"'";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql, connection);
                if (command.ExecuteNonQuery() > 0)
                {
                    onSuccess = true;
                }

            }
            catch (MySqlException)
            {

                LogMessage(ErrorType.MySqlException, "Something went wrong while querying");

            }
            finally
            {
                connection.Close();
            }
            return onSuccess;
        }

        private bool DeleteVisitorFromTable(string rfidCode)
        {
            bool onSuccess = false;

            string sql = "DELETE FROM visitor WHERE RFID='"+rfidCode+"'";


            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql, connection);
                if (command.ExecuteNonQuery() > 0)
                {
                    onSuccess = true;
                }

            }
            catch (MySqlException)
            {

                LogMessage(ErrorType.MySqlException, "DeleteVisitorFromTable: Something went wrong while deleting");

            }
            finally
            {
                connection.Close();
            }
            return onSuccess;
        }

        private bool UpdateRfidTableIsCardLinkedColumn(string rfidCode, bool isCardLinked)
        {
            bool onSuccess = false;

            string sql = "UPDATE rfid " +
            "SET IsCardLinked = " + isCardLinked +
             " WHERE Code='" + rfidCode + "'";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql, connection);
                if (command.ExecuteNonQuery() > 0)
                {
                    onSuccess = true;
                }

            }
            catch (MySqlException)
            {

                LogMessage(ErrorType.MySqlException, "UpdateRfidColumn: Something went wrong while updating");

            }
            finally
            {
                connection.Close();
            }
            return onSuccess;
        }

        private bool AddVisitorToDeletedVisitorTable(Visitor visitorTobeAdded)
        {
            bool onSuccess = false;

            String sql = "INSERT INTO deletedvisitor (FullName,EmailAddress,PhoneNumber,Balance,RFID,VisitorId)" +
               "VALUES  (@FullName,@EmailAddress,@PhoneNumber,@Balance,@RFID,@VisitorId)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@FullName", visitorTobeAdded.FullName);
            command.Parameters.AddWithValue("@EmailAddress", visitorTobeAdded.EmailAddress);
            command.Parameters.AddWithValue("@PhoneNumber", visitorTobeAdded.PhoneNumber);
            command.Parameters.AddWithValue("@RFID", visitorTobeAdded.RFID);
            command.Parameters.AddWithValue("@Balance", visitorTobeAdded.Balance);
            command.Parameters.AddWithValue("@VisitorId", visitorTobeAdded.Id);

            try
            {

                connection.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    connection.Close();
                    onSuccess = true;
                }


            }
            catch
            {
                LogMessage(ErrorType.MySqlException, "AddVisitorToDeletedVisitorTable: Error while adding visitor");
            }
            finally
            {
                connection.Close();
            }
            return onSuccess;
        }
        #endregion

        #region Public Method
        /// <summary>
        /// If visitor exist with rfid in table,visitor can not linked and
        /// it returns false and if not exist then return true.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="emailAddress"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="balance"></param>
        /// <param name="rfid"></param>
        /// <returns></returns>
        public bool LinKCard(string name, string emailAddress, int phoneNumber, double balance, string rfid)
        {
            bool onSuccess = false;
            Visitor foundvisitor = FindVisitor(rfid);
           
            
                if (foundvisitor == null)
                {
                    String sql = "INSERT INTO visitor (FullName,EmailAddress,PhoneNumber,Balance,RFID,IsCardLinked,IsCheckedIn)" +
                                  "VALUES  (@FullName,@EmailAddress,@PhoneNumber,@Balance,@RFID,@IsCardLinked,@IsCheckedIn )";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@FullName", name);
                    command.Parameters.AddWithValue("@EmailAddress", emailAddress);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@RFID", rfid);
                    command.Parameters.AddWithValue("@Balance", balance);
                    command.Parameters.AddWithValue("@IsCardLinked", true);
                    command.Parameters.AddWithValue("@IsCheckedIn", false);

                    try
                    {

                        connection.Open();
                        if (command.ExecuteNonQuery() > 0)
                        {
                            connection.Close();
                            onSuccess = true; //UpdateRfidTableIsCardLinkedColumn(rfid, linkCard);
                        }


                    }
                    catch
                    {
                        LogMessage(ErrorType.MySqlException, "AddVisitor: Error while adding visitor");
                    }
                    finally
                    {
                        connection.Close();
                    }
                } 
 
            return onSuccess;
        }
        /// <summary>
        /// if it exist with visitor rfid table then return true
        /// and othrwise return false
        /// </summary>
        /// <param name="foundvisitor"></param>
        /// <returns></returns>
        public bool UnlinkCard(Visitor foundvisitor)
        {
            bool onSuccess = false;
            if (foundvisitor != null)
            {
                onSuccess = AddVisitorToDeletedVisitorTable(foundvisitor);
                if (onSuccess)
                {
                    onSuccess = DeleteVisitorFromTable(foundvisitor.RFID);
                    
                }

            }
            return onSuccess;

        }
        #endregion        
    }
}
