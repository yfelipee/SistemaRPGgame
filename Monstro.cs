using JogoRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Monstro : Personagem
{
    public Monstro(int hp, int ataque, int defesa) : base(hp, ataque, defesa)
    {
    }

    public void Atacar(Heroi heroi)
    {
        Console.WriteLine("Monstro atacou heroi");
        heroi.ReceberDano(this.ataque);
    }
}