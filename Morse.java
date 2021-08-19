import com.phidget22.*;//Add Phidgets Library.
public class Morse 
{	
    //Turn on/off LEDs with Global Variables
    static boolean turnRedLEDOn = false;
    static boolean turnGreenLEDOn = false;
	//Handle Exceptions
	public static void main(String[] args) throws Exception
	{
		
		//Create
		DigitalInput redButton = new DigitalInput();
		DigitalOutput redLED = new DigitalOutput();
		DigitalInput greenButton = new DigitalInput();
		DigitalOutput greenLED = new DigitalOutput();
		
		//Address
		redButton.setHubPort(0);
		redButton.setIsHubPortDevice(true);
		redLED.setHubPort(1);
		redLED.setIsHubPortDevice(true);
		greenButton.setHubPort(5);
		greenButton.setIsHubPortDevice(true);
		greenLED.setHubPort(4);
		greenLED.setIsHubPortDevice(true);
				
		//Event for red button
		redButton.addStateChangeListener(new DigitalInputStateChangeListener()
		{
			public void onStateChange(DigitalInputStateChangeEvent e)
			{
				turnRedLEDOn = e.getState();
			}
		});
		//Event for green button
		greenButton.addStateChangeListener(new DigitalInputStateChangeListener()
		{
			public void onStateChange(DigitalInputStateChangeEvent e)
			{
				turnGreenLEDOn = e.getState();
			}			
		});
		
		//Open 
		redButton.open(1000);
		redLED.open(1000);
		greenButton.open(1000);
		greenLED.open(1000);
		
		while(true)
		{
			redLED.setState(turnRedLEDOn);
			greenLED.setState(turnGreenLEDOn);
			
		}
	}
}