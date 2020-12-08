using Microsoft.Data.SqlClient;
using IdentitySample;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using System.Configuration;

namespace Tercera
{
    public class IdentityManager
    {
        public IdentityManager()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private static ApplicationSignInManager _signInManager;
        private static ApplicationUserManager _userManager;

        public static ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.Current.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public static ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

    }
    public class Connection
    {
        /// </summary>
        /// <param name="_database"></param>
        /// <returns></returns>
        public static SqlConnection GetConnectionSpecific(string _database)
        {
            // Get the connection string from the configuration file
            string connectionString = "";

            switch (_database.ToLower())
            {
                case "identitydb":
                    connectionString = ConfigurationManager.ConnectionStrings["identitydb"].ConnectionString;
                    break;
            }
            // Create a new connection object
            SqlConnection connection = new SqlConnection(connectionString);

            // Open the connection, and return it
            connection.Open();
            return connection;

        }
    }

}
