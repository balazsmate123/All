using MySql.Data.MySqlClient;

namespace users
{
    public class Connect
    {
        public MySqlConnection connection;
        private string Host;
        private string DbName;
        private string Password;
        private string Username;
        private string ConnectionString;

        public Connect()
        {
            Host = "localhost";
            DbName = "db_user";
            Username = "root";
            Password = "";

            //onnectionString = "Host="+Host+";Database"+DbName+";User="+Username+";Password="+Password+";SslMode=none";
            ConnectionString = $"Host={Host};Database={DbName};User={Username};Password={Password};SslMode=None;";

            connection = new MySqlConnection(ConnectionString);
        }
    }
}
