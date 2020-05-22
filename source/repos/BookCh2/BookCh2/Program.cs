using System;


namespace BookCh2{
    class Program {
        static void Main(string[] args){
            int celsius = 0;
            double fahrenheit = 0.0;
            Console.WriteLine("Enter the temperature in Celsius(°C): ");
            celsius = int.Parse(Console.ReadLine());
            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("The temperature in Fahrenheit is: "+ fahrenheit +"°F" );
            Console.ReadLine();

        }
    }
}
