using System;
using System.Collections.Generic;

namespace _05._HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titleOfArticle = Console.ReadLine();
            string content = Console.ReadLine();

            List<string> allComments = new List<string>();

            while (true)
            {
                string comment = Console.ReadLine();
                if (comment == "end of comments")
                {
                    break;
                }
                allComments.Add(comment);
            }

            Console.WriteLine("<h1>");
            Console.WriteLine($"    {titleOfArticle}");
            Console.WriteLine("</h1>");
            Console.WriteLine($"<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine($"</article>");

            foreach (var comment in allComments)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {comment}");
                Console.WriteLine($"</div>");
            }
        }
    }
}
