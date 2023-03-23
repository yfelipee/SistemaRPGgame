using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Mago : Heroi
{
    int mana;

    public Mago(int mana, int hp, int ataque, int defesa) : base(hp, ataque, defesa)
    {
        this.mana = mana;
    }

    public void Atacar(Monstro monstro)
    {
        if (mana > 0)
        {
            mana = mana - 40;
            base.Atacar(monstro, true);
        }
        else
        {
            Console.WriteLine("Mana insuficiente");
        }
    }
}
