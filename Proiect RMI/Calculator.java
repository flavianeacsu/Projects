import java.rmi.*;
import java.rmi.server.*;


public class Calculator extends UnicastRemoteObject implements ICalculator{
    double result, memory;
    private int value, currentNumber;
		
		public Calculator (int currentValue, int number) throws RemoteException {
			result = 0;
			memory = 0;
			value = currentValue;
			currentNumber = number;
		}
		
                @Override
		public void adunare (double number) throws RemoteException {
			result = result + number;
		}
		
		public void scadere (double number) throws RemoteException {
			result = result - number;
		}
		
		public void inmultire (double number) throws RemoteException {
			result = result * number;
		}
		
		public void impartire (double number) throws RemoteException {
			if (number != 0)
				result = result / number;
			else
				result = -1;
		}
		
		public double rezultat () throws RemoteException {
			return result;
		}
		
		public double showMem () throws RemoteException {
			return memory;
		}
		
		public void invers (double number) throws RemoteException {
			result = 1 / number;
		}
		
		public void radical(double number) throws RemoteException {
			result = Math.sqrt(number);
		}
		
		public void factorial (double number) throws RemoteException {
			int tempValue = 1;
			if (number == 0) {
				result = 1;
			}
			else {
				for (int i = 1; i <= number; i++) 
					tempValue = tempValue * i;
				result = tempValue;
			}
		}
		
		public void putere (double number, double power) throws RemoteException {
			result = Math.pow(number, power);
		}
		
		public void adaugareMem () throws RemoteException {
			memory = memory + result;
			result = memory;
		}
		
		public void adaugareMem (double number) throws RemoteException {
			memory = memory + number;
			result = memory;
		}
		
		public void stergeMem () throws RemoteException {
			memory = memory - result;
			result = memory;
		}
		
		public void stergeMem (double number) throws RemoteException {
			memory = memory - number;
			result = memory;
		}
		
		public void resetMem () throws RemoteException {
			memory = 0;
		}
		
    
}
