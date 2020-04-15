t=int(input())
while t>0:n,m=map(int,input().split());x,y=map(int,input().split());x+=1;y+=1;c=min(x-1,y-1)+min(n-x,m-y)+min(n-x,y-1)+min(x-1,m-y)+n+m-2;print(c);t-=1