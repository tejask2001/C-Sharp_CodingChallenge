using PetPals.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Entity
{
    internal class PetShelter
    {
        List<Pet> availablePets = new List<Pet>();
        public string connectionString;
        SqlCommand cmd = null;
        public PetShelter() 
        {
            connectionString = "Server=TEJAS;Database=PetPals;Trusted_Connection=True";
            cmd = new SqlCommand();
        }

        public void AddPet(Pet pet)
        {
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                cmd.CommandText = "insert into Pets values(@name,@age,@breed,@type,@availableForAdoption)";
                cmd.Parameters.AddWithValue("@name", pet.Name);
                cmd.Parameters.AddWithValue("@age", pet.Age);
                cmd.Parameters.AddWithValue("@breed", pet.Breed);
                cmd.Parameters.AddWithValue("@type", pet.Type);
                cmd.Parameters.AddWithValue("@availableForAdoption", pet.AvailableForAdoption);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Pet added to cart Successfully............");
                }
            }
        }
        public void RemovePet(Pet pet)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                cmd.CommandText = "delete from Pets where pet_id=@petId";
                cmd.Parameters.AddWithValue("@petId", pet.PetId);
                cmd.Connection= sqlConnection;
                sqlConnection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Pet deleted Successfully............");
                }
            }

        }
        public List<Pet> ListAvailablePets()
        {
            List<Pet> availablePets = new List<Pet>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                
                cmd.CommandText = "select * from Pets";
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Pet pet = new Pet();
                    pet.PetId = (int)reader["pet_id"];
                    pet.Name = (string)reader["name"];
                    pet.Age = (int)reader["age"];
                    pet.Breed = (string)reader["Breed"];
                    pet.Type = (string)reader["type"];
                    bool available=(bool)reader["available_for_adoption"];
                    if(available)
                    {
                        pet.AvailableForAdoption = 1;
                    }
                    else
                    {
                        pet.AvailableForAdoption = 0;
                    }                    
                    availablePets.Add(pet);
                }                
            }
            return availablePets;
        }
    }
}
