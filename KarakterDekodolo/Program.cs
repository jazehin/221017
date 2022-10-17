namespace KarakterDekodolo
{
    internal class Program
    {
        static List<Karakter> bank = new();
        static List<Karakter> dekodolt = new();
        static char inputBetu;
        const string valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static void Main(string[] args)
        {
            bank = F04("../../../res/bank.txt");
            F05();
            F06();
            F07();
            F08();
        }

        private static void F08()
        {
            Console.WriteLine("8. feladat: Dekódolás");
            dekodolt = F04("../../../res/dekodol.txt");

            foreach (Karakter betu in dekodolt)
            {
                foreach (Karakter bankBetu in bank)
                {
                    if (betu.Felismer(bankBetu))
                        betu.Betu = bankBetu.Betu;
                }

                Console.Write(betu.Betu);
            }


        }

        private static void F07()
        {
            int index = 0;
            while (index < bank.Count && bank[index].Betu != inputBetu)
                index++;

            Console.WriteLine("7. feladat:");

            if (index >= bank.Count)
            {
                Console.WriteLine("Nincs ilyen karakter a bankban!");
            }
            else
            {
                for (int s = 0; s < bank[index].Matrix.GetLength(0); s++)
                {
                    for (int o = 0; o < bank[index].Matrix.GetLength(1); o++)
                    {
                        Console.Write((bank[index].Matrix[s, o] == true ? 'X' : ' '));
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void F06()
        {
            string be = "";
            while (be.Length != 1 || !valid.Contains(be[0]))
            {
                Console.Write("6. feladat: Kérek egy angol nagybetűt: ");
                be = Console.ReadLine();
            }
            inputBetu = char.Parse(be);
        }

        private static void F05()
        {
            Console.WriteLine($"5. feladat: Karakterek száma: {bank.Count}");
            
        }

        private static List<Karakter> F04(string eleresiUt)
        {
            List<Karakter> karakterLista = new();

            using StreamReader sr = new(@$"{eleresiUt}");

            while (!sr.EndOfStream)
            {
                char betu = char.Parse(sr.ReadLine());
                bool[,] matrix = new bool[7, 4];

                for (int s = 0; s < matrix.GetLength(0); s++)
                {
                    string sor = sr.ReadLine();
                    for (int o = 0; o < matrix.GetLength(1); o++)
                    {
                        matrix[s,o] = sor[o] == '1';
                    }
                }

                karakterLista.Add(new(betu, matrix));
            }

            return karakterLista;
        }
    }
}