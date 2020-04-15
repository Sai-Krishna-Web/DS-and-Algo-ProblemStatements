t=int(input())
while t>0:
 n=int(input());v=list(map(int,input().split()));m=list(map(int,input().split()));s=0
 for i in range(1,n):s,m[i]=(s+m[i]+m[i-1]-v[i],v[i])if m[i]+m[i-1]>v[i]else(s+0,m[i]+m[i-1])
 print(m[n-1],s);t-=1