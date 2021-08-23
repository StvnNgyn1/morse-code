from Phidget22.Phidget import *
from Phidget22.Devices.DigitalInput import *
from Phidget22.Devices.DigitalOutput import *
#Required for sleep statement 
import time
#Integer for unit of delay
delay = 0.25
#Create
greenLED = DigitalOutput()

#Address
greenLED.setHubPort(4)
greenLED.setIsHubPortDevice(True)

#Open
greenLED.openWaitForAttachment(1000)

#Light instruction for a dot of Morse Code
def dot():
    print(".", end = ' ')
    greenLED.setState(True)
    time.sleep(delay)
    greenLED.setState(False)
    time.sleep(delay)
#Light instruction for a dash of Morse code
def dash():
    print("-", end = ' ')
    greenLED.setState(True)
    time.sleep(delay * 3)
    greenLED.setState(False)
    time.sleep(delay)

#Assigns Morse code to letters with appropriate delay
def A():
    dot()
    time.sleep(delay)
    dash()
    time.sleep(delay)
    
def B():
    dash()
    time.sleep(delay)
    dot()
    time.sleep(delay)
    dot()
    time.sleep(delay)
    dot()
    time.sleep(delay)

def C():
    dash()
    time.sleep(delay)
    dot()
    time.sleep(delay)
    dash()
    time.sleep(delay)
    dot()
    time.sleep(delay)

def D():
    dash()
    time.sleep(delay)
    dot()
    time.sleep(delay)
    dot()
    time.sleep(delay)

def E():
    dot()
    time.sleep(delay)

def F():
    dot()
    time.sleep(delay)
    dot()
    time.sleep(delay)
    dash()
    time.sleep(delay)
    dot()
    time.sleep(delay)

def G():
    dash()
    time.sleep(delay)
    dash()
    time.sleep(delay)
    dot()
    time.sleep(delay)

def H():
    dot()
    time.sleep(delay)
    dot()
    time.sleep(delay)
    dot()
    time.sleep(delay)
    dot()
    time.sleep(delay)

def I():
    dot()
    time.sleep(delay)
    dot()
    time.sleep(delay)

def J():
    dot()
    time.sleep(delay)
    dash()
    time.sleep(delay)
    dash()
    time.sleep(delay)
    dash()
    time.sleep(delay)

def K():
    dash()
    time.sleep(delay)
    dot()
    time.sleep(delay)
    dash()
    time.sleep(delay)

def L():
    dot()
    time.sleep(delay)
    dash()
    time.sleep(delay)
    dot()
    time.sleep(delay)
    dot()
    time.sleep(delay)

def M():
    dash()
    time.sleep(delay)
    dash()
    time.sleep(delay)

def N():
    dash()
    time.sleep(delay)
    dot()
    time.sleep(delay)

def O():
    dash()
    time.sleep(delay)
    dash()
    time.sleep(delay)
    dash()
    time.sleep(delay)

def P():
    dot()
    time.sleep(delay)
    dash()
    time.sleep(delay)
    dash()
    time.sleep(delay)
    dot()

def Q():
    dash()
    time.sleep(delay)
    dash()
    time.sleep(delay)
    dot()
    time.sleep(delay)
    dash()
    time.sleep(delay)        

def R():
    dot()
    time.sleep(delay)
    dash()
    time.sleep(delay)
    dot()
    time.sleep(delay)       

def S():
    dot()
    time.sleep(delay)
    dot()
    time.sleep(delay)
    dot()
    time.sleep(delay)

def T():
    dash()
    time.sleep(delay)
            
def U():
    dot()
    time.sleep(delay)
    dot()
    time.sleep(delay)
    dash()
    time.sleep(delay)
        
def V():
    dot()
    time.sleep(delay)
    dot()
    time.sleep(delay)
    dot()
    time.sleep(delay)
    dash()
    time.sleep(delay)      

def W():
    dot()
    time.sleep(delay)
    dash()
    time.sleep(delay)
    dash()
    time.sleep(delay)

def X():
    dash()
    time.sleep(delay)
    dot()
    time.sleep(delay)
    dot()
    time.sleep(delay)
    dash()
    time.sleep(delay)
        
def Y():
    dash()
    time.sleep(delay)
    dot()
    time.sleep(delay)
    dash()
    time.sleep(delay)
    dash()
    time.sleep(delay)   

def Z():
    dash()
    time.sleep(delay)
    dash()
    time.sleep(delay)
    dot()
    time.sleep(delay)
    dot()
    time.sleep(delay)      

#Asks user for word to encode, puts into lowercase to help case sensitivity.
userInput = input("Enter the word you would like to encode: ")
word = userInput.lower()
print("Translating... Look at the green LED." + "\n")
time.sleep(2)

#Loop that goes through the word and encodes it.
for index in range(len(word)):
    if (word[index] == 'a'):
        A()
        print(" ", end = '')
        
    elif (word[index] == 'b'):
        B()
        print(" ", end = '')
        
    elif (word[index] == 'c'):
        C()
        print(" ", end = '')
        
    elif (word[index] == 'd'):
        D()
        print(" ", end = '')
        
    elif (word[index] == 'e'):
        E()
        print(" ", end = '')
    
    elif (word[index] == 'f'):
        F()
        print(" ", end = '')
    
    elif (word[index] == 'g'):
        G()
        print(" ", end = '')
    
    elif (word[index] == 'h'):
        H()
        print(" ", end = '')
    
    elif (word[index] == 'i'):
        I()
        print(" ", end = '')
    
    elif (word[index] == 'j'):
        J()
        print(" ", end = '')
    
    elif (word[index] == 'k'):
        K()
        print(" ", end = '')
    
    elif (word[index] == 'l'):
        L()
        print(" ", end = '')
    
    elif (word[index] == 'm'):
        M()
        print(" ", end = '')
    
    elif (word[index] == 'n'):
        N()
        print(" ", end = '')
    
    elif (word[index] == 'o'):
        O()
        print(" ", end = '')
    
    elif (word[index] == 'p'):
        P()
        print(" ", end = '')
    
    elif (word[index] == 'q'):
        Q()
        print(" ", end = '')
    
    elif (word[index] == 'r'):
        R()
        print(" ", end = '')
    
    elif (word[index] == 's'):
        S()
        print(" ", end = '')
    
    elif (word[index] == 't'):
        T()
        print(" ", end = '')
    
    elif (word[index] == 'u'):
        U()
        print(" ", end = '')
    
    elif (word[index] == 'v'):
        V()
        print(" ", end = '')
    
    elif (word[index] == 'w'):
        W()
        print(" ", end = '')
    
    elif (word[index] == 'x'):
        X()
        print(" ", end = '')
    
    elif (word[index] == 'y'):
        Y()
        print(" ", end = '')
    
    elif (word[index] == 'z'):
        Z()
        print(" ", end = '')
    
    if (word[index] == ' '): 
        time.sleep(delay * 7) #7 units of delay between words
        print("/ ", end = '')
    else:
        time.sleep(delay * 3) #3 units between letters
    
