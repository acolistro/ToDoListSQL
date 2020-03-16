using System;
using MySql.Data.MySqlClient;
using ToDoList;

namespace ToDoList.Models
{
  public class DB
  {
    public staticMySqlConnection Connection()
    {
      staticMySqlConnection conn = new staticMySqlConnection(BDConfiguration.ConnectionString);
      return conn;
    }
  }
}