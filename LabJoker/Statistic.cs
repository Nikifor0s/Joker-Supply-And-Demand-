using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabJoker
{
    public class Statistic
    {
        //Fields tha i can save the results of the Frequencies in DrawList and Joker
        public int MostFrequentDrawNum;
        public int MostFrequentDrawNumCount;

        public int SecondMostFrequentDrawNumber;
        public int SecondMostFrequentDrawNumberCount;

        public int ThirdMostFrequentDrawNumber;
        public int ThirdMostFrequentDrawNumberCount;

        public int LessFrequentDrawNum;
        public int LessFrequentDrawNumCount;

        public int SecondLessFrequentDrawNumber;
        public int SecondLessFrequentDrawNumberCount;

        public int ThirdLessFrequentDrawNumber;
        public int ThirdLessFrequentDrawNumberCount;

        public int MostFrequentJoker;
        public int MostFrequentJokerCount;

        public int SecondMostFrequentJoker;
        public int SecondMostFrequentJokerCount;

        public int ThirdMostFrequentJoker;
        public int ThirdMostFrequentJokerCount;

        public int LessFrequentJoker;
        public int LessFrequentJokerCount;

        public int SecondLessFrequentJoker;
        public int SecondLessFrequentJokerCount;

        public int ThirdLessFrequentJoker;
        public int ThirdLessFrequentJokerCount;

        //constrauctor that initialize the frequencies
        public Statistic(List<Draw> draws)
        {
            var serializedJokers = new List<int>();
            var serializedDrawNums = new List<int>();
            foreach (var dl in draws)
            {
                serializedJokers.Add(dl.Joker);

                foreach (var num in dl.List)
                {
                    serializedDrawNums.Add(num);

                }
                var sortedDraw = serializedDrawNums.GroupBy(x => x)
                    .Select(x => new { num = x, cnt = x.Count() })
                    .OrderByDescending(g => g.cnt);

                MostFrequentDrawNum = sortedDraw.First().num.Key;
                MostFrequentDrawNumCount = sortedDraw.First().cnt;

                SecondMostFrequentDrawNumber = sortedDraw.Skip(1).First().num.Key;
                SecondMostFrequentDrawNumberCount = sortedDraw.Skip(1).First().cnt;

                ThirdMostFrequentDrawNumber = sortedDraw.Skip(2).First().num.Key;
                ThirdMostFrequentDrawNumberCount = sortedDraw.Skip(2).First().cnt;

                LessFrequentDrawNum = sortedDraw.Last().num.Key;
                LessFrequentDrawNumCount = sortedDraw.Last().cnt;

                SecondLessFrequentDrawNumber = sortedDraw.Skip(1).Last().num.Key;
                SecondLessFrequentDrawNumberCount = sortedDraw.Skip(1).Last().cnt;

                ThirdLessFrequentDrawNumber = sortedDraw.Skip(2).Last().num.Key;
                ThirdLessFrequentDrawNumberCount = sortedDraw.Skip(2).Last().cnt;


            }

            var sortedJoker = serializedJokers.GroupBy(x => x)
                .Select(x => new { num = x, cnt = x.Count() })
                .OrderByDescending(g => g.cnt);

            MostFrequentJoker = sortedJoker.First().num.Key;
            MostFrequentJokerCount = sortedJoker.First().cnt;

            SecondMostFrequentJoker = sortedJoker.Skip(1).First().num.Key;
            SecondMostFrequentJokerCount = sortedJoker.Skip(1).First().cnt;

            ThirdMostFrequentJoker = sortedJoker.Skip(2).First().num.Key;
            ThirdMostFrequentJokerCount = sortedJoker.Skip(2).First().cnt;

            LessFrequentJoker = sortedJoker.Last().num.Key;
            LessFrequentJokerCount = sortedJoker.Last().cnt;

            SecondLessFrequentJoker = sortedJoker.Skip(1).Last().num.Key;
            SecondLessFrequentJokerCount = sortedJoker.Skip(1).Last().cnt;

            ThirdLessFrequentJoker = sortedJoker.Skip(2).Last().num.Key;
            ThirdLessFrequentJokerCount = sortedJoker.Skip(2).Last().cnt;


        }
    }
}
//Other Constructor

//======================================================================================================
//public Statistic(List<Draw> draws)
//{
//    var resultJokers = new Dictionary<int, int>();
//    var resultDraws = new Dictionary<int, int> ();
//    var serializedJokers = new List<int>();
//    var serializedDrawNums = new List<int>();
//    var valueslList = new List<int>();
//    foreach (var dl in draws)
//    {
//        serializedJokers.Add(dl.Joker);
//        foreach (var num in serializedJokers)
//        {
//            if (resultJokers.TryGetValue(num, out int count))
//                resultJokers[num] = count + 1;
//            else
//                resultJokers.Add(num, 1);
//        }

//         var sortedJoker = from pair in resultJokers
//                             orderby pair.Value descending
//                             select pair;
//          foreach (var num in dl.DrawList)
//          {
//             serializedDrawNums.Add(num);
//             foreach (var draw in serializedDrawNums)
//             {
//                if (resultDraws.TryGetValue(num, out int count))
//                        //Increase existing value...
//                    resultDraws[num] = count + 1;
//                else
//                        //New Value, set to 1....
//                    resultDraws.Add(num, 1);
//             }
//             var sortedDraw = from pairs in resultDraws
//          }                     orderby pairs.Value descending
//                                select pairs;
//        foreach (var pair in sortedJoker)
//        {
//            var firstJoker = sortedJoker.First();
//            //MostFrequentJokerCount = sortedJoker.First().Value;
//            Console.WriteLine($"The Most Frequent Joker is : {firstJoker.Key} and it has {firstJoker.Value}  Counts");

//            var SecondJoker = sortedJoker.Skip(1).First();
//            //SecondMostFrequentJokerCount = sortedJoker.Skip(1).First().Value;
//            Console.WriteLine($"The Second Most Frequent Joker is : {SecondJoker.Key} and it has {SecondJoker.Value}  Counts");

//             var ThirdJoker= sortedJoker.Skip(2).First();
//            //ThirdMostFrequentJokerCount = sortedJoker.Skip(2).First().Value;
//            Console.WriteLine($"The Third Most Frequent Joker is : {ThirdJoker.Key} and it has {ThirdJoker.Value}  Counts");

//            var LessJoker = sortedJoker.Last();
//            //LessFrequentJokerCount = sortedJoker.Last().Value;
//            Console.WriteLine($"The Less Frequent Joker is : {LessJoker.Key} and it has {LessJoker.Value}  Counts");

//            var SecondLessFrequentJoker = sortedJoker.Skip(1).Last();
//            //SecondLessFrequentJokerCount = sortedJoker.Skip(1).Last().Value;
//            Console.WriteLine($"The Second Less Frequent Joker is : {SecondLessFrequentJoker.Key} and it has {SecondLessFrequentJoker.Value}  Counts");

//            var ThirdJoker = sortedJoker.Skip(2).Last();
//            //ThirdLessFrequentJokerCount = sortedJoker.Skip(2).Last().Value;
//        }   Console.WriteLine($"The Third Less Frequent Joker is : {sortedJoker.Skip(2).Last().Key} and it has {sortedJoker.Skip(2).Last().Value}  Counts");
//     }
//        foreach (var pair in sortedJoker)
//        {
//            var firstJoker = sortedJoker.First();
//            //MostFrequentJokerCount = sortedJoker.First().Value;
//            Console.WriteLine($"The Most Frequent Joker is : {firstJoker.Key} and it has {firstJoker.Value}  Counts");

//            var SecondJoker = sortedJoker.Skip(1).First();
//            //SecondMostFrequentJokerCount = sortedJoker.Skip(1).First().Value;
//            Console.WriteLine($"The Second Most Frequent Joker is : {SecondJoker.Key} and it has {SecondJoker.Value}  Counts");

//             var ThirdJoker= sortedJoker.Skip(2).First();
//            //ThirdMostFrequentJokerCount = sortedJoker.Skip(2).First().Value;
//            Console.WriteLine($"The Third Most Frequent Joker is : {ThirdJoker.Key} and it has {ThirdJoker.Value}  Counts");

//            var LessJoker = sortedJoker.Last();
//            //LessFrequentJokerCount = sortedJoker.Last().Value;
//            Console.WriteLine($"The Less Frequent Joker is : {LessJoker.Key} and it has {LessJoker.Value}  Counts");

//            var SecondLessFrequentJoker = sortedJoker.Skip(1).Last();
//            //SecondLessFrequentJokerCount = sortedJoker.Skip(1).Last().Value;
//            Console.WriteLine($"The Second Less Frequent Joker is : {SecondLessFrequentJoker.Key} and it has {SecondLessFrequentJoker.Value}  Counts");

//            var ThirdJoker = sortedJoker.Skip(2).Last();
//            //ThirdLessFrequentJokerCount = sortedJoker.Skip(2).Last().Value;
//        }   Console.WriteLine($"The Third Less Frequent Joker is : {sortedJoker.Skip(2).Last().Key} and it has {sortedJoker.Skip(2).Last().Value}  Counts");
 