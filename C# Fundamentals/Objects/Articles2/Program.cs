using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2
{
    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] articleData = Console.ReadLine()
                    .Split(", ").ToArray();

                articles.Add(new Article()
                {
                    Title = articleData[0],
                Content = articleData[1],
                Author = articleData[2]
                });
            }

            string sortBy = Console.ReadLine();
            List<Article> sorted = new List<Article>();

            if (sortBy=="title")
            {
                sorted = articles
                    .OrderBy(x => x.Title)
                    .ToList();
            }
            else if (sortBy == "content")
            {
                sorted = articles
                    .OrderBy(x => x.Content)
                    .ToList();
            }
            else 
            {
                sorted = articles
                    .OrderBy(x => x.Author)
                    .ToList();
            }

            foreach (var article in sorted)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }
        }
    }
}
