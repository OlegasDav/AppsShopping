using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Parduotuve
{
    class Parduotuve : IParduotuve
    {
        private Saldainiai _saldainiai;
        private Knyga _knyga;
        private Puodukas _puodukas;

        public Parduotuve()
        {
            _saldainiai = new Saldainiai();
            _knyga = new Knyga();
            _puodukas = new Puodukas();
        }

        public void List()
        {
            Console.WriteLine(_saldainiai.ToString());
            Console.WriteLine(_knyga.ToString());
            Console.WriteLine(_puodukas.ToString());
        }

        public void Buy(int preke)
        {
            switch (preke)
            {
                case 1:
                    Console.Write("\nIveskite, kiek kg saldainiu norite nupirkti: ");

                    var kiekisSaldainiu = Convert.ToInt32(Console.ReadLine());

                    _saldainiai.DecreaseAmount(kiekisSaldainiu);

                    break;
                case 2:
                    Console.Write("\nIveskite, kiek vnt. knygu norite nupirkti: ");

                    var kiekisKnygu = Convert.ToInt32(Console.ReadLine());

                    _knyga.DecreaseAmount(kiekisKnygu);

                    break;
                case 3:
                    Console.Write("\nIveskite, kiek vnt. puoduku norite nupirkti: ");

                    var kiekisPuoduku = Convert.ToInt32(Console.ReadLine());

                    _puodukas.DecreaseAmount(kiekisPuoduku);

                    break;
                default:
                    Console.WriteLine("\nTokios prekes nera parduotuveje.");
                    break;
            }
        }

        public void Add(int preke)
        {
            switch (preke)
            {
                case 1:
                    Console.Write("\nIveskite, kiek kg saldainiu norite papildyti parduotuve: ");

                    var kiekisSaldainiu = Convert.ToInt32(Console.ReadLine());

                    _saldainiai.IncreaseAmount(kiekisSaldainiu);

                    break;
                case 2:
                    Console.Write("\nIveskite, kiek vnt. knygu norite papildyti parduotuve: ");

                    var kiekisKnygu = Convert.ToInt32(Console.ReadLine());

                    _knyga.IncreaseAmount(kiekisKnygu);

                    break;
                case 3:
                    Console.Write("\nIveskite kiek vnt. puoduku norite papildyti parduotuve: ");

                    var kiekisPuoduku = Convert.ToInt32(Console.ReadLine());

                    _puodukas.IncreaseAmount(kiekisPuoduku);

                    break;
                default:
                    Console.WriteLine("\nPasirinkta neteisinga preke.");
                    break;
            }
        }
    }
}
