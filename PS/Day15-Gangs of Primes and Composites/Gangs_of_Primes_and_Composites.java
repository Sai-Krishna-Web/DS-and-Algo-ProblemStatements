import java.util. * ;
import java.lang. * ;
import java.io. * ;
class solution {static int[][] g;static int a;static int b;
static int R(int r, int c, int e, boolean f) {
    int i, j;
    if ((r < a) && (c < b))
        if (!P(g[r][c], f) && g[r][c] != 0) {
            e = 1;
            for (i = r; i < r + 1; i++) 
                for (j = c; j < b; j++)
                    if (r < a) 
                        if (!P(g[i][j], f) && g[i][j] != 0) {
                            g[i][j] = 0;if (i > 0) U(i - 1, j, f);if (i + 1 < a) D(i + 1, j, f);
} else break;}return e;}
static void R(int r, int c, boolean f) {
    int i, j;
    if ((r < a) && (c < b))
        if (!P(g[r][c], f) && g[r][c] != 0)
            for (i = r; i < r + 1; i++)
                for (j = c; j < b; j++)
                    if (r < a) 
                        if (!P(g[i][j], f) && g[i][j] != 0) {
                            g[i][j] = 0;if (i > 0) U(i - 1, j, f);if (i + 1 < a) D(i + 1, j, f);
}else break;}
static void L(int r, int c, boolean f) {
    int i, j;
    if ((r < a) && (c < b))
        if (!P(g[r][c], f) && g[r][c] != 0)
            for (i = r; i < r + 1; i++) 
                for (j = c; j >= 0; j--) 
                    if (r < a)
                        if (!P(g[i][j], f) && g[i][j] != 0) {
                            g[i][j] = 0;if (i > 0) U(i - 1, j, f);if (i + 1 < a) D(i + 1, j, f);
}else break;}
static void D(int r, int c, boolean f) {
    int i,  j;
    if ((r < a) && (c < b))
        if (!P(g[r][c], f) && g[r][c] != 0)
            for (i = c; i < c + 1; i++)
                for (j = r; j < a; j++)
                    if (c < b)
                        if (!P(g[j][i], f) && g[j][i] != 0) {
                            g[j][i] = 0;if (i > 0) L(j, i - 1, f);if (i + 1 < b) R(j, i + 1, f);
} else break;}
static void U(int r, int c, boolean f) {
    int i, j;
    if ((r < a) && (c < b))
        if (!P(g[r][c], f) && g[r][c] != 0)
            for (i = c; i < c + 1; i++)
                for (j = r; j >= 0; j--)
                    if (c < b)
                        if (!P(g[j][i], f) && g[j][i] != 0) {
                            g[j][i] = 0;
                            if (i > 0) L(j, i - 1, f);
                            if (i + 1 < b) R(j, i + 1, f);
} else break;}
static int N(boolean h){int f,w=0,i,j;for (i=0;i<a;i++)for(j=0;j<b;j++){f=0;f=R(i,j,0,h);if(f==1)w++;}return w;}
static boolean P(int y,boolean f){for (int i=2;i<=y/2;++i)if (y%i==0){f=!f;break;}return f;}
public static void main(String[] args){
Scanner z=new Scanner(System.in );int i,j,n=z.nextInt();
while(n>0){a = z.nextInt();b = z.nextInt();g = new int[a][b];for (i = 0; i < a; i++)for (j = 0; j < b; j++)g[i][j] = z.nextInt();
System.out.println(N(false)+" "+N(true));n--;}z.close();}}