using System;
class Prime{
    public static bool checkPrime(int number){
        if (number <= 1)
        {
            return false; 
        }
        for(int i=2;i<number;i++){
            if(i%number==0){
                return false;
                
            }
        }
        return true;
    }
    public static void Main(){
        Console.WriteLine("Enter the number:");
        int num=int.Parse(Console.ReadLine());
        if(checkPrime(num)){
            Console.WriteLine("The given number is prime");
        }
        else{
            Console.WriteLine("The given number is not prime");
        }
    }
        
}