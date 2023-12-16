using PetPals.Entity;
using PetPals.UserException;
using PetPals.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using NullReferenceException = PetPals.UserException.NullReferenceException;

namespace PetPals.Dao
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
            int age = pet.Age;
            bool validAge = checkPetAge(age);
            if(validAge)
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
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
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }                
            
            }
        }
        public void RemovePet(Pet pet)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    cmd.CommandText = "delete from Pets where pet_id=@petId";
                    cmd.Parameters.AddWithValue("@petId", pet.PetId);
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Pet deleted Successfully............");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
        public List<Pet> ListAvailablePets()
        {
            List<Pet> availablePets = new List<Pet>();
            try
            {
                
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
                        bool available = (bool)reader["available_for_adoption"];
                        if (available)
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            return availablePets;
        }

        public bool checkPetAge(int age)
        {
            if (age > 0)
                return true;
            else
                throw new InvalidPetAgeException("Please enter valid age of the pet");
        }
        public bool checkNullReference(string name)
        {
            if (name != null)
                return true;
            else
                throw new NullReferenceException($"Null value encountered");
        }
    }
}
