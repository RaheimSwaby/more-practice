using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;

namespace more_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "({[]})";
            bool result = Isvalid(s);
            Console.WriteLine(result);



        }
        public static bool Isvalid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char top = stack.Peek();
                    if (top == '(' && c == ')' || top == '{' && c == '}' || top == '[' && c == ']')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }

                }
                
            }
            return stack.Count == 0;
       }
    }
}
