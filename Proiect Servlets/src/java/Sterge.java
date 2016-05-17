import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.sql.*;

@WebServlet(urlPatterns = {"/delete"})
public class Sterge extends HttpServlet {
    static Connection link;
    static Statement statement;
    static ResultSet results;
    @Override
    public void doPost(HttpServletRequest request, HttpServletResponse response) throws IOException,ServletException{
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
        int result;
        String rasp="Succes";
        
        try{
            statement=link.createStatement();
            int pp=0;
            todo = "DELETE FROM contacte WHERE";
            if(!nume.equals("")){
                todo = todo + " Nume='" + nume + "'"; 
                pp=1;
            }
            if(!prenume.equals("")){
                if(pp==1) 
                    todo=todo+" and";
                todo = todo + " Prenume='" + prenume + "'"; 
                pp=1;
            }
            if(!mobil.equals("")){
                if(pp==1) 
                    todo=todo+" and";
                todo = todo + " Telefon_Mobil='" + mobil + "'"; 
                pp=1;
            }
            if(!fix.equals("")){
                if(pp==1) 
                    todo=todo+" and";
                todo = todo + " Telefon_Fix='" + fix + "'"; 
                pp=1;
            }
            if(!email.equals("")){
                if(pp==1) 
                    todo=todo+" and";
                todo = todo + " Email='" + email + "'"; 
                pp=1;
            }
            if(!adresa.equals("")){
                if(pp==1) 
                    todo=todo+" and";
                todo = todo + " Adresa='" + adresa + "'"; 
                pp=1;
            }
            if(!oras.equals("")){
                if(pp==1) 
                    todo=todo+" and";
                todo = todo + " Oras='" + oras + "'"; 
                pp=1;
            }
            if(!judet.equals("")){
                if(pp==1) 
                    todo=todo+" and";
                todo = todo + " Judet='" + judet + "'"; 
                pp=1;
            }
            if(!cod.equals("")){
                if(pp==1) 
                    todo=todo+" and";
                todo = todo + " Cod_Postal='" + cod + "'";
            }
            
            todo = todo + ";";
            result = statement.executeUpdate(todo);
            if (result == 0) 
                rasp="Nu am putut sterge inregistrarea!";
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
