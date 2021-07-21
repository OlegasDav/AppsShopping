using System;

namespace Lecture_Parduotuve
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|Sveiki atvyke i ObjProgram parduotuve!|");
            Console.WriteLine("--------------------------------");

            var parduotuve = new Parduotuve();

            var salyga = true;

            while (salyga)
            {
                Console.Write("\nPasirinkite ka norite nuveikti parduotuveje: \n" +
                    "1 - Parodyti, ka galima nusipirkti parduotuveje; \n" +
                    "2 - Nusipirkti prekes; \n" +
                    "3 - Papildyti parduotuve prekemis. \n\n");

                Console.Write("Jusu veiksmas: ");
                var veiksmas = Convert.ToInt32(Console.ReadLine());

                switch (veiksmas)
                {
                    case 1:
                        Console.WriteLine("\nParduotuveje yra:");

                        parduotuve.List();

                        break;
                    case 2:
                        var salyga2 = true;

                        while (salyga2){

                            Console.Write("\nPasirinkite kokias prekes norite nusipirkti: \n" +
                            "1 - Saldainius; \n" +
                            "2 - Knyga; \n" +
                            "3 - Puoduka. \n\n");
                            Console.Write("Jusu pasirinkta preke: ");

                            var preke = Convert.ToInt32(Console.ReadLine());

                            parduotuve.Buy(preke);
                            
                            Console.Write("\nAr noritumete baigti apsipirkima (y/n): ");
                            var atsakymas2 = Console.ReadLine();
                            salyga2 = atsakymas2 == "n";
                        }

                        break;
                    case 3:
                        var salyga3 = true;

                        while (salyga3)
                        {

                            Console.Write("\nPasirinkite kokiomis prekemis norite papildyti parduotuve: \n" +
                            "1 - Saldainiais; \n" +
                            "2 - Knyga; \n" +
                            "3 - Puoduku. \n\n");
                            Console.Write("Jusu pasirinkta preke: ");

                            var preke = Convert.ToInt32(Console.ReadLine());

                            parduotuve.Add(preke);

                            Console.Write("\nAr noritumete baigti parduotuves pildyma (y/n): ");
                            var atsakymas3 = Console.ReadLine();
                            salyga3 = atsakymas3 == "n";
                        }

                        break;
                    default:
                        Console.WriteLine("Negalima atlikti tokio veiksmo. Bandykite dar karta!");
                        break;
                }
                Console.Write("\nAr noritumete iseiti is parduotuves (y/n): ");
                var atsakymas = Console.ReadLine();
                salyga = atsakymas == "n";
            }
        }
    }
}
