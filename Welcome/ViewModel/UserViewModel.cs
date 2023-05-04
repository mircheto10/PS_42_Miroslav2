﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.Others;

namespace Welcome.ViewModel
{
    public class UserViewModel
    {
        private User _user;
        private Model.User user;

        public UserViewModel(User user)
        {
            _user = user;
        }

        public UserViewModel(Model.User user)
        {
            this.user = user;
        }

        public string Name
        {
            get { return _user.Names; }
            set { _user.Names = value; }
        }

        public string Password
        {
            get { return _user.Password; }
            set { _user.Password = value; }
        }

        public UserRolesEnum Role
        {
            get { return _user.Role; }
            set { _user.Role = value; }
        }

        public string FacultyNumber
        {
            get { return _user.FacultyNumber; }
            set { _user.Email = value; }
        }

        public string Email
        {
            get { return _user.Email; }
            set { _user.Email = value; }
        }
    }
}