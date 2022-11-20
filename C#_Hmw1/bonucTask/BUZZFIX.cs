int test= 0;

while (test<=100)
{
if (test%3==0 && test%5==0 )
   Console.Write("BUZZFIX, "); 
else  
{ if (test%3!=0 && test%5!=0 )
      Console.Write(test+", "); 
      else 
      {if (test%3==0) Console.Write("BUZZ, ");
          else Console.Write("FIX, ");
      }
}
test++;
}

