using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ScoringAlgorithm algorithm;

            Console.WriteLine("\nMen");
            algorithm = new MenScoringAlgorithm();
            Console.WriteLine(algorithm.GenerateScore(10, new TimeSpan(0, 2, 34)));

            Console.WriteLine("\nWomen");
            algorithm = new WomenScoringAlgorithm();
            Console.WriteLine(algorithm.GenerateScore(10, new TimeSpan(0, 2, 34)));

            Console.WriteLine("\nChildren");
            algorithm = new ChildrenScoringAlgorithm();
            Console.WriteLine(algorithm.GenerateScore(10, new TimeSpan(0, 2, 34)));


            Console.ReadLine();
        }
    }

    abstract class ScoringAlgorithm
    {
        public int GenerateScore(int hits, TimeSpan time)
        {
            int score = CalculateBaseScore(hits);
            int reduction = CalculateReduction(time);
            return CalculateOverallScore(score, reduction);
        }

        public abstract int CalculateBaseScore(int hits);
        public abstract int CalculateReduction(TimeSpan time);
        public abstract int CalculateOverallScore(int score, int reduction);
    }

    class MenScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 5;
        }

        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }
    }

    class WomenScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 3;
        }

        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }
    }

    class ChildrenScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 2;
        }

        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }
    }
}
