//Add Phidgets Library
using Phidget22;

namespace MorseEncoder
{
    class MorseCode{//Global variable for the greenLED

        static DigitalOutput greenLED;
        //Global integer for the unit of delay
        static int delay = 250;

        static void Main(string[] args){

            //Create
            greenLED = new DigitalOutput();

            //Address
            greenLED.HubPort = 4;
            greenLED.IsHubPortDevice = true;

            //Open
            greenLED.Open(1000);

            System.Console.WriteLine("Enter the word you would like to encode:");
            string userInput = System.Console.ReadLine();
            string word = userInput.ToLower();
            System.Console.WriteLine("Translating... Look at the green LED." + "\n");
            System.Threading.Thread.Sleep(2000);
            //Looks through user unput and translates it to morse code.
            for (int i = 0; i < word.Length; i++){

                if (word[i] == 'a'){
                    A();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'b'){
                    B();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'c'){
                    C();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'd'){
                    D();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'e'){
                    E();
                    System.Console.Write(" ");}
                else if (word[i] == 'f'){
                    F();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'g'){
                    G();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'h'){
                    H();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'i'){
                    I();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'j'){
                    J();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'k'){
                    K();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'l'){
                    L();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'm'){
                    M();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'n'){
                    N();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'o'){
                    O();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'p'){
                    P();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'q'){
                    Q();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'r'){
                    R();
                    System.Console.Write(" ");
                }
                else if (word[i] == 's'){
                    S();
                    System.Console.Write(" ");
                }
                else if (word[i] == 't'){
                    T();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'u'){
                    U();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'v'){
                    V();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'w'){
                    W();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'x'){
                    X();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'y'){
                    Y();
                    System.Console.Write(" ");
                }
                else if (word[i] == 'z'){
                    Z();
                    System.Console.Write(" ");
                }
                if (word[i] == ' '){//7 units of delay between words
                    System.Threading.Thread.Sleep(delay * 7);
                    System.Console.Write("/ ");
                }
                else{
                    System.Threading.Thread.Sleep(delay * 3);
                }
            }
        }

        //Use your Phidgets
        public static void dot(){ //Light instruction for a dot of Morse code
            System.Console.Write(".");
            greenLED.State = true;
            System.Threading.Thread.Sleep(delay);
            greenLED.State = false;
            System.Threading.Thread.Sleep(delay);
        }
        public static void dash(){ //Light instruction for a dash of Morse code
            System.Console.Write("-");
            greenLED.State = true;
            System.Threading.Thread.Sleep(delay * 3);
            greenLED.State = false;
            System.Threading.Thread.Sleep(delay);
        }
        //Assigns Morse Code to the letters with the delay needed.
        public static void A(){
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }

        public static void B(){
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }

        public static void C(){
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }
        public static void D(){
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }

        public static void E(){
            dot();
            System.Threading.Thread.Sleep(delay);
        }

        public static void F(){
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }

        public static void G(){
            dash();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }

        public static void H(){
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }

        public static void I(){
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }

        public static void J(){
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }

        public static void K(){
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }

        public static void L(){
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }

        public static void M(){
            dash();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }

        public static void N(){
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }

        public static void O(){
            dash();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }

        public static void P(){
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
        }

        public static void Q(){
            dash();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }

        public static void R(){
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }

        public static void S(){
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
        }

        public static void T(){
            dash();
            System.Threading.Thread.Sleep(delay);
        }

        public static void U(){
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }

        public static void V(){
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }

        public static void W(){
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }

        public static void X(){
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }

        public static void Y(){
            dash();
            System.Threading.Thread.Sleep(delay);
            dot();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
            dash();
            System.Threading.Thread.Sleep(delay);
        }

        public static void Z(){
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
