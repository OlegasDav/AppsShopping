using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Parduotuve
{
    interface IParduotuve
    {
        void List();

        void Buy(int preke);

        void Add(int preke);
    }
}
