using System;
class S {
    static void Main() {
        int n, t = int.Parse(Console.ReadLine());
        while (t > 0) {
            n = int.Parse(Console.ReadLine());
            int[] v = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int i, j, e, d = 0, x = 0, c = 0;
            for (i = 0; i < n; i++) {
                for (j = 0; j < n; j++) {
                    if (m[i] == v[j]) {
                        m[i] = v[j] = -1;
                        break;
                    }
                }
                if (m[i] != -1) {
                    d = m[i];
                    c++;
                }
                if (c > 1) break;
            }
            if (c == 0) Console.WriteLine("Yes");
            else if (c > 1) Console.WriteLine("No");
            else {
                for (j = 0; j < n; j++) {
                    if (v[j] != -1) x = v[j];
                }
                e = x - d;
                if (e > 0) Console.WriteLine(e + " 2");
                if (e < 0) Console.WriteLine(Math.Abs(e) + " 1");
            }
            t--;
        }
    }
}