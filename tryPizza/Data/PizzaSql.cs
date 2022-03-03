using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace tryPizza.Data
{


    public interface IPizzaItemData
    {
        Task<string> GetPizza();
        Task AddPizza(int id, string name, string isGlutenFree);
    }
    public class PizzaSql : IPizzaItemData
    {
        private string _conn;
        private readonly ILogger _log;
        private readonly AppConfig appconfig;



        public async Task<string> GetPizza()
        {
            try
            {
                string connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = C:\Users\matt_\OneDrive\Documents\pizza.mdf;";
                using (SqlConnection conn = new SqlConnection(connetionString))
                {
                    var cmd = new SqlCommand
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "GetAllPizza"

                    };
                    cmd.Connection = conn;
                    cmd.Connection.Open();
                    var reader = await cmd.ExecuteReaderAsync();
                    var pizza = "";
                    while (reader.Read())
                    {
                        pizza = pizza + reader.GetValue(0) + " " + reader.GetValue(1) + " " + reader.GetValue(2) + "\n";
                    }
                    return pizza;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error in GetPizza /n");
                throw ex;
            }
        }

        public async Task AddPizza(int id, string name, string isGlutenFree)
        {
            try
            {
                string connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = C:\Users\matt_\OneDrive\Documents\pizza.mdf;";
                using (SqlConnection conn = new SqlConnection(connetionString))
                {
                    /*
                    var cmd = new SqlCommand
                    {
                        //CommandType = CommandType.StoredProcedure,
                        //CommandText = "GetAllPizza"

                    };*/
                    //cmd.Connection = conn;
                    //cmd.Connection.Open();
                    conn.Open();
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    string sql = "";
                    sql = $"Insert into dbo.Pizza (Id, Name, IsGlutenFree) values({id}, '{name}', {int.Parse(isGlutenFree)} );";
                    command = new SqlCommand(sql, conn);
                    adapter.InsertCommand = new SqlCommand(sql, conn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    command.Dispose();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error in AddPizza /n");
                throw ex;
            }
        }
    }
}
