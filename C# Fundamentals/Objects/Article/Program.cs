using System;
using System.Collections.Generic;
using System.Linq;

namespace Article
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
            string[] initialArticle = Console.ReadLine()
                .Split(", ")
                .ToArray();

            Article article = new Article()
            {
                Title = initialArticle[0],
                Content = initialArticle[1],
                Author = initialArticle[2]
            };
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(": ")
                    .ToArray();
                string action = line[0];
                string argument = line[1];

                if (action == "Edit")
                {
                    article.Edit(argument);
                }
                else if (action == "ChangeAuthor")
                {
                    article.ChangeAuthor(argument);
                }
                else if (action=="Rename")
                {
                    article.Rename(argument);
                }
            }

            Console.WriteLine(article.ToString());
        }
    }
}
