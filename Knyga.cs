using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Parduotuve
{
    class Knyga : Produktai
    {
        public Knyga()
        {
            _kaina = 5;
        }

        public override void DecreaseAmount(int kiekis)
        {
            if ((_kiekis - kiekis) >= 0)
            {
                _kiekis -= kiekis;
            }
            else
            {
                Console.WriteLine($"Atsiprasome, siuo metu parduotuveje like tik {_kiekis} vnt. knygu.");
            }
        }

        public override void IncreaseAmount(int kiekis)
        {
            _kiekis += kiekis;
        }

        public override string ToString()
        {
            return $"{_kiekis} vnt. knygu; vnt. kaina {_kaina} Eur";
        }
    }
}
