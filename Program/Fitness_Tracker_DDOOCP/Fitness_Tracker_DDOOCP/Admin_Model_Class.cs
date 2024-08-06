using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker_DDOOCP
{
    class Admin_Model_Class
    {
        private string _AdminID, _UserName, _Password, _FullName, _Email, _Contact;

        public string AdminID
        {
            set
            {
                _AdminID = value;
            }
            get
            {
                return _AdminID;
            }
        }
        public string UserName
        {
            set
            {
                _UserName = value;
            }
            get
            {
                return _UserName;
            }
        }
        public string Password
        {
            set
            {
                _Password = value;
            }
            get
            {
                return _Password;
            }
        }
        public string FullName
        {
            set
            {
                _FullName = value;
            }
            get
            {
                return _FullName;
            }
        }
        public string Email
        {
            set
            {
                _Email = value;
            }
            get
            {
                return _Email;
            }
        }
        public string Contact
        {
            set
            {
                _Contact = value;
            }
            get
            {
                return _Contact;
            }
        }
        
    }
}
