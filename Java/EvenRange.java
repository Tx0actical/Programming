import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class EvenRange  
 */
@WebServlet("/EvenRange")
public class EvenRange extends HttpServlet {
    private static final long serialVersionUID = 1L;

    /**
     * @see HttpServlet#HttpServlet()
     */
    public EvenRange() {
        super();
        // TODO Auto-generated constructor stub    
    }

    /**
     * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
     */


    /**
     * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
     */
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        // TODO Auto-generated method stub    

        PrintWriter pw;
        response.setContentType("text/html");
        pw=response.getWriter();

        int start=Integer.parseInt(request.getParameter("start"));
        int end=Integer.parseInt(request.getParameter("end"));


        for(int i=start;i<=end;i++)
        {
            if(i%2!=0)
            {
                pw.println(i+"<br>");
            }
        }

        pw.close();


    }
}