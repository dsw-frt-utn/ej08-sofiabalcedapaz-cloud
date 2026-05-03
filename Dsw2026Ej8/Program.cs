namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var helper = new ProductHelper();
            Console.WriteLine(helper.ObtenerEtiquetaProducto(1, "Producto A", 19.99m));
        }
    }
}
