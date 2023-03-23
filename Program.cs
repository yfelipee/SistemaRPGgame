namespace JogoRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guerreiro guerreiro = new Guerreiro(500, 30, 20);
            Arqueiro arqueiro = new Arqueiro(2, 500, 10, 20);
            Mago mago = new Mago(100, 200, 30, 10);

            Monstro monstro = new Monstro(1000, 25, 10);

            for (int i = 0; i < 10; i++)
            {
                guerreiro.Atacar(monstro);
                arqueiro.Atacar(monstro);
                mago.Atacar(monstro);

                monstro.Atacar(guerreiro);
                monstro.Atacar(arqueiro);
                monstro.Atacar(mago);
            }

        }
    }
}