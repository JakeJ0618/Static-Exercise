namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature in F you wanna convert?");
            double fTemp = Convert.ToDouble(Console.ReadLine());
            var convertedToCel = TempConverter.FahrenheitToCelsius(fTemp);

            Console.WriteLine($"That equals {convertedToCel} degrees celsius\n");

            Console.WriteLine("What is the temperature in C that you want to convert?");
            double celTemp = Convert.ToDouble(Console.ReadLine());
            var convertedToFar = TempConverter.CelsiusToFahrenheit(celTemp);

            Console.WriteLine($"That equals {convertedToFar} degrees fahrenheit\n");
        }
    }
}
