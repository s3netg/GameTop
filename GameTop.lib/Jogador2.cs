using gametop.Interface;
using GameTop.lib;

namespace GameTop.lib
{
    public class Jogador2 : iJogador
    {
        private readonly string _nome;

        public Jogador2(string nome)
        {
            _nome = nome;
        }
        string iJogador.Chuta()
        {
            return $"{_nome} esta pateando \n"; 
        }

        string iJogador.Corre()
        {
            return $"{_nome} esta corriendo \n";
        }

        string iJogador.Passe()
        {
            return $"{_nome} esta pasando \n";;
        }
    }
}