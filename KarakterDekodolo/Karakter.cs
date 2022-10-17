using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarakterDekodolo
{
    internal class Karakter
    {
        private char _betu;
        private bool[,] _matrix;

        public char Betu { get => _betu; set => _betu = value; }
        public bool[,] Matrix { get => _matrix; set => _matrix = value; }

        public Karakter(char betu, bool[,] matrix)
        {
            Betu = betu;
            Matrix = matrix;
        }

        public bool Felismer(Karakter felismerendo)
        {
            bool igaz = true;

            for (int x = 0; x < Matrix.GetLength(0); x++)
            {
                for (int y = 0; y < Matrix.GetLength(1); y++)
                {
                    if (Matrix[x, y] != felismerendo.Matrix[x, y])
                        return false;
                }
            }
            return true;
        }
    }
}
