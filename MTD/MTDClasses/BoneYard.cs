using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTDClasses
{
    class BoneYard
    {
        List<Domino> dominos;
        public static Random rng = new Random();

        public BoneYard(int maxDots)
        {
            dominos = new List<Domino>();
        }

        /// <summary>
        /// Fisher Yates Shuffle
        ///  Usage : List<Product> products = GetProducts();
        ///     products.Shuffle();
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>

        public void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int temp = rng.Next(n + 1);
                T value = list[temp];
                list[temp] = list[n];
                list[n] = value;
            }
           
        }

        public bool IsEmpty()
        {
            if (dominos.Count < 0)
            {
                return true;
            }
            else
                return false;
        }

        public int DominosRemaining
        {
            get
            {
                return dominos.Count;
            }
        }
/*
        public Domino Draw()
        {
            // draw random domino
            // if you can play it, play it, else if not keep in hand
        }
*/        
        public Domino this[int i]
        {
            get
            {
                if (i < 0 || i > dominos.Count)
                {
                    throw new ArgumentOutOfRangeException("i");
                }
                return dominos[i];
            }
            set { dominos[i] = value; }
        }

        public override string ToString()
        {
            string output = "";
            foreach (Domino d in dominos)
            {
                output += d.ToString() + "\n";
            }
            return output;
        }
        
    }
}
