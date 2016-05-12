import java.rmi.*;
import java.util.Scanner;

public class CalculatorServer {
     private static final String host = "localhost";

    public static void main(String[] args) throws Exception {
        Scanner sc = new Scanner (System.in);
        try{
            Calculator temp = new Calculator(0,0);
            String rmiObjectName = "rmi://" + host + "/Hello";
            Naming.rebind(rmiObjectName, temp);
            System.out.println("Binding complete...\n");
        }        
        catch (Exception e) {
			System.out.println("Error: " + e + "\n The Server is OFF!");
			System.exit(0);
		}
    }
}
