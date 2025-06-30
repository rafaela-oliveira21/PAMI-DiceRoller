using System.Collections.Generic;
<<<<<<< HEAD
using System.Threading.Tasks;
using System.Linq;
using System.Text;
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 39f76a84859c1677f03556d7927ea9e56f5201e5

namespace DiceRoller.Models
{
    public class Sequencia
    {
<<<<<<< HEAD
=======

>>>>>>> 39f76a84859c1677f03556d7927ea9e56f5201e5
        private int playerPoint = 0;
        private int streak = 0;

        public int PlayerPoint { get => playerPoint; set => playerPoint = value; }
        public int Streak { get => streak; set => streak = value; }

<<<<<<< HEAD
=======

>>>>>>> 39f76a84859c1677f03556d7927ea9e56f5201e5
        public bool CheckWinner(int LadoSorteado, int ladoEscolhido)
        {
            if (LadoSorteado == ladoEscolhido)
            {
                PlayerPoint++;
                Streak++;
                return true;
            }
            else
            {
                Streak = 0;
                return false;
            }
<<<<<<< HEAD
        }
=======

        }


>>>>>>> 39f76a84859c1677f03556d7927ea9e56f5201e5
    }
}