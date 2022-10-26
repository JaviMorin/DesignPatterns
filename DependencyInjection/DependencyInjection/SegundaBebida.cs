namespace DependencyInjection
{
    public class SegundaBebida: InterfaceBebida
    {
        public void Preparar()
        {
            Console.WriteLine("Se hace una segunda bebida");
        }
    }
}
