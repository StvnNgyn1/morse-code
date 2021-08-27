//Add Phidgets Library
using Phidget22;
using System.Diagnostics;

namespace MorseDecoder
{
    class Program
    {
        //Global variables to turn on/off LEDS
        static bool turnRedLEDOn = false;
        static bool turnGreenLEDOn = false;

        //Global variables to hold times and the stopwatch
        static double timePressed;
        static Stopwatch stopwatch = new Stopwatch();

        //Global variable for the userInput
        static string userInput = "";
        //Decoder method that will take the user input (code) and loop it through the morseCode array, looking for a match.
        static char Decoder(string code)
        {
            System.String[] morseCode = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "Unknown Code" };
            int i = 0;
            while (morseCode[i].Equals("Unknown Code") == false)
            {
                if (code.Equals(morseCode[i]))
                { //Once a match is found, the method will return the character corresponding to that code. 
                    return System.Char.ToUpper((char)(97 + i)); //Character 'a' starts at 97.
                }
                i++;
            }
            return '?'; //unknown code
        }
        //Event
        private static void redButton_StateChange(object sender, Phidget22.Events.DigitalInputStateChangeEventArgs e)
        {
            turnRedLEDOn = e.State; //Turns on red LED
            if (e.State)
            { //Once red button is pushed, Decoder methid is called for the users input.
                System.Console.Write(" = ");
                System.Console.Write(Decoder(userInput));
                System.Console.WriteLine();
                userInput = ""; //Clears userInput for next code
            }
        }
        //Event
        private static void greenButton_StateChange(object sender, Phidget22.Events.DigitalInputStateChangeEventArgs e)
        {
            turnGreenLEDOn = e.State; //Turns on green LED
            if (e.State)
            {
                stopwatch.Start(); //Grab time when the button is first pressed
            }
            if (e.State == false)
            {
                timePressed = (stopwatch.ElapsedMilliseconds); //Grabs time when the button is released, and suctracts start time.
                stopwatch.Reset();
            }
            if (timePressed < 600 && timePressed > 100)
            {
                userInput += ".";
                System.Console.Write("."); //Prints a dot to the screen
            }
            else if ((timePressed > 600) && (timePressed < 5000))
            {
                userInput += "-";
                System.Console.Write("-"); //Prints a dash to the screen     
            }
        }
        static void Main(string[] args)
        {
            //Create stopwatch
            stopwatch = new Stopwatch();

            //Create
            DigitalInput redButton = new DigitalInput();
            DigitalOutput redLED = new DigitalOutput();
            DigitalInput greenButton = new DigitalInput();
            DigitalOutput greenLED = new DigitalOutput();

            //Address
            redLED.HubPort = 1;
            redLED.IsHubPortDevice = true;
            redButton.HubPort = 0;
            redButton.IsHubPortDevice = true;
            greenButton.HubPort = 5;
            greenButton.IsHubPortDevice = true;
            greenLED.HubPort = 4;
            greenLED.IsHubPortDevice = true;

            //Subscribe to events
            redButton.StateChange += redButton_StateChange;
            greenButton.StateChange += greenButton_StateChange;

            //Open | Connect your program to your physical devices.
            redButton.Open(1000);
            redLED.Open(1000);
            greenButton.Open(1000);
            greenLED.Open(1000);

            System.Console.WriteLine("Start entering into the decoder." + "\n" + "Press the green button for a dot, hold for a dash." + "\n" + "Press the red button after you enter a letter.");
            while (true)
            { //According to how long the user holds the button down for, it will add a dot or a dash to the userInput string. Also controls LEDS
                timePressed = 0;
                redLED.State = turnRedLEDOn;
                greenLED.State = turnGreenLEDOn;
            }
        }

    }
}
