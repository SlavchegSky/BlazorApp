using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blazor.Models
{
    public class Article
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string ArticleText { get; set; }
        public DateTime CreateData { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int? AutorID { get; set; }
        public Autor Autor { get; set; }
        public int? ThematicsID { get; set; }
        public Thematics Thematics { get; set; }

        }

    public class Autor
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public IEnumerable<Article> Articles { get; set; }
    }

    public class Thematics
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public IEnumerable<Article> Articles { get; set; }
    }
}
