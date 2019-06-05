using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    public class ArticleIdentity
    {
        public int ArticleIdentityId { get; set; }
        public string Context { get; set; }
        public DateTime DateTime { get; set; }
        public string Author { get; set; }
        public virtual NewspaperIdentity NewspaperIdentityId { get; set; }
    }
}