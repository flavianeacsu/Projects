import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.sql.*;

@WebServlet(urlPatterns = {"/search"})
public class Cautare extends HttpServlet {
    static Connection link;
    static Statement statement;
    static ResultSet results;
    @Override
    public void doGet(HttpServletRequest request, HttpServletResponse response) throws IOException,ServletException{
        try{
            Class.forName("com.mysql.jdbc.Driver");
            link = DriverManager.getConnection("jdbc:mysql://localhost:3306/contact", "root", "22101995");
        }
        catch(ClassNotFoundException cnfe){
            System.out.println("* Driverul nu a putut fi incarcat! *");
            System.exit(1);
        }
	catch(SQLException sqlEx){
            System.out.println("* Conectarea la baza de date a esuat! *");
	    System.exit(1);
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
        String rasp="Succes";
        
        try{
            statement=link.createStatement();
            int pp=0;
            todo = "SELECT * FROM contacte";
            if(nume.equals("") && prenume.equals("") && mobil.equals("") && fix.equals("") && email.equals("") && adresa.equals("") && oras.equals("") && judet.equals("") && cod.equals("")) 
                todo=todo+";";
            else{
                todo=todo+" WHERE";
                if(!nume.equals("")){
                    todo = todo + " Nume='" + nume + "'"; 
                    pp=1;
                }
                if(!prenume.equals("")){
                    if(pp==1) 
                        todo=todo+" or";
                    todo = todo + " Prenume='" + prenume + "'"; 
                    pp=1;
                }
                if(!mobil.equals("")){
                    if(pp==1) 
                        todo=todo+" or";
                    todo = todo + " Telefon_Mobil='" + mobil + "'"; 
                    pp=1;
                }
                if(!fix.equals("")){
                    if(pp==1) 
                        todo=todo+" or";
                    todo = todo + " Telefon_Fix='" + fix + "'"; 
                    pp=1;
                }
                if(!email.equals("")){
                    if(pp==1) 
                        todo=todo+" or";
                    todo = todo + " Email='" + email + "'"; 
                    pp=1;
                }
                if(!adresa.equals("")){
                    if(pp==1) 
                        todo=todo+" or";
                    todo = todo + " Adresa='" + adresa + "'"; 
                    pp=1;
                }
                if(!oras.equals("")){
                    if(pp==1) 
                        todo=todo+" or";
                    todo = todo + " Oras='" + oras + "'"; 
                    pp=1;
                }
                if(!judet.equals("")){
                    if(pp==1) 
                        todo=todo+" or";
                    todo = todo + " Judet='" + judet + "'"; 
                    pp=1;
                }
                if(!cod.equals("")){
                    if(pp==1) 
                        todo=todo+" or";
                    todo = todo + " Cod_Postal='" + cod + "'";
                }
            }
            try{
                results = statement.executeQuery(todo);
            }
            catch(SQLException sqlEx){
                System.out.println("* Interogarea nu a putut fi executata.! *");
                sqlEx.printStackTrace();
                System.exit(1);
            }
            
            response.setContentType("text/HTML");
            PrintWriter out = response.getWriter();
            out.println("<HTML><HEAD><TITLE>Agenda</TITLE></HEAD><BODY>");
            try{
                int i=0;
                while(results.next()){
                    i++;
                    out.println(i + ".Nume: " + results.getString(1) + "; Prenume: " + results.getString(2)
                            + "; Telefon Mobil: " + results.getString(3) + "; Telefon Fix: " + results.getString(4) + ";");
                    out.println("Email: " + results.getString(5) + "; Adresa: " + results.getString(6) + ";");
                    out.println("Oras: " + results.getString(7) + "; Judet: " + results.getString(8) + "; Cod Postal: " + results.getString(9));
                    out.println("<BR/>");
                }
                
                if(i==0) 
                    rasp="Nu exista inregistrari care sa corespunda cautarii";
            }
            catch(SQLException sqlEx){
                System.out.println("* Eroare la primirea datelor! *");
                sqlEx.printStackTrace();
                System.exit(1);
            }
            
            out.println("<BR/>" +rasp);
            out.println("<BR/><BR/><BR/><CENTER><FORM METHOD=GET ACTION=\"Agenda\"><BR/><BR/><INPUT TYPE=\"Submit\" NAME=\"button\" VALUE = \"Creaza contact\">" +
                    "<INPUT TYPE=\"Submit\" NAME=\"button\" VALUE = \"Actualizeaza contact\"><INPUT TYPE=\"Submit\" NAME=\"button\" VALUE = \"Sterge contacte\">" +
                    "<INPUT TYPE=\"Submit\" NAME=\"button\" VALUE = \"Cauta contacte\"></FORM></CENTER></BODY></HTML>");
            out.flush();
            link.close();
            }
        
        catch(SQLException sqlEx){
            System.out.println("* Eroare de conexiune sau interogare SQL! *");
            sqlEx.printStackTrace();
            System.exit(1);
        }
    }
}
