using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LabJoker
{
    class Result
    {
        public void Results()
        {
            try
            {
                List<Player> AllPlayers = new List<Player>();
                List<Draw> AllDraws = new List<Draw>();
                Compare comp = new Compare();
                Category cat = new Category();

                //Choose 1 for random Compares And 2 for Userinputs compares
                Console.WriteLine("Type 1 For Random Inputs OR 2 for Manual Inputs");
                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("How Many Players");
                        int numberOfPlayers = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < numberOfPlayers; i++)
                        {
                            Player player = new Player();
                            player.GenerateRaNdomNumbers();
                            player.GenerateJoker();
                            AllPlayers.Add(player);
                            Thread.Sleep(50);
                        }

                        //compare Draws with Players
                        Console.WriteLine("How Many draws");
                        int numberOfDraws = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < numberOfDraws; i++)
                        {
                            Category.BudjetDependOFTheScore += 1000;
                            Draw draw = new Draw();
                            draw.GenerateJoker();
                            draw.GenerateRaNdomNumbers();
                            AllDraws.Add(draw);
                            Thread.Sleep(50);

                            foreach (var player in AllPlayers)
                            {
                                var comparison = comp.Comparison(player, draw);
                                var resultcat = comp.AddCategory(comparison);
                                comp.PrintCategorys(resultcat, Category.BudjetDependOFTheScore);
                            }

                        }
                        //Print the stats depends of the Frequencies (3 first Numbers and 3 LastNumbers of Drawlist and Jokers)
                        Statistic stat = new Statistic(AllDraws);
                        Console.WriteLine($"The Most Frequent Draw Number is : {stat.MostFrequentDrawNum} and it has {stat.MostFrequentDrawNumCount}  Counts");
                        Console.WriteLine($"The Second Most Frequent Draw Number is : {stat.SecondMostFrequentDrawNumber} and it has {stat.SecondMostFrequentDrawNumberCount}  Counts");
                        Console.WriteLine($"The Third Most Frequent Draw Number is : {stat.SecondMostFrequentDrawNumber} and it has {stat.SecondMostFrequentDrawNumberCount}  Counts");
                        Console.WriteLine($"The Less Frequent Draw Number is : {stat.LessFrequentDrawNum} and it has {stat.LessFrequentDrawNumCount}  Counts");
                        Console.WriteLine($"The Second Less Frequent Draw Number is : {stat.SecondLessFrequentDrawNumber} and it has {stat.SecondLessFrequentDrawNumberCount}  Counts");
                        Console.WriteLine($"The Third Less Frequent Draw Number is : {stat.ThirdLessFrequentDrawNumber} and it has {stat.ThirdLessFrequentDrawNumberCount}  Counts");
                        Console.WriteLine($"The Most Frequent Joker is : {stat.MostFrequentJoker} and it has {stat.MostFrequentJokerCount}  Counts");
                        Console.WriteLine($"The Second Most Frequent Joker is : {stat.SecondMostFrequentJoker} and it has {stat.SecondMostFrequentJokerCount}  Counts");
                        Console.WriteLine($"The Third Most Frequent Joker is : {stat.ThirdMostFrequentJoker} and it has {stat.ThirdMostFrequentJokerCount}  Counts");
                        Console.WriteLine($"The Less Frequent Joker is : {stat.LessFrequentJoker} and it has {stat.LessFrequentJokerCount}  Counts");
                        Console.WriteLine($"The Second Less Frequent Joker is : {stat.SecondLessFrequentJoker} and it has {stat.SecondLessFrequentJokerCount}  Counts");
                        Console.WriteLine($"The Third Less Frequent Joker is : {stat.ThirdLessFrequentJoker} and it has {stat.ThirdLessFrequentJokerCount}  Counts");

                        break;
                    case 2:
                        Console.WriteLine("How Many Players");
                        int numberOfPlayerss = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < numberOfPlayerss; i++)
                        {
                            Player player = new Player();
                            player.PlayerInputs();
                            player.UserJokerManual();
                            AllPlayers.Add(player);
                            Thread.Sleep(50);
                        }

                        //Compare Draws with Players
                        Console.WriteLine("How Many draws");
                        int numberOfDrawss = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < numberOfDrawss; i++)
                        {
                            Category.BudjetDependOFTheScore += 1000;
                            Draw draw = new Draw();
                            draw.GenerateRaNdomNumbers();
                            draw.GenerateJoker();
                            AllDraws.Add(draw);
                            Thread.Sleep(50);

                            foreach (var player in AllPlayers)
                            {
                                var comparison = comp.Comparison(player, draw);
                                var resultcat = comp.AddCategory(comparison);
                                comp.PrintCategorys(resultcat, Category.BudjetDependOFTheScore);

                            }
                            //Print the stats depends of the Frequencies (3 first Numbers and 3 LastNumbers of Drawlist and Jokers)
                            Statistic stats = new Statistic(AllDraws);
                            Console.WriteLine($"The Most Frequent Joker is : {stats.MostFrequentJoker} and it has {stats.MostFrequentJokerCount}  Counts");
                            Console.WriteLine($"The Second Most Frequent Joker is : {stats.SecondMostFrequentJoker} and it has {stats.SecondMostFrequentJokerCount}  Counts");
                            Console.WriteLine($"The Third Most Frequent Joker is : {stats.ThirdMostFrequentJoker} and it has {stats.ThirdMostFrequentJokerCount}  Counts");
                            Console.WriteLine($"The Less Frequent Joker is : {stats.LessFrequentJoker} and it has {stats.LessFrequentJokerCount}  Counts");
                            Console.WriteLine($"The Second Less Frequent Joker is : {stats.SecondLessFrequentJoker} and it has {stats.SecondLessFrequentJokerCount}  Counts");
                            Console.WriteLine($"The Third Less Frequent Joker is : {stats.ThirdLessFrequentJoker} and it has {stats.ThirdLessFrequentJokerCount}  Counts");
                            Console.WriteLine($"The Most Frequent Draw Number is : {stats.MostFrequentDrawNum} and it has {stats.MostFrequentDrawNumCount}  Counts");
                            Console.WriteLine($"The Second Most Frequent Draw Number is : {stats.SecondMostFrequentDrawNumber} and it has {stats.SecondMostFrequentDrawNumberCount}  Counts");
                            Console.WriteLine($"The Third Most Frequent Draw Number is : {stats.SecondMostFrequentDrawNumber} and it has {stats.SecondMostFrequentDrawNumberCount}  Counts");
                            Console.WriteLine($"The Less Frequent Draw Number is : {stats.LessFrequentDrawNum} and it has {stats.LessFrequentDrawNumCount}  Counts");
                            Console.WriteLine($"The Second Less Frequent Draw Number is : {stats.SecondLessFrequentDrawNumber} and it has {stats.SecondLessFrequentDrawNumberCount}  Counts");
                            Console.WriteLine($"The Third Less Frequent Draw Number is : {stats.ThirdLessFrequentDrawNumber} and it has {stats.ThirdLessFrequentDrawNumberCount}  Counts");
                            
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
           

        }

    }
}
