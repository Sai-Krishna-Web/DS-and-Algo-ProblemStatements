p=int(input())
for x in range(p):
 R,C,n=map(int,input().split());q=input();m=[[0 for i in range(C)]for j in range(R)];t=0;b=R-1;l=0;r=C-1;s=0;n-=1
 while(1):
  if(l>r):break
  for i in range(l,r+1):
   m[t][i]=q[s];s=s+1if s<n else 0
  t+=1
  if(t>b):break
  for i in range(t,b+1):
   m[i][r]=q[s];s=s+1if s<n else 0
  r-=1
  if(l>r):break
  for i in range(r,l-1,-1):
   m[b][i]=q[s];s=s+1if s<n else 0
  b-=1
  if(t>b):break
  for i in range(b,t-1,-1):  
   m[i][l]=q[s];s=s+1if s<n else 0
  l+=1
 for i in range(R): 
  for j in range(C):print(m[i][j],end="")
  print()