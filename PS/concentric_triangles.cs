using System;  
  public class PrintExample  
   {  
     public static void Main(string[] args)  
      {  
       int  i,j,k,l,n,m;           
          
       n= 19;m=n%2==0?n/2:n/2+1;
	
       for(i=1; i<=m; i++)      
       {          
        for(j=1; j<=n-i; j++)      
        {      
         Console.Write(" ");      
        }      
        for(k=1;k<=i;k++)      
        {      
         Console.Write(k%2==0?"0":"1");      
        }      
        for(l=i-1;l>=1;l--)      
        {      
        Console.Write(l%2==0?"0":"1");      
        }      
        Console.Write("\n");      
       } 
		 
	int p=m;	 
	for(i=m+1; i<=n; i++)      
       {          
        for(j=1; j<=n-i; j++)      
        {      
         Console.Write(" ");      
        }      
        for(k=1;k<=n-m;k++)      
        { 
			if(i==n)
				Console.Write("1");
			else
         Console.Write(k%2==0?"0":"1");      
        }
		while(k<=i)
		{
			if(i==n)
				Console.Write("1");
			else Console.Write((n-m)%2==0?"0":"1");k++;
		}
		for(int q=p+1;q<=i;q++){
			if(i==n)
				Console.Write("1");
			else
			Console.Write((n-m)%2==0?"0":"1");
		}
        for(l=p-1;l>=1;l--)      
        { 
			if(i==n)
				Console.Write("1");
			else
        Console.Write(l%2==0?"0":"1");      
        }
			 m++;p--;
        Console.Write("\n");      
       }   
   }  
  } 