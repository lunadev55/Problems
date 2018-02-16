import java.util.Scanner;
import java.math.*;

class Main{
    public static void main(String[] args){
    
        Scanner in = new Scanner(System.in);
        
        int tc;
        char t;
        BigInteger a, b;
        
        tc = in.nextInt();
                        
        for (int i=0;i<tc;i++){
            a = in.nextBigInteger();
            t = in.next().charAt(0);
            b = in.nextBigInteger();
            
            BigInteger z = a, j = b, aux;
            
            while (!j.equals(BigInteger.ZERO)){
                aux = j;
                j = z.mod(j);
                z = aux;                                   
            }
            
            System.out.print(a.divide(z) + " ");
            System.out.print(t + " ");
            System.out.println(b.divide(z));                        
        }
    
    }
}
