using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> allArticles = new List<Article>();

            int countOfArticles = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfArticles; i++)
            {
                List<string> article = Console.ReadLine().Split(", ").ToList();
                Article newArticle = new Article(article[0], article[1], article[2]);
                allArticles.Add(newArticle);
            }
            string str = Console.ReadLine();

            foreach (var item in allArticles)
            {
                Console.WriteLine($"{item.Title} - {item.Content}: {item.Author}");
            }
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
