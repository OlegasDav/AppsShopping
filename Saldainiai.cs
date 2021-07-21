using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Parduotuve
{
    class Saldainiai : Produktai
    {
        public Saldainiai()
        {
            _kaina = 3;
        }

        public override void DecreaseAmount(int kiekis)
        {
            if ((_kiekis - kiekis) >= 0)
            {
                _kiekis -= kiekis;
            }
            else
            {
                Console.WriteLine($"Atsiprasome, siuo metu parduotuveje like tik {_kiekis} kg saldainiu.");
            }
        }

        public override void IncreaseAmount(int kiekis)
        {
            _kiekis += kiekis;
        }

        public override string ToString()
        {
            return $"{_kiekis} kg saldainiu; kg kaina {_kaina} Eur";
        }
    }
}
