namespace lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _context = new BasicApiContext();
            #region CRUD
            #region create

            //var product = new Product { Id = 0, Name = "TestProduct", Sku = "123123" };

            //_context.Products.Add(product);
            //_context.SaveChanges();
            #endregion

            #region Read
            //var dbProduct = _context.Products.FirstOrDefault(p => p.Name.Contains("Test"));
            //Console.WriteLine(dbProduct != null ? $"{dbProduct.Id} - {dbProduct.Name} - {dbProduct.Sku}" : "No product with this name");
            #endregion

            #region Update
            //var dbProduct = _context.Products.FirstOrDefault(p => p.Name.Contains("Test"));

            //try
            //{
            //    dbProduct.Name = "UpdateedTestProduct";
            //    _context.Products.Update(dbProduct);
            //    _context.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Delete
            var dbProduct = _context.Products.FirstOrDefault(p => p.Name.Contains("Test"));

            try
            {
                _context.Remove(dbProduct);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

            #endregion
        }
    }
}
