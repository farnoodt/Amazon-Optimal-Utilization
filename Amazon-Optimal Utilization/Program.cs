using System;
using System.Collections.Generic;

namespace Amazon_Optimal_Utilization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> a = new List<List<int>>(){new List<int> { 1, 3},
                                                    new List<int>{2,5} ,
                                                    new List<int>{3,7},
                                                    new List<int>{4,10} } ;
            List<List<int>> b = new List<List<int>>() { new List<int> { 1, 2 },
                                                       new List<int> { 2, 3 },
                                                       new List<int> { 3, 4 },
                                                       new List<int> { 4, 5 }};
            getPairs(a, b, 10);
            Console.WriteLine("Hello World!");
        }

        static List<List<int>> getPairs(List<List<int>> a, List<List<int>> b, int target)
        {
            List<List<int>> res = new List<List<int>>();
            int max = 0;
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < b.Count; j++)
                {
                    if (a[i][1] + b[j][1] <= target)
                    {
                        if (a[i][1] + b[j][1] > max)
                        {
                            max = a[i][1] + b[j][1];
                            res.Clear();
                            res.Add(new List<int> { a[i][0], b[j][0] });
                        }
                        else if (a[i][1] + b[j][1] == max)
                            res.Add(new List<int> { a[i][0], b[j][0] });
                        
                    }
                }
            }
            return res;
        }
    }
}