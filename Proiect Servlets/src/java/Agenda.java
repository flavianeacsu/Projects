import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

@WebServlet(urlPatterns = {"/Agenda"})
public class Agenda extends HttpServlet {
    public void doGet(HttpServletRequest request, HttpServletResponse response) throws IOException,ServletException{
        response.setContentType("text/HTML");
        PrintWriter out = response.getWriter();
        String button=request.getParameter("button");
        out.println("<HTML>");
        out.println("<HEAD>");
        out.println("<TITLE>Agenda</TITLE>");
        out.println("</HEAD>");
        out.println("<BODY>");
        out.println("<BR/><BR/><BR/>");
        out.println("<CENTER>");
        
        if(button.equals("Creaza contact")) 
            out.println("<FORM METHOD=POST ACTION=\"/add\">");
        else if(button.equals("Actualizeaza contact")) 
            out.println("<FORM METHOD=POST ACTION=\"/edit\">");
        else if(button.equals("Sterge contacte")) 
            out.println("<FORM METHOD=POST ACTION=\"/delete\">");
        else if(button.equals("Cauta contacte")) 
            out.println("<FORM METHOD=GET ACTION=\"/search\">");
        
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
        out.println("<INPUT TYPE=\"Submit\" NAME=\"button\" VALUE = \"DONE\">");
        out.println("</FORM>");
        out.println("</CENTER>");
        out.println("</BODY>");
        out.println("</HTML>");
    }
}
