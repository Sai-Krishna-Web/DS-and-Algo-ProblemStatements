using System;
class S {
    static void Main() {
        int i, n, t = int.Parse(Console.ReadLine());
        while (t > 0) {
            n = int.Parse(Console.ReadLine());
            int[] c = new int[n];
            char[] b = Console.ReadLine().ToCharArray();
            int l = 0, x = 0, p = 0, m = 0;
            for (i = 0; i < n; i++) {
                if (b[i] == '[') {
                    l++;
                    c[l]++;
                }
                if (x < l) x = l;
                if (m < c[l]) m = c[l];
                if (b[i] == ']') l--;
            }
            for (i = 0; i < n; i++)
                if (c[i] == m) p++;
            Console.WriteLine(n / 2 + " " + x + " " + m + " " + p);
            t--;
        }
    }
}