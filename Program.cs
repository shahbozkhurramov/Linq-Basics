﻿namespace LinqBasics;

public class Program
{
    public static void Main(string[] args)
    {
        string[] cars = {"bmw", "merc", "ferrari", "lamborghini", "bugatti"};
        var myCar = from car in cars
                    where car.Contains('a')
                    select car;
        myCar.ToList().ForEach(car => Console.WriteLine(car));
        var myCar1 = cars.Where((c, i)=> i%2==0?true:false);
        myCar1.ToList().ForEach(car => Console.WriteLine(car));
    }
}
