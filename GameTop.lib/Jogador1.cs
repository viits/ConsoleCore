using GameTop.Interface;

namespace GameTop.lib
{
    public class Jogador1 : iJogador
    {
        public  string nome { get; set; }

        public Jogador1(string nome = "Ronaldo"){
            this.nome = nome;
        }

        public string Chuta()
        {
            return $"{nome} está chutando";
        }
        public string Corre()
        {
           return $"{nome} está correndo";
        }

        public string Passe()
        {
            return $"{nome} está passando";
        }

    }
}