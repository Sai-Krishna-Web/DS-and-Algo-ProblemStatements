using System;
class S {
    static void Main() {
        int n, s, i, j, t = int.Parse(Console.ReadLine());
        int[] c = new int[4];
        while (t > 0) {
            s = 0;
            n = int.Parse(Console.ReadLine());
            byte[, ] m = new byte[10105, 10105];
            while (n > 0) {
                c = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (i = c[0]; i < c[0] + c[2]; i++)
                    for (j = c[1]; j < c[1] + c[3]; j++) {
                        if (m[i, j] != 1) {
                            m[i, j] = 1;
                            s++;
                        }
                    }
                n--;
            }
            Console.WriteLine(s);
            t--;
        }
    }
}