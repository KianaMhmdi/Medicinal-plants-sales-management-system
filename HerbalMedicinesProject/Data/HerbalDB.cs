using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HerbalMedicinesProject.Data
{
    internal class HerbalDB
    {
        /// <summary>
        /// ///دستورات مربوط به دیتابیس
        /// </summary>
        /// 

        //آدرس دیتابیس
        private string connectionString = "Data Source=.;Initial Catalog=HerbalProjectDB;User Id=sa;Password=1234;";

        ///اضافه کردن فرد به دیتابیس
        public bool AddPerson(Person person)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                 string query = "INSERT INTO Person_DB_Table(NationalCode, FirstName, LastName, " +
                    "PhoneNumber, Gender, PasswordHash, Salt, Address, " +
                  "BirthDate, Role, Email) " +
                "VALUES (@nationalCode, @firstName, @lastName, " +
                "@phoneNumber, @gender, @passwordHash, @salt, @address, @birthDate, @role, @email)";
                
                SqlCommand command = new SqlCommand(query, connection);
               
              //مقدار دهی پارامتر ها

                command.Parameters.AddWithValue("@nationalCode", person.Id);
                command.Parameters.AddWithValue("@firstName", person.FirstName);
                command.Parameters.AddWithValue("@lastName", person.LastName);
                command.Parameters.AddWithValue("@phoneNumber", person.PhoneNumber);
                command.Parameters.AddWithValue("@gender", person.Gender);
                command.Parameters.AddWithValue("@passwordHash", person.PasswordHash);
                command.Parameters.AddWithValue("@salt", person.Salt);
                command.Parameters.AddWithValue("@address", person.Address);
                command.Parameters.AddWithValue("@birthDate", person.BirthDate);
                command.Parameters.AddWithValue("@role", person.Role);
                command.Parameters.AddWithValue("@email", person.Email);

                command.ExecuteNonQuery();
                return true;
            }
                
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
