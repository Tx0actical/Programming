package Practice;

import java.util.Scanner;

public class Practice {
    public static int main(String[] args) {
        System.out.println("Enter the grade : ");
        Scanner obj = new Scanner(System.in);
        String grade = obj.next();

        String message = switch (grade) {
            case "A" -> "ADFAD";
            case "B" -> "Asdfad";
            case "C" -> "adfadfa";
            case "D" -> "cadxrger";
            case "F" -> "adf";
            default -> "Error";
        };
        return 0;
    }
}