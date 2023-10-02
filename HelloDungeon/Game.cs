using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        float independence = 4.8f;
        double test2 = 5.6;
        int lives = 3;
        string name;

        int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        int Multiply(int a, int b)
        {
            int result = a * b;
            return result;
        }

        int GetSmallerNumber(int a, int b)
        {
            if (a < b)
            {
                return a;
            }            
            return b;            
        }

        void FizzBuzz()
        {
            if()
            {
                Console.WriteLine("FizzBuzz");
            }
            else if()
            {
                Console.WriteLine("Fizz");
            }
            else if()
            {
                Console.WriteLine("Buzz");
            }
            else if()
            {
                Console.WriteLine(i);
            }
        }

        public void Run()
        {
            //int num = GetSmallerNumber(45, 47);
            //Console.WriteLine(num);

            //Multiply(4, 6);
            //Console.WriteLine(Multiply(4, 6));

            //int sum = Add(1, 2);
            //Console.WriteLine(sum);

            //Console.WriteLine(Add(1,2));

            int currentScene;
            float damage;
            string Word;
            bool gameOver;
            char playerChoice;
            double time;

            //Console.WriteLine("What is your name?");
            //name = Console.ReadLine();

            //Console.WriteLine(name);

            //int num1 = 2;
            //int num2 = 3;
            //Console.WriteLine("Num1 is: " + num1);
            //Console.WriteLine("Num2 is: " + num2);

            //int temp = num1;
            //num1 = num2;
            //num2 = temp;

            //Console.WriteLine("Num1 is: " + num1);
            //Console.WriteLine("Num2 is: " + num2);

            //string firstname = Console.ReadLine();
            //string lastname = Console.ReadLine();
            //name = firstname + lastname;

            //float playerHealth = 0;

            //if(playerHealth == 0)
            //{
                //Console.WriteLine("Game Over");
            //}

            //string playerInput = "";

            //Console.WriteLine("Please input the word toast");

            //playerInput = Console.ReadLine();

            //if (playerInput == "Toast")
            //{
                //Console.WriteLine("egg");
            //}

            //playerHealth = 100;
            //Console.WriteLine("An old man approaches you with a bottle of strange liquid." +
                //"He offers you a sip. Do you accept?");

            //if (playerInput == "yes")
            //{
                //Console.WriteLine("You died");
            //}
            //else if (playerInput == "no")
            //{
                //Console.WriteLine("You died twice");
            //}

            //if (playerHealth >= 90)
            //{
                //Console.WriteLine("Health Status: Great!");
            //}
            //else if (playerHealth >= 50)
            //{
                //Console.WriteLine("Health Status: Wounded!");
            //}
            //else if (playerHealth >= 10)
            //{
                //Console.WriteLine("Health Status: Danger!");
            //}
            //else if (playerHealth == 0)
            //{
                //Console.WriteLine("Health Status: You are dead. Great!");
            //}

            //Console.WriteLine("Please input the word Pancakes");

            //playerInput = Console.ReadLine();

            //if (playerInput == "Pancakes")
            //{
                //Console.WriteLine("Bacon");
            //}

            //bool playerHasRedKey = false;
            //bool playerHasGreenKey = true;

            //f(playerHasRedKey || playerHasGreenKey)
            //{
                //Console.WriteLine("The door will open.");
            //}

            //gameOver = true;
            
            //if (gameOver || playerHealth <= 0)
            //{
                //onsole.WriteLine("Game Over.");
            //}            

            //for(int i = 0; i <= 10; i += 2)
            //{                
                //Console.WriteLine(i);
            //}


            //while (playerInput != "1" && playerInput != "2")
            //{
                //Console.WriteLine("Pick your class.");

                //Console.WriteLine("1. Knight");
                //Console.WriteLine("2. Warlock");
                //Console.Write("> ");

                //playerInput = Console.ReadLine();

                //if (playerInput == "1")
                //{
                    //Console.WriteLine("You've choosen: Knight");
                //}
                //else if (playerInput == "2")
                //{
                    //Console.WriteLine("You've choosen: Warlock");
                //}
                //else
                //{
                    //Console.WriteLine("Invalid Input");
                    //Console.WriteLine("Press any key to continue");
                    //Console.ReadKey(true);
                    //Console.Clear();
                    
                //}
                
            //}
        }
    }
}
