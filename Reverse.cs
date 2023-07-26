using System;
class Reverse{
    public static void Main(){
        int number,reverse=0,remainder;
        Console.WriteLine("Enter a number:");
        number=int.Parse(Console.ReadLine());
        while(number!=0){
            remainder=number%10;
            reverse=reverse*10+remainder;
            number=number/10;
        }
        Console.WriteLine("Reversed number is:"+reverse);
    }
}