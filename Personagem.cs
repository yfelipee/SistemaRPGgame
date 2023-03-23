using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{
    public class Personagem
    {
        public int hp;
        public int ataque;
        public int defesa;

        public Personagem(int hp, int ataque, int defesa)
        {
            this.hp = hp;
            this.ataque = ataque;
            this.defesa = defesa;
        }

        public void ReceberDano(int forcaAtaque)
        {
            int dano = forcaAtaque + this.defesa;

            if (dano > this.hp)
            {
                Console.WriteLine("Morreu");
            }
            else
            {
                this.hp = this.hp - dano;
                Console.WriteLine("Dano sofrido: " + dano + ", sobrou de hp: " + this.hp);
            }
        }
    }
}
