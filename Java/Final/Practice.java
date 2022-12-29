package Final;

import java.util.Scanner;

public class Practice {
    public static int main(String[] args) {
        System.out.println("Enter the grade : ");
        Scanner obj = new Scanner(System.in);
        String grade = obj.next();

        // switch expressions
        String message = switch (grade) {
            case "A" -> {
                System.out.print("The grade is : ");
                yield grade;
            }
            case "B" -> {
                System.out.print("Your grade is : ");
                yield grade;
            }
            case "C" -> {
                System.out.print("Grade is : ");
                yield grade;
            }
            case "D" -> {
                System.out.print("Grade : ");
                yield grade;
            }
            case "F" -> {
                System.out.print("Your damn grade is  : ");
                yield grade;
            }
            default -> "Error";
        };
        return 0;
    }
}