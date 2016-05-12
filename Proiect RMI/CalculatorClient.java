import java.rmi.*;
import java.util.Scanner;

public class CalculatorClient
{
    private static final String host = "localhost";
    static Scanner sc = new Scanner  (System.in);

    public static void main(String[] args) 
    {
        try 
        {
            ICalculator calc = (ICalculator) Naming.lookup("rmi://" 
                    + host + "/Hello");

            System.out.println("Menu: \n1. Adunare \n2. Scadere \n3. Inmultire \n4. Impartire \n5. Inversare \n6. Radical \n7. Factorial \n8. Numar^putere \n9. M+ \n10. M+ (a new number) \n11. M- \n12. M- (a new number) \n13. MC \n14. MR \n15. Rezultat \n0. Exit");
		
		System.out.println("Numar: ");
		double number = sc.nextInt();
		calc.adunare(number);
                System.out.println("Alegeti o optiune: ");
			
		int option = sc.nextInt();

		while (option!=0) {
			
			
			switch (option) {
				case 1:
				System.out.println("Numar: ");
				number = sc.nextInt();
				calc.adunare(number);
				System.out.println("Rezultat: " + calc.rezultat());
				break;
				
				case 2:
				System.out.println("Numar: ");
				number = sc.nextInt();
				calc.scadere(number);
				System.out.println("Rezultat: " + calc.rezultat());
				break;
				
				case 3:
				System.out.println("Numar: ");
				number = sc.nextInt();
				calc.inmultire(number);
				System.out.println("Rezultat: " + calc.rezultat());
				break;
				
				case 4:
				System.out.println("Numar: ");
				number = sc.nextInt();
				calc.impartire(number);
				if (calc.rezultat() == -1) 
					System.out.println("Nu se poate imparti la 0!");
				else 
					System.out.println("Rezultat: " + calc.rezultat());
				break;
				
				case 5:
				if (calc.rezultat() != 0) {
					calc.invers(calc.rezultat());
					System.out.println("Rezultat: " + calc.rezultat());
				}
				else {
					System.out.println("Nu se poate imparti la 0!");
					System.out.println("Numar: ");
					number = sc.nextInt();
				}
				break;
				
				case 6:
				if (calc.rezultat() >= 0) {
					calc.radical(calc.rezultat());
					System.out.println("Rezultat: " + calc.rezultat());
				}
				else {
					System.out.println("Nu putem calcula radical din numar <0");
				
				System.out.println("Numar: ");
				number = sc.nextInt();}
				break;
				
				case 7:
				if (calc.rezultat() >= 0) {
					calc.factorial(number);
					System.out.println("Rezultat: " + calc.rezultat());
				}
				else {
					System.out.println("Nu putem face factorial pentru numere <0");
				
				System.out.println("Numar: ");
				number = sc.nextInt();}
				break;
				
				case 8:
				System.out.print("Putere: ");
				int power = sc.nextInt();
				
				calc.putere(number, power);
				System.out.println("Rezultat: " + calc.rezultat());
				break;
				
				case 9:
				calc.adaugareMem();
				System.out.println("Memorie: " + calc.showMem());
				break;
				
				case 10:
				System.out.println("Numar: ");
				number = sc.nextInt();
				calc.adaugareMem(number);
				System.out.println("Memorie: " + calc.showMem());
				break;
				
				case 11:
				calc.stergeMem();
				System.out.println("Memorie: " + calc.showMem());
				break;
				
				case 12:
				System.out.println("Number: ");
				number = sc.nextInt();
				calc.stergeMem(number);
				System.out.println("Memorie: " + calc.showMem());
				break;
				
				case 13:
				calc.resetMem();
				System.out.println("Memorie: " + calc.showMem());
				break;
				
				case 14:
				System.out.println("Memorie: " + calc.showMem());
				break;
				
				case 15:
				System.out.println("Rezultat: " + calc.rezultat());
				break;
				
			}
			
			System.out.println("Alegeti o optiune: ");
			
			option = sc.nextInt();
		}
        } 
        catch (ConnectException conEx) 
        {
            System.out.println("Unable to connect to server!");
            System.exit(1);
        } 
        catch (Exception ex) 
        {
            ex.printStackTrace();
            System.exit(1);
        }
    }
}
