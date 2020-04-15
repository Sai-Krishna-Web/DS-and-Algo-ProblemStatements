t=int(input())
while t>0:
 a,b=map(int,input().split());c,d=map(int,input().split())
 r=a-c if a>b else b-d
 if r<b-d:r=b-d
 if r<a-c:r=a-c
 if r<d-1:r=d-1
 if r<c-1:r=c-1
 print(r);t-=1