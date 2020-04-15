def I(r,s,d):
 l=len(s)-1;k=0;i=r-1if d<0else 0;q=-1if d<0else r;p=[]
 while(1):
  print(' '*(r-i-1),end="");
  for j in range(2*i+1):print(s[k],end="");k=k+1if k<l else 0
  print();i+=d;if(i==q):break
  print(' '*(r-i-1),end="")
  for j in range(2*i+1):p.insert(0,s[k]);k=k+1if k<l else 0
  print("".join(p));i+=d;p.clear()
  if(i==q):break   
t=int(input())
for x in range(t):s,h,d=map(str,input().split());I(int(h),s,int(d))