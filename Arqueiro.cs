using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Arqueiro : Heroi
{
    int qtdFlechas;

    public Arqueiro(int qtdFlechas, int hp, int ataque, int defesa) : base(hp, ataque, defesa)
    {
        this.qtdFlechas = qtdFlechas;
    }

    public void Atacar(Monstro monstro)
    {
        if (qtdFlechas > 0)
        {
            qtdFlechas--;
            base.Atacar(monstro, false);
        }
        else
        {
            Console.WriteLine("Quantidade de flechas insuficiente");
        }
    }
}
