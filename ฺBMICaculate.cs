// See https://aka.ms/new-console-template for more information

namespace learnCSharp {
    class Program {
        static void Main(string[] args) {
            double weight, height;
            Console.Write("Input Weight(kg) :");
            double.TryParse(Console.ReadLine(), out weight);

            Console.Write("Input Height(m) :");
            double.TryParse(Console.ReadLine(), out height);

            double bmi = weight / Math.Pow(height, 2);

            Console.WriteLine("BMI = {0}", bmi);
        }
    }
};