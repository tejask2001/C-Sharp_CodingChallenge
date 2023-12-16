using PetPals.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Dao
{
    internal class AdoptionEvent : IAdoptable
    {
        public string connectionString;
        SqlCommand cmd = null;
        public AdoptionEvent()
        {
            connectionString = "Server=TEJAS;Database=PetPals;Trusted_Connection=True";
            cmd = new SqlCommand();
        }
        

        public void HostEvent(Event events)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                cmd.CommandText = "insert into adoptionevents values(@eventName,@eventDate,@location)";
                cmd.Parameters.AddWithValue("eventName",events.EventName);
                cmd.Parameters.AddWithValue("eventDate",events.EventDate);
                cmd.Parameters.AddWithValue("location",events.Location);
                cmd.Connection= sqlConnection;
                sqlConnection.Open();
                int rowsAffected=cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Event registered for hosting...........");
                }
            }
        }
        public void RegisterParticipant(Participants participants)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                cmd.CommandText = "insert into participants values(@participantName,@participantType,@eventId)";
                cmd.Parameters.AddWithValue("@participantName", participants.ParticipantName);
                cmd.Parameters.AddWithValue("@participantType",participants.ParticipantType);
                cmd.Parameters.AddWithValue("@eventId",participants.EventID);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Participant Registered Successfully...........");
                }
            }
        }
        public void Adopt()
        {

        }

    }
}
