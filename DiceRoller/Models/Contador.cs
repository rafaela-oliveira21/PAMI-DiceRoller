using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Models
{
    internal class Contador
    {
        public int Sequencia;
        public int Pontos;
        public int Limite;
        public string Venceu;

        public void Jogar(Dice DadoJogador, int numeroSelecionado)
        {

            //Comparar se o selecionado é igual a facePraCima do dado do jogador
            if (numeroSelecionado == DadoJogador.FaceParaCima)
            {
                //Se for igual o jogador venceu
                Venceu = "Sim";
                Pontos++;//Somo um ponto

                if (Venceu == "Sim")
                {
                    Sequencia++;//Se ele tinha vencido o duelo anterior, soma 1 ponto na sequência
                }
            }
            //Se não, zera a sequência
            else
            {   //Perdeu Playboy
                Venceu = "Não";
                Sequencia = 0;
            }
        }
    }
}