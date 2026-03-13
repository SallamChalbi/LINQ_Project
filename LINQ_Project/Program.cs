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
            ///// 1.Sort a list of products by name
            //var Result1 = ProductList.OrderBy(P => P.ProductName);
            //foreach (var Result in Result1)
            //    Console.WriteLine(Result);

            ///// 2.Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result2 = Arr.OrderBy(S => S, new CustomComparer());
            //foreach (var Result in Result2)
            //    Console.WriteLine(Result);

            ///// 3.Sort a list of products by units in stock from highest to lowest.
            //var Result3 = ProductList.OrderByDescending(P => P.UnitsInStock);
            //foreach (var item in Result3)
            //    Console.WriteLine(item);

            ///// 4.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr1 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result4 = Arr1.OrderBy(S => S.Length).ThenBy(S => S);
            //foreach (var item in Result4)
            //    Console.WriteLine(item);

            ///// 5.Sort first by word length and then by a case-insensitive sort of the words in an array.
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result5 = words.OrderBy(S => S.Length).ThenBy(S => S, new CustomComparer());
            //foreach (var item in Result5)
            //    Console.WriteLine(item);

            ///// 6.Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var Result6 = ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);
            //foreach (var item in Result6)
            //    Console.WriteLine(item);

            ///// 7.Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr2 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result7 = Arr2.OrderBy(S => S.Length).ThenByDescending(S => S, new CustomComparer());
            //foreach (var item in Result7)
            //    Console.WriteLine(item);

            ///// 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr3 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result8 = Arr3.Where(T => T[1] == 'i').Reverse();
            //foreach (var item in Result8)
            //    Console.WriteLine(item);
            #endregion

            #region Transformation Operators
            ///// 1. Return a sequence of just the names of a list of products.
            //var Result1 = ProductList.Select(P => P.ProductName);
            //foreach (var Product in Result1)
            //    Console.WriteLine(Product);

            ///// 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var Result2 = words.Select(W => new
            //{
            //    Uppercase = W.ToUpper(),
            //    Lowercase = W.ToLower(),
            //});
            //foreach (var result in Result2)
            //    Console.WriteLine(result);

            ///// 3.Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var Result3 = ProductList.Select(P => new
            //{
            //    P.ProductID,
            //    P.ProductName,
            //    Price = P.UnitPrice
            //});
            //foreach (var Result in Result3)
            //    Console.WriteLine(Result);

            ///// 4.Determine if the value of ints in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result4 = Arr.Select((V, I) => $"{V}:{V == I}");
            //foreach (var result in Result4)
            //    Console.WriteLine(result);

            ///// 5.Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var Result5 = from a in numbersA
            //              from b in numbersB
            //              where a < b
            //              select $"{a} is less than {b}";
            ////// or
            ////var Result5 = numbersA.SelectMany(N => numbersB, (a, b) => new {a, b})
            ////                      .Where(Num => Num.a < Num.b)
            ////                      .Select(Num => $"{Num.a} is less than {Num.b}");
            //foreach (var result in Result5)
            //    Console.WriteLine(result);

            ///// 6. Select all orders where the order total is less than 500.00.
            //var Result6 = CustomerList.SelectMany(C => C.Orders)
            //                         .Where(O => O.Total < 500.00m);
            //foreach (var result in Result6)
            //    Console.WriteLine(result);

            ///// 7. Select all orders where the order was made in 1998 or later.
            //var Result7 = CustomerList.SelectMany(C => C.Orders)
            //                          .Where(O => O.OrderDate.Year >= 1998);
            //foreach(var result in Result7) 
            //    Console.WriteLine(result);
            #endregion

            
        }
    }
}
