def f(n,r):
 if len(n)==1:return n,r
 else:
  r+=1;s=0
  for i in n:s+=int(i)
  return f(str(s),r)
t=int(input())
for x in range(t):
 n=input();r=0;n,r=f(n,r);print(n,r)