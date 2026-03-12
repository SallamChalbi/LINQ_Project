using static LINQ_Project.ListGenerator;
namespace LINQ_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ProductList[0]);
            //Console.WriteLine(CustomerList[0]);

            #region Restriction Operators
            /// 1. Find all products that are out of stock.
            var Result1 = ProductList.Where(P => P.UnitsInStock == 0);
            foreach (var item in Result1)
                Console.WriteLine(item);

            /// 2.Find all products that are in stock and cost more than 3.00 per unit.
            var Result2 = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3.00m);
            foreach (var item in Result2)
                Console.WriteLine(item);

            /// 3.Returns digits whose name is shorter than their value.
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var Result3 = Arr.Where((V, I) => V.Length < I);
            foreach (var item in Result3)
                Console.WriteLine(item);
            #endregion
        }
    }
}
