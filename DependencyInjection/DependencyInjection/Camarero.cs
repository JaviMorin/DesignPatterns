namespace DependencyInjection
{
    public class Camarero
    {
        InterfaceBebida bebida;
        public Camarero(InterfaceBebida bebida)
        {
            this.bebida = bebida;
        }
        public void Preparar()
        {
            this.bebida.Preparar();
        }
    }
}
