class A extends Thread {
    synchronized public void run() {
        for (int i = 0; i < 5; i++) {
            System.out.println("a"+i);
            if (i == 3)
                try {
                    sleep(1000);
                } catch (Exception ignored) {

                }
        }
    }
}
class B extends Thread {
    public void run() {
        for (int j = 0; j < 5; j++) {
            System.out.println("b"+j);
        }
    }
}
public class multithreading {
    public static void main(String arg[]) {
        A a1 = new A();
        B b1 = new B();
        a1.start();
        b1.start();
    }
}