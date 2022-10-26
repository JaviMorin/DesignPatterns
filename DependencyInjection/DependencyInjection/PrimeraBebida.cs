namespace DependencyInjection
{
    public class PrimeraBebida: InterfaceBebida
    {
        public void Preparar()
        {
            Console.WriteLine("Se hace una primera bebida");
        }
    }
}
