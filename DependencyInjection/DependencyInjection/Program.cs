namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfaceBebida oBebida = new PrimeraBebida();
            Camarero oCamarero = new Camarero(oBebida);
            oCamarero.Preparar();

        }
    }
}
