namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var helper = new ProductHelper();
            Console.WriteLine(helper.ObtenerEtiquetaProducto(1, "Producto A", 19.99m));

            var p = new Problema2();
            Console.WriteLine(p.CrearResumenVenta(12345, "Producto A", 3, 19.99m));

            var p3 = new Problema3();
            Console.WriteLine(p3.CompararCopias(100, new Product("Producto A")));

            var p4 = new Problema4();
            Console.WriteLine(p4.CalcularPromedio(85, 90, null));

            var p5 = new Problema5();
            Sale s1 = new RetailSale(1000);
            Sale s2 = new WholesaleSale(1000);
            Console.WriteLine(p5.ObtenerImporteFinal(s1)); // 1000
            Console.WriteLine(p5.ObtenerImporteFinal(s2)); // 900

            var p6 = new Problema6();
            Console.WriteLine(p6.NormalizarCodigoProducto(" ab 123 x "));
        }
    }
}