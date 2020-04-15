using System;
class program {
    public static void Main() {
        int number, i, k, count = 1;
        byte t = Convert.ToByte(Console.ReadLine());
        while (t > 0) {
            number = int.Parse(Console.ReadLine());
            count = number - 1;
            for (k = 1; k <= number; k++) {
                for (i = 1; i <= count; i++) Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * k - 1; i++) Console.Write(i % 2 == 0 ? "0" : "1");
                Console.WriteLine();
            }
            count = 1;
            for (k = 1; k <= number - 1; k++) {
                for (i = 1; i <= count; i++) Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - k) - 1; i++) Console.Write(i % 2 == 0 ? "0" : "1");
                Console.WriteLine();
            }
            t--;
        }
    }
}