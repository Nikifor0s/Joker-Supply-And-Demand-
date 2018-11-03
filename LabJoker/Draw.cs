using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LabJoker
{
    public class Draw : IStorable
    {
        public const int One = 1;
        public const int TwentyOne = 21;
        public const int FourtySix = 46;
        public const int Draws = 5;

        private List<int> list;
        public List<int> List
        {
            get
            {
                return list;
            }
            set
            {
                if (value.Equals(null))
                    throw new ArgumentNullException("DrawList can not be null");
                list = value;
            }
        }
        private int joker;
        public int Joker
        {
            get
            {
                return joker;
            }
            set
            {
                if (value.Equals(null))
                    throw new ArgumentNullException("Joker can not be null");
                joker = value;
            }
        }


        public int MostFrequentJoker { get ; set ; }

        public Draw()
        {            
            
        }

        //Constrains for Draw Joker Random Number
        public int GenerateJoker()
        {
            Console.WriteLine("Draw Joker");
            Random joker = new Random();
            this.Joker = joker.Next(One, TwentyOne);
            Console.WriteLine(Joker);
            return Joker;

        }
        //Constrains For Draw Random List Which Contains 5 Numbers
        public List<int> GenerateRaNdomNumbers()
        {
                List = new List<int>();
                var rand = new Random();
                Console.WriteLine("Draw");

                
                for (int j = 0; j < Draws; j++)
                {
                    int randomNum = rand.Next(One, FourtySix);
                    if (!List.Contains(randomNum))
                    {
                        List.Add(randomNum);
                    }
                       

                    else
                        j--;
                }
                foreach (int num in List)
                {
                    Console.WriteLine(num);
                }
            return List;
        } 
    }
}
