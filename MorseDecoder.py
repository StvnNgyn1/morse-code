#Add Phidgets Library
from Phidget22.Phidget import *
from Phidget22.Devices.DigitalInput import *
from Phidget22.Devices.DigitalOutput import *

#To get current time
import time

#Global variables to hold times
startPress = 0
timePressed = 0

#Global variable for userInput
userInput = ""

#Function to retrieve the time
def currentTime():
    return int(round(time.time() * 1000))

#Decoder function that will take the user input (code) and loop it through the morse code array, looking for a match
def Decoder(code):
    morseCode = [".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..",
                "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..",
                "Unknown Code"]
    i = 0
    while (morseCode[i] != "Unknown Code"): #Once a match is found, the method will return the character corresponding to that code
        if (code == morseCode[i]):
            return (chr(97 + i)).upper() #Character a starts at 97. 
        i+=1
    return '?' # unknown code

#Event
def onRedButton_StateChange(self, state):
    global userInput #Tells function to use global variable userInput defined above
    redLED.setState(state) #Turns on red LED
    if (state): #Once red button is pushed, Decoder method is called for the users input
        print(" = ", end = '')
        print(Decoder(userInput))
        print()
        userInput = "" #Clears userInput for next code
        
#Event
def onGreenButton_StateChange(self, state):
    global startPress #Tells function to use global variables for startPress and timePressed
    global timePressed
    global userInput
    greenLED.setState(state) #Turns on green LED
    if (state):
        startPress = currentTime() #Grabs time when the button is first pressed
    if(state == False):
        timePressed = ((currentTime() - startPress)) #Grabs time when button is released, startPress subtracted.
    if ((timePressed < 600) and (timePressed > 100)):
        print(".", end = '') #Prints dot to screen
        userInput+= "."
    elif (timePressed > 600):
        print("-", end = '') #Prints dash to screen
        userInput+= "-"
        
#Create
redButton = DigitalInput()
redLED = DigitalOutput()
greenButton = DigitalInput()
greenLED = DigitalOutput()

#Address
redButton.setHubPort(0)
redButton.setIsHubPortDevice(True)
redLED.setHubPort(1)
redLED.setIsHubPortDevice(True)
greenButton.setHubPort(5)
greenButton.setIsHubPortDevice(True)
greenLED.setHubPort(4)
greenLED.setIsHubPortDevice(True)

#Open 
redButton.openWaitForAttachment(1000)
redLED.openWaitForAttachment(1000)
greenButton.openWaitForAttachment(1000)
greenLED.openWaitForAttachment(1000)
    
#Subscribe to Events 
redButton.setOnStateChangeHandler(onRedButton_StateChange)
greenButton.setOnStateChangeHandler(onGreenButton_StateChange)

print("Start entering into the decoder." + "\n" + "Press the green button for a dot, hold for a dash." + "\n" + "Press the red button after you enter a letter.")
while(True): #According to how long user holds button down for, add a dot or dash to userInput. Also print to screen.
    timePressed = 0