using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryGap {

    class Solution {
        public int solution(int N) {
            int value = 0;
            var results = new List<int>();
            var binary = Convert.ToString(N, 2);

            foreach (var c in binary) {
                if (c.Equals('0')) {
                    value += 1;
                } else {
                    results.Add(value);
                    value = 0;
                }
            }

            return results.Max();
        }
    }

    class MainClass {
        public static void Main(string[] args) {
            Solution sol = new Solution();
            Console.WriteLine(sol.solution(1041));
        }
    }
}
