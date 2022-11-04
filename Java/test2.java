class A extends Thread {
    synchronized public void run() {
        for (int i = 0; i < 5; i++) {
            System.out.println(i);
            if (i == 3)
                try {
                    sleep(1000);
                } catch (Exception e) {

                }
        }
    }
}

class B extends Thread {
    public void run() {
        for (int j = 0; j < 5; j++) {
            System.out.println(j);
        }
    }
}


public class test2 {
    public static void main(String arg[]) { A a1=new A();
        B b1=new B(); a1.start();
        b1.start();
    }
}