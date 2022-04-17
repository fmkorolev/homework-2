//Задача 10
/*
Console.Write("Input a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int trippledigits(int n)
{
    Console.Write(n + " -> ");
    if(n < 100 || n > 999)
    {
        Console.WriteLine("Incorrect number");
        return n; 
    }
    else
    {
        int result = (n / 10) % 10;
        Console.WriteLine(result); 
        return result;
        
    }
}
trippledigits(num);

*/

// задача 15
/*
Console.Write("Input the number of the day of the week: ");
int day = Convert.ToInt32(Console.ReadLine());
void Dayoff( int d)
{
    Console.Write(d + " -> ");
    if( d > 5 && d < 8)
    {
        Console.WriteLine("Day off");
    }
    else
    {
         if(d < 1 || d > 7)
        Console.Write("Incorect number of day!!!");
        else
        Console.Write("Working day");
    }
   
        
}
Dayoff(day);
*/
//задача 13


 Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int ThirdNum(int n)
{   
    Console.Write(n + " -> ");
    if(n < 100)
    {
        Console.WriteLine("Third digit doesn't exsist");
        return n;
    }
    else
    {
        int result = (n %10)  ;
        Console.WriteLine(result);
        return result;
    }
}
ThirdNum(num);

