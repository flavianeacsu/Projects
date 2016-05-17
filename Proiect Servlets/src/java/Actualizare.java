import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.sql.*;

@WebServlet(urlPatterns = {"/edit"})
public class Actualizare extends HttpServlet {
    static Connection link;
    static Statement statement;
    static ResultSet results;
    static String[] v=new String[11];
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
        String rasp="Succes";
        
        String button=request.getParameter("button");
        if(button.equals("DONE")){
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
                
                if(!results.next()) 
                    rasp="Nu exista contactul";
                else {
                    rasp="S1"; 
                    v[1]=nume;
                    v[2]=prenume;
                    v[3]=mobil;
                    v[4]=fix;
                    v[5]=email;
                    v[6]=adresa;
                    v[7]=oras;
                    v[8]=judet;
                    v[9]=cod;
                }

                link.close();
            }
            catch(SQLException sqlEx){
                System.out.println("* Eroare de conexiune sau interogare SQL! *");
                sqlEx.printStackTrace();
                System.exit(1);
            }
        }
        else{
            try{
                statement=link.createStatement();
                String nume1=request.getParameter("Nume1");
                String prenume1=request.getParameter("Prenume1");
                String mobil1=request.getParameter("Mobil1");
                String fix1=request.getParameter("Fix1");
                String email1=request.getParameter("Email1");
                String adresa1=request.getParameter("Adresa1");
                String oras1=request.getParameter("Oras1");
                String judet1=request.getParameter("Judet1");
                String cod1=request.getParameter("Cod1");
                int result=0;
                int pp=0;
                todo = "UPDATE contacte SET";
                if(!nume.equals("")){
                    todo = todo + " Nume='" + nume + "'"; 
                    pp=1;
                }
                if(!prenume.equals("")){
                    if(pp==1) 
                        todo=todo+",";
                    todo = todo + " Prenume='" + prenume + "'"; 
                    pp=1;
                }
                if(!mobil.equals("")){
                    if(pp==1) 
                        todo=todo+",";
                    todo = todo + " Telefon_Mobil='" + mobil + "'"; 
                    pp=1;
                }
                if(!fix.equals("")){
                    if(pp==1) 
                        todo=todo+",";
                    todo = todo + " Telefon_Fix='" + fix + "'"; 
                    pp=1;
                }
                if(!email.equals("")){
                    if(pp==1) 
                        todo=todo+",";
                    todo = todo + " Email='" + email + "'"; 
                    pp=1;
                }
                if(!adresa.equals("")){
                    if(pp==1) 
                        todo=todo+",";
                    todo = todo + " Adresa='" + adresa + "'"; 
                    pp=1;
                }
                if(!oras.equals("")){
                    if(pp==1) 
                        todo=todo+",";
                    todo = todo + " Oras='" + oras + "'"; 
                    pp=1;
                }
                if(!judet.equals("")){
                    if(pp==1) 
                        todo=todo+",";
                    todo = todo + " Judet='" + judet + "'"; 
                    pp=1;
                }
                if(!cod.equals("")){
                    if(pp==1) 
                        todo=todo+",";
                    todo = todo + " Cod_Postal='" + cod + "'";
                }
                
                todo = todo + " WHERE";
                pp=0;
                if(!nume1.equals("")){
                    todo=todo+" Nume='" + nume1 + "'"; 
                    pp=1;
                }
                if(!prenume1.equals("")){
                    if(pp==1) 
                        todo=todo+" and";
                    todo=todo+" Prenume='" + prenume1 + "'"; 
                    pp=1;
                }
                if(!mobil1.equals("")){
                    if(pp==1) 
                        todo=todo+" and";
                    todo=todo+" Telefon_Mobil='" + mobil1 + "'"; 
                    pp=1;
                }
                if(!fix1.equals("")){
                    if(pp==1) 
                        todo=todo+" and";
                    todo=todo+" Telefon_Fix='" + fix1 + "'"; 
                    pp=1;
                }
                if(!email1.equals("")){
                    if(pp==1) 
                        todo=todo+" and";
                    todo=todo+" Email='" + email1 + "'"; 
                    pp=1;
                }
                if(!adresa1.equals("")){
                    if(pp==1) 
                        todo=todo+" and";
                    todo=todo+" Adresa='" + adresa1 + "'"; 
                    pp=1;
                }
                if(!oras1.equals("")){
                    if(pp==1) 
                        todo=todo+" and";
                    todo=todo+" Oras='" + oras1 + "'";
                    pp=1;
                }
                if(!judet1.equals("")){
                    if(pp==1) 
                        todo=todo+" and";
                    todo=todo+" Judet='" + judet1 + "'";
                    pp=1;
                }
                if(!cod1.equals("")){
                    if(pp==1) 
                        todo=todo+" and";
                    todo=todo+" Cod_Postal='" + cod1 + "'";
                }
                
                todo=todo+";";
                result = statement.executeUpdate(todo);
                if (result == 0) 
                    rasp="Nu am putut actualiza inregistrarea!";
                
                link.close();
                }
                catch(SQLException sqlEx){
                    System.out.println("* Eroare de conexiune sau interogare SQL! *");
                    sqlEx.printStackTrace();
                    System.exit(1);
                }
        }
        
        sendPage(response,rasp);
    }
    
    private void sendPage(HttpServletResponse reply,String result) throws IOException{
        reply.setContentType("text/HTML");
        PrintWriter out = reply.getWriter();
        out.println("<HTML><HEAD><TITLE>Agenda</TITLE></HEAD><BODY>");
        
        if(result.equals("S1")){
            out.println("<BR/><BR/><BR/>");
            out.println("<CENTER>");
            out.println("<FORM METHOD=POST ACTION=\"edit\">");
            out.println("<TABLE>");
            out.println("<TR><TD>Nume:</TD>"
                    + "<TD><INPUT TYPE=\"Text\" NAME=\"Nume1\" VALUE = \"" + v[1] + "\" ></TD>"
                    + "</TR>");
            out.println("<TR><TD>Prenume:</TD>"
                    + "<TD><INPUT TYPE=\"Text\" NAME=\"Prenume1\" VALUE = \"" + v[2] + "\" ></TD>"
                    + "</TR>");
            out.println("<TR><TD>Telefon mobil:</TD>"
                    + "<TD><INPUT TYPE=\"Text\" NAME=\"Mobil1\" VALUE = \"" + v[3] + "\" ></TD>"
                    + "</TR>");
            out.println("<TR><TD>Telefon fix:</TD>"
                    + "<TD><INPUT TYPE=\"Text\" NAME=\"Fix1\" VALUE = \"" + v[4] + "\" ></TD>"
                    + "</TR>");
            out.println("<TR><TD>Email:</TD>"
                    + "<TD><INPUT TYPE=\"Text\" NAME=\"Email1\" VALUE = \"" + v[5] + "\" ></TD>"
                    + "</TR>");
            out.println("<TR><TD>Adresa:</TD>"
                    + "<TD><INPUT TYPE=\"Text\" NAME=\"Adresa1\" VALUE = \"" + v[6] + "\" ></TD>"
                    + "</TR>");
            out.println("<TR><TD>Oras:</TD>"
                    + "<TD><INPUT TYPE=\"Text\" NAME=\"Oras1\" VALUE = \"" + v[7] + "\" ></TD>"
                    + "</TR>");
            out.println("<TR><TD>Judet:</TD>"
                    + "<TD><INPUT TYPE=\"Text\" NAME=\"Judet1\" VALUE = \"" + v[8] + "\" ></TD>"
                    + "</TR>");
            out.println("<TR><TD>Cod postal:</TD>"
                    + "<TD><INPUT TYPE=\"Text\" NAME=\"Cod1\" VALUE = \"" + v[9] + "\" ></TD>"
                    + "</TR>");
            out.println("</TABLE>");
            out.println("<BR/><BR/>Ce doriti sa modificati la acest contact?<BR/><BR/>");
            out.println("<TABLE>");
            out.println("<TR><TD>Nume:</TD>"
                    + "<TD><INPUT TYPE=\"Text\" NAME=\"Nume\" VALUE = \"\" ></TD>"
                    + "</TR>");
            out.println("<TR><TD>Prenume:</TD>"
                    + "<TD><INPUT TYPE=\"Text\" NAME=\"Prenume\" VALUE = \"\" ></TD>"
                    + "</TR>");
            out.println("<TR><TD>Telefon mobil:</TD>"
                    + "<TD><INPUT TYPE=\"Text\" NAME=\"Mobil\" VALUE = \"\" ></TD>"
                    + "</TR>");
            out.println("<TR><TD>Telefon fix:</TD>"
                    + "<TD><INPUT TYPE=\"Text\" NAME=\"Fix\" VALUE = \"\" ></TD>"
                    + "</TR>");
            out.println("<TR><TD>Email:</TD>"
                    + "<TD><INPUT TYPE=\"Text\" NAME=\"Email\" VALUE = \"\" ></TD>"
                    + "</TR>");
            out.println("<TR><TD>Adresa:</TD>"
                    + "<TD><INPUT TYPE=\"Text\" NAME=\"Adresa\" VALUE = \"\" ></TD>"
                    + "</TR>");
            out.println("<TR><TD>Oras:</TD>"
                    + "<TD><INPUT TYPE=\"Text\" NAME=\"Oras\" VALUE = \"\" ></TD>"
                    + "</TR>");
            out.println("<TR><TD>Judet:</TD>"
                    + "<TD><INPUT TYPE=\"Text\" NAME=\"Judet\" VALUE = \"\" ></TD>"
                    + "</TR>");
            out.println("<TR><TD>Cod postal:</TD>"
                    + "<TD><INPUT TYPE=\"Text\" NAME=\"Cod\" VALUE = \"\" ></TD>"
                    + "</TR>");
            out.println("</TABLE>");
            out.println("<BR/><BR/>");
            out.println("<INPUT TYPE=\"Submit\" NAME=\"button\" VALUE = \"Actualizare\">");
            out.println("</FORM>");
            out.println("</CENTER>");
            out.println("</BODY>");
            out.println("</HTML>");
        }
        else 
            out.println(result + "<BR/><BR/><BR/><CENTER><FORM METHOD=GET ACTION=\"Agenda\"><BR/><BR/>"
                    + "<INPUT TYPE=\"Submit\" NAME=\"button\" VALUE = \"Creaza contact\">" +
                      "<INPUT TYPE=\"Submit\" NAME=\"button\" VALUE = \"Actualizeaza contact\">"
                    + "<INPUT TYPE=\"Submit\" NAME=\"button\" VALUE = \"Sterge contacte\">" +
                        "<INPUT TYPE=\"Submit\" NAME=\"button\" VALUE = \"Cauta contacte\"></FORM>"
                    + "</CENTER></BODY></HTML>");
        out.flush();
    }
}
