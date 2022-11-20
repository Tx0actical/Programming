package sockets;

import java.io.*;
import java.net.*;

public class server {
    public static void main(String[] args) {
        try {
            ServerSocket ss = new ServerSocket(6666); // create a server socket
            Socket s = ss.accept(); // return an instance of socket if a client connects
            DataInputStream dis = new DataInputStream(s.getInputStream());
            String str = (String) dis.readUTF(); // read UTF strings
            System.out.println("message = " + str); // print message sent from client
            ss.close(); // close socket connection
        } catch (Exception e) {
            System.out.println(e);
        }
    }
}