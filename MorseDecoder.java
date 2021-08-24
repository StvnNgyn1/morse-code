import com.phidget22.*;
public class MorseDecoder 
{
	//Global variables to turn on/off LEDS
	static boolean turnRedLEDOn = false;
	static boolean turnGreenLEDOn = false;
	
	//Global variables to hold times
	static long startPress;
	static double timePressed;
	//Global variable for the userInput
	static String userInput = "";
	
	//Handle Exceptions
	public static void main(String[] args) throws Exception
	{
		//Create
		DigitalInput redButton = new DigitalInput();
		DigitalOutput redLED = new DigitalOutput();
		DigitalInput greenButton = new DigitalInput();
		DigitalOutput greenLED = new DigitalOutput();
		
		//Address
		redLED.setHubPort(1);
		redLED.setIsHubPortDevice(true);
		redButton.setHubPort(0);
        redButton.setIsHubPortDevice(true);
        greenButton.setHubPort(5);
        greenButton.setIsHubPortDevice(true);
        greenLED.setHubPort(4);
        greenLED.setIsHubPortDevice(true);
        
        //Event 
        redButton.addStateChangeListener(new DigitalInputStateChangeListener() 
        {
            public void onStateChange(DigitalInputStateChangeEvent e) 
            {
            	turnRedLEDOn= e.getState();
            	if(e.getState()) 
            	{
            		System.out.print(" = ");
            		System.out.print(Decoder(userInput));
            		System.out.println();
            		userInput = "";
            	}
            }
        });

        //Event 
        greenButton.addStateChangeListener(new DigitalInputStateChangeListener() 
        {
            public void onStateChange(DigitalInputStateChangeEvent e) 
            {
            	turnGreenLEDOn = e.getState(); 
            	if(e.getState())
            	{
            		startPress = System.currentTimeMillis();
            	}
            	if(e.getState() == false)
            	{
            		timePressed = ((double)(System.currentTimeMillis() - startPress) / 1000);
            	}
            }
        });
		
        //Open
        redLED.open(1000);
        greenLED.open(1000);
        redButton.open(1000);
        greenButton.open(1000);
        
        System.out.println("Start entering into the decoder." + "\n" + "Press the green button for a dot, hold for a dash." + "\n" + "Press the red button after you enter a letter.");
        while(true)//According to how long the user holds the button down for, it will add a dot or a dash to the userInput string. Also controls LEDS
        {
        	timePressed = 0;
        	redLED.setState(turnRedLEDOn);
        	greenLED.setState(turnGreenLEDOn);
    		if(timePressed < 0.6 && timePressed > 0.1)
    		{
    			userInput+= ".";
    			System.out.print(".");
    		}
    		else if (timePressed > 0.6)
    		{
    			userInput+= "-";
    			System.out.print("-");
    		}
        }
	}
	//Decoder method that will take the user input (code) and loop it through the morseCode array, looking for a match.
	public static char Decoder(String code)
	{
		String[] morseCode = {".-","-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "Unknown Code"};
		int i = 0;
		while (morseCode[i].equals("Unknown Code") == false)
		{
			if (code.equals(morseCode[i])) //Once a match is found, the method will return the character corresponding to that code.
			{
				return Character.toUpperCase((char)(97 + i)); //Character 'a' starts at 97 in java. 
			}
			i++;
		}
		return '?';//unknown character
	}
		
}
