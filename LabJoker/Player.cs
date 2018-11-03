using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LabJoker
{
    public class Player : IStorable
    {
        private const int One = 1;
        private const int TwentyOne = 21;
        private const int FourtySix = 46;
        private const int Players = 5;

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
                    throw new ArgumentNullException("PlayerList can not be null");
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





        Random rand = new Random();

        public Player(List<int> playerlist, int playerJoker)
        {
            List = playerlist;
            Joker = playerJoker;
        }

        public Player()
        {
            List = new List<int>();
            Joker = rand.Next(One, TwentyOne);
        }
        //Random Player Joker Method
        public int GenerateJoker()
        {
            Console.WriteLine("Player Random Choice Joker");
            Random joker = new Random();
            Joker = joker.Next(One, TwentyOne);
            Console.WriteLine(Joker);
            return Joker;
        }
        //Input Player Joker Method
        public int UserJokerManual()
        {
            Console.WriteLine("Type Your Joker");
            Joker = Convert.ToInt32(Console.ReadLine());

            if (Joker >= One && Joker < TwentyOne)
                Joker = Joker;

            return Joker;
        }
        //Method which fills the List Of the Player with 5 Numbers
        public List<int> PlayerInputs()
        {
            List = new List<int>();
            Console.WriteLine("Type your Numbers");
            for (int i = 0; i < Players; i++)
            {
                int userInputs = Convert.ToInt32(Console.ReadLine());
                if (userInputs >= One && userInputs < FourtySix)
                {
                    if (!List.Contains(userInputs))
                        List.Add(userInputs);
                    
                }
                else
                {
                    i--;
                    Console.WriteLine("Type again");
                }
                    

            }
            return List;
        }
        //Method which fills with Random Number the List of The Player
        public List<int> GenerateRaNdomNumbers()
        {

                List = new List<int>();
                Random rand = new Random();
                for (int j = 0; j < Players; j++)
                {
                    int randomNum = rand.Next(One, FourtySix);
                    if (!List.Contains(randomNum))
                        List.Add(randomNum);
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
