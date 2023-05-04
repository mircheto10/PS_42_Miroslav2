﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        public int Id;
        private string _names;
        private string _password;
        private UserRolesEnum _role;
        private string _facultyNumber;
        private string _email;

        public string Names
        {
            get { return _names; }
            set { _names = value; }
        }
       
            public string Password
        {
            get { return _password; }
            set { _password = Mask(value); }
        }

                  public UserRolesEnum Role
        {
                     get { return _role; }
                       set { _role = value; }
        }

                     public string FacultyNumber
        {
                              get { return _facultyNumber; }
                              set { _facultyNumber = value; }
        }

                              public string Email
        {
                                    get { return _email; }
                                     set { _email = value; }
        }

        private string Mask(string toBeMaskedString)
        {
            StringBuilder masked = new StringBuilder();
            foreach (char it in toBeMaskedString)
            {
                masked.Append((char)(it + 5));
            }


            return masked.ToString();
        }

        private string Unmask(string maskedString)
        {
            StringBuilder unmasked = new StringBuilder();

            foreach (char it in maskedString)
            {
                var result = it - 5;
                unmasked.Append((char)result);
            }


            return unmasked.ToString();
        }
    }
}
