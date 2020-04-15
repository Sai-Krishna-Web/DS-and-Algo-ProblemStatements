using System;
class s {
    static void Main() {
        int i, j, g, r, c, t = int.Parse(Console.ReadLine());
        while (t > 0) {
            int[] v = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            r = v[0];
            c = v[1];
            char[, ] a = new char[r, c];
            for (i = 0; i < r; i++) {
                char[] tp = (Console.ReadLine()).ToCharArray();
                for (j = 0; j < c; j++) a[i, j] = tp[j];
            }
            g = 0;
            for (i = 0; i < r; i++)
                for (j = 0; j < c; j++) {
                    if (a[i, j] == 'r' || a[i, j] == 'b') {
                        if (i + 1 < r && a[i + 1, j] == 'x') a[i + 1, j] = 'k';
                        if (i - 1 >= 0 && a[i - 1, j] == 'x') a[i - 1, j] = 'k';
                        if (j + 1 < c && a[i, j + 1] == 'x') a[i, j + 1] = 'k';
                        if (j - 1 >= 0 && a[i, j - 1] == 'x') a[i, j - 1] = 'k';
                    }
                    if (a[i, j] == 'r') {
                        if (i + 1 < r && j + 1 < c && a[i + 1, j + 1] == 'x') a[i + 1, j + 1] = 'k';
                        if (i + 1 < r && j - 1 >= 0 && a[i + 1, j - 1] == 'x') a[i + 1, j - 1] = 'k';
                        if (i - 1 >= 0 && j - 1 >= 0 && a[i - 1, j - 1] == 'x') a[i - 1, j - 1] = 'k';
                        if (i - 1 >= 0 && j + 1 < c && a[i - 1, j + 1] == 'x') a[i - 1, j + 1] = 'k';
                    }
                }
            for (i = 0; i < r; i++)
                for (j = 0; j < c; j++) {
                    if (a[i, j] == 'x') g++;
                }
            Console.WriteLine(g);
            t--;
        }
    }
}