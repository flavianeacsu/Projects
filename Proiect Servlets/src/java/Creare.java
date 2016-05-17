import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.sql.*;
import java.util.logging.Level;
import java.util.logging.Logger;

@WebServlet(urlPatterns = {"/add"})
public class Creare extends HttpServlet {
    static Connection link;
    static Statement statement;
    static ResultSet results;
    @Override
    public void doPost(HttpServletRequest request, HttpServletResponse response) throws IOException,ServletException{
        try{
            Class.forName("com.mysql.jdbc.Driver").newInstance();
            link = DriverManager.getConnection("jdbc:mysql://127.0.0.1:3306/contact", "root", "22101995");
        }
        catch(ClassNotFoundException cnfe){
            System.out.println("* Driverul nu a putut fi incarcat! *");
            System.exit(1);
        }
	catch(SQLException sqlEx){
            System.out.println("* Conectarea la baza de date a esuat! *");
	    System.exit(1);
        } catch (InstantiationException ex) {
            Logger.getLogger(Creare.class.getName()).log(Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            Logger.getLogger(Creare.class.getName()).log(Level.SEVERE, null, ex);
        }
        
        String nume=request.getParameter("Nume");
        String prenume=request.getParameter("Prenume");
        String mobil=request.getParameter("Mobil");
        String fix=request.getParameter("Fix");
        String email=request.getParameter("Email");
        String adresa=request.getParameter("Adresa");
        String oras=request.getParameter("Oras");
        String judet=request.getParameter("Judet");
        String cod=request.getParameter("Cod");
        String todo;
        int result=0;
        String rasp="Succes";
        try{
            statement=link.createStatement();
            todo = "SELECT * FROM contacte WHERE Nume='" + nume + "' and Prenume='" + prenume + "' and Telefon_Mobil='" + mobil 
                    + "' and Telefon_Fix='" + fix + "' and Email='" + email + "' and Adresa='" + adresa + "' and Oras='" + oras 
                    + "' and Judet='" + judet + "' and Cod_Postal='" + cod + "';";
            try{
                results = statement.executeQuery(todo);
            }
            catch(SQLException sqlEx){
                System.out.println("* Interogarea nu a putut fi executata.! *");
                sqlEx.printStackTrace();
                System.exit(1);
            }
            
            if(!results.next()){
                todo = "INSERT INTO contacte VALUES ('" + nume + "','" + prenume + "','" + mobil + "','" + fix + "','" + email + "','"
                    + adresa + "','" + oras + "','" + judet + "','" + cod + "');";
                result = statement.executeUpdate(todo);
            }
            
            if (result == 0) 
                rasp="Nu am putut insera inregistrarea!";
            
            link.close();
            }
        catch(SQLException sqlEx){
            System.out.println("* Eroare de conexiune sau interogare SQL! *");
            sqlEx.printStackTrace();
            System.exit(1);
        }
        
        sendPage(response,rasp);
    }
    
    private void sendPage(HttpServletResponse reply,String result) throws IOException{
        reply.setContentType("text/HTML");
        PrintWriter out = reply.getWriter();
        out.println("<HTML><HEAD><TITLE>Agenda</TITLE></HEAD><BODY>" + result);
        out.println("<BR/><BR/><BR/><CENTER>"
                + "<FORM METHOD=GET ACTION=\"Agenda\"><BR/><BR/>"
                + "<INPUT TYPE=\"Submit\" NAME=\"button\" VALUE = \"Creaza contact\">" 
                + "<INPUT TYPE=\"Submit\" NAME=\"button\" VALUE = \"Actualizeaza contact\">"
                + "<INPUT TYPE=\"Submit\" NAME=\"button\" VALUE = \"Sterge contacte\">" 
                + "<INPUT TYPE=\"Submit\" NAME=\"button\" VALUE = \"Cauta contacte\">"
                + "</FORM></CENTER></BODY></HTML>");
        out.flush();
    }
}
