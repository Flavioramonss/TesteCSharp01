using System;

public class Principal {
        
    public static void Main() {
        Console.WriteLine("Olá Mundo...");

        var result = Sum(7, 3);
        Console.WriteLine(result);

        var car = new Car {
            Code = 1234,
            Name = "Palio",
            Brand = "Fiat",
            Year = 2010
        };

        Console.WriteLine(car);
    }

    private static int Sum(int a, int b) {
        return a + b;
    }
}