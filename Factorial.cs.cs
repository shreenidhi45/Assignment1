using System;
class Factorial{
    public static void Main(){
    int i,number,fact=1;
    Console.WriteLine("Enter a number");
    number=int.Parse(Console.ReadLine());
    for(i=1;i<=number;i++){
        fact=fact*i;
    }
    Console.WriteLine("The factorial of "+number+"is "+fact);
}
}
