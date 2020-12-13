using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CampApp

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
                    LogMessage(ErrorType.Database, "DatabaseHelper: Cannot connect");
                }
            }
            catch
            {
              
                LogMessage(ErrorType.Database, "DatabaseHelper: Something went wrong cannot connect");
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
        private bool AddToReservationTable(Reservation newReservation)
        {
            bool onSuccess = false;
            String sql = "INSERT INTO reservation (StartDate,EndDate,SpotNumber,LocationNumber,TotalMember,IsPaid,LeaderRFIDCode)" +
              "VALUES  (@StartDate,@EndDate,@SpotNumber,@LocationNumber,@TotalMember,@IsPaid,@LeaderRFIDCode)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@StartDate", newReservation.StartDate);
            command.Parameters.AddWithValue("@EndDate", newReservation.EndDate);
            command.Parameters.AddWithValue("@SpotNumber", newReservation.LocationNumber);
            command.Parameters.AddWithValue("@LocationNumber", newReservation.SpotNumber);
            command.Parameters.AddWithValue("@TotalMember", newReservation.TotalMember);
            command.Parameters.AddWithValue("@IsPaid", newReservation.IsPaid);
            command.Parameters.AddWithValue("@LeaderRFIDCode", newReservation.LeaderRFIDCode);

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
                LogMessage(ErrorType.MySqlException, "Reservation: Error while adding visitor");
            }
            finally
            {
                connection.Close();
            }
            return onSuccess;
        }
        private bool AddToParticipantTable(List<Participant> pariticpants)
        {
            bool onSuccess = false;
            String sql = "INSERT INTO participant (FullName,RFIDCode,Role,LeaderRFIDCode)" +
              "VALUES    (@FullName,@RFIDCode,@Role,@LeaderRFIDCode)";
       
            try
            {
                connection.Open();

                foreach (Participant participant in pariticpants)
                {
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@FullName",participant.FullName );
                    command.Parameters.AddWithValue("@RFIDCode",participant.RFID);
                    command.Parameters.AddWithValue("@Role", participant.Role);
                    command.Parameters.AddWithValue("@LeaderRFIDCode",participant.LeaderRFIDCode);
                    if (command.ExecuteNonQuery() > 0)
                    {    
                        onSuccess = true;
                    }
                }
            }
            catch
            {
                LogMessage(ErrorType.MySqlException, "Reservation: Error while adding visitor");
            }
            finally
            {
                connection.Close();
               
            }
            return onSuccess;
        }
        private bool UpdateVisitorTableBalanceColumn(Visitor visitor)
        {
            bool onSuccess = false;

            string sql = "UPDATE visitor " +
            "SET Balance = " + visitor.Balance +
             " WHERE RFID='" + visitor.RFID + "'";

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

                LogMessage(ErrorType.MySqlException, "UpdateVisitorTableBalanceColumn: Something went wrong while Updating");

            }
            finally
            {
                connection.Close();
            }
            return onSuccess;
        }
        #endregion

        #region Public Methods
        public bool CampReservation(Reservation reservationAdd,List<Participant> participants)
        {
            bool onSucess = false;
            if (reservationAdd != null)
            {
                onSucess = AddToReservationTable(reservationAdd);
                if(onSucess)
                {
                    onSucess = AddToParticipantTable(participants);
                    if(onSucess)
                    {
                        onSucess = UpdateVisitorTableBalanceColumn(participants[0]);
                    }
                }
            }

            return onSucess;
        }
      
        public List<CampSpot> GetAllCampSpot()
        {
            string sql = "select * from camp_spot";
            List<CampSpot> getAllCampSpot = new List<CampSpot>();
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string spotname;
                    int locationId;
                    spotname = Convert.ToString(reader["SpotName"]);
                    locationId = Convert.ToInt32(reader["LocationNr"]);
                    CampSpot campSpot = new CampSpot();
                    campSpot.Name = spotname;
                    campSpot.LocationId = locationId;
                    getAllCampSpot.Add(campSpot);
                }
                return getAllCampSpot;
            }
            catch
            {
                LogMessage(ErrorType.MySqlException, "GetAllCampSpot: Something went wrong while querying");
            }
            finally
            {
                connection.Close();
            }
            return getAllCampSpot;
        }
        public Location GetLocation(int locationId)
        {
            string sql = "select * from camp_location where LocationNr='" + locationId + "'";
            Location foundLocation = null;
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string Locationname;
                    Locationname = Convert.ToString(reader["LocationName"]);
                    foundLocation = new Location
                    {
                        LocationId = locationId,
                        LocationName = Locationname
                    };
                }

            }
            catch
            {
                LogMessage(ErrorType.MySqlException, "GetLocation: Something went wrong while querying");
            }
            finally
            {
                connection.Close();
            }
            return foundLocation;
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
                    foundVisitor = new Visitor(fullName, rfidCode,balance);
                    foundVisitor.IsCheckedIn = isCheckedIn;
                    foundVisitor.Id = id;
                }
            }
            catch (MySqlException)
            {
                LogMessage(ErrorType.MySqlException, "FindVisitor: Something went wrong while querying");
            }
            finally
            {
                connection.Close();
            }
            return foundVisitor;
        }


       
    }

}


    #endregion



