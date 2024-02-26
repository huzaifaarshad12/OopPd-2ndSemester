using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int RECORDS = 200;
            static int entry_count = -1, flight_count = 1, user_count = 0, total_count = 0;

            // BASIC/MAIN DATA STRUCTURES
            static string[] usernameA = new string[RECORDS];
            static string[] passwordsA = new string[RECORDS];
            static string[] rolesA = new string[RECORDS];
            static string username;

            // USER DATA STRUCTURES
            static string[] pName = new string[RECORDS];
            static string[] passport = new string[RECORDS];
            static string[] cnic = new string[RECORDS];
            static string[] mail = new string[RECORDS];
            static string[] gender = new string[RECORDS];
            static string[] pNum = new string[RECORDS];
            static string[] pClass = new string[RECORDS];
            static string[] pDepartCity = new string[RECORDS];
            static string[] pArrCity = new string[RECORDS];
            static string[] pTrip = new string[RECORDS];
            static string[] pDepartDate = new string[RECORDS];
            static int[] optionF = new int[RECORDS];  // Flight Option
            static int[] adult = new int[RECORDS];
            static int[] child = new int[RECORDS];
            static int[] infant = new int[RECORDS];
            static int[] total = new int[RECORDS]; // Expenditures
            static string[] seating = new string[RECORDS];

            // ADMIN DATA STRUCTURES
            static string[] aDepartDate = new string[RECORDS];
            static string[] aDepartCity = new string[RECORDS];
            static string[] aArrCity = new string[RECORDS];
            static string[] aTrip = new string[RECORDS];
            static string[] aDepartTime = new string[RECORDS];
            static int[] totalSeats = new int[RECORDS];

            //
            static string flightNumber = "SV-734";
            static string Name = "Huzaifa";
            static string comments;
            static int feedbackRating;
            static string user, pass, role;

            static string who = " ";
            // Options to select, Variable.
            static int option = 0,
               optionP = 0,
               optionA = 0;
            
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                header();
                option = loginMenu();
                if (option == 1)
                {
                    header();
                    who = signinMenu(passwordsA, pass, usernameA, username, rolesA, RECORDS);

                    // Passenger
                    if (who == "user")
                    {
                        Console.Clear();
                        optionP = 0;
                        while (optionP < 9)
                        {
                            optionP = UserMenu();
                            // REGISTRATION
                            if (optionP == 1)
                            {
                                Console.Clear();
                                Register(pName, passport, cnic, mail, gender, pNum, entry_count, RECORDS);
                                clearScreen();
                            }
                            // Enter Flight Details
                            else if (optionP == 2)
                            {
                                Console.Clear();
                                flightP(pClass, pDepartCity, pArrCity, pTrip, pDepartDate, adult, child, infant, totalSeats, entry_count, RECORDS);
                                clearScreen();
                            }
                            // Book from available Flights
                            else if (optionP == 3)
                            {
                                Console.Clear();
                                optionF[entry_count] = bookP(pDepartCity, pArrCity, pDepartDate, aDepartDate, aDepartCity, aArrCity, aDepartTime, optionF, entry_count, flight_count);
                                if (optionF[entry_count] == 1)
                                {
                                    invoice(pClass, pDepartCity, pArrCity, pTrip, pDepartDate, adult, child, infant, total, entry_count);
                                }
                                clearScreen();
                            }
                            // View booked flights
                            else if (optionP == 4)
                            {
                                Console.Clear();
                                bookedFlightsP(usernameA, username, rolesA, pDepartCity, pArrCity, pDepartDate, optionF, total, RECORDS);
                                clearScreen();
                            }
                            // Cancel booked flights
                            else if (optionP == 5)
                            {
                                Console.Clear();
                                cancelFlights(usernameA, username, rolesA, pDepartCity, pArrCity, pDepartDate, optionF, total, entry_count, RECORDS);
                                clearScreen();
                            }
                            //view flights
                            else if (optionP == 6)
                            {
                                Console.Clear();
                                viewFlightsP(aDepartDate, aDepartCity, aArrCity, aTrip, aDepartTime, flight_count);
                                clearScreen();
                            }
                            //feedback
                            else if (optionP == 7)
                            {
                            Console.Clear();
                            int ans = FlightFeedback(flightNumber, Name, feedbackRating, comments);
                            // Display feedback
                            Console.WriteLine("\nThank you for providing feedback!");
                            Console.WriteLine($"Flight: {flightNumber}\nPassenger: {Name}\n");
                            Console.WriteLine($"Your rating: {ans}");
                            Console.WriteLine("Your Feedback is added to our system..");
                            Console.WriteLine();
                            clearScreen();
                            }
                            //book to international flight
                            else if (optionP == 8)
                            {
                                Console.Clear();
                                bookInter();
                                clearScreen();
                            }
                        }
                    }

                // ADMIN
                else if (who == "admin")
                {
                    optionA = 0;
                    while (optionA < 9)
                    {
                        Console.Clear();
                        optionA = adminMenu();
                        // View Passengers Data
                        if (optionA == 1)
                        {
                            Console.Clear();
                            viewPData(pName, passport, cnic, mail, gender, pNum, seating, total, entry_count);
                            clearScreen();
                        }
                        // View Passengers travel Data
                        else if (optionA == 2)
                        {
                            Console.Clear();
                            viewPTravelData(pClass, pDepartCity, pArrCity, pTrip, pDepartDate, adult, child, infant, entry_count);
                            clearScreen();
                        }
                        // Add new flights
                        else if (optionA == 3)
                        {
                            Console.Clear();
                            addFlights(aDepartDate, aDepartCity, aArrCity, aTrip, aDepartTime, flight_count);
                            clearScreen();
                        }
                        //view flights that admin has added
                        else if (optionA == 4)
                        {
                            Console.Clear();
                            viewFlightsA(aDepartDate, aDepartCity, aArrCity, aTrip, aDepartTime, flight_count);
                            clearScreen();
                        }

                        // Allot Seats
                        else if (optionA == 5)
                        {
                            Console.Clear();
                            seats(pClass, pDepartCity, pArrCity, pTrip, pDepartDate, adult, child, infant, seating, entry_count);
                            clearScreen();
                        }
                        //view booked flights by passenger
                        else if (optionA == 6)
                        {
                            Console.Clear();
                            bookedFlightsA(usernameA, username, rolesA, pDepartCity, pArrCity, pDepartDate, optionF, total, RECORDS);
                            clearScreen();
                        }

                        // Ordered Passengers
                        else if (optionA == 7)
                        {
                            Console.Clear();
                            sorting(pName, passport, cnic, mail, gender, pNum, seating, total, entry_count);
                            clearScreen();
                        }
                        else if (optionA == 8)
                        {
                            Console.Clear();
                            Astore(aDepartCity, aArrCity, aTrip, aDepartDate, aDepartTime, pName, passport, cnic, mail, gender, pNum, pClass, pDepartCity, pArrCity, pTrip, pDepartDate, adult, child, infant);
                            clearScreen();
                        }
                    }
                }
                else if (who == "EXIT")
                {
                    Console.WriteLine("You entered wrong credentials..");
                    clearScreen();
                }
            }

            if (option == 2)
            {
                header();
                Console.WriteLine("Main Menu  >   Sign Up ");
                Console.WriteLine("---------------------");
                signup(user, pass, role, passwordsA, usernameA, rolesA, entry_count, total_count, RECORDS);
                clearScreen();
            }
            if (option == 3)
            {
                header();
                Console.WriteLine("Main Menu  >  User Details");
                Console.WriteLine("---------------------");
                credentials(pass, username, role);
                clearScreen();
            }
            if (option == 4)
            {
                return;
            }
        }
    }
    static void header()
    {
        Console.Clear();
        Console.WriteLine(@"                                                            |                                                         ");
        Console.WriteLine(@"                                                      --====|====--                                                       ");
        Console.WriteLine(@"                                                            |                                                         ");
        Console.WriteLine(@"                                                                                                                          ");
        Console.WriteLine(@"                                                        .-\""""""-.                                                         ");
        Console.WriteLine(@"                                                      .'_________'.                                                       ");
        Console.WriteLine(@"                                                     /_/_|__|__|_\_\                                                      ");
        Console.WriteLine(@"                                                    ;'-._       _.-';                                                     ");
        Console.WriteLine(@"                               ,--------------------|    `-. .-'    |--------------------,                                ");
        Console.WriteLine(@"                                ``""--..__    ___   ;       '       ;   ___    __..--""``                                 ");
        Console.WriteLine(@"                                          `""-// \\.._\             /_..// \\-""`                                           ");
        Console.WriteLine(@"                                             \\_//    '._       _.'    \\_//                                              ");
        Console.WriteLine(@"                                              `""`        ``---``        `""`                                               ");
        Console.WriteLine(@"            _         _______  _        _          _      _____                                       _    _               ");
        Console.WriteLine(@"     /\    (_)       |__   __|(_)      | |        | |     |  __ \                                    | |  (_)              ");
        Console.WriteLine(@"    /  \    _  _ __     | |    _   ___ | | __ ___ | |_    | |__) | ___  ___   ___  _ __ __   __ __ _ | |_  _   ___   _ __  ");
        Console.WriteLine(@"   / /\ \  | || '__|    | |   | | / __|| |/ // _ \| __|   |  _  / / _ \/ __| / _ \| '__|\ \ / // _` || __|| | / _ \ | '_ \ ");
        Console.WriteLine(@"  / ____ \ | || |       | |   | || (__ |   <|  __/| |_    | | \ \|  __/\__ \|  __/| |    \ V /| (_| || |_ | || (_) || | | |");
        Console.WriteLine(@" /_/    \_\|_||_|       |_|   |_| \___||_|\_\\___| \__|   |_|  \_\\___||___/ \___||_|     \_/  \__,_| \__||_| \___/ |_| |_|");
        Console.WriteLine();
        Console.WriteLine(@"---------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine(@"                                                       Huzaifa Arshad                                                         ");
        Console.WriteLine(@"---------------------------------------------------------------------------------------------------------------------------");
    } 


}

}

