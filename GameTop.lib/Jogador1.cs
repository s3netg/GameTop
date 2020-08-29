using gametop.Interface;

namespace GameTop.lib
{
    public class Jogador1:iJogador{
       public readonly string _nome;
       public Jogador1(string nome="Ronaldo")
       {
            _nome = nome;
        }
       
        public string Chuta ()
        {
            return $"{_nome} esta chutando \n";
        }
        public string Corre(){
            return $"{_nome} esta correndo \n";

        }
        public string Passe(){

            return $"{_nome} esta passando\n";

        }

   }
}