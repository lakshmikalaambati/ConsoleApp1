using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "[]]][]]][{{}())(";
            string pattern = @"[^{}()\[\]]";
            string newinput = Regex.Replace(input,pattern,string.Empty);

            var stacklist = new Stack<char>();
            bool flag = true;
            Console.WriteLine(input);
            Console.WriteLine(newinput);
            

            if((newinput.Length%2!=0) || (newinput.Substring(0,1) =="]") || (newinput.Substring(0, 1) == "}")|| (newinput.Substring(0, 1) == ")"))
            { 
                Console.WriteLine("given string is not well formed");
                
            }
            else
            {
                //char chars = newinput.ToCharArray();

                foreach (char c in newinput)
                {
                    //Console.WriteLine(c);
                    switch (c)
                    {
                        
                        case '(':
                        case '{':
                        case '[':
                            stacklist.Push(c);
                            //Console.WriteLine(c);
                            break;

                        case ')':
                            if (stacklist.Peek() == '(')
                                stacklist.Pop();
                            else
                                flag = false;
                            break;
                        case '}':
                            if (stacklist.Peek() == '{')
                                stacklist.Pop();
                            else
                                flag = false;
                            break;
                        case ']':
                            if (stacklist.Peek() == '[')
                                stacklist.Pop();
                            else
                                flag = false;
                            break;

                        default:
                            break;
                    }

                   
                 
                }
                foreach (char ch in stacklist)
                {
                    Console.Write(ch);
                }


             if(flag==false)
             {
                    Console.WriteLine("given string is not well formed");
             }
             else
                {
                    Console.WriteLine("given string is  well formed");
                }



            }

        }
    }
}
