using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Parduotuve
{
    class Puodukas : Produktai
    {
        public Puodukas()
        {
            _kaina = 4;
        }

        public override void DecreaseAmount(int kiekis)
        {
            if ((_kiekis - kiekis) >= 0)
            {
                _kiekis -= kiekis;
            }
            else
            {
                Console.WriteLine($"Atsiprasome, siuo metu parduotuveje like tik {_kiekis} vnt. puoduku.");
            }
        }

        public override void IncreaseAmount(int kiekis)
        {
            _kiekis += kiekis;
        }

        public override string ToString()
        {
            return $"{_kiekis} vnt. puoduku; vnt. kaina {_kaina} Eur";
        }
    }
}
