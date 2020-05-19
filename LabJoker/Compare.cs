using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabJoker
{
    class Compare
    {


		//this is a comment
        public List<int> Comparison(Player player,  Draw draw)
        {
            var counters = new List<int>();

            //Counters Jokers and Lists
            var resultJoker = 0;
            var counter = 0;
            //Compare if Numbers Exist in both list with help of The Counter: counter
            foreach (var number in player.List)
            {
                if (draw.List.Contains(number))
                    counter++;

            }
            //Compare if Player Joker is Equal With Draw Joker with Help of the Counter : resultJoker
            if (draw.Joker.Equals(player.Joker))
                resultJoker++;
            counters.Add(counter);
            counters.Add(resultJoker);

            return counters;
        }

        public Category AddCategory (List<int> resultsComparison)
        {
            Category category = new Category();
            if (resultsComparison[0].Equals(5) && resultsComparison[1].Equals(1))
            {
                category.FivePlusOne += 1;
            }
            else if (resultsComparison[0].Equals(5))
            {
                category.Five += 1;
            }
            else if (resultsComparison[0].Equals(4) && resultsComparison[1].Equals(1))
            {
                category.FourPlusOne += 1;
            }
            else if (resultsComparison[0].Equals(4))
            {
                category.Four += 1;
            }
            else if (resultsComparison[0].Equals(3) && resultsComparison[1].Equals(1))
            {
                category.ThreePlusOne += 1;
            }
            else if (resultsComparison[0].Equals(3))
            {
                category.Three += 1;
            }
            else if (resultsComparison[0].Equals(2) && resultsComparison[1].Equals(1))
            {
                category.TwoPlusOne += 1;
            }
            else if (resultsComparison[0].Equals(2))
            {
                category.Two += 1;
            }
            else if (resultsComparison[0].Equals(1) && resultsComparison[1].Equals(1))
            {
                category.OnePlusOne += 1;
            }
            else if (resultsComparison[0].Equals(1))
            {
                category.One += 1;
            }
            else
                category.Zero += 1;

            return category;
        }

        public void PrintCategorys(Category cat, double budjetDependOFTheScore)
        {
            if (cat.FivePlusOne > 0 )
            {
                budjetDependOFTheScore -= budjetDependOFTheScore * 40 / 100 / cat.FivePlusOne;
                Console.WriteLine($"{cat.FivePlusOne} 5 + 1 Won {budjetDependOFTheScore}");
            }
            else
                Console.WriteLine($"{cat.FivePlusOne} 5 + 1");

            if (cat.Five > 0)
            {
                budjetDependOFTheScore -= budjetDependOFTheScore * 25 / 100 / cat.Five;
                Console.WriteLine($"{cat.Five} 5 Won {budjetDependOFTheScore}");
            }
            else
                Console.WriteLine($"{cat.Five} 5");  
            
            if (cat.FourPlusOne > 0)
            {
                budjetDependOFTheScore -= budjetDependOFTheScore * 15 / 100 / cat.FourPlusOne;
                Console.WriteLine($"{cat.FourPlusOne} 4 + 1 Won {budjetDependOFTheScore}");
            }
            else
                Console.WriteLine($"{cat.FourPlusOne} 4 + 1");

            if (cat.Four > 0)
            {
                budjetDependOFTheScore -= budjetDependOFTheScore * 5 / 100 / cat.Four;
                Console.WriteLine($"{cat.Four} 4 Won {budjetDependOFTheScore}");
            }
            else
                Console.WriteLine($"{cat.Four} 4");

            if (cat.ThreePlusOne > 0)
            {
                budjetDependOFTheScore -= budjetDependOFTheScore * 4 / 100 / cat.ThreePlusOne;
                Console.WriteLine($"{cat.ThreePlusOne} 3 + 1 Won {budjetDependOFTheScore}");
            }
            else
                Console.WriteLine($"{cat.ThreePlusOne} 3 + 1");

            if (cat.Three > 0)
            {
                budjetDependOFTheScore -= budjetDependOFTheScore * 3.5 / 100 / cat.Three;
                Console.WriteLine($"{cat.Three} 3 Won {budjetDependOFTheScore}");
            }
            else
                Console.WriteLine($"{cat.Three} 3");

            if (cat.TwoPlusOne > 0)
            {
                budjetDependOFTheScore -= budjetDependOFTheScore * 1.5 / 100 / cat.TwoPlusOne;
                Console.WriteLine($"{cat.TwoPlusOne} 2 + 1 Won {budjetDependOFTheScore}");
            }
            else
                Console.WriteLine($"{cat.TwoPlusOne} 2 + 1");

            if (cat.Two > 0)
            {
                budjetDependOFTheScore -= budjetDependOFTheScore * 1.5 / 100 / cat.Two;
                Console.WriteLine($"{cat.Two} 2 Won {budjetDependOFTheScore}");
            }
            else
                Console.WriteLine($"{cat.Two} 2");

            if (cat.OnePlusOne > 0)
            {
                budjetDependOFTheScore -= budjetDependOFTheScore * 1 / 100 / cat.OnePlusOne;
                Console.WriteLine($"{cat.OnePlusOne} 1 + 1 Won {budjetDependOFTheScore}");
            }
            else
                Console.WriteLine($"{cat.OnePlusOne} 1 + 1");

            if (cat.One > 0)
            {
                budjetDependOFTheScore = 0;
                Console.WriteLine($"{cat.One} 1 Won {budjetDependOFTheScore}");
            }
            else
                Console.WriteLine($"{cat.One} 1");

            if (cat.Zero > 0)
            {
                budjetDependOFTheScore = 0;
                Console.WriteLine($"{cat.Zero} 0 Won {budjetDependOFTheScore}");
            }
            else
                Console.WriteLine($"{cat.Zero} 0");
        }

        
    }

}
