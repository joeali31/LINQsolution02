namespace LINQsolution02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //var TopProducts = Source.ProductList.OrderByDescending(p => p.UnitPrice).Take(3);

            //foreach (var item in TopProducts)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Question02
            //int pageSize = 5;
            //int pageNumber = 2;

            //var Products = Source.ProductList.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            //foreach (var item in Products)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Question03
            //var Products = Source.ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25M);

            //foreach (var item in Products)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Question04
            //var Products = Source.ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);

            //Console.WriteLine(Products);
            #endregion


            #region Question05
            //int[] ids = { 3, 9, 13, 18 };

            //Console.WriteLine(ids.Contains(9));
            #endregion



            #region Question06
            //var Products = Source.ProductList.GroupBy(p => p.Category);

            //foreach (var item in Products)
            //{
            //    Console.WriteLine($"Category: {item.Key} , Count: {item.Count()}");

            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }

            //    Console.WriteLine("=======================================================");
            //}
            #endregion



            #region Question07
            //var Products = Source.ProductList.GroupBy(p => p.Category);

            //foreach (var item in Products)
            //{
            //    Console.WriteLine($"Category: {item.Key} , Count: {item.Count()}");

            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }

            //    Console.WriteLine("=======================================================");
            //}
            #endregion

            #region Question08
            //var Products = Source.ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 3);

            //foreach (var item in Products)
            //{
            //    Console.WriteLine($"Category: {item.Key} , Count: {item.Count()}");

            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }

            //    Console.WriteLine("=======================================================");
            //}
            #endregion

            #region Question09
            //var customers = from c in Source.CustomerList
            //                group c by c.Country
            //                into g
            //                select new {Country = g.Key , Count = g.Count() , TotalOrderValue = g.Sum(i => i.Orders.Length) };

            //foreach (var item in customers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question10
            //var UnitsInStock = Source.ProductList.Sum(p => p.UnitsInStock);

            //Console.WriteLine(UnitsInStock);
            #endregion

            #region Question11
            //var Cheapest = Source.ProductList.MinBy(p => p.UnitPrice);
            //var Expensive = Source.ProductList.MaxBy(p => p.UnitPrice);

            //Console.WriteLine(Cheapest);
            //Console.WriteLine(Expensive);

            #endregion

            #region Question12
            //var categories  = Source.ProductList.Select(p => p.Category).Distinct();

            //foreach (var item in categories)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Question13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var res = setA.Except(setB);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Question14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var res = list1.Except(list2 , StringComparer.OrdinalIgnoreCase);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Question15
            //var Products = Source.ProductList.ToDictionary(p => p.ProductID);

            //Console.WriteLine(Products[18]);

            #endregion

            #region Question16
            //var Products = Source.ProductList.First(p => p.UnitPrice > 50M);

            //Console.WriteLine(Products);

            #endregion

            #region Question17
            //var Products = Source.ProductList.FirstOrDefault(p => p.UnitPrice > 50000000M);

            //Console.WriteLine(Products);

            #endregion

            #region Question18
            //var table7 = Enumerable.Range(1, 10).Select(i => 7 * i);

            //foreach (var val in table7)
            //{
            //    Console.WriteLine(val);
            //}
            #endregion

            #region Question19
            //var even = Enumerable.Range(1, 30).Where(e => e % 2 == 0);

            //foreach (var item in even)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question20
            //var products = Source.ProductList.Select(p => p.ProductName).Take(3);
            //var Customers = Source.CustomerList.Select(c => c.CompanyName).Take(3);

            //var res = products.Concat(Customers);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Question21
            //var paired  = Source.ProductList.Zip(Source.CustomerList,(p , c) => $"{p.ProductName} sold to {c.CompanyName}");

            //foreach (var item in paired)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

        }
    }
}
