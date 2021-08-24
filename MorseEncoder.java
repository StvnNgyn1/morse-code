import com.phidget22.*;
import java.util.Scanner;

public class MorseEncoder {
	// Global variable for greenLED
	static DigitalOutput greenLED;
	// Global integer for unit of delay.
	static int delay = 250;

	// Handle Exceptions
	public static void main(String[] args) throws Exception {
		Scanner scan = new Scanner(System.in);
		// Create
		greenLED = new DigitalOutput();

		// Address
		greenLED.setHubPort(4);
		greenLED.setIsHubPortDevice(true);

		// Open
		greenLED.open(1000);

		// Use your Phidgets
		System.out.println("Enter the word you would like to encode:");
		String userInput = scan.nextLine();
		String word = userInput.toLowerCase();
		System.out.print("Translating... Look at the green LED." + "\n");
		Thread.sleep(2000);
		for (int i = 0; i < word.length(); i++) {
			if (word.charAt(i) == 'a') {
				A();
				System.out.print(" ");
			} else if (word.charAt(i) == 'b') {
				B();
				System.out.print(" ");
			} else if (word.charAt(i) == 'c') {
				C();
				System.out.print(" ");
			} else if (word.charAt(i) == 'd') {
				D();
				System.out.print(" ");
			} else if (word.charAt(i) == 'e') {
				E();
				System.out.print(" ");
			} else if (word.charAt(i) == 'f') {
				F();
				System.out.print(" ");
			} else if (word.charAt(i) == 'g') {
				G();
				System.out.print(" ");
			} else if (word.charAt(i) == 'h') {
				H();
				System.out.print(" ");
			} else if (word.charAt(i) == 'i') {
				I();
				System.out.print(" ");
			} else if (word.charAt(i) == 'j') {
				J();
				System.out.print(" ");
			} else if (word.charAt(i) == 'k') {
				K();
				System.out.print(" ");
			} else if (word.charAt(i) == 'l') {
				L();
				System.out.print(" ");
			} else if (word.charAt(i) == 'm') {
				M();
				System.out.print(" ");
			} else if (word.charAt(i) == 'n') {
				N();
				System.out.print(" ");
			} else if (word.charAt(i) == 'o') {
				O();
				System.out.print(" ");
			} else if (word.charAt(i) == 'p') {
				P();
				System.out.print(" ");
			} else if (word.charAt(i) == 'q') {
				Q();
				System.out.print(" ");
			} else if (word.charAt(i) == 'r') {
				R();
				System.out.print(" ");
			} else if (word.charAt(i) == 's') {
				S();
				System.out.print(" ");
			} else if (word.charAt(i) == 't') {
				T();
				System.out.print(" ");
			} else if (word.charAt(i) == 'u') {
				U();
				System.out.print(" ");
			} else if (word.charAt(i) == 'v') {
				V();
				System.out.print(" ");
			} else if (word.charAt(i) == 'w') {
				W();
				System.out.print(" ");
			} else if (word.charAt(i) == 'x') {
				X();
				System.out.print(" ");
			} else if (word.charAt(i) == 'y') {
				Y();
				System.out.print(" ");
			} else if (word.charAt(i) == 'z') {
				Z();
				System.out.print(" ");
			}
			if (word.charAt(i) == ' ')// 7 units of delay between words
			{
				Thread.sleep(delay * 7);
				System.out.print("/ ");
			} else {
				Thread.sleep(delay * 3);// 3 units between letters
			}
		}

	}

	// Light instruction for a dot of Morse code
	public static void dot() throws Exception {
		System.out.print(".");
		greenLED.setState(true);
		Thread.sleep(delay);
		greenLED.setState(false);
		Thread.sleep(delay);
	}

	// Light instruction for a dash of Morse code
	public static void dash() throws Exception {
		System.out.print("-");
		greenLED.setState(true);
		Thread.sleep(delay * 3);
		greenLED.setState(false);
		Thread.sleep(delay);
	}

	// Assigns Morse code to letters with appropriate delay
	public static void A() throws Exception {
		dot();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
	}

	public static void B() throws Exception {
		dash();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
	}

	public static void C() throws Exception {
		dash();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
	}

	public static void D() throws Exception {
		dash();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
	}

	public static void E() throws Exception {
		dot();
		Thread.sleep(delay);
	}

	public static void F() throws Exception {
		dot();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
	}

	public static void G() throws Exception {
		dash();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
	}

	public static void H() throws Exception {
		dot();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
	}

	public static void I() throws Exception {
		dot();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
	}

	public static void J() throws Exception {
		dot();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
	}

	public static void K() throws Exception {
		dash();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
	}

	public static void L() throws Exception {
		dot();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
	}

	public static void M() throws Exception {
		dash();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
	}

	public static void N() throws Exception {
		dash();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
	}

	public static void O() throws Exception {
		dash();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
	}

	public static void P() throws Exception {
		dot();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
		dot();
	}

	public static void Q() throws Exception {
		dash();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
	}

	public static void R() throws Exception {
		dot();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
	}

	public static void S() throws Exception {
		dot();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
	}

	public static void T() throws Exception {
		dash();
		Thread.sleep(delay);
	}

	public static void U() throws Exception {
		dot();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
	}

	public static void V() throws Exception {
		dot();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
	}

	public static void W() throws Exception {
		dot();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
	}

	public static void X() throws Exception {
		dash();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
	}

	public static void Y() throws Exception {
		dash();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
	}

	public static void Z() throws Exception {
		dash();
		Thread.sleep(delay);
		dash();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
		dot();
		Thread.sleep(delay);
	}
}
