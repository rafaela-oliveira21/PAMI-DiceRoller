namespace DiceRoller.Models
{
    public class Dice
    {
        //property
        //Atributos - utilizamos property nesse caso. (public tipo Nome)
        public int FaceParaBaixo;
        public int FaceParaCima;
        public int QuantidadeDeFaces;

        public Dice()
        {
            QuantidadeDeFaces = 6;
        }
        public Dice(int faces)
        {
            QuantidadeDeFaces = faces;
        }

        //Método responsável por sortear um número
        /// <summary>
        /// Método utilizado para sortear um dado
        /// </summary>
        public void Sortear()
        {
            //Gero um numero aleatório de 1 a 6
            Random random = new Random();
            //Jogo esse número na face para cima
            FaceParaCima = random.Next(1, QuantidadeDeFaces + 1);
            //FaceParaBaixo = random.Next(1, 7);  -- Método mais simples mesma usabilidade do método de cima
            // A soma mágica = o menor lado possível + o maior
            // A soma mágica = 1 + quantidadeDeFaces
            FaceParaBaixo = QuantidadeDeFaces + 1 - FaceParaCima;
            //Jogo um número na face para cima
            //Calcular a face para baixo
            
            /*
            int lados;
            int numeracao;
            int numeroSorteado;

            public Dice(int quantidadeDeLados) { 
                lados = quantidadeDeLados;
            }
            public int Rolar()
            {
                numeroSorteado = new Random().Next(1, lados + 1);
                return numeroSorteado;
            }
            */
        }

    }
}

