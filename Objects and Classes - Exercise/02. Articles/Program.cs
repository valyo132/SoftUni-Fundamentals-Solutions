using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> article = Console.ReadLine().Split(", ").ToList();
            Article newArticle = new Article(article[0], article[1], article[2]);

            int countOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfCommands; i++)
            {
                string command = Console.ReadLine();
                string[] token = command.Split(": ");

                switch (token[0])
                {
                    case "Edit":
                        Edit(newArticle, token);
                        break;
                    case "ChangeAuthor":
                        ChangeAuthor(newArticle, token);
                        break;
                    case "Rename":
                        Rename(newArticle, token);
                        break;
                }
            }
            Console.WriteLine($"{newArticle.Title} - {newArticle.Content}: {newArticle.Author}");
        }

        private static void Rename(Article newArticle, string[] token)
        {
            string newName = token[1];
            newArticle.Title = newName;
        }

        private static void ChangeAuthor(Article newArticle, string[] token)
        {
            string newAuthor = token[1];
            newArticle.Author = newAuthor;
        }

        private static void Edit(Article newArticle, string[] token)
        {
            string newContent = token[1];
            newArticle.Content = newContent;
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
    }
}
