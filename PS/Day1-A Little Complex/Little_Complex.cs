using System;
public class Solution
{
public struct Complex {
   public double real;
   public double imaginary;
   public Complex(double real, double imaginary) {
      this.real = real;
      this.imaginary = imaginary;
   }
   public static Complex operator *(Complex one, Complex two) {
      return new Complex((one.real * two.real)-(one.imaginary*two.imaginary), 
      (one.real * two.imaginary)+(two.real*one.imaginary));
   }
   
}

    public static void Main()
{
        int t = Convert.ToInt32(Console.ReadLine());
        for (int c = 0; c < t; c++) {
            int n = Convert.ToInt32(Console.ReadLine());
                string[] tokens = Console.ReadLine().Split();
                double a = double.Parse(tokens[0]);
                double b = double.Parse(tokens[1]);
                Complex res = new Complex(a, b);
                while( n>1){
                 tokens = Console.ReadLine().Split();
                 a = double.Parse(tokens[0]);
                 b = double.Parse(tokens[1]);
                Complex val2 = new Complex(a, b);
            
                 res = res * val2;
                 n--;
                }
                Console.WriteLine(res.real+" "+ res.imaginary);
                
        }
}
  
}