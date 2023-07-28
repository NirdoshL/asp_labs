//Linq=> Language Integrated Query
//Linq provides way to use query on 
//any collections type data i.e array,list etc
//syntax : from .... where.....select
// Note: Linq syntax can only be defined under static class
using System;
using System.Linq;

class LinqConcept{
    static void Main8(string[] args){


    int[] numbers = {12,13,25,27,57,109,1,90,4,88};

   //Method syntax
    var result1=numbers.Where(num => num>30).Select(num=>num);
    //Method to partition the array
    //Take(int) Skip(int) is used
    //to select first five elements in array Linq syntax 
    //doesnot work so you have to use Take,Skip
    var take5=numbers.Take(5);
    //to skip first five and take next 2 elements
    var skip5take2=numbers.Skip(5).Take(2);
    //Linq Query expression syntax
    var result2= from num in numbers
                 where num>30
                 select num;

    Console.WriteLine("First five numbers in array.");
    foreach(var r in take5){
        Console.WriteLine(r +" ");
    }

    Console.WriteLine("Skip First five numbers and Take two numbers in array.");
    foreach(var r in skip5take2){
        Console.WriteLine(r +" ");
    }
//Method print
    Console.WriteLine("From First Result:");
    foreach(var r in result1){
        Console.WriteLine(r +" ");
    }

//Linq print
    Console.WriteLine("From Second Result:");
    foreach(var r in result2){
        Console.WriteLine(r +" ");
    }
    }
}

