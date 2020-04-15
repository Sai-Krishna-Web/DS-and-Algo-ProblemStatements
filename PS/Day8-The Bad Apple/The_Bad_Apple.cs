using System;
class s {
    static void Main() {
        int t = int.Parse(Console.ReadLine());
        int
        d = 0;
        while (t > 0) {
            int[] v = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            if (v[0] > v[1]) {
                d = v[0] - m[0];
            } else {
                d = v[1] - m[1];
            }
            if (d <
                v[1] - m[1]) d = v[1] - m[1];
            if (d < v[0] - m[0]) d = v[0] - m[0];
            if (d < m[1] - 1) d = m[1] - 1;
            if (d < m[0] - 1) d = m[0] - 1;
            Console.WriteLine(d);
            t--;
        }
    }
}