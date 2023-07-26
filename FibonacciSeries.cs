using System;
class FibonacciSeries{
    public static void Main (){
        int i, terms,t1=0,t2=1,nextTerm;
        Console.WriteLine("Enter the terms upto which the series is printed:");
        terms=int.Parse(Console.ReadLine());
        Console.WriteLine("Fibonacci Series:");
        for(i=1;i<=terms;i++){
            if(i==1){
                Console.WriteLine(t1);
                continue;
            }
            if(i==2){
                Console.WriteLine(t2);
                continue;
            }
            nextTerm=t1+t2;
            t1=t2;
            t2=nextTerm;
            Console.WriteLine(nextTerm);
        }
    }
}