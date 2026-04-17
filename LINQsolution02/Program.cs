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

        }
    }
}
