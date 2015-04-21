namespace MusicShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using MusicShopManager.Interfaces;

    public class MusicShop : IMusicShop
    {
        private string name;
        private IList<IArticle> articles;

        public MusicShop(string name)
        {
            this.Name = name;
            this.articles = new List<IArticle>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                string parametar = "name of the music shop";
                ValidateData.ValidateRequiredRule(value, parametar);

                this.name = value;
            }
        }

        public IList<IArticle> Articles
        {
            get
            {
                return new List<IArticle>(this.articles);
            }
            private set
            {
                ;
            }
        }
        
        public void AddArticle(IArticle article)
        {
            this.articles.Add(article);
        }

        public void RemoveArticle(IArticle article)
        {
            this.articles.Remove(article);
        }

        private string SomeMethod<T1>(string head)
        {
            StringBuilder result = new StringBuilder();

            var sortedArticles = this.Articles
                .Where(a => a is T1)
                .OrderBy(a => a.Make)
                .ThenBy(a => a.Model);

            if (sortedArticles.Count() > 0)
            {
                result.AppendLine(head);

                foreach (var article in sortedArticles)
                {
                    result.Append(article.ToString());
                }
            }

            return result.ToString();
        }

        public string ListArticles()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("===== {0} =====", this.Name));

            if (this.Articles.Count > 0)
            {
                string mics = SomeMethod<IMicrophone>("----- Microphones -----");
                result.Append(mics);

                string drums = SomeMethod<IDrums>("----- Drums -----");
                result.Append(drums);

                string elGuitar = SomeMethod<IElectricGuitar>("----- Electric guitars -----");
                result.Append(elGuitar);

                string acGuitar = SomeMethod<IAcousticGuitar>("----- Acoustic guitars -----");
                result.Append(acGuitar);

                string bassGuitars = SomeMethod<IBassGuitar>("----- Bass guitars -----");
                result.Append(bassGuitars);
            }
            else
            {
                result.Append("The shop is empty. Come back soon.");
            }

            return result.ToString();
        }

       
    }
}
