import java.util.Scanner;
import java.lang.Math;

public class roots {
    public static void main(String[] args) {
        double a, b, c, d, root1, root2;
        Scanner myObj = new Scanner(System.in);
        System.out.println("Type value of a: ");
        a = myObj.nextInt();
        System.out.println("Type value of b: ");
        b = myObj.nextInt();
        System.out.println("Type value of c: ");
        c = myObj.nextInt();

        d = (b * b) - (4 * a * c);

        System.out.println("Discriminant is " + d);
        if (d < 0)
            System.out.println("There are no real roots.");
        else {
            root1 = (-b + (Math.sqrt(d))) / (2 * a);
            root2 = (-b - (Math.sqrt(d))) / (2 * a);

            System.out.println("1st Root is: " + root1);
            System.out.println("2nd Root is: " + root2);
        }
    }
}
