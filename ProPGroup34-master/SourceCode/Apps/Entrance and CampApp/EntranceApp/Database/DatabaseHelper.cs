using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using EntranceApp.Helper;
using EntranceApp.Models;

namespace EntranceApp
{
    public class DatabaseHelper
    {
        #region Private Fields
        private MySqlConnection connection;
        private ILogger logger;
        #endregion

        #region Properties
        public bool Isconnected { get; set; }
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


                LoggingError(ErrorType.Database, "Connected");

                Isconnected = true;
            }
            catch
            {
                connection.Close();
                LoggingError(ErrorType.Database, "Something went wrong cannot connect");

            }
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="errorType"></param>
        /// <param name="message"></param>
        private void LoggingError(ErrorType errorType, String message)
        {
            if (this.logger != null)
            {
                logger.LogMessage(errorType, message);
            }
        }
        #endregion

        #region Public Method
        /// <summary>
        /// read data from visitor
        /// </summary>
        /// <param name="rfidCode"></param>
        /// <returns></returns>

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
                LoggingError(ErrorType.MySqlException, "Something went wrong while querying");
            }
            finally
            {
                connection.Close();
            }
            return foundVisitor;
        }
        /// <summary>
        /// update the checkin column to the visitor
        /// </summary>
        /// <param name="rfidCode"></param>
        /// <param name="checkedIn"></param>
        /// <returns></returns>
        private bool UpdateVisitorTableIsCheckedInColumn(string rfidCode, bool checkedIn)
        {
            bool onSuccess = false;

            string sql = "UPDATE visitor " +
            "SET IsCheckedIn = " + checkedIn +
             " WHERE RFID='" + rfidCode + "'";

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

                LoggingError(ErrorType.MySqlException, "Something went wrong while querying");

            }
            finally
            {
                connection.Close();
            }
            return onSuccess;
        }



        /// <summary>
        /// Update IscheckedIn column value of database true or flase
        /// </summary>
        /// <param name="rfidCode"></param>
        /// <param name="foundVistor"></param>
        /// <returns></returns>

          public bool MakeCheckInOrOut(string rfidCode, out Visitor visitor)
         {
            bool onSuccess = false;
           Visitor foundVistor = FindVisitor(rfidCode);

            if (foundVistor != null)
            {
                if (foundVistor.IsCheckedIn)
                {
                    onSuccess = UpdateVisitorTableIsCheckedInColumn(rfidCode, false);
                }
                else 
                {
                    onSuccess = UpdateVisitorTableIsCheckedInColumn(rfidCode, true);
                }
            }
            if (onSuccess)
            {
                visitor = foundVistor;
            }
            else
            {
                visitor = null;
            }

            return onSuccess;
         }
         #endregion

    }


}
