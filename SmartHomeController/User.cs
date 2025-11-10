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
        private string ContactInfo;

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
    }
}
