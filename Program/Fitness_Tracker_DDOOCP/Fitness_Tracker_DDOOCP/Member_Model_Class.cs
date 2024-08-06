using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracker_DDOOCP
{
    class Member_Model_Class
    {
        private string
            _MemberID,
            _UserName,
            _Password,
            _FullName,
            _NRIC,
            _Email,
            _Contact,
            _Gender;

        private DateTime
            _DateOfBirth,
            _JoinDate;

        private decimal
            _Weight,
            _Height;

        public string MemberID
        {
            set {_MemberID = value;}
            get {return _MemberID; }
        }
        public string UserName
        {
            set { _UserName = value; }
            get { return _UserName; }
        }
        public string Password
        {
            set { _Password = value; }
            get { return _Password; }
        }
        public string FullName
        {
            set { _FullName = value; }
            get { return _FullName; }
        }
        public string NRIC
        {
            set { _NRIC = value; }
            get { return _NRIC; }
        }
        public string Email
        {
            set { _Email = value; }
            get { return _Email; }
        }
        public string Contact
        {
            set { _Contact = value; }
            get { return _Contact; }
        }

        public DateTime DateOfBirth
        {
            set { _DateOfBirth = value; }
            get { return _DateOfBirth; }
        }
        public DateTime JoinDate
        {
            set { _JoinDate = value; }
            get { return _JoinDate; }
        }

        public decimal Weight
        {
            set { _Weight = value; }
            get { return _Weight; }
        }
        public decimal Height
        {
            set { _Height = value; }
            get { return _Height; }
        }
        public string Gender
        {
            set { _Gender = value; }
            get { return _Gender; }
        }

        public void SetGender(RadioButton radioMale, RadioButton radioFemale)
        { 
            if (radioMale.Checked)
            {
                _Gender = "Male";
            }
            else if (radioFemale.Checked)
            {
                _Gender = "Female";
            }
            else
            {
                _Gender = null;
            }

        }
    }
}
