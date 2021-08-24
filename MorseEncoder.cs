using System;
using Phidget22;
namespace MorseEncoder
{
    class MorseCode
    {	//Global variable for the greenLED
        static DigitalOutput greenLED;
        //Global integer for the unit of delay
        static int delay = 250;

        static void Main(string[] args)
        {
            //Create
            greenLED = new DigitalOutput();

            //Address
            greenLED.HubPort = 4;
            greenLED.IsHubPortDevice = true;

            //Open
            greenLED.Open(1000);

            Console.WriteLine("Enter the word you would like to encode:");
            string userInput = Console.ReadLine();
            string word = userInput.ToLower();
            Console.WriteLine("Translating... Look at the green LED." + "\n");
            System.Threading.Thread.Sleep(2000);
            //Looks through user unput and translates it to morse code.
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    A();
                    Console.Write(" ");
                }
                else if (word[i] == 'b')
                {
                    B();
                    Console.Write(" ");
                }
                else if (word[i] == 'c')
                {
                    C();
                    Console.Write(" ");
                }
                else if (word[i] == 'd')
                {
                    D();
                    Console.Write(" ");
                }
                else if (word[i] == 'e')
                {
                    E();
                    Console.Write(" ");
                }
                else if (word[i] == 'f')
                {
                    F();
                    Console.Write(" ");
                }
                else if (word[i] == 'g')
                {
                    G();
                    Console.Write(" ");
                }
                else if (word[i] == 'h')
                {
                    H();
                    Console.Write(" ");
                }
                else if (word[i] == 'i')
                {
                    I();
                    Console.Write(" ");
                }
                else if (word[i] == 'j')
                {
                    J();
                    Console.Write(" ");
                }
                else if (word[i] == 'k')
                {
                    K();
                    Console.Write(" ");
                }
                else if (word[i] == 'l')
                {
                    L();
                    Console.Write(" ");
                }
                else if (word[i] == 'm')
                {
                    M();
                    Console.Write(" ");
                }
                else if (word[i] == 'n')
                {
                    N();
                    Console.Write(" ");
                }
                else if (word[i] == 'o')
                {
                    O();
                    Console.Write(" ");
                }
                else if (word[i] == 'p')
                {
                    P();
                    Console.Write(" ");
                }
                else if (word[i] == 'q')
                {
                    Q();
                    Console.Write(" ");
                }
                else if (word[i] == 'r')
                {
                    R();
                    Console.Write(" ");
                }
                else if (word[i] == 's')
                {
                    S();
                    Console.Write(" ");
                }
                else if (word[i] == 't')
                {
                    T();
                    Console.Write(" ");
                }
                else if (word[i] == 'u')
                {
                    U();
                    Console.Write(" ");
                }
                else if (word[i] == 'v')
                {
                    V();
                    Console.Write(" ");
                }
                else if (word[i] == 'w')
                {
                    W();
                    Console.Write(" ");
                }
                else if (word[i] == 'x')
                {
                    X();
                    Console.Write(" ");
                }
                else if (word[i] == 'y')
                {
                    Y();
                    Console.Write(" ");
                }
                else if (word[i] == 'z')
                {
                    Z();
                    Console.Write(" ");
                }
                if (word[i] == ' ')//7 units of delay between words
                {
                    System.Threading.Thread.Sleep(delay * 7);
                    Console.Write("/ ");
                }
                else
                {
                    System.Threading.Thread.Sleep(delay * 3);
                }
            }
        }

        public static void dot() //Light instruction for a dot of Morse code
        {
            Console.Write(".");
            greenLED.State = true;
            System.Threading.Thread.Sleep(delay);
            greenLED.State = false;
            System.Threading.Thread.Sleep(delay);
        }
        public static void dash() //Light instruction for a dash of Morse code
        {
            Console.Write("-");
            greenLED.State = true;
            System.Threading.Thread.Sleep(delay * 3);
            greenLED.State = false;
            System.Threading.Thread.Sleep(delay);
        }
        //Assigns Morse Code to the letters with the delay needed.
        public static void A()
        {
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }

        public static void B()
        {
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }

        public static void C()
        {
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }
        public static void D()
        {
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }

        public static void E()
        {
            dot();
            System.Threading.Thread.Sleep(delay);
        }

        public static void F()
        {
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }

        public static void G()
        {
            dash();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }

        public static void H()
        {
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }

        public static void I()
        {
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }

        public static void J()
        {
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }

        public static void K()
        {
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }

        public static void L()
        {
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }

        public static void M()
        {
            dash();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }

        public static void N()
        {
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }

        public static void O()
        {
            dash();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }

        public static void P()
        {
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
        }

        public static void Q()
        {
            dash();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }

        public static void R()
        {
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }

        public static void S()
        {
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }


        public static void T()
        {
            dash();
            System.Threading.Thread.Sleep(delay);
        }


        public static void U()
        {
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }


        public static void V()
        {
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }


        public static void W()
        {
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }


        public static void X()
        {
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }


        public static void Y()
        {
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }

        public static void Z()
        {
            dash();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }
    }
}
