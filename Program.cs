namespace sesion4_iti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Problem 1
            // Problem 1: Inheritance
            //Console.WriteLine(" Vehicle Inheritance ");
            //Car car = new Car
            //{

            //    Brand = "BMW",
            //    Speed = 220,
            //    NumberOfDoors = 4
            //};
            //car.DisplayInfo();
            #endregion
            #region Problem 2 Multiple Inheritance
            //// Problem 2: Multiple Inheritance using Interfaces
            //Console.WriteLine(" Book and Interfaces ");
            //Book book = new Book
            //{
            //    Title = "C# Basics",
            //    Author = "John Smith"
            //};
            //book.PrintDetails();
            //book.Borrow();
            #endregion
            #region Problem 3: Method Overloading
            // Problem 3: Method Overloading
            Console.WriteLine(" Calculator Overloading ");
            Calculator calc = new Calculator();
            Console.WriteLine("Add(int, int): " + calc.Add(5, 10));
            Console.WriteLine("Add(double, double): " + calc.Add(2.5, 3.7));
            Console.WriteLine("Add(int, int, int): " + calc.Add(1, 2, 3));
            #endregion
            #region 4: Method Override
            // Problem 4: Method Override - Runtime Polymorphism
            Console.WriteLine(" Shape Polymorphism ");
            Shape shape = new Circle();
            shape.Draw();
            #endregion
        }
    }
}
