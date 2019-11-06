using System;

namespace Lab_8_final
{
    class Program
    {
        static bool res = true;
        static bool rep;
        static string[] name = { "Jacob", " Drew", "Peter" };
        static string[] food = { "Cookies", "Ice Cream", " Thai Food" };
        static string[] homeTown = { "Merrilville", "Detroit", "Michigan" };
        static int input;
        static string valid;
        static char validchar;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? ");


            while (res)  // continue as long as the user  want to continu getting another student
            {
                try
                {
                    Console.WriteLine("Enter a number 1 - 2");
                    input = int.Parse(Console.ReadLine());
                    if (input > 2)
                    {
                        Console.WriteLine("That student does not exist.Please try again");

                    }

                    else if (input <= 2)
                    {
                        Console.WriteLine($"Student {input} is {name[input]} . What would you like to know about {name[input]}?  “hometown” or “favorite food”:");
                        bool res2 = true;  // for while loop

                        while (res2 == true)  // continue if the user want to know more about the user
                        {
                            string option = Console.ReadLine();
                            if (option == "hometown" || option == "Hometown")
                            {
                                Console.WriteLine($"{name[input]} is from {homeTown[input]} Would you like to know more? (enter “yes” or “no):");
                                rep = validation2();
                                if (rep != true)
                                {
                                    break;
                                }
                                else
                                {
                                    GetFavoriteFood(food[input]);
                                }

                                res2 = false;
                            }
                            else if (option == "favorite food")
                            {
                                GetFavoriteFood(food[input]);
                                Console.WriteLine(" Would you like to know more ? (enter “yes” or “no):");
                                rep = validation2();
                                if (rep != true)
                                {
                                    if (rep == false)
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    GetHomeTown(homeTown[input]);
                                }
                                res2 = false;
                            }
                            else
                            {
                                Console.WriteLine("That data does not exist.Please try again . (enter or “hometown” or “favorite food”):");
                                res2 = true;
                            }

                        }   // end the while loop
                        validation();
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("index out of randge ex");
                }
                catch (FormatException)
                {
                    Console.WriteLine("there is some error. please try again.");

                }
            }

            // validation method to check if the user want to find another student information

            static bool validation()
            {
                Char res1;

                // Console.WriteLine("Do you want to continu ? y/n ");
                // Char res1 = char.Parse(Console.ReadLine());
                res1 = InvalidChar(validchar);
                if (res1 == 'y' || res1 == 'Y')
                {
                    return res = true;
                }
                else
                {
                    Console.WriteLine("Thanks!!");
                    return res = false;

                }
            }
        }
        // validation method to check if the user want to know mor information about the current student

        public static bool validation2()
        {
            string output;
             output = InvalidInput(valid);
            //string output = Console.ReadLine();
            if (output == "yes" || output == "Yes")
            {
                return true;
            }
            else //if (output == "No" || output == "no")
            {
                return false;
            }
        }

        // Static method that return the student FavoriteFood
        public static void GetFavoriteFood(string favorit)
        {
            Console.WriteLine($"{name[input]} FavoriteFood is {food[input]}.");
            return;
        }

        // static method to return the student HomeTown
        public static void GetHomeTown(string home)
        {
            Console.Write($"{name[input]} HomeTown is {homeTown[input]}.");
            return;
        }
        // method to validate an input char Yes or No
        public static string InvalidInput(string valid)
        {
            bool repeat = true;
            while (repeat)
            {
                string output = Console.ReadLine();
                if (output != "yes" && output != "Yes" && output != "no" && output != "No")
                {
                   Console.WriteLine("Invalid input. Enter Yes or No?");
                    //return output;
                }
                else {
                         repeat = false;
                return   valid = output;
                 
                }
               
            }
            return valid;
        }
        // method to validate an input char Y or N
        public static char InvalidChar(char validchar)
        {
            Console.WriteLine("Do you want to continu ? y/n ");
            bool repeat = true;
            while (repeat)
            {
                char outputchar = char.Parse(Console.ReadLine());
                if (outputchar != 'Y' && outputchar != 'y' && outputchar != 'N' && outputchar != 'n')
                {
                    Console.WriteLine("Invalid input. Enter Y or N?");
                }
                else
                {
                    repeat = false;
                    return validchar = outputchar;
                }

            }
            return validchar;
        }
    }
}

