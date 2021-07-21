using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Parduotuve
{
    abstract class Produktai
    {
        protected int _kiekis;
        protected int _kaina;

        public Produktai()
        {
            _kiekis = 100;
        }

        public abstract void DecreaseAmount(int kiekis);

        public abstract void IncreaseAmount(int kiekis);
    }
}
