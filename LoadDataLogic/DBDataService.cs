using LoadCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using System.Text.Json;

namespace LoadDataLogic
{
    class DBDataService : ILoadDataProcess
    {

        static string connectionString
        = "Data Source =DESKTOP-CNV7A0F\\SQLEXPRESS; Initial Catalog = LoadSystem; " +
            "Integrated Security = True; TrustServerCertificate=True;";

        static SqlConnection sqlConnection;

        public DBDataService()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        public List<LoadAccount> GetAllAccounts()
        {
            string selectStatement = "SELECT PhoneNumber, Name, PIN, Balance, Data, History FROM LoadAccountDetails";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();

            SqlDataReader reader = selectCommand.ExecuteReader();

            var loadAccounts = new List<LoadAccount>();

            while (reader.Read())
            {

                LoadAccount loadAccount = new LoadAccount();
                loadAccount.phoneNumber = reader["PhoneNumber"].ToString();
                loadAccount.name = reader["Name"].ToString();
                loadAccount.pin = reader["PIN"].ToString();
                loadAccount.balance = Convert.ToDouble(reader["Balance"]);
                loadAccount.data = Convert.ToDouble(reader["Data"]);
                string history = reader["History"].ToString();
                loadAccount.history = JsonSerializer.Deserialize<List<string>>(history) ?? new List<string>();

                loadAccounts.Add(loadAccount);
            }

            sqlConnection.Close();
            return loadAccounts;
        }

        public void RegisterAccount(LoadAccount loadAccount)
        {
            var insertStatement = "INSERT INTO LoadAccountDetails VALUES (@PhoneNumber, @Name, @PIN, @Balance, @Data, @History)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@PhoneNumber", loadAccount.phoneNumber);
            insertCommand.Parameters.AddWithValue("@Name", loadAccount.name);
            insertCommand.Parameters.AddWithValue("@PIN", loadAccount.pin);
            insertCommand.Parameters.AddWithValue("@Balance", loadAccount.balance);
            insertCommand.Parameters.AddWithValue("@Data", loadAccount.data);
            string history = JsonSerializer.Serialize(loadAccount.history ?? new List<string>());
            insertCommand.Parameters.AddWithValue("@History", history);

            sqlConnection.Open();

            insertCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void UpdateAccount(LoadAccount loadAccount)
        {
            sqlConnection.Open();

            var updateStatement = @"UPDATE LoadAccountDetails SET Name = @Name, PIN = @PIN, Balance = @Balance, Data = @Data, History = @History WHERE PhoneNumber = @PhoneNumber";

            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);

            updateCommand.Parameters.AddWithValue("@Name", loadAccount.name);
            updateCommand.Parameters.AddWithValue("@PIN", loadAccount.pin);
            updateCommand.Parameters.Add("@Balance", System.Data.SqlDbType.Money).Value = Convert.ToDecimal(loadAccount.balance);
            updateCommand.Parameters.Add("@Data", System.Data.SqlDbType.Money).Value = Convert.ToDecimal(loadAccount.data);
            string history = JsonSerializer.Serialize(loadAccount.history ?? new List<string>());
            updateCommand.Parameters.AddWithValue("@History", history);

            updateCommand.Parameters.AddWithValue("@PhoneNumber", loadAccount.phoneNumber);

            updateCommand.ExecuteNonQuery();

            sqlConnection.Close();

        }
    }
}
