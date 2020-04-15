t=int(input())
while t>0:
 n=int(input());a,b=map(int,input().split());r=complex(a,b)
 while(n>1):c,d=map(int,input().split());r=r*complex(c,d);n-=1
 print(int(r.real),int(r.imag));t-=1