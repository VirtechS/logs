using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;

        public ConnectionToSql() {
            connectionString = "server=DESKTOP-8FMQ1MB\\SQLEXPRESS;DataBase= delivery; integrated security=true";
        }
        protected SqlConnection GetConnection() {
            return new SqlConnection(connectionString);
        }
    }
}