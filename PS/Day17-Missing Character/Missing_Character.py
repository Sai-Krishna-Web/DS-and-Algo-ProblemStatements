t=int(input());p="ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/"
while t>0:
 i=int(input())-1;q=0;c=input()
 while i>=0:
  s=p.index(c[i])*2;q+=s-63if s>63else s;i-=1
  if(i>=0):q+=p.index(c[i]);i-=1
 print(p[64-q%64]if q%64!=0else p[0]);t-=1