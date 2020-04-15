using System;
class s {
    static int x(int i, int j) {
        return i == 1 && j == 1 ? 0 : 1;
    }
    static int y(int[] v, int p, int q, int h, int i, int l) {
        if (i == h) return x(v[p], v[q]);
        else {
            i++;
            return x(y(v, p, p + l / (int) Math.Pow(2, i), h, i, l), y(v, q, q + l / (int) Math.Pow(2, i), h, i, l));
        }
    }
    static void Main() {
        int s, h, t = int.Parse(Console.ReadLine());
        while (t > 0) {
            h = int.Parse(Console.ReadLine());
            int[] v = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            s = v.Length;
            Console.WriteLine(y(v, 0, s / 2, h - 1, 1, s));
            t--;
        }
    }
}