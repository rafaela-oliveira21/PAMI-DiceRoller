<<<<<<< HEAD
﻿using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 39f76a84859c1677f03556d7927ea9e56f5201e5

namespace DiceRoller.Models
{
    public class Dice
    {
<<<<<<< HEAD
=======
        /*
            //property
            public string LadoSorteado;
            public int FaceParaCima;
            public int FaceParaBaixo;
            public int QuantidadeDeFaces;

            //add agora
            public Dice()
            {
                QuantidadeDeFaces = 6;
            }
            //add agora
            public Dice(int faces)
            {
                QuantidadeDeFaces = faces;
            }

            public string Roller(int pickerSelect)
            {
                Random random = new Random();
                // FaceParaCima = random.Next(1, 7);
                FaceParaCima = random.Next(1, QuantidadeDeFaces + 1); //add agora

                // FaceParaBaixo = 7 - FaceParaCima;
                FaceParaBaixo = 1 + QuantidadeDeFaces - FaceParaCima;



                if (FaceParaCima == pickerSelect)
                {
                    LadoSorteado = "Você acertou!";
                }
                else
                {
                    LadoSorteado = "Você errou!";
                }

                return LadoSorteado;
            }
        */

>>>>>>> 39f76a84859c1677f03556d7927ea9e56f5201e5
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
        /// Método responsável por sortear um dado
        /// </summary>
        public void Sortear()
        {
            //Gero um numero aleatório de 1 a 6
            Random random = new Random();
            //Jogo esse número na face para cima
            FaceParaCima = random.Next(1, QuantidadeDeFaces + 1);
            // A soma mágica = o menor lado possível + o maior
            // A soma mágica = 1 + quantidadeDeFaces
            FaceParaBaixo = QuantidadeDeFaces + 1 - FaceParaCima;
            //Calcular a face para baixo
        }

<<<<<<< HEAD
        /*
            //property
            public string LadoSorteado;
            public int FaceParaCima;
            public int FaceParaBaixo;
            public int QuantidadeDeFaces;

            //add agora
            public Dice()
            {
                QuantidadeDeFaces = 6;
            }
            //add agora
            public Dice(int faces)
            {
                QuantidadeDeFaces = faces;
            }

            public string Roller(int pickerSelect)
            {
                Random random = new Random();
                // FaceParaCima = random.Next(1, 7);
                FaceParaCima = random.Next(1, QuantidadeDeFaces + 1); //add agora

                // FaceParaBaixo = 7 - FaceParaCima;
                FaceParaBaixo = 1 + QuantidadeDeFaces - FaceParaCima;



                if (FaceParaCima == pickerSelect)
                {
                    LadoSorteado = "Você acertou!";
                }
                else
                {
                    LadoSorteado = "Você errou!";
                }

                return LadoSorteado;
            } */
=======
>>>>>>> 39f76a84859c1677f03556d7927ea9e56f5201e5
    }
}