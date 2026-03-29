using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assignment.roleadmin.Classes
{

    public class Admin
    {
        //Fields --------------------------------------------------------------------------------------
        //Backing Fields
        private string _accID;
        private string _adminID;
        private string _roleID;
        private string _username;
        private string _password;
        private string _gender;
        private string _phoneNum;

        //Public Fields
        public string AccID
        {
            get { return _accID; }
            set { _accID = value; }
        }

        public string AdminID
        {
            get { return _adminID; }
            set { _adminID = value; }
        }

        public string RoleID
        {
            get { return _roleID; }
            set { _roleID = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string PhoneNum
        {
            get { return _phoneNum; }
            set { _phoneNum = value; }
        }
        
        //Constructors --------------------------------------------------------------------------------
        //Default Constructor
        public Admin() {
            _accID = "unknown";
            _adminID = "unknown";
            _roleID = "unknown";
            _username = "unknown";
            _password = "unknown";
            _gender = "unknown";
            _phoneNum = "unknown";
        }
        
        //Methods ----------------------------------------------------------------------------------------

    }
}
