using System;

namespace DepthOfNestingParentheses
{
    class Program
    {

        static int Parentheses(string s)
        {

            int current_max = 0;
            int max = 0;
            int n = s.Length;

            for (int i = 0; i < n; i++)
            {
                if (s[i].ToString() == "(")
                {
                    current_max++;

                    if (current_max > max)
                    {
                        max = current_max;
                    }

                    else if (s[i].ToString() == ")")
                    {
                        if (current_max > 0)
                        {
                            current_max--;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
            }


            return max;

        }

        static void Main(string[] args)
        {
            string string1 = "( ((X)) (((Y))) )";
            string string2 = "(()1()";

            Console.WriteLine(Parentheses(string1));
            Console.WriteLine(Parentheses(string2));

        }
    }
}
