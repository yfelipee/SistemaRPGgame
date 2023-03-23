using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Guerreiro : Heroi
{
    public Guerreiro(int hp, int ataque, int defesa) : base(hp, ataque, defesa) { }

    public void Atacar(Monstro monstro)
    {
        base.Atacar(monstro, false);
        base.Atacar(monstro, false);
    }
}

