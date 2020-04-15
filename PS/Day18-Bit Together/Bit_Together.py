def F(p,l,c):
 r=0
 for i in range(l):
  if(int(p[i])==c):r+=1
 return r
t=int(input())
while t>0:l=int(input());p=input();print(min(F(p,F(p,l,0),1),F(p,F(p,l,1),0)));t-=1