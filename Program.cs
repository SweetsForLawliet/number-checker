Console.WriteLine("Enter a number:");
var num = Convert.ToInt32(Console.ReadLine());

if (num >= 1)
{
   
    if (num % 2 == 0)
    {
        Console.WriteLine("Positive and even");
    }
    else
    {
        Console.WriteLine("Positive and odd");
    }
}
else if (num <= -1)
{
   if (num % 2 == -1)
   {
       Console.WriteLine("Negative and odd");
   }
    else
    {
        Console.WriteLine("Negative and even");
    }
} 
else if(num == 0)
{
    Console.WriteLine("Neutral");  
}
