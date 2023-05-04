﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    public static class UserHelper
    {
        private static UserData _userData;

        public static string ToString(this User user)
        {
            return user.ToString();
        }

        public static void ValidateCredentials(this User user)
        {
            Console.WriteLine("The {field} cannot be empty");
            _userData.ValidateUser(user.Names, user.Password);
        }

        public static User GetUser(this User user)
        {
            return user.GetUser();
        }
    }
}
