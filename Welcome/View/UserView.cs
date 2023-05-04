using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.ViewModel;

namespace Welcome.View
{
    public class UserView
    {
        private UserViewModel _viewModel;
        private ViewModel.UserViewModel viewModel;

        public UserView(UserViewModel viewModel)
              {
            _viewModel = viewModel;
               }

        public UserView(ViewModel.UserViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public void Display()
        {
            System.Console.WriteLine("Welcome");
            System.Console.WriteLine("User: " + _viewModel.Name);
            System.Console.WriteLine("Role: " + _viewModel.Role);
            System.Console.WriteLine("Pass: " + _viewModel.Password);
        }

        public void DisplayError()
        {
            throw new Exception("Forced Exception!");
        }
    }
}