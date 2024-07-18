using Microsoft.Extensions.Configuration;
using ShabatHosts.DAL;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace ShabatGuests
{
    internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()

        {
            var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
            string? conn = config["ConnectionString"];
            string? dbName = config["DefaultDB"];

            if (string.IsNullOrEmpty(conn) || string.IsNullOrEmpty(dbName))
            {
                throw new ArgumentNullException("Connection string or database name is missing");
            }
            //DBContext mydb = new DBContext(conn);
            //mydb.CheckConnectionToDefaultDB(dbName);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            DBContext dbc = new DBContext(conn);
            Application.Run(new HostForm(dbc));

        }


    }
}