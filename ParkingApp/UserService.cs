using System;
using System.IO;
using System.Linq;

namespace ParkingApp
{
    public class UserService
    {
        public User CreateUser(StreamWriter streamWriter)
        {
            string filePath = ((FileStream)(streamWriter.BaseStream)).Name;
            var lineCount = File.ReadLines(filePath).Count() + 1;
            var user = new User
            {
                Id = lineCount
            };
            
            Console.WriteLine("Enter First Name: ");
            user.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            user.LastName = Console.ReadLine();
            Console.WriteLine("Enter Email: ");
            user.Email = Console.ReadLine();
                    
            streamWriter.WriteLine(user.Id + "," + user.FirstName + "," +  user.LastName + "," + user.Email);
            streamWriter.Close();

            return user;
        }
        
        public void PrintCreatedUser(User user)
        {
            Console.Clear();
            Console.WriteLine("NEW USER CREATED");
            Console.WriteLine("FIRST NAME: " + user.FirstName);
            Console.WriteLine("LAST NAME: " + user.LastName);
            Console.WriteLine("E-MAIL: " + user.Email);
        }
    }
}