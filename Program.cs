using System;
using System.Collections.Generic;
using System.Linq;

namespace Program1
{
    class Program
    {

        //
        //For any of these exercises, ignore input validation unless otherwise directed.
        //Assume the user enters values in the format that the program expects.
        //

        public static void Exercise1()
        {
            /*
              When you post a message on Facebook, depending on the number of people who like your post, 
              Facebook displays different information.

              If no one likes your post, it doesn't display anything.
              If only one person likes your post, it displays: [Friend's Name] likes your post.
              If two people like your post, it displays:[Friend 1] and[Friend 2] like your post.
              If more than two people like your post, it displays:[Friend 1], [Friend 2] and[Number of Other People] others like your post.*/

            /*Write a program and continuously ask the user to enter different names, until the user presses Enter(without supplying a name). 
              Depending on the number of names provided, display a message based on the above pattern.*/

            bool isTrue = true;
            var userList = new List<string>();
            string userContine;
            
            try
            {
                while (isTrue)
                {
                    Console.WriteLine("Please enter a name in or Press enter to stop");
                    var userInput = Console.ReadLine();

                    userList.Add(userInput);
              

               
                    if (userInput == "")
                    {
                        userList.Remove("");

                        break;

                    }
                }

                foreach (var names in userList)
                {
                    Console.WriteLine("Testing: " + names);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You did not enter words. Please try again.");
                Console.WriteLine("The program will restart");
                
                Exercise1();
            }

            if (userList.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", userList[0], userList[1], userList.Count - 2);
            else if (userList.Count == 2)
                Console.WriteLine("{0} and {1} like your post", userList[0], userList[1]);
            else if (userList.Count == 1)
                Console.WriteLine("{0} likes your post.", userList[0]);
            else
                Console.WriteLine();



            while (isTrue)
            {

                Console.WriteLine("Would you like to restart the program? Yes or no?");
                userContine = Convert.ToString(Console.ReadLine());
                userContine.ToLower();

                if (userContine == "yes")
                {
                    userList.Clear();

                    Exercise1();
                }
                else if (userContine == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You did not type yes or no");
                    Console.WriteLine("Please try again \n");

                }

                Console.WriteLine("Thank you for trying this out");
            }

        }

        public static void Exercise2()
        {
            /*Write a program and ask the user to enter their name. 
             * Use an array to reverse the name and then store the result in a new string. 
             * Display the reversed name on the console.*/

            
            string userInput;
            string reversedName = "";

                       
            Console.WriteLine("Please enter in your name: ");
            userInput = Console.ReadLine();
            
            char[] myArray = new char[userInput.Length];

            for (var i = userInput.Length; i > 0; i--)
            {
                myArray[userInput.Length - 1] = userInput[i - 1];

                reversedName = reversedName + new string(myArray);
            }

            Console.WriteLine("Reversed Name: "+ reversedName);

        }

        public static void Exercise3()
        {
            /*
             * Write a program and ask the user to enter 5 numbers. If a number has been previously entered,
             * display an error message and ask the user to re-try. 
             * Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
             */

            const int MAX = 5;
            var myList = new List<int>(MAX);
            int number;


            for (var i = 0; i < MAX; i++)
            {

                //I used this to make sure the incrementor would make sure to go down by one if 
                //the use entered the sam number in the system

                Console.WriteLine("The incrementor Testing: " + i);

    
                Console.WriteLine($"USER: Please enter in digit number {i + 1}: ");
                var userInput = Console.ReadLine();

                while (!int.TryParse(userInput, out number))
                {
                    Console.WriteLine("This is not a number!");
                    Console.WriteLine("please try again!!!");
                    userInput = Console.ReadLine();
                }

                if (myList.Contains(number))
                {
                    Console.WriteLine("Error: Please use another number different from previous numbers entered");
                             
                    i--;

                }
                else
                {
                    myList.Add(number);
                }

            
            }
            
            myList.Sort();

            Console.WriteLine("Your numbers sorted in order: ");
            
            foreach (var ii in myList)
            {
                Console.Write(ii);

            }


        }

        public static void Exercise4()
        {

            /*
             Write a program and ask the user to continuously enter a number or type "Quit" to exit.
            The list of numbers may include duplicates. Display the unique numbers that the user has entered.
            */

            const string QUIT = "quit";
            var myList = new List<int>();
            var uniqueNum = new List<int>();
            bool isTrue = true;
            int number;

            while (isTrue)
            {
                Console.WriteLine("Please enter a number or type 'Quit' to exit: ");
                var userInput = Console.ReadLine();

                if (userInput.ToLower() == QUIT)
                {
                    break;
                }
                else if (!int.TryParse(userInput, out number))
                {
                    Console.WriteLine("You did not enter a number or pressed quit");
                    Console.WriteLine("The computer will restart \n");
                }
                else
                {
                    myList.Add(number);
                }


            }

            Console.WriteLine("Your digits: ");

            foreach (var i in myList)
            {
                Console.Write(i +" ");
            }


            Console.WriteLine();

            foreach (var n in myList)
            {
                if (!uniqueNum.Contains(n))
                {
                    uniqueNum.Add(n);
                }
            }


            Console.WriteLine("Unique numbers:");

            foreach (var number2 in uniqueNum)
            {
                Console.WriteLine(number2);
            }

        }
     
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();








        }
    }
}
