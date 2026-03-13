using LINQ_Project.Data;
using System.Collections.Generic;
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

            #region Element Operators
            ///// 1. Get first Product out of Stock 
            //var Result1 = ProductList.FirstOrDefault(P => P.UnitsInStock == 0);
            //Console.WriteLine(Result1);

            ///// 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var Result2 = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);
            //Console.WriteLine(Result2);

            ///// 3.Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result3 = Arr.Where(N => N > 5).ElementAtOrDefault(1);
            //Console.WriteLine(Result3);
            #endregion

            #region Aggregate Operators
            ///// 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result1 = Arr.Count(N => N % 2 == 1);
            //Console.WriteLine(Result1);

            ///// 2. Return a list of customers and how many orders each has.
            //var Result2 = CustomerList.Select(C => new
            //{
            //    C.CustomerID,
            //    C.CustomerName,
            //    OrderCount = C.Orders.Count()
            //});
            //foreach (var result in Result2)
            //    Console.WriteLine(result);

            ///// 3. Return a list of categories and how many products each has
            //var Result3 = from P in ProductList
            //              group P by P.Category into CategoryGroup
            //              select new
            //              {
            //                  Category = CategoryGroup.Key,
            //                  ProductsCount = CategoryGroup.Count(),
            //              };
            //foreach (var result in Result3)
            //    Console.WriteLine(result);

            ///// 4. Get the total of the numbers in an array.
            //int[] Arr1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result4 = Arr1.Sum();
            //Console.WriteLine(Result4);

            //string[] Arr2 = File.ReadAllLines("dictionary_english.txt");
            ///// 5.Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //var Result5 = Arr2.Sum(W => W.Length);
            //Console.WriteLine(Result5);

            ///// 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var Result6 = Arr2.Min(W => W.Length);
            //Console.WriteLine(Result6);

            ///// 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var Result7 = Arr2.Max(W => W.Length);
            //Console.WriteLine(Result7);

            ///// 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var Result8 = Arr2.Average(W => W.Length);
            //Console.WriteLine(Result8);

            ///// 9. Get the total units in stock for each product category.
            //var Result9 = ProductList.GroupBy(P => P.Category)
            //                         .Select(C => new
            //                         {
            //                             Category = C.Key,
            //                             TotalUnitInStock = C.Sum(P => P.UnitsInStock)
            //                         });
            //foreach (var Result in Result9)
            //    Console.WriteLine(Result);

            ///// 10. Get the cheapest price among each category's products
            //var Result10 = from P in ProductList
            //               group P by P.Category into C
            //               select new
            //               {
            //                   Category = C.Key,
            //                   CheapestPrice = C.Min(P => P.UnitPrice)
            //               };
            //foreach (var Result in Result10)
            //    Console.WriteLine(Result);

            ///// 11. Get the products with the cheapest price in each category (Use Let)
            //var Result11 = from P in ProductList
            //               group P by P.Category into C
            //               let Cheap = C.Min(p => p.UnitPrice)
            //               from prod in C
            //               where prod.UnitPrice == Cheap
            //               select new
            //               {
            //                   Category = C.Key,
            //                   Product = prod.ProductName,
            //                   Price = Cheap
            //               };
            //foreach (var result in Result11)
            //    Console.WriteLine(result);

            ///// 12. Get the most expensive price among each category's products.
            //var Result12 = from P in ProductList
            //               group P by P.Category into C
            //               select new
            //               {
            //                   Category = C.Key,
            //                   ExpensivePrice = C.Max(P => P.UnitPrice)
            //               };
            //foreach (var Result in Result12)
            //    Console.WriteLine(Result);

            ///// 13. Get the products with the most expensive price in each category.
            //var Result13 = from P in ProductList
            //               group P by P.Category into C
            //               let Expensive = C.Max(p => p.UnitPrice)
            //               from prod in C
            //               where prod.UnitPrice == Expensive
            //               select new
            //               {
            //                   Category = C.Key,
            //                   Product = prod.ProductName,
            //                   Price = Expensive
            //               };
            ///*Result13 = ProductList.GroupBy(P => P.Category)
            //                      .Select(C => new
            //                      {
            //                          Category = C.Key,
            //                          Product = C.Where(P => P.UnitPrice == C.Max(p => p.UnitPrice)).Select(P => P.ProductName).FirstOrDefault(),
            //                          Price = C.Max(P => P.UnitPrice)
            //                      });*/
            //foreach (var result in Result13)
            //    Console.WriteLine(result);

            ///// 14.Get the average price of each category's products.
            //var Result14 = ProductList.GroupBy(P => P.Category)
            //                          .Select(C => new
            //                          {
            //                              Category = C.Key,
            //                              AveragePrice = C.Average(p => p.UnitPrice)
            //                          });
            //foreach(var Result in Result14)
            //    Console.WriteLine(Result);
            #endregion

            #region Set Operators
            ///// 1.Find the unique Category names from Product List
            //var Result1 = ProductList.GroupBy(P => P.Category)
            //                         .Select(C => new { Category = C.Key }).Distinct();
            //foreach (var Result in Result1)
            //    Console.WriteLine(Result);

            ///// 2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var Result2 = ProductList.Select(P => P.ProductName[0]).Union(CustomerList.Select(C => C.CustomerName[0]));
            //foreach (var Result in Result2)
            //    Console.WriteLine(Result);

            ///// 3. Create one sequence that contains the common first letter from both product and customer names.
            //var Result3 = ProductList.Select(P => P.ProductName[0]).Intersect(CustomerList.Select(C => C.CustomerName[0]));
            //foreach (var Result in Result3)
            //    Console.WriteLine(Result);

            ///// 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var Result4 = ProductList.Select(P => P.ProductName[0]).Except(CustomerList.Select(C => C.CustomerName[0]));
            //foreach (var Result in Result4)
            //    Console.WriteLine(Result);

            ///// 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var Result5 = ProductList.Select(P => P.ProductName[^3..]).Concat(CustomerList.Select(C => C.CustomerName[^3..]));
            //foreach (var Result in Result5)
            //    Console.WriteLine(Result);
            #endregion

            #region Partitioning Operators
            ///// 1. Get the first 3 orders from customers in Washington
            //var Result1 = CustomerList.Where(C => C.Region == "WA").SelectMany(C => C.Orders).Take(3);
            //foreach (var Result in Result1)
            //    Console.WriteLine(Result);

            ///// 2. Get all but the first 2 orders from customers in Washington.
            //var Result2 = CustomerList.Where(C => C.Region == "WA").SelectMany(C => C.Orders).Skip(2);
            //foreach (var Result in Result2)
            //    Console.WriteLine(Result);

            ///// 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result3 = numbers.TakeWhile((N, I) => N > I);
            //foreach (var result in Result3)
            //    Console.WriteLine(result);

            ///// 4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result4 = numbers1.SkipWhile(N => N % 3 != 0);
            //foreach (var result in Result4)
            //    Console.WriteLine(result);

            ///// 5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result5 = numbers2.SkipWhile((N, I) => N > I);
            //foreach (var result in Result5)
            //    Console.WriteLine(result);
            #endregion

            #region Quantifiers Operators
            /// 1.Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            string[] Arr2 = File.ReadAllLines("dictionary_english.txt");
            var Result1 = Arr2.Any(W => W.Contains("ei"));
            Console.WriteLine(Result1);

            /// 2.Return a grouped a list of products only for categories that have at least one product that is out of stock.
            var Result2 = ProductList.GroupBy(P => P.Category)
                                     .Where(C => C.Any(p => p.UnitsInStock == 0));
            foreach (var Result in Result2)
            {
                Console.WriteLine(Result.Key);
                foreach (var product in Result)
                    Console.WriteLine($"---{product}");
            }

            /// 3. Return a grouped a list of products only for categories that have all of their products in stock.
            var Result3 = ProductList.GroupBy(P => P.Category)
                                     .Where(C => C.All(p => p.UnitsInStock > 0));
            foreach (var Result in Result3)
            {
                Console.WriteLine(Result.Key);
                foreach (var product in Result)
                    Console.WriteLine($"---{product}");
            }
            #endregion
        }
    }
}
