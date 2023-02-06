using System;
using System.IO;
using System.Linq;

namespace ParkingApp
{
    public class UserInterfaceService
    {
        private const string UsersFilePath = "/home/slobodan/Documents/private/development/ParkingApp/users.txt";
        private const string ReservationsFilePath = "/home/slobodan/Documents/private/development/ParkingApp/reservations.txt";
        private const string GarageFilePath = "/home/slobodan/Documents/private/development/ParkingApp/garages.txt";

        public void OpenStartMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("*********************************************************************************   PARKING APP   ********************************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("CHOOSE A NUMBER FROM MENU");
            Console.WriteLine();
            Console.Write("*1* CREATE NEW USER *1*     ");
            Console.Write("*2* CREATE NEW RESERVATION *2*     ");
            Console.Write("*3* UPDATE DATA *3*     ");
            Console.Write("*4* DELETE DATA *4*     ");
            Console.Write("*5* SHOW USERS' DATA *5*     ");
            Console.Write("*6* SHOW MONTHLY FINANCE REPORT *6*     ");
            Console.WriteLine("");
            Console.ResetColor();

            var readLineResult = Console.ReadLine();  
            int.TryParse(readLineResult, out var option);
            
            if (option > 0 && option <= 6)
            {
                switch (option)
                {
                    case 1:
                        var usersStreamWriter = File.AppendText(UsersFilePath);
                        var userService = new UserService();
                        var newUser = userService.CreateUser(usersStreamWriter);
                        userService.PrintCreatedUser(newUser);
                        break;
                    case 2:
                        var userString = File.ReadLines(UsersFilePath).Last().Split(',');
                        var lastUser = new User
                        {
                            Id = int.Parse(userString[0]),
                            FirstName = userString[1],
                            LastName = userString[2]
                        };

                        var garageId = int.Parse(File.ReadLines(GarageFilePath).Last().Split(',')[0]);
                        var reservationsStreamWriter = File.AppendText(ReservationsFilePath);
                        var reservationService = new ReservationService();
                        var newReservation = reservationService.CreateReservation(reservationsStreamWriter, lastUser.Id, garageId);
                        reservationService.PrintCreatedReservation(newReservation, lastUser);
                        break;
                }
                
                OpenExitMenu();
            }
            else
            {
                Console.WriteLine("YOU NEED TO ENTER VALID NUMBER THAT IS BETWEEN 1 AND 6.");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                
                OpenExitMenu();
            }
        }

        public void OpenExitMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("*1* GO BACK TO MAIN MENU *1*     ");
            Console.Write("*2* EXIT APPLICATION *2*     ");
            var readLineResult = Console.ReadLine();  
            int.TryParse(readLineResult, out var nextStep);
            if (nextStep > 0 && nextStep <= 2)
            {
                if (nextStep == 1)
                {
                    Console.Clear();
                    OpenStartMenu();
                } else
                {
                    Environment.Exit(1);
                }
            }
            else
            {
                Console.WriteLine("YOU NEED TO ENTER VALID NUMBER THAT IS BETWEEN 1 AND 6.");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                
                OpenExitMenu();
            }
           
        }
    }
}