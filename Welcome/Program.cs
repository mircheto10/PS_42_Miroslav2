using System;
using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;
using Welcome.Others;

namespace Welcome
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            User user = new User("Miroslav", "Georgiev", "admin121220028");

            UserViewModel userViewModel = new UserViewModel(user);

            UserView userView = new UserView(userViewModel);

            userView.Display();

            Console.ReadKey();
        }
    }

        class User
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Password { get; set; }
        public string Names { get; internal set; }
        public UserRolesEnum Role { get; internal set; }
        public string FacultyNumber { get; internal set; }
        public string Email { get; internal set; }

        public User(string firstName, string lastName, string password)
            {
                FirstName = firstName;
                LastName = lastName;
                Password = password;
            }
        }
    

    class UserViewModel
    {
        public string FullName { get; set; }

        public UserViewModel(User user)
        {
            FullName = $"{user.FirstName} {user.LastName}";
        }
    }

    class UserView
    {
        private UserViewModel userViewModel;

        public UserView(UserViewModel userViewModel)
        {
            this.userViewModel = userViewModel;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {userViewModel.FullName}");
        }
    }



}
