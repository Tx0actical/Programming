import java.util.Scanner;

public class fibo {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        System.out.println("Enter the upper limit : ");
        int N = s.nextInt();
        System.out.println("The series is : ");
        for (int i = 0; i < N; i++) {
            System.out.print(fiboRecursion(i) + " ");
        }
    }
    public static int fiboRecursion(int N) {
        if (N <= 1) return N;
        else {
            return fiboRecursion(N - 1) + fiboRecursion(N - 2);
        }
    }
}
