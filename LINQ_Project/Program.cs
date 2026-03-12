using static LINQ_Project.ListGenerator;
namespace LINQ_Project
{
    class CustomComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ProductList[0]);
            //Console.WriteLine(CustomerList[0]);

            #region Restriction Operators
            ///// 1. Find all products that are out of stock.
            //var Result1 = ProductList.Where(P => P.UnitsInStock == 0);
            //foreach (var item in Result1)
            //    Console.WriteLine(item);

            ///// 2.Find all products that are in stock and cost more than 3.00 per unit.
            //var Result2 = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3.00m);
            //foreach (var item in Result2)
            //    Console.WriteLine(item);

            ///// 3.Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result3 = Arr.Where((V, I) => V.Length < I);
            //foreach (var item in Result3)
            //    Console.WriteLine(item);
            #endregion

            #region Ordering Operators
            /// 1.Sort a list of products by name
            var Result1 = ProductList.OrderBy(P => P.ProductName);
            foreach (var Result in Result1)
                Console.WriteLine(Result);

            /// 2.Uses a custom comparer to do a case-insensitive sort of the words in an array.
            string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var Result2 = Arr.OrderBy(S => S, new CustomComparer());
            foreach (var Result in Result2)
                Console.WriteLine(Result);

            /// 3.Sort a list of products by units in stock from highest to lowest.
            var Result3 = ProductList.OrderByDescending(P => P.UnitsInStock);
            foreach (var item in Result3)
                Console.WriteLine(item);

            /// 4.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            string[] Arr1 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var Result4 = Arr1.OrderBy(S => S.Length).ThenBy(S => S);
            foreach (var item in Result4)
                Console.WriteLine(item);

            /// 5.Sort first by word length and then by a case-insensitive sort of the words in an array.
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var Result5 = words.OrderBy(S => S.Length).ThenBy(S => S, new CustomComparer());
            foreach (var item in Result5)
                Console.WriteLine(item);

            /// 6.Sort a list of products, first by category, and then by unit price, from highest to lowest.
            var Result6 = ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);
            foreach (var item in Result6)
                Console.WriteLine(item);

            /// 7.Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            string[] Arr2 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var Result7 = Arr2.OrderBy(S => S.Length).ThenByDescending(S => S, new CustomComparer());
            foreach (var item in Result7)
                Console.WriteLine(item);

            /// 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            string[] Arr3 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var Result8 = Arr3.Where(T => T[1] == 'i').Reverse();
            foreach (var item in Result8)
                Console.WriteLine(item);
            #endregion
        }
    }
}
