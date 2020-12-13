using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampEntranceApp
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
        //Connecting to the dbi387862 database
        public DatabaseHelper(ILogger logger)
        {
            this.logger = logger;
            try
            {
                String connectionInfo = "server=studmysql01.fhict.local;" +//the hera-server
                               "database=dbi387862;" +
                               "user id=dbi387862;" +
                               "password=blueberrypie;";
                connection = new MySqlConnection(connectionInfo);


                LogMessage(ErrorType.Database, "Connected");

                Isconnected = true;
            }
            catch
            {
                connection.Close();
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

        private bool UpdateParticipantTableCheckedInColumn(string rfidCode, bool checkedIn)
        {
            bool onSuccess = false;

            string sql3 = "UPDATE participant " +
                "SET CheckedIn = " + checkedIn +
                " WHERE RFIDNr='" + rfidCode + "'";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql3, connection);
                if (command.ExecuteNonQuery() > 0)
                {
                    onSuccess = true;
                }
                else
                {
                    onSuccess = false;
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
        private Reservation GetReservation(Participant participant)

        {
            Reservation foundReservation = null;

            if (participant != null)
            {
                string sql1 = "SELECT * FROM reservation_info WHERE Reserver = " + participant.Id;
                MySqlCommand command1 = new MySqlCommand(sql1, connection);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command1.ExecuteReader();
                    int id;
                    string reservDate;
                    string reservTime;
                    string endDate;
                    string startDate;
                    int totalmember;
                    int spotNr;
                    int nrCheckedIn;
                    bool paid;

                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["ReservNr"]);
                        reservDate = Convert.ToString(reader["ReservDate"]);
                        reservTime = Convert.ToString(reader["ReservTime"]);
                        spotNr = Convert.ToInt32(reader["SpotNr"]);
                        totalmember = Convert.ToInt32(reader["NrOfRegistered"]);
                        nrCheckedIn = Convert.ToInt32(reader["NrCheckedIn"]);
                        paid = Convert.ToBoolean(reader["Paid"]);
                        startDate = Convert.ToString(reader["StartDate"]);
                        endDate = Convert.ToString(reader["EndDate"]);
                        foundReservation = new Reservation(startDate, endDate, spotNr, totalmember, nrCheckedIn, paid);
                        foundReservation.Id = id;

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
            }
            return foundReservation;
        }

        #endregion

        #region Public Method
        public Participant GetParticipant(string rfid)
        {
            Participant foundParticipant = null;
            string sql = "SELECT * FROM participant WHERE RFIDNr ='" + rfid + "'";
            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();

                int id;
                string firstname;
                string lastName;
                int phone;
                string mail;
                bool isCheckedIn;
                double balance;
                int spotNr;
                // reading
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["IdNr"]);
                    firstname = Convert.ToString(reader["FirstName"]);
                    lastName = Convert.ToString(reader["lastName"]);
                    mail = Convert.ToString(reader["Email"]);
                    phone = Convert.ToInt32(reader["Phone"]);
                    isCheckedIn = Convert.ToBoolean(reader["CheckedIn"]);
                    balance = Convert.ToDouble(reader["Credit"]);
                    spotNr = Convert.ToInt32(reader["spotNr"]);
                    foundParticipant = new Participant(firstname, lastName, rfid, balance, spotNr);
                    foundParticipant.IsCheckedIn = isCheckedIn;
                    foundParticipant.Id = id;
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
            return foundParticipant;
        }
       

        /// <summary>
        /// Check if the particpant has paid or not for the camp
        /// </summary>
        /// <param name="rfid">RFID code of a visitor</param>
        /// <param<see cref="out"/> name="participant">Participant who has paid</param>
        /// <returns>True when a participant has paid otherwise returns false</returns>
        public bool CheckInOrCheckout(Participant participant)
        {
            bool onSuccess = false;
            if (participant != null)
            {
                Reservation foundReservation = GetReservation(participant);
                if (foundReservation != null)
                {
                    if (foundReservation.IsPaid)
                    {
                        if (participant.IsCheckedIn)
                        {
                            onSuccess = UpdateParticipantTableCheckedInColumn(participant.RFID, false);
                        }
                        else
                        {
                            onSuccess = UpdateParticipantTableCheckedInColumn(participant.RFID, true);
                        }
                    }
                }
            }
           
            return onSuccess;
        }
        #endregion

    }
}





