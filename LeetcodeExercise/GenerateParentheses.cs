using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeExercise
{
    public class GenerateParentheses
    {
        private IList<string> res = new List<String>();

        public void Backtrack(ref int n, int open, int close, string temp)
        {
            if (open > n || close > open)
            {
                return;
            }
            if (temp.Length == n * 2)
            {
                res.Add(temp);
                return;
            }
            Backtrack(ref n, open + 1, close, temp + '(');
            Backtrack(ref n, open, close + 1, temp + ')');
        }
        public IList<string> GenerateParenthesis(int n)
        {
            Backtrack(ref n, 0, 0, "");
            return res;
        }
    }
}
