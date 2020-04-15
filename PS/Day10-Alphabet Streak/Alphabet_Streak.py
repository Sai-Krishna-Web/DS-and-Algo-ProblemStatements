t=int(input())
while(t>0):
 n=int(input());s=input();p=0;q=1
 for i in range(n): 
  q=q+1if i<n-1and s[i]==s[i+1]else 1
  if q==p and not s[i] in r:r=r+s[i]
  if q>p:p=q;r=s[i]
 print(p,''.join(sorted(r)));t-=1