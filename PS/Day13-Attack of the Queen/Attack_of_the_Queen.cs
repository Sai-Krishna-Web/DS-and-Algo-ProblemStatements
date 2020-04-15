using System;
class s {
    static void Main() {
        int x, y, n, m, c, t = int.Parse(Console.ReadLine());
        while (t > 0) {
            string[] p = Console.ReadLine().Split();
            n = int.Parse(p[0]);
            m = int.Parse(p[1]);
            p = Console.ReadLine().Split();
            x = int.Parse(p[0]) + 1;
            y = int.Parse(p[1]) + 1;
            c = Math.Min(x - 1, y - 1) + Math.Min(n - x, m - y) + Math.Min(n - x, y - 1) + Math.Min(x - 1, m - y) + n + m - 2;
            Console.WriteLine(c);
            t--;
        }
    }
}