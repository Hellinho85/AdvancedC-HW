using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAdv02
{
    class Program
    {
        static void Main(string[] args)
        {
            // List of total available cars in the BMW Saloon;

            List<Car> BMWCars = new List<Car>
            {

                new BMW ("F20", Type.Passenger, Manufacturer.BMW, 3, "Diesel", 13.2, 43000, true),
                new BMW ("F36", Type.Freight, Manufacturer.BMW, 5, "Petrol", 18.7, 59000, true),
                new BMW ("G30", Type.Passenger, Manufacturer.BMW, 3, "Petrol", 8, 68500, false),
                new BMW ("G31", Type.Freight, Manufacturer.BMW, 5, "Diesel", 15.4, 72000, false),
                new BMW ("X5 M", Type.Freight, Manufacturer.BMW, 5, "Petrol", 16.7, 90000, true),
                new BMW ("X6 M", Type.Passenger, Manufacturer.BMW, 3, "Diesel", 18, 15000, false),
                new BMW ("E52", Type.Passenger, Manufacturer.BMW, 5, "Petrol", 6.6, 34700, true),
                new BMW ("E90", Type.Freight, Manufacturer.BMW, 5, "Petrol", 12, 23000, false),
                new BMW ("503", Type.Passenger, Manufacturer.BMW, 5, "Diesel", 16, 72000, true),
                new BMW ("700", Type.Freight, Manufacturer.BMW, 3, "Diesel", 9.8, 41300, false)
            };

            // List of total available cars in the Audi Saloon;

            List<Car> AudiCars = new List<Car>
            {
                new Audi ("Q3", Type.Passenger, Manufacturer.Audi, 5, "Diesel", 19.2, 78500, "Blue"),
                new Audi ("Q7", Type.Freight, Manufacturer.Audi, 5, "Diesel", 7, 11000, "Yellow"),
                new Audi ("SQ5", Type.Passenger, Manufacturer.Audi, 3, "Diesel", 7.1, 12000, "Gray"),
                new Audi ("SQ7", Type.Passenger, Manufacturer.Audi, 3, "Petrol", 9.8, 33400, "Brown"),
                new Audi ("TT RS", Type.Freight, Manufacturer.Audi, 5, "Petrol", 16.9, 62300, "Green"),
                new Audi ("TT RQ", Type.Passenger, Manufacturer.Audi, 3, "Diesel", 13.2, 78500, "White"),
                new Audi ("RS4", Type.Freight, Manufacturer.Audi, 5, "Petrol", 7.3, 11000, "Purple"),
                new Audi ("RS7", Type.Passenger, Manufacturer.Audi, 3, "Diesel", 6.4, 12000, "DarkGrey"),
                new Audi ("A2", Type.Freight, Manufacturer.Audi, 3, "Petrol", 11.8, 33400, "Mint"),
                new Audi ("A8", Type.Freight, Manufacturer.Audi, 5, "Petrol", 17.7, 62300, "Black")
            };

            // List of total available cars in the Opel Saloon;

            List<Car> OpelCars = new List<Car>
            {
                new Opel ("Regal", Type.Passenger, Manufacturer.Audi, 3, "Diesel", 7.7, 32000, "Poland"),
                new Opel ("Cascada", Type.Passenger, Manufacturer.Audi, 5, "Petrol", 16, 70000, "Sweden"),
                new Opel ("Astra", Type.Freight, Manufacturer.Audi, 5, "Petrol", 18.4, 82000, "Austria"),
                new Opel ("Insignia", Type.Freight, Manufacturer.Audi, 5, "Diesel", 6.1, 19000, "Slovakia"),
                new Opel ("LaCrosse", Type.Passenger, Manufacturer.Audi, 3, "Diesel", 15, 22000, "China"),
                new Opel ("Meriva", Type.Passenger, Manufacturer.Audi, 3, "Diesel", 14.6, 66000, "Malaysia"),
                new Opel ("Vectra", Type.Freight, Manufacturer.Audi, 5, "Petrol", 20, 91000, "Singapoore"),
                new Opel ("Calibra", Type.Passenger, Manufacturer.Audi, 5, "Petrol", 22.3, 107000, "Germany"),
                new Opel ("Kadett", Type.Freight, Manufacturer.Audi, 3, "Diesel", 10, 65000, "USA"),
                new Opel ("Ascona", Type.Freight, Manufacturer.Audi, 5, "Petrol", 9.7, 44000, "Denmark")
            };


            while (true)
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Choose your prefered Car Saloon: ");
                Console.WriteLine("Press 1 for BMW, Press 2 for Audi, Press 3 for Opel: ");
                Console.WriteLine("----------------------------------------------------");
                try
                {
                    int DealerChoice = int.Parse(Console.ReadLine());

                    switch (DealerChoice)
                    {
                        //BMW Saloon switch case;

                        case 1:
                            Saloon SaloonBMW = new Saloon();
                            SaloonBMW.SaloonName = "BMW Macedonia";
                            SaloonBMW.SaloonAddress = "Boulevard Kliment Ohridski no.40 - Skopje";
                            SaloonBMW.ListOfCars = BMWCars;
                            Console.WriteLine("-------------------------------------------------------------");
                            Console.WriteLine("Hello and welcome to the amazing car Saloon of BMW!");
                            Console.WriteLine("Area you interested in any kind of particular car type today?");
                            Console.WriteLine("Press 1 for passenger cars, Press 2 for freight cars: ");
                            Console.WriteLine("-------------------------------------------------------------");
                            try
                            {
                                int UserInputBMW = int.Parse(Console.ReadLine());
                                if (UserInputBMW == 1)
                                {
                                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");
                                    foreach (var car in SaloonBMW.ListOfCars.Where(x => x.Type == Type.Passenger))
                                    {
                                        Console.WriteLine(car.GetCarInfo());
                                    }
                                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");
                                }
                                else if (UserInputBMW == 2)
                                {
                                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");
                                    foreach (var car in SaloonBMW.ListOfCars.Where(x => x.Type == Type.Freight))
                                    {
                                        Console.WriteLine(car.GetCarInfo());
                                    }
                                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");
                                }
                                else if ((UserInputBMW != 1) || (UserInputBMW != 2))
                                {
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Invalid input! Please try again!");
                                    Console.WriteLine("--------------------------------");
                                    break;

                                }

                                try
                                {
                                    GetTotalBudget(SaloonBMW);
                                    continue;

                                }
                                catch (FormatException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                };
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            };
                            break;

                        //Audi Saloon switch case;

                        case 2:
                            Saloon AudiSaloon = new Saloon();
                            AudiSaloon.SaloonName = "Audi Macedonia";
                            AudiSaloon.SaloonAddress = "Boulevard Partizanski Odredi no.102 - Skopje";
                            AudiSaloon.ListOfCars = AudiCars;

                            Console.WriteLine("-------------------------------------------------------------");
                            Console.WriteLine("Hello and welcome to the amazing car Saloon of Audi!");
                            Console.WriteLine("Area you interested in any kind of particular car type today?");
                            Console.WriteLine("Press 1 for passenger cars, Press 2 for freight cars: ");
                            Console.WriteLine("--------------------------------------------------------------");
                            try
                            {
                                int UserInputAudi = int.Parse(Console.ReadLine());
                                if (UserInputAudi == 1)
                                {
                                    foreach (var car in AudiSaloon.ListOfCars.Where(x => x.Type == Type.Passenger))
                                    {
                                        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine(car.GetCarInfo());
                                        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
                                    }
                                }
                                else if (UserInputAudi == 2)
                                {
                                    foreach (var car in AudiSaloon.ListOfCars.Where(x => x.Type == Type.Freight))
                                    {
                                        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine(car.GetCarInfo());
                                        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");
                                    }
                                }
                                else if ((UserInputAudi != 1) || (UserInputAudi != 2))
                                {
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Invalid input! Please try again!");
                                    Console.WriteLine("--------------------------------");
                                    break;
                                }

                                try
                                {
                                    GetTotalBudget(AudiSaloon);
                                    continue;

                                }
                                catch (FormatException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                };
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            };
                            break;

                        //Opel Saloon switch case;

                        case 3:
                            Saloon OpelSaloon = new Saloon();
                            OpelSaloon.ListOfCars = OpelCars;
                            OpelSaloon.SaloonName = "Opel Macedonia";                            
                            OpelSaloon.SaloonAddress = "st. Petar Deljan no.5/2-3 - Skopje";
                            Console.WriteLine("-------------------------------------------------------------");
                            Console.WriteLine("Hello and welcome to the amazing car Saloon of Audi!");
                            Console.WriteLine("Area you interested in any kind of particular car type today?");
                            Console.WriteLine("Press 1 for passenger cars, Press 2 for freight cars: ");
                            Console.WriteLine("-------------------------------------------------------------");
                            try
                            {
                                int UserInputOpel = int.Parse(Console.ReadLine());
                                if (UserInputOpel == 1)
                                {
                                    foreach (var car in OpelSaloon.ListOfCars.Where(x => x.Type == Type.Passenger))
                                    {
                                        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine(car.GetCarInfo());
                                        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
                                    }
                                }
                                else if (UserInputOpel == 2)
                                {
                                    foreach (var car in OpelSaloon.ListOfCars.Where(x => x.Type == Type.Freight))
                                    {
                                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                        Console.WriteLine(car.GetCarInfo());
                                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                    }
                                }
                                else if ((UserInputOpel != 1) || (UserInputOpel != 2))
                                {
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Invalid input! Please try again!");
                                    Console.WriteLine("--------------------------------");
                                }

                                try
                                {
                                    GetTotalBudget(OpelSaloon);
                                    continue;

                                }
                                catch (FormatException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                };
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            };
                            break;

                        default:
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("Invalid input! Please try again!");
                            Console.WriteLine("--------------------------------");
                            break;
                    }
                    continue;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void GetTotalBudget(Saloon minimax)
        {
            try
            {
                Console.WriteLine("Choose your starting budget : ");
                int userChoiceStart = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose your maximum budget: ");
                int userChoiceMaximum = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("We have these cars available in accordance with your total budget: ");
                minimax.BudgetPrice(userChoiceStart, userChoiceMaximum);
                Console.WriteLine("Thank you for your visit. Please come again and have a nice day!");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
