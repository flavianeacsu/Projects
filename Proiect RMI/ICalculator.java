import java.rmi.*;

public interface ICalculator extends Remote{
    public void adunare (double number) throws RemoteException;
    public void scadere (double number) throws RemoteException;
    public void inmultire (double number) throws RemoteException;
    public void impartire (double number) throws RemoteException;

    public void invers (double number) throws RemoteException;
    public void radical(double number) throws RemoteException;
    public void factorial (double number) throws RemoteException;
    public void putere (double number, double power) throws RemoteException;
    
    public double rezultat () throws RemoteException;

    public void adaugareMem () throws RemoteException;
    public void adaugareMem (double number) throws RemoteException;
    public void stergeMem () throws RemoteException;
    public void stergeMem (double number) throws RemoteException;
    public void resetMem () throws RemoteException;
    public double showMem () throws RemoteException;
}
