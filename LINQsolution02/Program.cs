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


        }
    }
}
