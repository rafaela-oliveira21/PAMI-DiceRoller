using CommunityToolkit.Mvvm.ComponentModel;
using DiceRoller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.ViewModels
{
    //Inserido o public e o partial
    public partial class GameViewModels : ObservableObject //É nescessário importar,instalar npvamente para funcionar.
    {
        //Toda classe na ViewModel vai ser parcial
        // Toolkit serve como get e set, por isso usamos "[ObservableProperty]"
        //Notifica a classe Observable


        [ObservableProperty]
        public string diceImage; //Variável tipo string para adcionar uma imagem

        [ObservableProperty]
        public string nomeUsuario;

        [ObservableProperty]
        public int selectValue;

        public GameViewModels() {
            diceImage = "dice1.png";
            NomeUsuario = "Eu";
        }

        public void Jogar()
        {
            //Sortear um dado
            Dice dice = new Dice();                    //Instanciou um novo dado
            dice.Sortear();
            if ( dice.FaceParaCima == SelecteValue) //posso usar em qualquer situação
            {

            }

            //Verificar qual face está selecionada
            //Verificar se o usuário escolheu certo
            //Exibir uma mensagem na tela 

        }



    }

}
