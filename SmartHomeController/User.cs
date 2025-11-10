using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeController
{
    public class User
    {
        private int userid;
        private string userName;
        private string password;
        private string ContactInfo;
        private bool isLoggedin;

        public int Userid
        {
            get { return userid; }
            set { userid = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Contactinfo
        {
            get { return ContactInfo; }
            set { ContactInfo = value; }
        }

        public bool Isloggedin
        {
            get { return isLoggedin; }
            set { isLoggedin = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool Login(string userName, string password)
        {
            if (UserName == userName && Password == password)
            {
                //username and password authentication
                // advise user that their login is successful
                Isloggedin = true;
                Console.WriteLine("Login Successful");
            }
            else
            {
                //user name and/or password are incorrect
                //ask user to reenter details.
                Isloggedin = false;
                Console.WriteLine($"Login Failed. Username {userName} or password is incorrect");
            }
            return isLoggedin;
        }

        public void Logout()
        {
            if (isLoggedin)
            {
                isLoggedin = false;
                Console.WriteLine("user is logged out successfully");
            }
            else
            {
                Console.WriteLine("User is not logged in");
            }
        }
        public void ControlDevice(int deviceID, string deviceName, string deviceAction)
        {
            if (Isloggedin)
            {
                Console.WriteLine($"Perfroming action {deviceAction} on {deviceName}");
            }
            else
            {
                Console.WriteLine("Please log in to control the device");
            }
        }
        public User(int Userid, string UserName, string Password, string contactInfo, bool isLoggedin, int userid, string userName, string contactinfo, bool isloggedin, string password)
        {
            this.userid = Userid;
            this.UserName = UserName;
            this.password = Password;
            this.Contactinfo = contactInfo;
            this.isLoggedin = false;
        }
    }
}
