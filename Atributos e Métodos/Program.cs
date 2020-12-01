using System;

namespace Atributos_e_Métodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem jogador1 = new Personagem();
            jogador1.nome = "oKaiiN";
            jogador1.idade = 17;
            jogador1.armadura = "Kairoseki Armor";
            jogador1.IA = "Haki do Conquistador";

            Personagem jogador2 = new Personagem();
            jogador2.nome = "SnTyh";
            jogador2.idade = 15;
            jogador2.armadura = "Silver Armor";
            jogador2.IA = "Sword Attack";

            Console.Clear();
            Console.WriteLine($"Partida {jogador1.nome} VS {jogador2.nome}");
            Console.WriteLine($"Jogador 1 Armadura: {jogador1.armadura} || Jogador 2 Armadura: {jogador2.armadura}");
            Console.WriteLine($"Jogador 1 IA: {jogador1.IA} || Jogador 2 IA: {jogador2.IA}");

            //COMECE A LUTA

            int vidaDoJogador2 = jogador2.Defender(jogador1.Atacar2());

            if(vidaDoJogador2 <= 0){
                Console.WriteLine($"O Jogador Morreu");
            }else{
                Console.WriteLine($"Jogador 2 depois do ataque ficou com {jogador2.vida} de vida");
            }
        }
    }
}
