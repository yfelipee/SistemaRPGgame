using JogoRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Heroi : Personagem
{
    public Heroi(int hp, int ataque, int defesa) : base(hp, ataque, defesa)
    {

    }

    public void Atacar(Monstro monstro, bool danoDobrado)
    {
        Console.WriteLine("Heroi atacou mostro");

        int dano = this.ataque;

        if (danoDobrado)
        {
            dano = dano * 2;
        }

        monstro.ReceberDano(dano);
    }
}
