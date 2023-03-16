using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeExtended
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Example 2
                var user = new User
                {
                    Name = "John Smith",
                    Password = "password123",
                    Role = UserRolesEnum.Student
                };
                var viewModel = new UserViewModel(user);
                var view = new UserView(viewModel);

                view.Display();

                //Throw error here
                view.DisplayError();
            }
            catch (Exception e)
            {
                var log = new ActionOnError(log);
                log(e.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case!");
            }

        }
    }
}