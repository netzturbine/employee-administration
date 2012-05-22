using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace employeeAdministration
{
    class tools
    {

        //////////////////////////////////////////////////////////////////////////////////
        // data checking method expects value + regular expression to check against
        // called by valuecheck method
        // returns boolean if expression matches
        //////////////////////////////////////////////////////////////////////////////////
        private bool checkString(string value, string strRegex)
        {
            return Regex.IsMatch(value, strRegex);
        }
        //////////////////////////////////////////////////////////////////////////////////
        // value checking method
        // calls check string method
        //////////////////////////////////////////////////////////////////////////////////
        public bool checkValue(string valueKind, string value)
        {
            bool valid = false;
            switch (valueKind)
            {
                case "username":
                    MessageBox.Show("checking username", "regex check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    valid = this.checkString(value, "([a-zA-Z0-9]{4,10}$)");
                    break;
                case "passwd":
                    MessageBox.Show("checking passwd", "regex check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    valid = checkString(value, "(^(?=.{8,})(?=.*[a-z])(?=.*[A-Z])(?!.*s).*$)");
                    break;
                case "surname":
                    MessageBox.Show("checking surname", "regex check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    valid = checkString(value, "(^[A-Za-z]*$)");
                    break;
                case "name":
                    MessageBox.Show("checking name", "regex check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    valid = checkString(value, "(^[A-Za-z,.-]*$)");
                    break;
                case "email":
                    MessageBox.Show("checking email", "regex check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    valid = checkString(value, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                    + "@"
                    + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
                    break;
                default:
                    MessageBox.Show("checking Telephone", "regex check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    valid = checkString(value, "(^[0-9]{6,15}$)");
                    break;
            }
            return valid;
        } 
    }
}
