using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assignment.LoginPage
{
    public class CredentialValidation : DatabaseHelper
    {
        public static Dictionary<int, string> errorCodes = new Dictionary<int, string>()
        {
            { 1001, "Username must be at least 3 characters long" },
            { 1002, "Username must not contain spaces" },
            { 1003, "Username must only contain letters, digits, or underscores" },
            { 1004, "Username already exists" },
            { 1005, "Username doesn't exists" },
            { 2000, "Password cannot be empty" },
            { 2001, "Password must be at least 8-20 characters long" },
            { 2002, "Password must not contain whitespace" },
            { 2003, "Password must contain at least 1 uppercase letter, 1 lowercase letter, 1 number, and 1 symbol" },
            { 3001, "Phone number must be at least 9-12 digits long" },
            { 3002, "Phone number must only contain digits"  }
        };

        public static int usernameValidation(string username)
        {
            if (string.IsNullOrWhiteSpace(username) || username.Length < 3)
                return 1001; // Custom error code for invalid username length
            if (username.Any(c => char.IsWhiteSpace(c)))
                return 1002; // Passwords should not contain whitespace
            if (username.Any(c => !char.IsLetterOrDigit(c) && c != '_'))
                return 1003; // Username should only contain letters, digits, or underscores
            if (checkDuplicateUsername(username) != 0)
                return 1004; // Custom error code for duplicate username
            return 0;
        }
        
        public static int passwordValidation(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8 || password.Length > 20)
                return 2001; // Custom error code for invalid password length
            if (password.Any(c => char.IsWhiteSpace(c)))
                return 2002; // Passwords should not contain whitespace
            if (!password.Any(char.IsUpper) || !password.Any(char.IsLower) ||
                !password.Any(char.IsDigit) || !password.Any(c => !char.IsLetterOrDigit(c)))
                return 2003; // Password must contain at least 1 uppercase letter, 1 lowercase letter, 1 number, and 1 symbol
            return 0;
        }

        public static int phoneNumberValidation(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber) || phoneNumber.Length < 9 || phoneNumber.Length > 12)
                return 3001; // Custom error code for invalid phone number
            if (!phoneNumber.All(char.IsDigit))
                return 3002; // Custom error code for non-digit characters in phone number
            return 0;
        }

        public static int checkDuplicateUsername(string username)
        {
            string query = "SELECT AccountID FROM Account WHERE Name = @username";
            SqlParameter[] parameters = new SqlParameter[]
 {
                new SqlParameter("@username", username)
            };
            DataTable result = ExecuteQuery(query, parameters);
            if (result != null && result.Rows.Count > 0)
            {
                // Duplicate username found
                return 1004; // Custom error code for duplicate username
            }
            return 0; // Return 0 if no duplicate username found
        }
    }
}
