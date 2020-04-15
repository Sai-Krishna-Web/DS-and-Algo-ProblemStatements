t=int(input())
while t>0:
 n=int(input())*2-1;p=n//2;q=1
 for i in range(1,n+1):
  for j in range(1,p+1):print(" ",end='')
  c=q//2+1
  for k in range(1,q+1):print(((1,0)[k%2==0]),end='');c=c-1if(k<=(q//2))else c+1
  print();p,q=(p-1,q+2)if i<=n//2else(p+1,q-2)
 t-=1